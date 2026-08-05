using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_ApplicationLifecycle_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x956DC80", Offset = "0x956C680", VA = "0x18956DC80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class AXHXPYAICLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread TMKBGNDKIOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ZXAIUVYSBST
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x956D930", Offset = "0x956C330", VA = "0x18956D930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x956D8D0", Offset = "0x956C2D0", VA = "0x18956D8D0")]
		[RRRuntimeInitializeMethod]
		internal static void TRWAHLHDOMR()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PPZYJVSYXNF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent UMIRIARWSZC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent AVOZDGIRMXR;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent TROZIORBWRH;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent LMUFCDFKYXN;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent YZNWJCVOYSF;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent KLAGENJUNFM;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent SQZDZXHEWJE;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent ULNVRITYTPT;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent IOAQXUZGTPZ;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent AAGDRSQJJXF;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void UpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void FixedUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void LateUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void PreRenderUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void LatePreRenderUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void RigidbodyExLateUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void PostNetworkReceiveEvent();
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void PostUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void ApplicationFocusEvent(bool hasFocus);
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void EndOfFrameEvent();
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x956D980", Offset = "0x956C380", VA = "0x18956D980")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x956DA80", Offset = "0x956C480", VA = "0x18956DA80")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class GJAJZEIGHXB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool ZKEWHPJGEUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x956DC40", Offset = "0x956C640", VA = "0x18956DC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x956DB50", Offset = "0x956C550", VA = "0x18956DB50")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x956DC00", Offset = "0x956C600", VA = "0x18956DC00")]
		internal static void KFINLCSZMIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ELJHPRQZQVA
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> CUGSBIOMFAQ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(ELJHPRQZQVA innerProvider);
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
