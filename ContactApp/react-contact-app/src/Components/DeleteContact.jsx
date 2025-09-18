import React, { useEffect, useState } from 'react';
import { ContactService } from '../Services/ContactService';

function DeleteContact() {
  const [contacts, setContacts] = useState([]);
  const [error, setError] = useState('');
  const [message, setMessage] = useState('');

  useEffect(() => {
    loadContacts();
  }, []);

  const loadContacts = () => {
    ContactService.getAllContacts()
      .then((response) => {
        setContacts(response.data);
      })
      .catch((err) => {
        console.error(err);
        setError('Failed to load contacts');
      });
  };

  const handleDelete = async (id) => {
    try {
      await ContactService.deleteContact(id);
      setMessage('Contact deleted successfully');
      loadContacts(); // Refresh list
    } catch (err) {
      console.error(err);
      setError('Failed to delete contact');
    }
  };

const getImageUrl = (path) => {
    const filename = path.split('/').pop(); // Extract filename from path
    return `http://localhost:5248/images/${filename}`; // Adjust based on your backend image serving
  };

  return (
    <div className="container mt-4">
      <h2>Delete Contact</h2>
      {error && <div className="alert alert-danger">{error}</div>}
      {message && <div className="alert alert-success">{message}</div>}
      <table className="table table-bordered table-hover">
        <thead className="table-dark">
          <tr>
            <th>Photo</th>
            <th>Name</th>
            <th>Phone No</th>
            <th>Delete</th>
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
                  <button
                    className="btn btn-danger btn-sm"
                    onClick={() => handleDelete(contact.id)}
                  >
                    Delete
                  </button>
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

export default DeleteContact;
