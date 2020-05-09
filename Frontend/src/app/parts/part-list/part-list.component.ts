import { Component, OnInit } from '@angular/core';
import {Part} from '../../shared/part.model';
import {PartService} from '../part.service';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-part-list',
  templateUrl: './part-list.component.html',
})
export class PartListComponent implements OnInit {
  parts: Part[];
  constructor(private partService: PartService,
              private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit(): void {
    this.parts = this.partService.getParts();
  }

  onEdit() {
    this.router.navigate(['add'], {relativeTo: this.route, queryParamsHandling: 'preserve'});
  }

}
