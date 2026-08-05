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
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void SetupAudioSessionForVoiceChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AC0", Offset = "0x3D3EC0", VA = "0x1803D4AC0")]
		public static bool IsUsingSpeakers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA02080", Offset = "0xA01480", VA = "0x180A02080")]
		public static double OutputVolume()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x611E10", Offset = "0x611210", VA = "0x180611E10")]
		public static int ActiveMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA02090", Offset = "0xA01490", VA = "0x180A02090")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA02090", Offset = "0xA01490", VA = "0x180A02090")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void EnableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void DisableBackgroundUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void ShowStatusBar(bool show)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void SetStatusBarStyle(iOSStatusBarStyle statusBarStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540")]
		public static void RequireDoubleSwipeForSystemGestures(bool require)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x698FC0", Offset = "0x6983C0", VA = "0x180698FC0")]
		public static float GetTimeSinceBoot()
		{
			return default(float);
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
