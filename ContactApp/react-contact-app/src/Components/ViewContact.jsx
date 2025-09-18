import React, { useEffect, useState } from 'react';
import { ContactService } from '../Services/ContactService';
import { useParams, useNavigate } from 'react-router-dom';

function ViewContact() {
  const { id } = useParams();
  const navigate = useNavigate();

  const [contact, setContact] = useState(null);
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

  const getImageUrl = (path) => {
    const filename = path.split('/').pop(); // Extract filename from path
    return `http://localhost:5248/images/${filename}`; // Adjust based on your backend image serving
  };


  return (
    <div className="container mt-4">
      <h2>View Contact</h2>
      {error && <div className="alert alert-danger">{error}</div>}
      {contact ? (
        <div className="card" style={{ maxWidth: '400px' }}>
          <img
            src={getImageUrl(contact.photo)}
            alt={contact.name}
            className="card-img-top"
            style={{ height: '300px', objectFit: 'cover' }}
          />
          <div className="card-body">
            <h5 className="card-title">{contact.name}</h5>
            <p className="card-text"><strong>Phone No:</strong> {contact.phoneNo}</p>
            <button className="btn btn-secondary" onClick={() => navigate('/')}>Back to List</button>
          </div>
        </div>
      ) : (
        !error && <p>Loading contact...</p>
      )}
    </div>
  );
}

export default ViewContact;
