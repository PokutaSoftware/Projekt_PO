import { Component, OnInit } from '@angular/core';
import {Client} from '../shared/client.model';
import {ClientService} from './client.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  providers: [ClientService]
})
export class ClientComponent implements OnInit {
  clients: Client[];
  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
    this.clients = this.clientService.getClients();
  }

}
