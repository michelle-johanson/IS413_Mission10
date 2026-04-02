import { useEffect, useState } from 'react';
import type { bowler } from "../types/bowler";

function BowlerTable() {
    const [bowlers, setBowlers] = useState<bowler[]>([]);

    useEffect(() => {
            const fetchBowler = async () => {
            const response = await fetch('https://localhost:5000/api/Bowlers')
            const data = await response.json();
            setBowlers(data);
        }
        fetchBowler();
    }, []);

    return (
        <div className="page">
        <div className="table-wrapper">
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Team</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Zip</th>
                    <th>Phone</th>
                </tr>
            </thead>
            <tbody>
                {bowlers.map((b, i) => (
                    <tr key={i}>
                        <td>{b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}</td>
                        <td>{b.teamName}</td>
                        <td>{b.bowlerAddress}</td>
                        <td>{b.bowlerCity}</td>
                        <td>{b.bowlerState}</td>
                        <td>{b.bowlerZip}</td>
                        <td>{b.bowlerPhoneNumber}</td>
                    </tr>
                ))}
            </tbody>
        </table>
        </div>
        </div>
    );
}

export default BowlerTable;
