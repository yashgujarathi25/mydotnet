import React, { Component, useEffect, useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';


const App=()=>{
  const [arr,setarr] = useState([]);
   
  useEffect(()=>{
      fetch("api/employee/GetEmployees")
      .then(response => {return response.json()})
      .then(responseJson => {
        console.log(responseJson)
        setarr(responseJson)
      })
    },[]);


  return(
    <div>
      <table>
        <tbody>
          <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Email</th>
          <th>Address</th>
          <th>Phone</th>
          </tr>
          {arr.map((item)=>{
            return <tr key={item.id}>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.email}</td>
              <td>{item.address}</td>
              <td>{item.phone}</td>
            </tr>
          })}
        </tbody>
      </table>
    </div>
  )
}

export default App;