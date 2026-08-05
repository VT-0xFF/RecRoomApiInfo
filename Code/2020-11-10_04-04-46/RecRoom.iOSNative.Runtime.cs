using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Platforms.IOS
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class iOSNativeSetup
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum iOSStatusBarStyle
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			LightContent
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void SetupAudioSessionForVoiceChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3BD060", Offset = "0x3BC060", VA = "0x1803BD060")]
		public static bool IsUsingSpeakers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x30DAB90", Offset = "0x30D9B90", VA = "0x1830DAB90")]
		public static double OutputVolume()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AF180", Offset = "0x8AE180", VA = "0x1808AF180")]
		public static int ActiveMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x30DABA0", Offset = "0x30D9BA0", VA = "0x1830DABA0")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30DABA0", Offset = "0x30D9BA0", VA = "0x1830DABA0")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void EnableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void DisableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void ShowStatusBar(bool show)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void SetStatusBarStyle(iOSStatusBarStyle statusBarStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA390", Offset = "0x3A9390", VA = "0x1803AA390")]
		public static void RequireDoubleSwipeForSystemGestures(bool require)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
