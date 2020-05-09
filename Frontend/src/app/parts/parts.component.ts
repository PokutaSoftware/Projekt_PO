import { Component, OnInit } from '@angular/core';
import {PartService} from './part.service';

@Component({
  selector: 'app-parts',
  templateUrl: './parts.component.html',
  providers: [PartService]
})
export class PartsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
