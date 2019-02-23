import { Component, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-value",
  templateUrl: "./value.component.html",
  styleUrls: ["./value.component.css"]
})
export class ValueComponent implements OnInit {
  plans: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getPlans();
  }

  getPlans() {
    this.http.get("http://localhost:5000/api/values").subscribe(
      plans => {
        this.plans = plans;
        console.log(this.plans);
      },
      errors => {
        console.log(errors);
      }
    );
  }
}
