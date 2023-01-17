import React, { Component, useEffect, useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

export default function App() {
  const [arr, setarr] = useState([]);
  useEffect(()=>{
    fetch("api/student/GetStudents")
    .then(response => {return response.json()})
    .then(responseJson => {
      console.log(responseJson)
      setarr(responseJson)
    })
  },[])
  return (
    <div>
      <div className='container'>
      <h1>Student</h1>
      </div>
      <div></div>
      <table className='table table-striped'>
        <tbody>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Email</th>
          </tr>
          {arr.map((item)=>{
            return <tr key={item.id}>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.email}</td>
            </tr>
          })}
        </tbody>
      </table>
    </div>
  )
}

