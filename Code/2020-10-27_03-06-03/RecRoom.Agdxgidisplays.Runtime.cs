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
			[Cpp2IlInjected.Address(RVA = "0x1FD6BF0", Offset = "0x1FD55F0", VA = "0x181FD6BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1FD70C0", Offset = "0x1FD5AC0", VA = "0x181FD70C0")]
		private static extern void LinkUnityDebugCallback(NativeUnityDebugLogCallback callback);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7150", Offset = "0x1FD5B50", VA = "0x181FD7150")]
		[MonoPInvokeCallback(typeof(NativeUnityDebugLogCallback))]
		private static void OnDebugCallback(IntPtr request, int size, int logType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7050", Offset = "0x1FD5A50", VA = "0x181FD7050")]
		private static extern void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6B80", Offset = "0x1FD5580", VA = "0x181FD6B80")]
		private static extern void Finalize();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6BF0", Offset = "0x1FD55F0", VA = "0x181FD6BF0")]
		private static extern int GetDisplayCount();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6CE0", Offset = "0x1FD56E0", VA = "0x181FD6CE0")]
		private static extern int GetDisplayLeft(int id);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6F50", Offset = "0x1FD5950", VA = "0x181FD6F50")]
		private static extern int GetDisplayTop(int id);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6FD0", Offset = "0x1FD59D0", VA = "0x181FD6FD0")]
		private static extern int GetDisplayWidth(int id);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6C60", Offset = "0x1FD5660", VA = "0x181FD6C60")]
		private static extern int GetDisplayHeight(int id);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7270", Offset = "0x1FD5C70", VA = "0x181FD7270")]
		public DXGIDisplays()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6B80", Offset = "0x1FD5580", VA = "0x181FD6B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6D60", Offset = "0x1FD5760", VA = "0x181FD6D60")]
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
