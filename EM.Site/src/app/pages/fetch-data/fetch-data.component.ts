import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];
  public employees: any = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,  @Inject('API_URL') apiUrl: string) {
    console.log('API_URL', apiUrl)

    http.get('/api/employees').subscribe(result => {
      console.log(result)
      this.employees = result;
    }, error => console.error(error));

    // http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //   this.forecasts = result;
    // }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
