using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SVPullToRefresh {

  [Category, BaseType (typeof (UIScrollView))]
  interface SVPullToRefresh_UIScrollView {

    [Export ("addPullToRefreshWithActionHandler:")]
    void AddPullToRefreshWithActionHandler (Action actionHandler);

    [Export ("addPullToRefreshWithActionHandler:position:")]
    void AddPullToRefreshWithActionHandler (Action actionHandler, SVPullToRefreshPosition position);

    [Export ("triggerPullToRefresh")]
    void TriggerPullToRefresh ();

    [Export ("pullToRefreshView", ArgumentSemantic.Retain)]
    SVPullToRefreshView GetPullToRefreshView();

    [Export ("showsPullToRefresh")]
    bool GetShowsPullToRefresh();

    [Export ("setShowsPullToRefresh:")]
    bool SetShowsPullToRefresh(bool showsPullToRefresh);
  }

  [BaseType (typeof (UIView))]
  interface SVPullToRefreshView {

    [Export ("arrowColor", ArgumentSemantic.Retain)]
    UIColor ArrowColor { get; set; }

    [Export ("textColor", ArgumentSemantic.Retain)]
    UIColor TextColor { get; set; }

    [Export ("titleLabel", ArgumentSemantic.Retain)]
    UILabel TitleLabel { get; }

    [Export ("subtitleLabel", ArgumentSemantic.Retain)]
    UILabel SubtitleLabel { get; }

    [Since (5,0), Export ("activityIndicatorViewColor", ArgumentSemantic.Retain)]
    UIColor ActivityIndicatorViewColor { get; set; }

    [Export ("activityIndicatorViewStyle")]
    UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

    [Export ("state")]
    SVPullToRefreshState State { get; }

    [Export ("position")]
    SVPullToRefreshPosition Position { get; }

    [Export ("setTitle:forState:")]
    void SetTitle (string title, SVPullToRefreshState state);

    [Export ("setSubtitle:forState:")]
    void SetSubtitle (string subtitle, SVPullToRefreshState state);

    [Export ("setCustomView:forState:")]
    void SetCustomView (UIView view, SVPullToRefreshState state);

    [Export ("startAnimating")]
    void StartAnimating ();

    [Export ("stopAnimating")]
    void StopAnimating ();

    [Export ("dateLabel", ArgumentSemantic.Retain)]
    UILabel DateLabel { get; }

    [Export ("lastUpdatedDate", ArgumentSemantic.Retain)]
    NSDate LastUpdatedDate { get; set; }

    [Export ("dateFormatter", ArgumentSemantic.Retain)]
    NSDateFormatter DateFormatter { get; set; }

    [Export ("triggerRefresh")]
    void TriggerRefresh ();
  }

  [Category, BaseType (typeof (UIScrollView))]
  interface SVInfiniteScrolling_UIScrollView {

    [Export ("addInfiniteScrollingWithActionHandler:")]
    void AddInfiniteScrollingWithActionHandler (Action actionHandler);

    [Export ("triggerInfiniteScrolling")]
    void TriggerInfiniteScrolling ();

    [Export ("infiniteScrollingView", ArgumentSemantic.Retain)]
    SVInfiniteScrollingView GetInfiniteScrollingView();

    [Export ("showsInfiniteScrolling")]
    bool GetShowsInfiniteScrolling();

    [Export ("setShowsInfiniteScrolling:")]
    bool SetShowsInfiniteScrolling(bool showsInfiniteScrolling);
  }

  [BaseType (typeof (UIView))]
  interface SVInfiniteScrollingView {

    [Export ("activityIndicatorViewStyle")]
    UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

    [Export ("state")]
    SVInfiniteScrollingState State { get; }

    [Export ("enabled")]
    bool Enabled { get; set; }

    [Export ("setCustomView:forState:")]
    void SetCustomView (UIView view, SVInfiniteScrollingState state);

    [Export ("startAnimating")]
    void StartAnimating ();

    [Export ("stopAnimating")]
    void StopAnimating ();
  }

}
