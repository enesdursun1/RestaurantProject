﻿namespace Business.Dtos.Responses.MonthlyIncomeRecord;

public class GetByIdMonthlyIncomeRecordResponse
{
    public int Id { get; set; }

    public DateTime Date { get; set; }
    public decimal Price { get; set; }

}
