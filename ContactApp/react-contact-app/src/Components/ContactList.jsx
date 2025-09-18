import React, { useEffect, useState } from 'react';
import { ContactService } from '../Services/ContactService';
import { Link } from 'react-router-dom';

function ContactList() {
  const [contacts, setContacts] = useState([]);
  const [error, setError] = useState("");

  useEffect(() => {
    ContactService.getAllContacts()
      .then((response) => {
        setContacts(response.data);
      })
      .catch((err) => {
        setError("Failed to fetch contacts");
        console.error(err);
      });
  }, []);

  // Helper to convert Windows path to usable image URL
  const getImageUrl = (path) => {
    const filename = path.split('/').pop(); // Extract filename from path
    return `http://localhost:5248/images/${filename}`; // Adjust based on your backend image serving
  };

  return (
    <div className="container">
      <h2 className="my-4">Contact List</h2>
      {error && <div className="alert alert-danger">{error}</div>}
      <table className="table table-bordered table-hover">
        <thead className="table-dark">
          <tr>
            <th>Photo</th>
            <th>Name</th>
            <th>Phone No</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {contacts.length > 0 ? (
            contacts.map((contact) => (
              <tr key={contact.id}>
                <td>
                  <img
                    src={getImageUrl(contact.photo)}
                    alt={contact.name}
                    style={{ width: '50px', height: '50px', borderRadius: '50%' }}
                  />
                </td>
                <td>{contact.name}</td>
                <td>{contact.phoneNo}</td>
                <td>
                  <Link to={`/view/${contact.id}`} className="btn btn-info btn-sm me-2">View</Link>
                  <Link to={`/edit/${contact.id}`} className="btn btn-warning btn-sm me-2">Edit</Link>
                </td>
              </tr>
            ))
          ) : (
            <tr>
              <td colSpan="4" className="text-center">No contacts found.</td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
}

export default ContactList;
