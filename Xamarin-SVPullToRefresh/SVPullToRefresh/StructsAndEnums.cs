using System;

namespace SVPullToRefresh
{


  public enum SVPullToRefreshPosition : uint {
    Top = 0,
    Bottom
  }

  public enum SVPullToRefreshState : uint {
    Stopped = 0,
    Triggered,
    Loading,
    All = 10
  }
     
  public enum SVInfiniteScrollingState : uint {
    Stopped = 0,
    Triggered,
    Loading,
    All = 10
  }


}

