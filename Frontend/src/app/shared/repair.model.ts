export class Repair {
    constructor(public id: number,
                public carModel: string,
                public registrationNumber: string,
                public clientName: string,
                public date: Date,
                public status: string) {}
  }