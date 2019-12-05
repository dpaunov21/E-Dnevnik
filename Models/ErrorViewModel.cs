using System;

namespace E_Dnevnik.Models {
  public class ErrorViewModel {
    public string RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
  }
}
