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
		[Cpp2IlInjected.Address(RVA = "0x81B79A0", Offset = "0x81B69A0", VA = "0x1881B79A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class NTCQNAQBCLQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread LSCPZPFFHEW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool QIVPYTNDMYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x81B7900", Offset = "0x81B6900", VA = "0x1881B7900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81B7950", Offset = "0x81B6950", VA = "0x1881B7950")]
		[RRRuntimeInitializeMethod]
		internal static void MTTBWJSTHKM()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface SICZKWXFWGM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent KXUETLROOHD;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent BPVKLNDYDVI;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent ESMOMPJXWSO;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent YEQNTOIVGES;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent ECRIBSAKJNS;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent PXLVPPEFANH;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent NLZLUSSCBYR;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent AHXYGBLSPGW;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent IOEWGTQQDQS;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent OGDABGFOIQW;
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
		[Cpp2IlInjected.Address(RVA = "0x81B7730", Offset = "0x81B6730", VA = "0x1881B7730")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81B7830", Offset = "0x81B6830", VA = "0x1881B7830")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class APSFKYXNIIY
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool DMFSQXYHPSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81B76F0", Offset = "0x81B66F0", VA = "0x1881B76F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81B7640", Offset = "0x81B6640", VA = "0x1881B7640")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81B7600", Offset = "0x81B6600", VA = "0x1881B7600")]
		internal static void EUVQSBBSCSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface URIUIDDLYDH
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> EGSODDDZZXR;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(URIUIDDLYDH innerProvider);
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
