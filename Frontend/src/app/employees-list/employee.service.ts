import {Employee} from '../shared/employee.model';

export class EmployeeService {
  private employees: Employee[] = [
    new Employee( 1, 'Steve', 'Rogers', new Date(2018, 5, 8), 987463522, 's.rogers@pokuta.pl', 'sprzedaż', ),
    new Employee( 2, 'Tony', 'Stark', new Date(2020, 9, 5), 983730321, 't.stark@pokuta.pl', 'warsztat'),
    new Employee( 3, 'Pepper', 'Potts', new Date(2010, 9, 1), 988437841, 'p.potts@pokuta.pl', 'sprzedaż')
  ];

  getEmployees() {
    return this.employees.slice();
  }
}
