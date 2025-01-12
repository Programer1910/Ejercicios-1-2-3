/* General */
body {
    font-family: 'Arial', sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f5f5f5;
}

/* Header */
.header-section 
{
    background-color: linear-gradient(to bottom, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.9));
    height: 300px; 
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: -1px;
}
.header-title {
    font-size: 2.5rem;
    font-weight: bold;
    text-shadow: 2px 2px 5px rgba(0, 0, 0, 0.8);
}
.header-text {
    font-size: 1.2rem;
    margin-top: 10px;
}

/* Navbar */
.navbar {
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}
.navbar .nav-link {
    font-size: 1rem;
    font-weight: bold;
    color: #ffffff;
}

/* Cards */
.card {
    border: none;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    transition: transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out;
}
.card:hover {
    transform: translateY(-10px);
    box-shadow: 0 8px 16px rgba(0, 0, 0, 0.3);
}
.card img {
    height: 200px;
    object-fit: cover;
}
.card-title {
    font-size: 1.2rem;
    font-weight: bold;
}
.card-text {
    font-size: 1rem;
}

/* Buttons */
.category-buttons .btn {
    width: 100%;
    font-size: 1rem;
    font-weight: bold;
    padding: 10px;
    background-color: #ffc107;
    color: #343a40;
}
.category-buttons .btn:hover {
    background-color: #ffcc00;
    color: white;
}

/* Footer */
.footer {
    background-color: #343a40;
    color: white;
    font-size: 0.9rem;
    padding: 10px 0;
}