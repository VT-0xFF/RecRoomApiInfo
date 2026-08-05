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
		[Cpp2IlInjected.Address(RVA = "0x81D7580", Offset = "0x81D6380", VA = "0x1881D7580", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class YEDEFLZTUOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread VQHHLOBOAXU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool TJHBVJQCRCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x81D7530", Offset = "0x81D6330", VA = "0x1881D7530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81D74D0", Offset = "0x81D62D0", VA = "0x1881D74D0")]
		[RRRuntimeInitializeMethod]
		internal static void RZIXSWHMNAI()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FLEFZDAPWTS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent XXYYIMDEDHX;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent UMQLZMHGDYC;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent FXJKMHLFAYC;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent BLTXHQNYPSC;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent RJNOWKJAIDC;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent WZQIJPTHZQN;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent VZAWOVUSKSR;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent CKESMZHAUZM;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent PLKLCFKIYDY;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent MAPNZYZNTKW;
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
		[Cpp2IlInjected.Address(RVA = "0x81D71D0", Offset = "0x81D5FD0", VA = "0x1881D71D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81D72D0", Offset = "0x81D60D0", VA = "0x1881D72D0")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YCCFRSHUQQI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool UTACLTGJOIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81D7490", Offset = "0x81D6290", VA = "0x1881D7490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81D73A0", Offset = "0x81D61A0", VA = "0x1881D73A0")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81D7450", Offset = "0x81D6250", VA = "0x1881D7450")]
		internal static void MEERROVAUUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GCJMOBMAWTP
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> SBRSKBKUXZV;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(GCJMOBMAWTP innerProvider);
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
