import { Part } from '../shared/part.model';

export class PartService {
  private parts: Part[] = [
    new Part(1, 'Engine', 2000, 2500, new Date(2020, 5, 7)),
    new Part(2, 'Wheel', 500, 800, new Date(2020, 5, 8)),
  ];

  getParts() {
    return this.parts.slice();
  }
}
