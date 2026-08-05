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
			[Cpp2IlInjected.Address(RVA = "0x33212E0", Offset = "0x33204E0", VA = "0x1833212E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x33217B0", Offset = "0x33209B0", VA = "0x1833217B0")]
		private static extern void LinkUnityDebugCallback(NativeUnityDebugLogCallback callback);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3321840", Offset = "0x3320A40", VA = "0x183321840")]
		[MonoPInvokeCallback(typeof(NativeUnityDebugLogCallback))]
		private static void OnDebugCallback(IntPtr request, int size, int logType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3321740", Offset = "0x3320940", VA = "0x183321740")]
		private static extern void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3321270", Offset = "0x3320470", VA = "0x183321270")]
		private static extern void Finalize();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x33212E0", Offset = "0x33204E0", VA = "0x1833212E0")]
		private static extern int GetDisplayCount();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x33213D0", Offset = "0x33205D0", VA = "0x1833213D0")]
		private static extern int GetDisplayLeft(int id);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3321640", Offset = "0x3320840", VA = "0x183321640")]
		private static extern int GetDisplayTop(int id);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33216C0", Offset = "0x33208C0", VA = "0x1833216C0")]
		private static extern int GetDisplayWidth(int id);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3321350", Offset = "0x3320550", VA = "0x183321350")]
		private static extern int GetDisplayHeight(int id);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3321960", Offset = "0x3320B60", VA = "0x183321960")]
		public DXGIDisplays()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3321270", Offset = "0x3320470", VA = "0x183321270", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3321450", Offset = "0x3320650", VA = "0x183321450")]
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
