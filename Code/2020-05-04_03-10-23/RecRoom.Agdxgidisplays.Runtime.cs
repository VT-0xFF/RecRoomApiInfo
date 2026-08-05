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
			[Cpp2IlInjected.Address(RVA = "0x2A002E0", Offset = "0x29FF0E0", VA = "0x182A002E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A00900", Offset = "0x29FF700", VA = "0x182A00900")]
		private static extern void LinkUnityDebugCallback(NativeUnityDebugLogCallback callback);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A009B0", Offset = "0x29FF7B0", VA = "0x182A009B0")]
		[MonoPInvokeCallback(typeof(NativeUnityDebugLogCallback))]
		private static void OnDebugCallback(IntPtr request, int size, int logType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A00870", Offset = "0x29FF670", VA = "0x182A00870")]
		private static extern void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A00250", Offset = "0x29FF050", VA = "0x182A00250")]
		private static extern void Finalize();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A002E0", Offset = "0x29FF0E0", VA = "0x182A002E0")]
		private static extern int GetDisplayCount();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A00410", Offset = "0x29FF210", VA = "0x182A00410")]
		private static extern int GetDisplayLeft(int id);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A00730", Offset = "0x29FF530", VA = "0x182A00730")]
		private static extern int GetDisplayTop(int id);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A007D0", Offset = "0x29FF5D0", VA = "0x182A007D0")]
		private static extern int GetDisplayWidth(int id);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A00370", Offset = "0x29FF170", VA = "0x182A00370")]
		private static extern int GetDisplayHeight(int id);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A00AD0", Offset = "0x29FF8D0", VA = "0x182A00AD0")]
		public DXGIDisplays()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A00250", Offset = "0x29FF050", VA = "0x182A00250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A004B0", Offset = "0x29FF2B0", VA = "0x182A004B0")]
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
