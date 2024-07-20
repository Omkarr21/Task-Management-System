import React, { useEffect, useState } from 'react';

const App = () => {
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        const fetchTasks = async () => {
            const response = await fetch('https://localhost:5001/api/tasks');
            const data = await response.json();
            setTasks(data);
        };
        fetchTasks();
    }, []);

    return (
        <div>
            <h1>Task Management System</h1>
            <ul>
                {tasks.map(task => (
                    <li key={task.id}>{task.title} - {task.isCompleted ? 'Completed' : 'Pending'}</li>
                ))}
            </ul>
        </div>
    );
};

export default App;
