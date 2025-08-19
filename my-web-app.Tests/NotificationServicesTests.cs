using System;
using MyWebApp.Services;
using Xunit;

namespace MyWebApp.Tests;

public class NotificationServiceTests
{
    [Fact]
    public void NotificationService_CanBeInstantiated()
    {
        var instance = new NotificationService();
        Assert.NotNull(instance);
    }

    [Fact]
    public void GetNotificationMessage_ReturnsExpectedMessage()
    {
        var instance = new NotificationService();
        var result = instance.GetNotificationMessage();
        Assert.Equal("This is your notification!", result);
    }

    [Fact]
    public void GetNotificationMessage_MethodExistsAndCanBeCalled()
    {
        var instance = new NotificationService();
        var method = typeof(NotificationService).GetMethod("GetNotificationMessage");
        Assert.NotNull(method);
        // Call the method and ensure no exception is thrown
        method.Invoke(instance, null);
    }

    [Fact]
    public void GetNotificationMessage_DoesNotThrowException()
    {
        var instance = new NotificationService();
        Exception ex = Record.Exception(() => instance.GetNotificationMessage());
        Assert.Null(ex);
    }
}