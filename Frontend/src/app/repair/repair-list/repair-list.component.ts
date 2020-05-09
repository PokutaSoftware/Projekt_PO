import { Component, OnInit } from '@angular/core';
import {Repair} from '../../shared/repair.model';
import {RepairService} from '../repair.service';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-repair-list',
  templateUrl: './repair-list.component.html',
})
export class RepairListComponent implements OnInit {
  repairs: Repair[];
  constructor(private repairService: RepairService,
              private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit(): void {
    this.repairs = this.repairService.getRepair();
  }

  onEdit() {
    this.router.navigate(['edit'], {relativeTo: this.route, queryParamsHandling: 'preserve'});
  }

}
