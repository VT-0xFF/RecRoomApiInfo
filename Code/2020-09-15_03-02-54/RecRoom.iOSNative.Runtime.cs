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
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
		public static void SetupAudioSessionForVoiceChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3B6580", Offset = "0x3B4D80", VA = "0x1803B6580")]
		public static bool IsUsingSpeakers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x30453A0", Offset = "0x3043BA0", VA = "0x1830453A0")]
		public static double OutputVolume()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C2940", Offset = "0x7C1140", VA = "0x1807C2940")]
		public static int ActiveMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x30453B0", Offset = "0x3043BB0", VA = "0x1830453B0")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30453D0", Offset = "0x3043BD0", VA = "0x1830453D0")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
		public static void EnableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
		public static void DisableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
		public static void ShowStatusBar(bool show)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
		public static void SetStatusBarStyle(iOSStatusBarStyle statusBarStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A1960", VA = "0x1803A3160")]
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
