import React, { useState } from 'react';
import { ContactService } from '../Services/ContactService';
import { useNavigate } from 'react-router-dom';

function AddContact() {
  const [contact, setContact] = useState({
    name: '',
    phoneNo: '',
    photo: ''
  });

  const [error, setError] = useState('');
  const navigate = useNavigate();

  const handleChange = (e) => {
    setContact({
      ...contact,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await ContactService.addContact(contact);
      navigate('/'); // Redirect to contact list
    } catch (err) {
      console.error(err);
      setError('Failed to add contact');
    }
  };

  return (
    <div className="container mt-4">
      <h2>Add New Contact</h2>
      {error && <div className="alert alert-danger">{error}</div>}
      <form onSubmit={handleSubmit}>
        <div className="mb-3">
          <label className="form-label">Name</label>
          <input
            type="text"
            name="name"
            value={contact.name}
            onChange={handleChange}
            className="form-control"
            placeholder="Enter name"
            required
          />
        </div>
        <div className="mb-3">
          <label className="form-label">Phone No</label>
          <input
            type="text"
            name="phoneNo"
            value={contact.phoneNo}
            onChange={handleChange}
            className="form-control"
            placeholder="Enter phone number"
            required
          />
        </div>
        <div className="mb-3">
          <label className="form-label">Photo Filename</label>
          <input
            type="text"
            name="photo"
            value={contact.photo}
            onChange={handleChange}
            className="form-control"
            placeholder="e.g., pic1.png"
            required
          />
        </div>
        <button type="submit" className="btn btn-success">Add Contact</button>
      </form>
    </div>
  );
}

export default AddContact;
