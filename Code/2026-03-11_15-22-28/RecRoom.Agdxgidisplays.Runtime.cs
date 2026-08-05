using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DXGI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class TGQDQSZDYWY : IDisposable
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
		public int GAWRJWPCFUK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8166D60", Offset = "0x8165D60", VA = "0x188166D60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8167040", Offset = "0x8166040", VA = "0x188167040")]
		private static extern void LinkUnityDebugCallback(NativeUnityDebugLogCallback callback);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81670D0", Offset = "0x81660D0", VA = "0x1881670D0")]
		[MonoPInvokeCallback(typeof(NativeUnityDebugLogCallback))]
		private static void MWGCKBLMDOO(IntPtr a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8166FD0", Offset = "0x8165FD0", VA = "0x188166FD0")]
		private static extern void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8166CF0", Offset = "0x8165CF0", VA = "0x188166CF0")]
		private static extern void Finalize();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8166D60", Offset = "0x8165D60", VA = "0x188166D60")]
		private static extern int GetDisplayCount();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8166E50", Offset = "0x8165E50", VA = "0x188166E50")]
		private static extern int GetDisplayLeft(int id);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8166ED0", Offset = "0x8165ED0", VA = "0x188166ED0")]
		private static extern int GetDisplayTop(int id);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8166F50", Offset = "0x8165F50", VA = "0x188166F50")]
		private static extern int GetDisplayWidth(int id);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8166DD0", Offset = "0x8165DD0", VA = "0x188166DD0")]
		private static extern int GetDisplayHeight(int id);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81673B0", Offset = "0x81663B0", VA = "0x1881673B0")]
		public TGQDQSZDYWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8166CF0", Offset = "0x8165CF0", VA = "0x188166CF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81671D0", Offset = "0x81661D0", VA = "0x1881671D0")]
		public Rect ZFXGKKIWPGT(int a)
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
