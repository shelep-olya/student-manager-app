const entry = {
  id: "",
  firstname: "",
  lastname: "",
  class: "",
  department: "",
  age: 18,
  isGraduated: false,
  birthday: new Date(),
};

export default function New(props) {
  const newData = (e) => {
    const name_ = e.target.name;
    const v_ = e.target.value;

    entry[name_] = v_;
    console.log("The New Student Is: ", entry);
  };
  return (
    <section className="m-20">
      <h1>Add New Student</h1>
      <div>
        <label htmlFor="fn">First Name</label>
        <input type="text" name="firstname" id="fn" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="fn">First Name</label>
        <input type="text" name="firstname" id="fn" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="fn">First Name</label>
        <input type="text" name="firstname" id="fn" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="fn">First Name</label>
        <input type="text" name="firstname" id="fn" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="fn">First Name</label>
        <input type="text" name="firstname" id="fn" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="ln">Last Name</label>
        <input type="text" name="lastname" id="ln" onChange={newData}></input>
      </div>

      <div>
        <label htmlFor="class">Class</label>
        <input type="text" name="class" id="class" onChange={newData}></input>
      </div>
    </section>
  );
}
