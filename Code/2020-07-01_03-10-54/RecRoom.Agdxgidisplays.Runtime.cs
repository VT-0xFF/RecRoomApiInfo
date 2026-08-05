using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DXGI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class DXGIDisplays : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private enum UnityDebugLogType
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate void NativeUnityDebugLogCallback(IntPtr request, int size, int logType);

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DisplayCount
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2E2C030", Offset = "0x2E2AA30", VA = "0x182E2C030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C650", Offset = "0x2E2B050", VA = "0x182E2C650")]
		private static extern void LinkUnityDebugCallback(NativeUnityDebugLogCallback callback);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C700", Offset = "0x2E2B100", VA = "0x182E2C700")]
		[MonoPInvokeCallback(typeof(NativeUnityDebugLogCallback))]
		private static void OnDebugCallback(IntPtr request, int size, int logType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C5C0", Offset = "0x2E2AFC0", VA = "0x182E2C5C0")]
		private static extern void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2E2BFA0", Offset = "0x2E2A9A0", VA = "0x182E2BFA0")]
		private static extern void Finalize();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C030", Offset = "0x2E2AA30", VA = "0x182E2C030")]
		private static extern int GetDisplayCount();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C160", Offset = "0x2E2AB60", VA = "0x182E2C160")]
		private static extern int GetDisplayLeft(int id);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C480", Offset = "0x2E2AE80", VA = "0x182E2C480")]
		private static extern int GetDisplayTop(int id);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C520", Offset = "0x2E2AF20", VA = "0x182E2C520")]
		private static extern int GetDisplayWidth(int id);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C0C0", Offset = "0x2E2AAC0", VA = "0x182E2C0C0")]
		private static extern int GetDisplayHeight(int id);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C820", Offset = "0x2E2B220", VA = "0x182E2C820")]
		public DXGIDisplays()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E2BFA0", Offset = "0x2E2A9A0", VA = "0x182E2BFA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C200", Offset = "0x2E2AC00", VA = "0x182E2C200")]
		public Rect GetDisplayRect(int displayId)
		{
			return default(Rect);
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
