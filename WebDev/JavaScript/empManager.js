class Employee{
    constructor(id,name,address,salary){
        this.id=id;
        this.name=name;
        this.address=address;
        this.salary=salary;
    }
}
class EmployeeRepo{
    empList=[];// create blank array

    addEmp =(emp)=>this.empList=[...this.empList,emp];

    removeEmp=(id)=>this.empList=this.empList.filter(emp =>emp.id!=id);
    // removeEmp=(id)=>{
    //     const index= this.empList.findIndex(e=>e.id=id);
    //     if(index>=0){
    //         this.empList.splice(index,1);
    //     }
    // }
    
    updateEmp = (emp)=>{
        const index= this.empList.findIndex(e=>e.id=emp.id);
        if(index>=0){
            this.empList.splice(index,1,emp);
        }
    }

    getall = ()=>this.empList;
    getEmp =(id)=>this.empList.find((e)=>e.id==id);

}