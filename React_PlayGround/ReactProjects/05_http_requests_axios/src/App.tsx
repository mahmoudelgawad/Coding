import { useEffect, useState } from 'react';
import HttpService from './services/http.service';

function App() {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(false);

  const fetchData = async () => {
    setLoading(true);
    try {
      const response = await HttpService.get('/items');
      setData(response.data);
    } catch (err) {
      // Local error handling if needed, otherwise global interceptor logs it
    } finally {
      setLoading(false);
    }
  };

  const addItem = async () => {
    try {
      await HttpService.post('/items', { name: 'New Item' });
      fetchData(); // Refresh list
    } catch (err) {
      console.error("Failed to add item");
    }
  };

  useEffect(() => {
    fetchData();
  }, []);

  return (
    <div style={{ padding: '20px' }}>
      <h1>React 19.2 Global Service</h1>
      <button onClick={addItem} disabled={loading}>Add Item</button>
      {loading ? <p>Loading...</p> : (
        <ul>
          {data.map(item => <li key={item.id}>{item.name}</li>)}
        </ul>
      )}
    </div>
  );
}

export default App;