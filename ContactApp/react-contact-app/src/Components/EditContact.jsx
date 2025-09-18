import React, { useEffect, useState } from 'react';
import { ContactService } from '../Services/ContactService';
import { useParams, useNavigate } from 'react-router-dom';

function EditContact() {
  const { id } = useParams(); // Get contact ID from URL
  const navigate = useNavigate();

  const [contact, setContact] = useState({
    id: '',
    name: '',
    phoneNo: '',
    photo: ''
  });

  const [error, setError] = useState('');

  useEffect(() => {
    ContactService.getContactById(id)
      .then((response) => {
        setContact(response.data);
      })
      .catch((err) => {
        console.error(err);
        setError('Failed to fetch contact');
      });
  }, [id]);

  const handleChange = (e) => {
    setContact({
      ...contact,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await ContactService.updateContact(contact);
      navigate('/'); // Redirect to contact list
    } catch (err) {
      console.error(err);
      setError('Failed to update contact');
    }
  };

  return (
    <div className="container mt-4">
      <h2>Edit Contact</h2>
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
            required
          />
        </div>
        <button type="submit" className="btn btn-primary">Update Contact</button>
      </form>
    </div>
  );
}

export default EditContact;
