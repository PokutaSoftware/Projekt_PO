import { Component, OnInit } from '@angular/core';
import {Employee} from '../shared/employee.model';
import {EmployeeService} from './employee.service';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css'],
  providers:[EmployeeService]
})
export class EmployeesListComponent implements OnInit {
  employees: Employee[];
  constructor(private employeeService:EmployeeService) { }

  ngOnInit(): void {
    this.employees=this.employeeService.getEmployees();
  }

}
