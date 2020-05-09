import { Component, OnInit } from '@angular/core';
import {Part} from '../../shared/part.model';
import {PartService} from '../part.service';

@Component({
  selector: 'app-part-list',
  templateUrl: './part-list.component.html',
})
export class PartListComponent implements OnInit {
  parts: Part[];
  constructor(private partService: PartService) { }

  ngOnInit(): void {
    this.parts = this.partService.getParts();
  }

}
