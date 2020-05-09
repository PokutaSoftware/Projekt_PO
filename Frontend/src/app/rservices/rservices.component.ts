import { Component, OnInit } from '@angular/core';
import {RservicesService} from './rservices.service';
import {Rservices} from '../shared/rservices.model';

@Component({
  selector: 'app-rservices',
  templateUrl: './rservices.component.html',
  providers: [RservicesService]
})
export class RservicesComponent implements OnInit {
  rservices: Rservices[];
  constructor(private rserviceService: RservicesService) { }

  ngOnInit(): void {
    this.rservices = this.rserviceService.getRservices();
  }

}
