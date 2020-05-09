import { Component, OnInit } from '@angular/core';
import {RepairService} from './repair.service';

@Component({
  selector: 'app-repair',
  templateUrl: './repair.component.html',
  providers: [RepairService]
})
export class RepairComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}