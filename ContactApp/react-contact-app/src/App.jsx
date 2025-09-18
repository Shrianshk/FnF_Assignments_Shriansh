import React from 'react';
import { Routes, Route } from 'react-router-dom';
import NavBar from './Components/NavBar';
import AddContact from './Components/AddContact';
import EditContact from './Components/EditContact';
import ContactList from './Components/ContactList';
import ViewContact from './Components/ViewContact';
import Contact from './Components/Contact';
import DeleteContact from './Components/DeleteContact';

function App() {
  return (
    <>
      <NavBar/>
      <div className="container mt-4">
        <Routes>
          <Route path="/" element={<ContactList />} />
          <Route path="/add" element={<AddContact />} />
          <Route path="/edit/:id" element={<EditContact />} />
          <Route path="/view/:id" element={<ViewContact />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/delete" element={<DeleteContact />} />
        </Routes>
      </div>
    </>
  );
}

export default App;
