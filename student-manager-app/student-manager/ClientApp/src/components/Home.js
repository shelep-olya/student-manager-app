import { useEffect, useState } from "react";

export default function Home() {
  const [students, setStudents] = useState({});
  useEffect(() => {
    fetch("api/student")
      .then((r) => r.json())
      .then((d) => {
        console.log("The students are: ", d);
        setStudents(d);
      })
      .catch((err) => console.log("the error fetching students"));
  }, []);

  return (
    <main>
      <h1>student-manager application</h1>
      <div className="add-btn">
        <a href="/new">+</a>
      </div>

      <table>
        <thead>
          <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Class</th>
            <th>Department</th>
            <th>BirthDay</th>
            <th>Age</th>
            <th>Gratuated</th>
            <th>Edit</th>
            <th>Delete</th>
          </tr>
        </thead>
        <tbody>
          {students.length === 0 ? (
            <div className="row waiting">
              <div>Loading</div>
              <div className="loading">...</div>
            </div>
          ) : (
            students.map((student) => (
              <tr key={student.id}>
                <td>{student.firstName}</td>
                <td>{student.lastName}</td>
                <td>{student.class}</td>
                <td>{student.department}</td>
                <td>{student.birthday}</td>
                <td>{student.age}</td>
                <td>{student.isGraduated ? "Yes" : "No"}</td>
                <td>
                  <a href={"/edit?id=" + student.id}>Edit</a>
                </td>
                <td>Delete</td>
              </tr>
            ))
          )}
        </tbody>
      </table>
    </main>
  );
}
