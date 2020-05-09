import {Client} from '../shared/client.model';

export class ClientService {
  private clients: Client[] = [
    new Client( 1, 'Waldemar', 'Pokuta', new Date(2020, 5, 1), 123456789, 'w.pokuta@pokuta.pl', 'waldek123'),
    new Client( 2, 'Bronisław', 'Tomczuk', new Date(2020, 5, 2), 987654321, 'b.tomczuk@pokuta.pl', 'btomczuk')
  ];

  getClients() {
    return this.clients.slice();
  }
}
