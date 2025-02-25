using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Calculator_App.Pages;

public class CalculatorModel : PageModel
{
    private readonly ILogger<CalculatorModel> _logger;

    public CalculatorModel(ILogger<CalculatorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void getButtonVal()
    {
        
    }
}