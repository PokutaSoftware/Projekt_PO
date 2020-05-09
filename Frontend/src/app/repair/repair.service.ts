import {Repair} from '../shared/repair.model';

export class RepairService {
  private repairs: Repair[] = [
    new Repair(1, 'Fiat Panda', 'SC 999C', 'Andrzej Random',new Date(2020, 5, 8),'W trakcie naprawy'),
    new Repair(2, 'Opel Astra', 'SC 777A', 'Karol Kowalski',new Date(2020, 5, 8),'W trakcie naprawy'),
  ];

  getRepair() {
    return this.repairs.slice();
  }
}