import {Rservices} from '../shared/rservices.model';

export class RservicesService {
  private rservices: Rservices[] = [
    new Rservices(1, 'Car review', 200, 2),
    new Rservices(2, 'Tires swap', 100, 1)
  ];

  getRservices() {
    return this.rservices.slice();
  }
}
