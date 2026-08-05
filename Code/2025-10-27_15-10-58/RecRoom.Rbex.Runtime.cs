using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.Core.Culling;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel;
using RecRoom.Rbex;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB4C0", Offset = "0x8EEA4C0", VA = "0x188EEB4C0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88DA640", Offset = "0x88D9640", VA = "0x1888DA640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFBF0", Offset = "0x8EFEBF0", VA = "0x188EFFBF0")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFB90", Offset = "0x8EFEB90", VA = "0x188EFFB90", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFED0", Offset = "0x8EFEED0", VA = "0x188EFFED0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, TMDZFQKERCW, BEQJGZNJVRX, ZVBIZIVXWCD
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log QKSEZEVEECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool OAWHZQHTSXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private XJZTLTZGAWA YGYRWQTKLTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[TooltipAttribute("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[TooltipAttribute("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Transform BGKZGOSZLJT;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal XJZTLTZGAWA UBQXSNUIYVR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8EEEBC0", Offset = "0x8EEDBC0", VA = "0x188EEEBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private XJZTLTZGAWA VHIKDTUULTN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int QLTDVVCUBDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0A60", Offset = "0x8EEFA60", VA = "0x188EF0A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OWAQMKKLRVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0DC0", Offset = "0x8EEFDC0", VA = "0x188EF0DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0D00", Offset = "0x8EEFD00", VA = "0x188EF0D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NDQRRLBLRIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8EF19C0", Offset = "0x8EF09C0", VA = "0x188EF19C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2EC0", Offset = "0x8EF1EC0", VA = "0x188EF2EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82CAF90", Offset = "0x82C9F90", VA = "0x1882CAF90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82CB0E0", Offset = "0x82CA0E0", VA = "0x1882CB0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform SHMGNXCOSGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2603BE0", Offset = "0x2602BE0", VA = "0x182603BE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform FWELKPJIQVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2603BE0", Offset = "0x2602BE0", VA = "0x182603BE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform KIAPFLNRTTO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2603BE0", Offset = "0x2602BE0", VA = "0x182603BE0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate TQURSMCBUBU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0AC0", Offset = "0x8EEFAC0", VA = "0x188EF0AC0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2670", Offset = "0x8EF1670", VA = "0x188EF2670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NZIWLYFHMIP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF10D0", Offset = "0x8EF00D0", VA = "0x188EF10D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool AZKGNCYZVPF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0BE0", Offset = "0x8EEFBE0", VA = "0x188EF0BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ENQIPYASMUS CMHQPJCCYML
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1010", Offset = "0x8EF0010", VA = "0x188EF1010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2830", Offset = "0x8EF1830", VA = "0x188EF2830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RRFQKYGWMGB DHTKKHZKWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0FB0", Offset = "0x8EEFFB0", VA = "0x188EF0FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8EF27C0", Offset = "0x8EF17C0", VA = "0x188EF27C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ZXQJCAPJPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0F00", Offset = "0x8EEFF00", VA = "0x188EF0F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0F60", Offset = "0x8EEFF60", VA = "0x188EF0F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QFWLKDKKNRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0C40", Offset = "0x8EEFC40", VA = "0x188EF0C40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8EF26E0", Offset = "0x8EF16E0", VA = "0x188EF26E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LIENDGCEWYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A91670", Offset = "0x1A90670", VA = "0x181A91670", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float AOERBTNFPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1960", Offset = "0x8EF0960", VA = "0x188EF1960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IJNMFPCSZPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1900", Offset = "0x8EF0900", VA = "0x188EF1900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2E50", Offset = "0x8EF1E50", VA = "0x188EF2E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float UECLNWWWEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1330", Offset = "0x8EF0330", VA = "0x188EF1330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2AD0", Offset = "0x8EF1AD0", VA = "0x188EF2AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float YTGLAAQBOUD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1130", Offset = "0x8EF0130", VA = "0x188EF1130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF28A0", Offset = "0x8EF18A0", VA = "0x188EF28A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KVDZDPXVHWG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1F10", Offset = "0x8EF0F10", VA = "0x188EF1F10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3400", Offset = "0x8EF2400", VA = "0x188EF3400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 TNPUHGHTHGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8EF16E0", Offset = "0x8EF06E0", VA = "0x188EF16E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2C20", Offset = "0x8EF1C20", VA = "0x188EF2C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 BHSLYUKEUNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2050", Offset = "0x8EF1050", VA = "0x188EF2050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode EKYTYQUVGQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1270", Offset = "0x8EF0270", VA = "0x188EF1270")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8EF29F0", Offset = "0x8EF19F0", VA = "0x188EF29F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float GBLJCTNXKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0CA0", Offset = "0x8EEFCA0", VA = "0x188EF0CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2750", Offset = "0x8EF1750", VA = "0x188EF2750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints CSRIRHJEXQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8EF12D0", Offset = "0x8EF02D0", VA = "0x188EF12D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2A60", Offset = "0x8EF1A60", VA = "0x188EF2A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BKWTXFIXKKN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1A80", Offset = "0x8EF0A80", VA = "0x188EF1A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 AOSHCGTDGCT
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1A80", Offset = "0x8EF0A80", VA = "0x188EF1A80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF31E0", Offset = "0x8EF21E0", VA = "0x188EF31E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MAMIHGPUNAS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF17C0", Offset = "0x8EF07C0", VA = "0x188EF17C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2D00", Offset = "0x8EF1D00", VA = "0x188EF2D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float CBGDGKBTOMX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1EB0", Offset = "0x8EF0EB0", VA = "0x188EF1EB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3390", Offset = "0x8EF2390", VA = "0x188EF3390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion WVSHGJGLILW
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1B60", Offset = "0x8EF0B60", VA = "0x188EF1B60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2F60", Offset = "0x8EF1F60", VA = "0x188EF2F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PDGEEDKFJVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1DE0", Offset = "0x8EF0DE0", VA = "0x188EF1DE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8EF32C0", Offset = "0x8EF22C0", VA = "0x188EF32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CBWVDTGQICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1C30", Offset = "0x8EF0C30", VA = "0x188EF1C30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3030", Offset = "0x8EF2030", VA = "0x188EF3030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion NJQUBRBTMXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1D10", Offset = "0x8EF0D10", VA = "0x188EF1D10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3110", Offset = "0x8EF2110", VA = "0x188EF3110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 YJMQICFRIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1F70", Offset = "0x8EF0F70", VA = "0x188EF1F70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3470", Offset = "0x8EF2470", VA = "0x188EF3470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 UEBDMTKCLRZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1820", Offset = "0x8EF0820", VA = "0x188EF1820")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2D70", Offset = "0x8EF1D70", VA = "0x188EF2D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 QCIFKUJJGQK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1190", Offset = "0x8EF0190", VA = "0x188EF1190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2910", Offset = "0x8EF1910", VA = "0x188EF2910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 QMHRRANNSBH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1600", Offset = "0x8EF0600", VA = "0x188EF1600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2B40", Offset = "0x8EF1B40", VA = "0x188EF2B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 YJVMLLZSLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8EF14C0", Offset = "0x8EF04C0", VA = "0x188EF14C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion PJGBBJPZEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8EF13F0", Offset = "0x8EF03F0", VA = "0x188EF13F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 YWNWJCJVBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2210", Offset = "0x8EF1210", VA = "0x188EF2210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 NRDLYWYNMWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2130", Offset = "0x8EF1130", VA = "0x188EF2130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool QLSFIHGNQBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8EF15A0", Offset = "0x8EF05A0", VA = "0x188EF15A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IIUDYPLQEWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1070", Offset = "0x8EF0070", VA = "0x188EF1070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ISYXZILMEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0B80", Offset = "0x8EEFB80", VA = "0x188EF0B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ORTXJIXPDLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0B20", Offset = "0x8EEFB20", VA = "0x188EF0B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JXVNZIJYKUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0A00", Offset = "0x8EEFA00", VA = "0x188EF0A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool RAPBMAMGTIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF1390", Offset = "0x8EF0390", VA = "0x188EF1390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xEC9940", Offset = "0xEC8940", VA = "0x180EC9940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction LALKDZUYMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0920", Offset = "0x8EEF920", VA = "0x188EF0920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2590", Offset = "0x8EF1590", VA = "0x188EF2590")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction GYEYMQHDVBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0690", Offset = "0x8EEF690", VA = "0x188EF0690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8EF22F0", Offset = "0x8EF12F0", VA = "0x188EF22F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction MGQFGEJOMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8EF06F0", Offset = "0x8EEF6F0", VA = "0x188EF06F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2360", Offset = "0x8EF1360", VA = "0x188EF2360")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction NFMMJNIKNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0840", Offset = "0x8EEF840", VA = "0x188EF0840")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8EF24B0", Offset = "0x8EF14B0", VA = "0x188EF24B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> OUHNYQSRYSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8EF07D0", Offset = "0x8EEF7D0", VA = "0x188EF07D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2440", Offset = "0x8EF1440", VA = "0x188EF2440")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction WWKNWCZVYTU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF08B0", Offset = "0x8EEF8B0", VA = "0x188EF08B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2520", Offset = "0x8EF1520", VA = "0x188EF2520")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction DYIDUSMESUI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0990", Offset = "0x8EEF990", VA = "0x188EF0990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF2600", Offset = "0x8EF1600", VA = "0x188EF2600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction FWYUDRKYADZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF0760", Offset = "0x8EEF760", VA = "0x188EF0760")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF23D0", Offset = "0x8EF13D0", VA = "0x188EF23D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20", Slot = "8")]
		private void RBDHEUFMZOR(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF100", Offset = "0x8EEE100", VA = "0x188EEF100", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF190", Offset = "0x8EEE190", VA = "0x188EEF190")]
		internal void HVRVTZZYTII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF03B0", Offset = "0x8EEF3B0", VA = "0x188EF03B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEE50", Offset = "0x8EEDE50", VA = "0x188EEEE50")]
		public TMDZFQKERCW GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0070", Offset = "0x8EEF070", VA = "0x188EF0070")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE9F0", Offset = "0x8EED9F0", VA = "0x188EEE9F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0300", Offset = "0x8EEF300", VA = "0x188EF0300")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEBC0", Offset = "0x8EEDBC0", VA = "0x188EEEBC0")]
		private XJZTLTZGAWA BCXIUGQMCER()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF780", Offset = "0x8EEE780", VA = "0x188EEF780")]
		private void RTFNZEQTDKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF6C0", Offset = "0x8EEE6C0", VA = "0x188EEF6C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF600", Offset = "0x8EEE600", VA = "0x188EEF600")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF190", Offset = "0x8EEE190", VA = "0x188EEF190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF660", Offset = "0x8EEE660", VA = "0x188EEF660")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF720", Offset = "0x8EEE720", VA = "0x188EEF720")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE040", Offset = "0x8EED040", VA = "0x188EEE040")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF900", Offset = "0x8EEE900", VA = "0x188EEF900")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEDF0", Offset = "0x8EEDDF0", VA = "0x188EEEDF0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF590", Offset = "0x8EEE590", VA = "0x188EEF590")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF01D0", Offset = "0x8EEF1D0", VA = "0x188EF01D0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFC10", Offset = "0x8EEEC10", VA = "0x188EEFC10")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF220", Offset = "0x8EEE220", VA = "0x188EEF220")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF320", Offset = "0x8EEE320", VA = "0x188EEF320")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE2B0", Offset = "0x8EED2B0", VA = "0x188EEE2B0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF970", Offset = "0x8EEE970", VA = "0x188EEF970")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE320", Offset = "0x8EED320", VA = "0x188EEE320")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF9E0", Offset = "0x8EEE9E0", VA = "0x188EEF9E0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0150", Offset = "0x8EEF150", VA = "0x188EF0150")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFF70", Offset = "0x8EEEF70", VA = "0x188EEFF70")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFE70", Offset = "0x8EEEE70", VA = "0x188EEFE70")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEFF0", Offset = "0x8EEDFF0", VA = "0x188EEEFF0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEEE0", Offset = "0x8EEDEE0", VA = "0x188EEEEE0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE1C0", Offset = "0x8EED1C0", VA = "0x188EEE1C0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE0B0", Offset = "0x8EED0B0", VA = "0x188EEE0B0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE4F0", Offset = "0x8EED4F0", VA = "0x188EEE4F0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE390", Offset = "0x8EED390", VA = "0x188EEE390")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0480", Offset = "0x8EEF480", VA = "0x188EF0480")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF480", Offset = "0x8EEE480", VA = "0x188EEF480")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEED90", Offset = "0x8EEDD90", VA = "0x188EEED90")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEED30", Offset = "0x8EEDD30", VA = "0x188EEED30")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEECD0", Offset = "0x8EEDCD0", VA = "0x188EEECD0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEC70", Offset = "0x8EEDC70", VA = "0x188EEEC70")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFD70", Offset = "0x8EEED70", VA = "0x188EEFD70")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFC70", Offset = "0x8EEEC70", VA = "0x188EEFC70")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFB30", Offset = "0x8EEEB30", VA = "0x188EEFB30")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0310", Offset = "0x8EEF310", VA = "0x188EF0310")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF420", Offset = "0x8EEE420", VA = "0x188EEF420")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8EF02A0", Offset = "0x8EEF2A0", VA = "0x188EF02A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0420", Offset = "0x8EEF420", VA = "0x188EF0420")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE480", Offset = "0x8EED480", VA = "0x188EEE480")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFA50", Offset = "0x8EEEA50", VA = "0x188EEFA50")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE880", Offset = "0x8EED880", VA = "0x188EEE880")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE780", Offset = "0x8EED780", VA = "0x188EEE780")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE940", Offset = "0x8EED940", VA = "0x188EEE940")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE6B0", Offset = "0x8EED6B0", VA = "0x188EEE6B0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE5E0", Offset = "0x8EED5E0", VA = "0x188EEE5E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFAC0", Offset = "0x8EEEAC0", VA = "0x188EEFAC0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EEF5F0", Offset = "0x8EEE5F0", VA = "0x188EEF5F0", Slot = "13")]
		private void NEJYJIAWCKG(KTZYOSJORDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EF0620", Offset = "0x8EEF620", VA = "0x188EF0620")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB40050", Offset = "0xB3F050", VA = "0x180B40050", Slot = "4")]
		private GameObject VAFQLNYMVWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF9F50", Offset = "0xAF8F50", VA = "0x180AF9F50", Slot = "10")]
		private bool BNWFRWAFNPA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class TSJVDLCAOWL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4FA0", Offset = "0x8EF3FA0", VA = "0x188EF4FA0")]
		public static XJZTLTZGAWA UBQXSNUIYVR(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(JWAVYXAPLSF), new string[] { })]
	public class RigidbodyExManager : JWAVYXAPLSF, GLEZUUFUFAX
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private SMIYUFKVXVA RGMEXGNFAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private VTRJYPGONIF NHPQGIPHOMB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public SMIYUFKVXVA NCNXGUZVGDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public VTRJYPGONIF HSRHZTGFXFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDE10", Offset = "0x8EECE10", VA = "0x188EEDE10", Slot = "7")]
		public void InitReferences(GQPULEKOHTO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDE80", Offset = "0x8EECE80", VA = "0x188EEDE80", Slot = "6")]
		public XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static JICXVMFHZKR UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CUDIVOZKCUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int UJWZSGOHRDD;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB950", Offset = "0x8EEA950", VA = "0x188EEB950")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB9D0", Offset = "0x8EEA9D0", VA = "0x188EEB9D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB970", Offset = "0x8EEA970", VA = "0x188EEB970")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBAD0", Offset = "0x8EEAAD0", VA = "0x188EEBAD0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ZOXVIDWOPSF
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class AXREWWGWUFD : ENQIPYASMUS, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xADE460", Offset = "0xADD460", VA = "0x180ADE460", Slot = "4")]
			public Vector3 IEJZLLGPFRO()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xADE460", Offset = "0xADD460", VA = "0x180ADE460", Slot = "5")]
			public Vector3 XBFMUHPXOVZ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "6")]
			public bool YNHUZFUDQEC(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public AXREWWGWUFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static ENQIPYASMUS NOJHOWUWEWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8EFFAC0", Offset = "0x8EFEAC0", VA = "0x188EFFAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface WNZUZFSUFYG
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode VSGEISVUTZL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WFEHNOGRBMP(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SWNVAGZQUBY(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MPJGZXXNDTJ(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface KHQDFQZAVOH : IDisposable, XNMRNNMTFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate TQURSMCBUBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> OUHNYQSRYSP;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VTRJYPGONIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GGOEXTYVIIM YMURTOINFAY(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FRAVEFYZJKG AJMGSCSHYFM(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XCDITRWSHZJ JBZNPTFGAZF(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CITIINMQJWM VLNEVJCYWWI(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		EEGCTYPDGNS IZPLWQQMNTS(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KHQDFQZAVOH XQJNFJFXNHV(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		LNHETRIJOTM CJYVJNISTUG(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		SDDHIVXMGFW GFNKNSMJICU(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		WNZUZFSUFYG JJCTDXGQPEW(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		PEEHVCQILPP ISFRZKGHXHH(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		EYOAFWXEHHT TRMTNPSFVQJ(XJZTLTZGAWA a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		HWNRSPGDOBB XMDUFHYWDEX(XJZTLTZGAWA a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		GNHQYMTGYNP QLJAANXXGOF(XJZTLTZGAWA a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		TYJTCMYXHOD IDKPAUMTYXF(XJZTLTZGAWA a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		QQEXSUJQEOP LAYOFUBXOXV(XJZTLTZGAWA a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a, RigidbodyExData b, JWAVYXAPLSF c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SDDHIVXMGFW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AJUZSHPTJLB(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMEZSBZYUVX(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VTFUZCZLODI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UNSPZCMZOGS(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface PEEHVCQILPP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool XBKZPUZJDAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ACMSCDEEPOJ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GGOEXTYVIIM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<XJZTLTZGAWA> ZBIKSKYEZRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		XJZTLTZGAWA BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		XJZTLTZGAWA JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction GYEYMQHDVBT;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction MGQFGEJOMDB;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction GYMPLDWUPIT;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action DRGHUKCQRES;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action IECNNIPRFVR;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<XJZTLTZGAWA> WTPSJPQZOLQ;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<XJZTLTZGAWA> UJXZGFBKOGB;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action HJGGGHOPBCW;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<XJZTLTZGAWA> TUBRFXRJKEP;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(XJZTLTZGAWA newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface XCDITRWSHZJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 QCDXDVYXYSS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 GMMZBJRQMSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PTFMBWTRBIM(XJZTLTZGAWA a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GJIKBSTVMSF(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface TYJTCMYXHOD
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 DKXFDXYZZPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 IEQCHLYWUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float MGLAWITLWEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float QNKISPLBYSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 JIUZZLYAAYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion MGBIOHGCALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction DGLHZNXSPRV;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KXNVYIKFFVQ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LKFVXGQYWEN();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TNOQAZXMECS();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void YADQZKCJUKE();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ACMSCDEEPOJ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface GNHQYMTGYNP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DMLYNDFCBBY(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IWSKOLAUUTL(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QXIHRXQIWGF(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OOLZMIELVNS(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LWUOBWVVYBX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LNHETRIJOTM
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool QNTHQBGQRNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction IOQKIGMQNHE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LYQLVHGXGNT(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HIERIGGYWKO(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XPJYMFVQJCY(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ACMSCDEEPOJ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HWNRSPGDOBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool NZIWLYFHMIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool AZKGNCYZVPF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction USSSUJVHDGQ;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TGPQVUQEWKT(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ATQUNCHWZPR(XJZTLTZGAWA a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QQEXSUJQEOP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool QFWLKDKKNRS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool SNXOYZKCVUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints KKRNWXZCYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ACMSCDEEPOJ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CITIINMQJWM
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float LEENVEAOBNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float VHIKLXPOFIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ACMSCDEEPOJ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface EEGCTYPDGNS
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool BVNXWLFFAGM;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction IEFSZGIDFCQ;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ACHZMMPSYGI();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GJRQMNCQZTU();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool XRERRFEUHUI();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool THPATHMDUVH();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JAGJZWQIODN(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MBKWWJZFSMU();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface EYOAFWXEHHT
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool XTGUXUNCCRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LAEYFUEGCRU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UGLHSYOEAXH(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VVSHGFTLYXC();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface FRAVEFYZJKG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		ENQIPYASMUS CMHQPJCCYML
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		RRFQKYGWMGB DHTKKHZKWQO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 QZEZETLJXDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 CCVHKZVVEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 GNRMVEDAEJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 BSIHZNGLUDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float GBLJCTNXKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool ZXQJCAPJPUU
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OJMHLQZOUJI(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void QVSLINJLLLK(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ZAFLRRHNGQJ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void FZYQDONGZPJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void HWMIHWBXVJZ();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ANCITXHEJVS();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void BKRUGKJRXIV();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void YAFAPCTPCFT();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void PGCLSGLMDDW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 URKULLRUWFY(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void XSXCYSAPQQJ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void PDUJNJKGVPX(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void LIPHXDEKFCI(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void TDGUNAHJSQV(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 GRFQMSNSDOU(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 MOQOGIJZMWK(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SMIYUFKVXVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool GMWORIDQLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TGDUYKPYTIH(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JOEHKBWREBQ(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ORMLYXCEUES BCFXCWCNGCB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GOCXFAWJUZR(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JWAVYXAPLSF
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		SMIYUFKVXVA NCNXGUZVGDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		VTRJYPGONIF HSRHZTGFXFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class VZRLFVWCNBN : XJZTLTZGAWA, IDisposable, FUIFYLTYZOT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly JWAVYXAPLSF LFODWQYYRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal GGOEXTYVIIM JPXCADTCCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal GNHQYMTGYNP WLKQDGNWVHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal HWNRSPGDOBB IWWUQQVVKSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal FRAVEFYZJKG YJMQICFRIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal XCDITRWSHZJ DGIHVKKARJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal TYJTCMYXHOD SIFQKYCWBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal CITIINMQJWM UTCABERJYOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal PEEHVCQILPP BWSHLATVYIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal EEGCTYPDGNS IIROPSMSRAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal KHQDFQZAVOH HDKCACFFNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal LNHETRIJOTM PHCYSEOLLVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal SDDHIVXMGFW RFWKNNYETNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal QQEXSUJQEOP IDZIDDGAVCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal EYOAFWXEHHT JZZEJBBCWNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal WNZUZFSUFYG NCEWWPGIXTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable WETGFGUKYCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool UBORQSPEEOJ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId RJENHRBEFWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public TMDZFQKERCW TUYSOQSUMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xC1E610", Offset = "0xC1D610", VA = "0x180C1E610", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC1E6E0", Offset = "0xC1D6E0", VA = "0x180C1E6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject NFQJYDXAFZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xADBF00", Offset = "0xADAF00", VA = "0x180ADBF00", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xADBEE0", Offset = "0xADAEE0", VA = "0x180ADBEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform CBOUXWVWQAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC1E5E0", Offset = "0xC1D5E0", VA = "0x180C1E5E0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xC1E680", Offset = "0xC1D680", VA = "0x180C1E680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7670", Offset = "0x8EF6670", VA = "0x188EF7670", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public XJZTLTZGAWA JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF99C0", Offset = "0x8EF89C0", VA = "0x188EF99C0", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB870", Offset = "0x8EFA870", VA = "0x188EFB870", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int QLTDVVCUBDW
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7B50", Offset = "0x8EF6B50", VA = "0x188EF7B50", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public XJZTLTZGAWA BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8EF62E0", Offset = "0x8EF52E0", VA = "0x188EF62E0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MTVNYVEZJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC0D0", Offset = "0x8EFB0D0", VA = "0x188EFC0D0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool NZIWLYFHMIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB7B0", Offset = "0x8EFA7B0", VA = "0x188EFB7B0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool AZKGNCYZVPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6DD0", Offset = "0x8EF5DD0", VA = "0x188EF6DD0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ENQIPYASMUS CMHQPJCCYML
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9A60", Offset = "0x8EF8A60", VA = "0x188EF9A60", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB670", Offset = "0x8EFA670", VA = "0x188EFB670", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public RRFQKYGWMGB DHTKKHZKWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB540", Offset = "0x8EFA540", VA = "0x188EFB540", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA500", Offset = "0x8EF9500", VA = "0x188EFA500", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float GBLJCTNXKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBF30", Offset = "0x8EFAF30", VA = "0x188EFBF30", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8EF66F0", Offset = "0x8EF56F0", VA = "0x188EF66F0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 CCVHKZVVEKD
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8B00", Offset = "0x8EF7B00", VA = "0x188EF8B00", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6390", Offset = "0x8EF5390", VA = "0x188EF6390", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 BSIHZNGLUDL
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8660", Offset = "0x8EF7660", VA = "0x188EF8660", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC130", Offset = "0x8EFB130", VA = "0x188EFC130", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 QZEZETLJXDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8740", Offset = "0x8EF7740", VA = "0x188EF8740", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8EF71B0", Offset = "0x8EF61B0", VA = "0x188EF71B0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 GNRMVEDAEJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6200", Offset = "0x8EF5200", VA = "0x188EF6200", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9B80", Offset = "0x8EF8B80", VA = "0x188EF9B80", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool ISYXZILMEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6CD0", Offset = "0x8EF5CD0", VA = "0x188EF6CD0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool ORTXJIXPDLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9800", Offset = "0x8EF8800", VA = "0x188EF9800", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool JXVNZIJYKUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8A20", Offset = "0x8EF7A20", VA = "0x188EF8A20", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool ZXQJCAPJPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB390", Offset = "0x8EFA390", VA = "0x188EFB390", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 QCDXDVYXYSS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7DD0", Offset = "0x8EF6DD0", VA = "0x188EF7DD0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 GMMZBJRQMSW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7CF0", Offset = "0x8EF6CF0", VA = "0x188EF7CF0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 DKXFDXYZZPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8EF5C40", Offset = "0x8EF4C40", VA = "0x188EF5C40", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8E70", Offset = "0x8EF7E70", VA = "0x188EF8E70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 IEQCHLYWUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBCC0", Offset = "0x8EFACC0", VA = "0x188EFBCC0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float MGLAWITLWEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB0E0", Offset = "0x8EFA0E0", VA = "0x188EFB0E0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float QNKISPLBYSW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA560", Offset = "0x8EF9560", VA = "0x188EFA560", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB330", Offset = "0x8EFA330", VA = "0x188EFB330", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 JIUZZLYAAYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6870", Offset = "0x8EF5870", VA = "0x188EF6870", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion MGBIOHGCALM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA8F0", Offset = "0x8EF98F0", VA = "0x188EFA8F0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float LEENVEAOBNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7820", Offset = "0x8EF6820", VA = "0x188EF7820", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8430", Offset = "0x8EF7430", VA = "0x188EF8430", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float VHIKLXPOFIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7870", Offset = "0x8EF6870", VA = "0x188EF7870", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8820", Offset = "0x8EF7820", VA = "0x188EF8820", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool XBKZPUZJDAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB760", Offset = "0x8EFA760", VA = "0x188EFB760", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6690", Offset = "0x8EF5690", VA = "0x188EF6690", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate TQURSMCBUBU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8EF77D0", Offset = "0x8EF67D0", VA = "0x188EF77D0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8BE0", Offset = "0x8EF7BE0", VA = "0x188EF8BE0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool QNTHQBGQRNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7F60", Offset = "0x8EF6F60", VA = "0x188EF7F60", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform KIAPFLNRTTO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC1E5E0", Offset = "0xC1D5E0", VA = "0x180C1E5E0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 ABOALKNYRTC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7FC0", Offset = "0x8EF6FC0", VA = "0x188EF7FC0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6750", Offset = "0x8EF5750", VA = "0x188EF6750", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float QGZFXJVAJIS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7FB0", Offset = "0x8EF6FB0", VA = "0x188EF7FB0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9590", Offset = "0x8EF8590", VA = "0x188EF9590", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float ZKIWDAFNCXP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBEC0", Offset = "0x8EFAEC0", VA = "0x188EFBEC0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8EF98C0", Offset = "0x8EF88C0", VA = "0x188EF98C0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion COGJZYLHQKN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9AE0", Offset = "0x8EF8AE0", VA = "0x188EF9AE0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB590", Offset = "0x8EFA590", VA = "0x188EFB590", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 FZEZTVXHVQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAFC0", Offset = "0x8EF9FC0", VA = "0x188EFAFC0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8E30", Offset = "0x8EF7E30", VA = "0x188EF8E30", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion UNSWVSOJZIW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB2F0", Offset = "0x8EFA2F0", VA = "0x188EFB2F0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9AB0", Offset = "0x8EF8AB0", VA = "0x188EF9AB0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints KKRNWXZCYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6BC0", Offset = "0x8EF5BC0", VA = "0x188EF6BC0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA5B0", Offset = "0x8EF95B0", VA = "0x188EFA5B0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool QFWLKDKKNRS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9F80", Offset = "0x8EF8F80", VA = "0x188EF9F80", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8150", Offset = "0x8EF7150", VA = "0x188EF8150", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode VSGEISVUTZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9A10", Offset = "0x8EF8A10", VA = "0x188EF9A10", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA4A0", Offset = "0x8EF94A0", VA = "0x188EFA4A0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool KFGQBXPPNGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8EF60C0", Offset = "0x8EF50C0", VA = "0x188EF60C0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool IIUDYPLQEWP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8EF74F0", Offset = "0x8EF64F0", VA = "0x188EF74F0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction GYEYMQHDVBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7720", Offset = "0x8EF6720", VA = "0x188EF7720", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6330", Offset = "0x8EF5330", VA = "0x188EF6330", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction MGQFGEJOMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6D70", Offset = "0x8EF5D70", VA = "0x188EF6D70", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA7C0", Offset = "0x8EF97C0", VA = "0x188EFA7C0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction GYMPLDWUPIT
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF5E50", Offset = "0x8EF4E50", VA = "0x188EF5E50", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7EA0", Offset = "0x8EF6EA0", VA = "0x188EF7EA0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction USSSUJVHDGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB290", Offset = "0x8EFA290", VA = "0x188EFB290", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6C10", Offset = "0x8EF5C10", VA = "0x188EF6C10", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction NFMMJNIKNCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7F00", Offset = "0x8EF6F00", VA = "0x188EF7F00", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6C70", Offset = "0x8EF5C70", VA = "0x188EF6C70", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction IEFSZGIDFCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBE60", Offset = "0x8EFAE60", VA = "0x188EFBE60", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAEC0", Offset = "0x8EF9EC0", VA = "0x188EFAEC0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> OUHNYQSRYSP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8EF76C0", Offset = "0x8EF66C0", VA = "0x188EF76C0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB230", Offset = "0x8EFA230", VA = "0x188EFB230", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction IOQKIGMQNHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9860", Offset = "0x8EF8860", VA = "0x188EF9860", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8EF6950", Offset = "0x8EF5950", VA = "0x188EF6950", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction FWYUDRKYADZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9400", Offset = "0x8EF8400", VA = "0x188EF9400", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7000", Offset = "0x8EF6000", VA = "0x188EF7000", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC210", Offset = "0x8EFB210", VA = "0x188EFC210")]
		public VZRLFVWCNBN(GameObject a, RigidbodyEx b, JWAVYXAPLSF c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB930", Offset = "0x8EFA930", VA = "0x188EFB930", Slot = "139")]
		protected virtual void XXATPGEMOOJ(JWAVYXAPLSF a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6AC0", Offset = "0x8EF5AC0", VA = "0x188EF6AC0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5F80", Offset = "0x8EF4F80", VA = "0x188EF5F80", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9020", Offset = "0x8EF8020", VA = "0x188EF9020", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8F70", Offset = "0x8EF7F70", VA = "0x188EF8F70", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8F50", Offset = "0x8EF7F50", VA = "0x188EF8F50", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8EF78C0", Offset = "0x8EF68C0", VA = "0x188EF78C0")]
		private void JAGJZWQIODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB3E0", Offset = "0x8EFA3E0", VA = "0x188EFB3E0")]
		private void VMJTVWVESZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA9C0", Offset = "0x8EF99C0", VA = "0x188EFA9C0")]
		private void THPATHMDUVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF83B0", Offset = "0x8EF73B0", VA = "0x188EF83B0", Slot = "30")]
		public XJZTLTZGAWA LOHFFJADBRV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA610", Offset = "0x8EF9610", VA = "0x188EFA610", Slot = "98")]
		public void SetParent(XJZTLTZGAWA value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8210", Offset = "0x8EF7210", VA = "0x188EF8210", Slot = "99")]
		public void LHQXQBHCJNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBED0", Offset = "0x8EFAED0", VA = "0x188EFBED0", Slot = "100")]
		public void ZGHYOSDKPUH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8880", Offset = "0x8EF7880", VA = "0x188EF8880", Slot = "101")]
		public Vector3 MOQOGIJZMWK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF70B0", Offset = "0x8EF60B0", VA = "0x188EF70B0", Slot = "102")]
		public Vector3 GRFQMSNSDOU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBC70", Offset = "0x8EFAC70", VA = "0x188EFBC70", Slot = "103")]
		public void YAFAPCTPCFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5E00", Offset = "0x8EF4E00", VA = "0x188EF5E00", Slot = "104")]
		public void ANCITXHEJVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7780", Offset = "0x8EF6780", VA = "0x188EF7780", Slot = "105")]
		public void HWMIHWBXVJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA6D0", Offset = "0x8EF96D0", VA = "0x188EFA6D0", Slot = "106")]
		public void TDGUNAHJSQV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8270", Offset = "0x8EF7270", VA = "0x188EF8270", Slot = "107")]
		public void LIPHXDEKFCI(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8EF94B0", Offset = "0x8EF84B0", VA = "0x188EF94B0", Slot = "108")]
		public void PDUJNJKGVPX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBDA0", Offset = "0x8EFADA0", VA = "0x188EFBDA0", Slot = "109")]
		public void ZAFLRRHNGQJ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9D70", Offset = "0x8EF8D70", VA = "0x188EF9D70", Slot = "110")]
		public void QVSLINJLLLK(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6F50", Offset = "0x8EF5F50", VA = "0x188EF6F50", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void FZYQDONGZPJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB130", Offset = "0x8EFA130", VA = "0x188EFB130", Slot = "112")]
		public Vector3 URKULLRUWFY(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8560", Offset = "0x8EF7560", VA = "0x188EF8560", Slot = "113")]
		public Vector3 MBNLYFIVHXU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8EF65E0", Offset = "0x8EF55E0", VA = "0x188EF65E0", Slot = "114")]
		public void BKRUGKJRXIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6800", Offset = "0x8EF5800", VA = "0x188EF6800", Slot = "115")]
		public void DFQJCQPWUHH(XJZTLTZGAWA a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6630", Offset = "0x8EF5630", VA = "0x188EF6630", Slot = "116")]
		public void CGEXOMMZTMS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8070", Offset = "0x8EF7070", VA = "0x188EF8070", Slot = "63")]
		public void KXNVYIKFFVQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAE70", Offset = "0x8EF9E70", VA = "0x188EFAE70", Slot = "117")]
		public void TNOQAZXMECS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8360", Offset = "0x8EF7360", VA = "0x188EF8360", Slot = "118")]
		public void LKFVXGQYWEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBC20", Offset = "0x8EFAC20", VA = "0x188EFBC20", Slot = "119")]
		public void YADQZKCJUKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5BF0", Offset = "0x8EF4BF0", VA = "0x188EF5BF0", Slot = "120")]
		public bool ACHZMMPSYGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA680", Offset = "0x8EF9680", VA = "0x188EFA680", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF84F0", Offset = "0x8EF74F0", VA = "0x188EF84F0", Slot = "121")]
		public void MBKWWJZFSMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8490", Offset = "0x8EF7490", VA = "0x188EF8490", Slot = "122")]
		public void LYQLVHGXGNT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7490", Offset = "0x8EF6490", VA = "0x188EF7490", Slot = "123")]
		public void HIERIGGYWKO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB800", Offset = "0x8EFA800", VA = "0x188EFB800", Slot = "124")]
		public void XPJYMFVQJCY(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7290", Offset = "0x8EF6290", VA = "0x188EF7290", Slot = "125")]
		public void HBMLJWCRSYA(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7BC0", Offset = "0x8EF6BC0", VA = "0x188EF7BC0", Slot = "126")]
		public void JUOMTBEVEOU(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6D20", Offset = "0x8EF5D20", VA = "0x188EF6D20", Slot = "127")]
		public bool FCELNZGSOSH(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8EF69B0", Offset = "0x8EF59B0", VA = "0x188EF69B0", Slot = "128")]
		public void DMKYZAUMLCA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB8D0", Offset = "0x8EFA8D0", VA = "0x188EFB8D0", Slot = "129")]
		public void XWWDKCLTNXX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8EF81B0", Offset = "0x8EF71B0", VA = "0x188EF81B0", Slot = "130")]
		public void LAEYFUEGCRU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAF60", Offset = "0x8EF9F60", VA = "0x188EFAF60", Slot = "131")]
		public void UGLHSYOEAXH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5D20", Offset = "0x8EF4D20", VA = "0x188EF5D20", Slot = "132")]
		public void AJUZSHPTJLB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9E70", Offset = "0x8EF8E70", VA = "0x188EF9E70", Slot = "133")]
		public void RMEZSBZYUVX(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB460", Offset = "0x8EFA460", VA = "0x188EFB460", Slot = "134")]
		public void VTFUZCZLODI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB000", Offset = "0x8EFA000", VA = "0x188EFB000", Slot = "135")]
		public void UNSPZCMZOGS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8980", Offset = "0x8EF7980", VA = "0x188EF8980", Slot = "136")]
		public bool MPJGZXXNDTJ(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8FD0", Offset = "0x8EF7FD0", VA = "0x188EF8FD0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAF20", Offset = "0x8EF9F20", VA = "0x188EFAF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8D60", Offset = "0x8EF7D60", VA = "0x188EF8D60")]
		private void OKRSYRGKLYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9C60", Offset = "0x8EF8C60", VA = "0x188EF9C60")]
		private void QUFHZHOHJXN(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9620", Offset = "0x8EF8620", VA = "0x188EF9620")]
		private void PKBZUOBFSIQ(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6A10", Offset = "0x8EF5A10", VA = "0x188EF6A10")]
		private void DNFESHGLYHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6E20", Offset = "0x8EF5E20", VA = "0x188EF6E20")]
		private void FYIRYLTLPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9FD0", Offset = "0x8EF8FD0", VA = "0x188EF9FD0")]
		private void ROHFEXUTZSI(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA820", Offset = "0x8EF9820", VA = "0x188EFA820")]
		private void TGPQVUQEWKT(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5EB0", Offset = "0x8EF4EB0", VA = "0x188EF5EB0")]
		private void ATQUNCHWZPR(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBF80", Offset = "0x8EFAF80", VA = "0x188EFBF80")]
		private void ZHTBOTDEKEW(TMDZFQKERCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAA20", Offset = "0x8EF9A20", VA = "0x188EFAA20", Slot = "142")]
		protected virtual void TMSNMXOBBHV(TMDZFQKERCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA180", Offset = "0x8EF9180", VA = "0x188EFA180")]
		protected void SEIEZWGJNVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8EF90B0", Offset = "0x8EF80B0", VA = "0x188EF90B0")]
		protected void PAGLLKVOXUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8C40", Offset = "0x8EF7C40", VA = "0x188EF8C40")]
		private void NZIMJICWCDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6470", Offset = "0x8EF5470", VA = "0x188EF6470")]
		private void BIURBZCKJRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class ROHMLRHYQEV
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBD40", Offset = "0x8EEAD40", VA = "0x188EEBD40")]
		public static XJZTLTZGAWA GCOKDDTDEVU(this XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBEA0", Offset = "0x8EEAEA0", VA = "0x188EEBEA0")]
		public static bool TGCQMOONKND(this XJZTLTZGAWA a, XJZTLTZGAWA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBE00", Offset = "0x8EEAE00", VA = "0x188EEBE00")]
		public static bool ORIIMIYKTHB(this XJZTLTZGAWA a, XJZTLTZGAWA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBF40", Offset = "0x8EEAF40", VA = "0x188EEBF40")]
		public static TMDZFQKERCW XXWJXQXRYYH(this XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBCD0", Offset = "0x8EEACD0", VA = "0x188EEBCD0")]
		public static VZRLFVWCNBN Base(this XJZTLTZGAWA impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HEWTYRWIJQW : VTRJYPGONIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA1F0", Offset = "0x8EE91F0", VA = "0x188EEA1F0", Slot = "19")]
		public XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a, RigidbodyExData b, JWAVYXAPLSF c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
		public GGOEXTYVIIM YMURTOINFAY(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "5")]
		public FRAVEFYZJKG AJMGSCSHYFM(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "6")]
		public XCDITRWSHZJ JBZNPTFGAZF(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "7")]
		public CITIINMQJWM VLNEVJCYWWI(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "8")]
		public EEGCTYPDGNS IZPLWQQMNTS(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "9")]
		public KHQDFQZAVOH XQJNFJFXNHV(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "10")]
		public LNHETRIJOTM CJYVJNISTUG(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "11")]
		public SDDHIVXMGFW GFNKNSMJICU(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "12")]
		public WNZUZFSUFYG JJCTDXGQPEW(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "13")]
		public PEEHVCQILPP ISFRZKGHXHH(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		public EYOAFWXEHHT TRMTNPSFVQJ(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		public HWNRSPGDOBB XMDUFHYWDEX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		public GNHQYMTGYNP QLJAANXXGOF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		public TYJTCMYXHOD IDKPAUMTYXF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		public QQEXSUJQEOP LAYOFUBXOXV(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HEWTYRWIJQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "14")]
		private EYOAFWXEHHT KWJAOUDLKHL(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "15")]
		private HWNRSPGDOBB QHFHQCMTLKH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "16")]
		private GNHQYMTGYNP EAHJFCWATBX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "17")]
		private TYJTCMYXHOD VSNXLFQBEEH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "18")]
		private QQEXSUJQEOP HFTGOUORLMT(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(VTRJYPGONIF), new string[] { })]
	public class UVTNFENHQYH : VTRJYPGONIF, GLEZUUFUFAX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly VTRJYPGONIF WKJHSYLTDDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly VTRJYPGONIF OBBIBUKJOZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private XWIQVZIPESB XZPNMOZOPYE;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private VTRJYPGONIF HSRHZTGFXFT
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF5AF0", Offset = "0x8EF4AF0", VA = "0x188EF5AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5540", Offset = "0x8EF4540", VA = "0x188EF5540", Slot = "20")]
		public void InitReferences(GQPULEKOHTO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5A50", Offset = "0x8EF4A50", VA = "0x188EF5A50", Slot = "4")]
		public GGOEXTYVIIM YMURTOINFAY(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5010", Offset = "0x8EF4010", VA = "0x188EF5010", Slot = "5")]
		public FRAVEFYZJKG AJMGSCSHYFM(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5590", Offset = "0x8EF4590", VA = "0x188EF5590", Slot = "6")]
		public XCDITRWSHZJ JBZNPTFGAZF(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5910", Offset = "0x8EF4910", VA = "0x188EF5910", Slot = "7")]
		public CITIINMQJWM VLNEVJCYWWI(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8EF54A0", Offset = "0x8EF44A0", VA = "0x188EF54A0", Slot = "8")]
		public EEGCTYPDGNS IZPLWQQMNTS(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8EF59B0", Offset = "0x8EF49B0", VA = "0x188EF59B0", Slot = "9")]
		public KHQDFQZAVOH XQJNFJFXNHV(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8EF50B0", Offset = "0x8EF40B0", VA = "0x188EF50B0", Slot = "10")]
		public LNHETRIJOTM CJYVJNISTUG(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5200", Offset = "0x8EF4200", VA = "0x188EF5200", Slot = "11")]
		public SDDHIVXMGFW GFNKNSMJICU(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5630", Offset = "0x8EF4630", VA = "0x188EF5630", Slot = "12")]
		public WNZUZFSUFYG JJCTDXGQPEW(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5400", Offset = "0x8EF4400", VA = "0x188EF5400", Slot = "13")]
		public PEEHVCQILPP ISFRZKGHXHH(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF56D0", Offset = "0x8EF46D0", VA = "0x188EF56D0")]
		public EYOAFWXEHHT TRMTNPSFVQJ(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5860", Offset = "0x8EF4860", VA = "0x188EF5860")]
		public HWNRSPGDOBB XMDUFHYWDEX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5150", Offset = "0x8EF4150", VA = "0x188EF5150")]
		public GNHQYMTGYNP QLJAANXXGOF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5350", Offset = "0x8EF4350", VA = "0x188EF5350")]
		public TYJTCMYXHOD IDKPAUMTYXF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF52A0", Offset = "0x8EF42A0", VA = "0x188EF52A0")]
		public QQEXSUJQEOP LAYOFUBXOXV(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5780", Offset = "0x8EF4780", VA = "0x188EF5780", Slot = "19")]
		public XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a, RigidbodyExData b, JWAVYXAPLSF c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5B50", Offset = "0x8EF4B50", VA = "0x188EF5B50")]
		public UVTNFENHQYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8EF56D0", Offset = "0x8EF46D0", VA = "0x188EF56D0", Slot = "14")]
		private EYOAFWXEHHT KWJAOUDLKHL(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5860", Offset = "0x8EF4860", VA = "0x188EF5860", Slot = "15")]
		private HWNRSPGDOBB QHFHQCMTLKH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5150", Offset = "0x8EF4150", VA = "0x188EF5150", Slot = "16")]
		private GNHQYMTGYNP EAHJFCWATBX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5350", Offset = "0x8EF4350", VA = "0x188EF5350", Slot = "17")]
		private TYJTCMYXHOD VSNXLFQBEEH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8EF52A0", Offset = "0x8EF42A0", VA = "0x188EF52A0", Slot = "18")]
		private QQEXSUJQEOP HFTGOUORLMT(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface NPJGYYKWWIF : GGOEXTYVIIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XPTCUTSUPQS(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LUGQEAQQUJH(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NOEQNZHSTIQ(XJZTLTZGAWA a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JVYBJRFYFZT(XJZTLTZGAWA a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface CRPJRFQAEBA : XCDITRWSHZJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		WPDRJPNZPVI<XJZTLTZGAWA> DFZNJQQWCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		XJZTLTZGAWA DITUXHGTBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface PIZXWUTHDTW : TYJTCMYXHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) PZJUAEOOKEJ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface VVUGXARGAJU : HWNRSPGDOBB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView QOSRXWSQIVE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class FTWINWVOTRJ : WNZUZFSUFYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode RXFYFNSOZRL;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5930", Offset = "0x8EE4930", VA = "0x188EE5930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode VSGEISVUTZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5B60", Offset = "0x8EE4B60", VA = "0x188EE5B60", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5D90", Offset = "0x8EE4D90", VA = "0x188EE5D90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5E20", Offset = "0x8EE4E20", VA = "0x188EE5E20")]
		public FTWINWVOTRJ(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5820", Offset = "0x8EE4820", VA = "0x188EE5820", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5AE0", Offset = "0x8EE4AE0", VA = "0x188EE5AE0", Slot = "9")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5E10", Offset = "0x8EE4E10", VA = "0x188EE5E10", Slot = "7")]
		public void WFEHNOGRBMP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5E00", Offset = "0x8EE4E00", VA = "0x188EE5E00", Slot = "8")]
		public void SWNVAGZQUBY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5980", Offset = "0x8EE4980", VA = "0x188EE5980", Slot = "10")]
		public bool MPJGZXXNDTJ(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5C70", Offset = "0x8EE4C70", VA = "0x188EE5C70")]
		private void RHPHBKTOEFH(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BKXCFHOPZXG : KHQDFQZAVOH, IDisposable, XNMRNNMTFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate NUBPIXNNIWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ORMLYXCEUES QMHVFOQTKWC;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate TQURSMCBUBU
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3FF0", Offset = "0x8EE2FF0", VA = "0x188EE3FF0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8EE4150", Offset = "0x8EE3150", VA = "0x188EE4150", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform NLQHILIBSTP
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8EE4130", Offset = "0x8EE3130", VA = "0x188EE4130", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> OUHNYQSRYSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3F40", Offset = "0x8EE2F40", VA = "0x188EE3F40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8EE4220", Offset = "0x8EE3220", VA = "0x188EE4220", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE42D0", Offset = "0x8EE32D0", VA = "0x188EE42D0")]
		public BKXCFHOPZXG(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3C80", Offset = "0x8EE2C80", VA = "0x188EE3C80", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3EF0", Offset = "0x8EE2EF0", VA = "0x188EE3EF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x14784F0", Offset = "0x14774F0", VA = "0x1814784F0", Slot = "11")]
		private void BGIPIBOEFIG(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		private void GZEMYKUMHRE(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HEWTYRWIJQW : VTRJYPGONIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA530", Offset = "0x8EE9530", VA = "0x188EEA530", Slot = "4")]
		public GGOEXTYVIIM YMURTOINFAY(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8EE95E0", Offset = "0x8EE85E0", VA = "0x188EE95E0", Slot = "5")]
		public FRAVEFYZJKG AJMGSCSHYFM(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9DB0", Offset = "0x8EE8DB0", VA = "0x188EE9DB0", Slot = "6")]
		public XCDITRWSHZJ JBZNPTFGAZF(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA400", Offset = "0x8EE9400", VA = "0x188EEA400", Slot = "7")]
		public CITIINMQJWM VLNEVJCYWWI(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9CF0", Offset = "0x8EE8CF0", VA = "0x188EE9CF0", Slot = "8")]
		public EEGCTYPDGNS IZPLWQQMNTS(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA470", Offset = "0x8EE9470", VA = "0x188EEA470", Slot = "9")]
		public KHQDFQZAVOH XQJNFJFXNHV(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8EE96F0", Offset = "0x8EE86F0", VA = "0x188EE96F0", Slot = "10")]
		public LNHETRIJOTM CJYVJNISTUG(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9920", Offset = "0x8EE8920", VA = "0x188EE9920", Slot = "11")]
		public SDDHIVXMGFW GFNKNSMJICU(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9ED0", Offset = "0x8EE8ED0", VA = "0x188EE9ED0", Slot = "12")]
		public WNZUZFSUFYG JJCTDXGQPEW(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9C30", Offset = "0x8EE8C30", VA = "0x188EE9C30", Slot = "13")]
		public PEEHVCQILPP ISFRZKGHXHH(XJZTLTZGAWA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9F90", Offset = "0x8EE8F90", VA = "0x188EE9F90")]
		public EYOAFWXEHHT TRMTNPSFVQJ(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA280", Offset = "0x8EE9280", VA = "0x188EEA280")]
		public HWNRSPGDOBB XMDUFHYWDEX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9800", Offset = "0x8EE8800", VA = "0x188EE9800")]
		public GNHQYMTGYNP QLJAANXXGOF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9AB0", Offset = "0x8EE8AB0", VA = "0x188EE9AB0")]
		public TYJTCMYXHOD IDKPAUMTYXF(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8EE99E0", Offset = "0x8EE89E0", VA = "0x188EE99E0")]
		public QQEXSUJQEOP LAYOFUBXOXV(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA0B0", Offset = "0x8EE90B0", VA = "0x188EEA0B0", Slot = "19")]
		public XJZTLTZGAWA LIOQPZWGECP(RigidbodyEx a, RigidbodyExData b, JWAVYXAPLSF c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HEWTYRWIJQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9F90", Offset = "0x8EE8F90", VA = "0x188EE9F90", Slot = "14")]
		private EYOAFWXEHHT KWJAOUDLKHL(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA280", Offset = "0x8EE9280", VA = "0x188EEA280", Slot = "15")]
		private HWNRSPGDOBB QHFHQCMTLKH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9800", Offset = "0x8EE8800", VA = "0x188EE9800", Slot = "16")]
		private GNHQYMTGYNP EAHJFCWATBX(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9AB0", Offset = "0x8EE8AB0", VA = "0x188EE9AB0", Slot = "17")]
		private TYJTCMYXHOD VSNXLFQBEEH(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8EE99E0", Offset = "0x8EE89E0", VA = "0x188EE99E0", Slot = "18")]
		private QQEXSUJQEOP HFTGOUORLMT(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class SZGWPVRBSJV : SDDHIVXMGFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5930", Offset = "0x8EE4930", VA = "0x188EE5930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool QNTHQBGQRNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8EF39D0", Offset = "0x8EF29D0", VA = "0x188EF39D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool MTVNYVEZJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8EEADB0", Offset = "0x8EE9DB0", VA = "0x188EEADB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private XJZTLTZGAWA JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8EF3C80", Offset = "0x8EF2C80", VA = "0x188EF3C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5E20", Offset = "0x8EE4E20", VA = "0x188EE5E20")]
		public SZGWPVRBSJV(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3610", Offset = "0x8EF2610", VA = "0x188EF3610", Slot = "4")]
		public void AJUZSHPTJLB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3A20", Offset = "0x8EF2A20", VA = "0x188EF3A20")]
		private void MXZSUMJABYW(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3CE0", Offset = "0x8EF2CE0", VA = "0x188EF3CE0", Slot = "5")]
		public void RMEZSBZYUVX(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8EF41C0", Offset = "0x8EF31C0", VA = "0x188EF41C0", Slot = "6")]
		public void VTFUZCZLODI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3770", Offset = "0x8EF2770", VA = "0x188EF3770")]
		private void ECEYGIOZMFD(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3F60", Offset = "0x8EF2F60", VA = "0x188EF3F60", Slot = "7")]
		public void UNSPZCMZOGS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class RAXDFEZLNUW : PEEHVCQILPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KVDZDPXVHWG;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool XBKZPUZJDAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8EEBB90", Offset = "0x8EEAB90", VA = "0x188EEBB90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5E20", Offset = "0x8EE4E20", VA = "0x188EE5E20")]
		public RAXDFEZLNUW(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBCA0", Offset = "0x8EEACA0", VA = "0x188EEBCA0", Slot = "6")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBB20", Offset = "0x8EEAB20", VA = "0x188EEBB20", Slot = "7")]
		public void ACMSCDEEPOJ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : NPJGYYKWWIF, GGOEXTYVIIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly XJZTLTZGAWA OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<XJZTLTZGAWA> BUSNIUHSBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private XJZTLTZGAWA IMODBVGEZXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private XJZTLTZGAWA NDQRRLBLRIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform BQQVHOKVCMI;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform CBOUXWVWQAH
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC380", Offset = "0x8EEB380", VA = "0x188EEC380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public XJZTLTZGAWA JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xACEBB0", Offset = "0xACDBB0", VA = "0x180ACEBB0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8EEDCB0", Offset = "0x8EECCB0", VA = "0x188EEDCB0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public XJZTLTZGAWA BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xACEBE0", Offset = "0xACDBE0", VA = "0x180ACEBE0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<XJZTLTZGAWA> ZBIKSKYEZRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xACEBF0", Offset = "0xACDBF0", VA = "0x180ACEBF0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction GYEYMQHDVBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC5C0", Offset = "0x8EEB5C0", VA = "0x188EEC5C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC1A0", Offset = "0x8EEB1A0", VA = "0x188EEC1A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction MGQFGEJOMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC3E0", Offset = "0x8EEB3E0", VA = "0x188EEC3E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8EED720", Offset = "0x8EEC720", VA = "0x188EED720", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction GYMPLDWUPIT
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC050", Offset = "0x8EEB050", VA = "0x188EEC050", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8EECA30", Offset = "0x8EEBA30", VA = "0x188EECA30", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action DRGHUKCQRES
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8EECE00", Offset = "0x8EEBE00", VA = "0x188EECE00", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC2E0", Offset = "0x8EEB2E0", VA = "0x188EEC2E0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action IECNNIPRFVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8EED110", Offset = "0x8EEC110", VA = "0x188EED110", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8EEDCC0", Offset = "0x8EECCC0", VA = "0x188EEDCC0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<XJZTLTZGAWA> WTPSJPQZOLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8EED7C0", Offset = "0x8EEC7C0", VA = "0x188EED7C0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8EECAD0", Offset = "0x8EEBAD0", VA = "0x188EECAD0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<XJZTLTZGAWA> UJXZGFBKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8EECC20", Offset = "0x8EEBC20", VA = "0x188EECC20", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8EED870", Offset = "0x8EEC870", VA = "0x188EED870", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action HJGGGHOPBCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC480", Offset = "0x8EEB480", VA = "0x188EEC480", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC660", Offset = "0x8EEB660", VA = "0x188EEC660", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<XJZTLTZGAWA> TUBRFXRJKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC0F0", Offset = "0x8EEB0F0", VA = "0x188EEC0F0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8EEC700", Offset = "0x8EEB700", VA = "0x188EEC700", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDD60", Offset = "0x8EECD60", VA = "0x188EEDD60")]
		public RbexHierarchy(XJZTLTZGAWA rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEC240", Offset = "0x8EEB240", VA = "0x188EEC240", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8EED1B0", Offset = "0x8EEC1B0", VA = "0x188EED1B0", Slot = "30")]
		public void SetParent(XJZTLTZGAWA newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8EECEA0", Offset = "0x8EEBEA0", VA = "0x188EECEA0", Slot = "6")]
		public void NOEQNZHSTIQ(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8EEC7B0", Offset = "0x8EEB7B0", VA = "0x188EEC7B0", Slot = "7")]
		public void JVYBJRFYFZT(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDBC0", Offset = "0x8EECBC0", VA = "0x188EEDBC0", Slot = "4")]
		public void XPTCUTSUPQS(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8EECB80", Offset = "0x8EEBB80", VA = "0x188EECB80", Slot = "5")]
		public void LUGQEAQQUJH(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8EEC520", Offset = "0x8EEB520", VA = "0x188EEC520")]
		private void HBLCMGOXGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8EED920", Offset = "0x8EEC920", VA = "0x188EED920")]
		private void VTEJLNXRMQD(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDA80", Offset = "0x8EECA80", VA = "0x188EEDA80")]
		private void XLUCFQOHWWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8EECCD0", Offset = "0x8EEBCD0", VA = "0x188EECCD0")]
		private void MOPLWVHTWRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8EED960", Offset = "0x8EEC960", VA = "0x188EED960")]
		private void WCYQTBZAIBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEBF90", Offset = "0x8EEAF90", VA = "0x188EEBF90")]
		[CompilerGenerated]
		private object APXATLPXZWB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class KLEWXWHZFCR
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB400", Offset = "0x8EEA400", VA = "0x188EEB400")]
		public static NPJGYYKWWIF DMCXJCHRJYY(this XJZTLTZGAWA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class ERMVNGQUCCM : CRPJRFQAEBA, XCDITRWSHZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly WPDRJPNZPVI<XJZTLTZGAWA> ZLDZCIOCUCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool CBGRQEMJZUG;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public WPDRJPNZPVI<XJZTLTZGAWA> DFZNJQQWCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 QCDXDVYXYSS
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5500", Offset = "0x8EE4500", VA = "0x188EE5500", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 GMMZBJRQMSW
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5200", Offset = "0x8EE4200", VA = "0x188EE5200", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 QZEZETLJXDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5530", Offset = "0x8EE4530", VA = "0x188EE5530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public XJZTLTZGAWA DITUXHGTBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8EE5680", Offset = "0x8EE4680", VA = "0x188EE5680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5730", Offset = "0x8EE4730", VA = "0x188EE5730")]
		public ERMVNGQUCCM(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5610", Offset = "0x8EE4610", VA = "0x188EE5610", Slot = "8")]
		public void PTFMBWTRBIM(XJZTLTZGAWA a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4E00", Offset = "0x8EE3E00", VA = "0x188EE4E00", Slot = "9")]
		public void GJIKBSTVMSF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4A60", Offset = "0x8EE3A60", VA = "0x188EE4A60")]
		private Vector3 CVREHFMEUJK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4E60", Offset = "0x8EE3E60", VA = "0x188EE4E60")]
		private void JNVSTFHWRQJ(XJZTLTZGAWA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class PRIIFLUHAYK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB890", Offset = "0x8EEA890", VA = "0x188EEB890")]
		public static CRPJRFQAEBA NLKESVXKPDV(this XJZTLTZGAWA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class GRAACFMLEPE : PIZXWUTHDTW, TYJTCMYXHOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 SDNMUQLWTRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 CTOWBYZRCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float IJNMFPCSZPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float AOERBTNFPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 TNPUHGHTHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? YJVMLLZSLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? PJGBBJPZEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool CKJCABCNSEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool EJEPAPJWURA;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 DKXFDXYZZPO
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x20055F0", Offset = "0x20045F0", VA = "0x1820055F0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8EE75E0", Offset = "0x8EE65E0", VA = "0x188EE75E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 IEQCHLYWUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8EE9360", Offset = "0x8EE8360", VA = "0x188EE9360", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float MGLAWITLWEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1E810", Offset = "0xB1D810", VA = "0x180B1E810", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8EE7430", Offset = "0x8EE6430", VA = "0x188EE7430")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float QNKISPLBYSW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB1E820", Offset = "0xB1D820", VA = "0x180B1E820", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8EE8B50", Offset = "0x8EE7B50", VA = "0x188EE8B50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 JIUZZLYAAYM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8EE6E20", Offset = "0x8EE5E20", VA = "0x188EE6E20", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion MGBIOHGCALM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8EE8C00", Offset = "0x8EE7C00", VA = "0x188EE8C00", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8EE70D0", Offset = "0x8EE60D0", VA = "0x188EE70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction DGLHZNXSPRV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8EE7540", Offset = "0x8EE6540", VA = "0x188EE7540", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8EE7690", Offset = "0x8EE6690", VA = "0x188EE7690", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9480", Offset = "0x8EE8480", VA = "0x188EE9480")]
		public GRAACFMLEPE(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8D80", Offset = "0x8EE7D80", VA = "0x188EE8D80", Slot = "17")]
		public void TNOQAZXMECS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7350", Offset = "0x8EE6350", VA = "0x188EE7350", Slot = "16")]
		public void LKFVXGQYWEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7BF0", Offset = "0x8EE6BF0", VA = "0x188EE7BF0", Slot = "19")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6C40", Offset = "0x8EE5C40", VA = "0x188EE6C40", Slot = "20")]
		public void ACMSCDEEPOJ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE91C0", Offset = "0x8EE81C0", VA = "0x188EE91C0", Slot = "18")]
		public void YADQZKCJUKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7730", Offset = "0x8EE6730", VA = "0x188EE7730", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE75E0", Offset = "0x8EE65E0", VA = "0x188EE75E0")]
		private void UONNWOSUDSG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6FB0", Offset = "0x8EE5FB0", VA = "0x188EE6FB0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 EXQGKZZPXIZ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7430", Offset = "0x8EE6430", VA = "0x188EE7430")]
		private void LTUVYETNMWH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8B50", Offset = "0x8EE7B50", VA = "0x188EE8B50")]
		private void QTVSPKQXZSI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8EA0", Offset = "0x8EE7EA0", VA = "0x188EE8EA0")]
		private Vector3 VLJRBCVLVWC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7120", Offset = "0x8EE6120", VA = "0x188EE7120", Slot = "15")]
		public void KXNVYIKFFVQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9040", Offset = "0x8EE8040", VA = "0x188EE9040")]
		private Quaternion XOJEYSPDKAY()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7CD0", Offset = "0x8EE6CD0", VA = "0x188EE7CD0")]
		public void PZJUAEOOKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7DA0", Offset = "0x8EE6DA0", VA = "0x188EE7DA0", Slot = "4")]
		public (float, Vector3) PZJUAEOOKEJ(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class SSTLAANAPNS
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3550", Offset = "0x8EF2550", VA = "0x188EF3550")]
		public static PIZXWUTHDTW KGMRVFAWMJZ(this XJZTLTZGAWA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class EIDQUQHTTCC : GNHQYMTGYNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly VOFSXJFIEEZ NLGOGIJJWGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode YFYTWTKYVJO;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool WNDIIPITCAA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1BCD0A0", Offset = "0x1BCC0A0", VA = "0x181BCD0A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode EBHZNDTKXHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4970", Offset = "0x8EE3970", VA = "0x188EE4970")]
		public EIDQUQHTTCC(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4360", Offset = "0x8EE3360", VA = "0x188EE4360", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4430", Offset = "0x8EE3430", VA = "0x188EE4430")]
		private bool BTBASMGVLGS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE44D0", Offset = "0x8EE34D0", VA = "0x188EE44D0", Slot = "5")]
		public void DMLYNDFCBBY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4680", Offset = "0x8EE3680", VA = "0x188EE4680", Slot = "6")]
		public void IWSKOLAUUTL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE46B0", Offset = "0x8EE36B0", VA = "0x188EE46B0", Slot = "9")]
		public void LWUOBWVVYBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4860", Offset = "0x8EE3860", VA = "0x188EE4860")]
		private void UKKGPRIALAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4500", Offset = "0x8EE3500", VA = "0x188EE4500")]
		private void HQZPBEVTLKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE47E0", Offset = "0x8EE37E0", VA = "0x188EE47E0", Slot = "8")]
		public void OOLZMIELVNS(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4820", Offset = "0x8EE3820", VA = "0x188EE4820", Slot = "7")]
		public void QXIHRXQIWGF(XJZTLTZGAWA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class JFVGSGULXSJ : LNHETRIJOTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly VOFSXJFIEEZ UOYCHSFWZPK;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool QNTHQBGQRNU
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8EEB030", Offset = "0x8EEA030", VA = "0x188EEB030", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction IOQKIGMQNHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8EEB170", Offset = "0x8EEA170", VA = "0x188EEB170", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8EEAF40", Offset = "0x8EE9F40", VA = "0x188EEAF40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB320", Offset = "0x8EEA320", VA = "0x188EEB320")]
		public JFVGSGULXSJ(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB0E0", Offset = "0x8EEA0E0", VA = "0x188EEB0E0", Slot = "7")]
		public void LYQLVHGXGNT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB020", Offset = "0x8EEA020", VA = "0x188EEB020", Slot = "8")]
		public void HIERIGGYWKO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB210", Offset = "0x8EEA210", VA = "0x188EEB210", Slot = "9")]
		public void XPJYMFVQJCY(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8EEAFE0", Offset = "0x8EE9FE0", VA = "0x188EEAFE0", Slot = "12")]
		public void FLEUJCGWTLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB0F0", Offset = "0x8EEA0F0", VA = "0x188EEB0F0", Slot = "10")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8EEAF10", Offset = "0x8EE9F10", VA = "0x188EEAF10", Slot = "11")]
		public void ACMSCDEEPOJ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class GCKQKLRFGUA : VVUGXARGAJU, HWNRSPGDOBB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView IAPDKSMLFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool TNXTPLZNSCT;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView QOSRXWSQIVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool NZIWLYFHMIP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8EE6A20", Offset = "0x8EE5A20", VA = "0x188EE6A20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool AZKGNCYZVPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF83E0", Offset = "0xCF73E0", VA = "0x180CF83E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction USSSUJVHDGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8EE6980", Offset = "0x8EE5980", VA = "0x188EE6980", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8EE6240", Offset = "0x8EE5240", VA = "0x188EE6240", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6A30", Offset = "0x8EE5A30", VA = "0x188EE6A30")]
		public GCKQKLRFGUA(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6020", Offset = "0x8EE5020", VA = "0x188EE6020", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6150", Offset = "0x8EE5150", VA = "0x188EE6150", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE65A0", Offset = "0x8EE55A0", VA = "0x188EE65A0", Slot = "10")]
		public void TGPQVUQEWKT(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5EB0", Offset = "0x8EE4EB0", VA = "0x188EE5EB0", Slot = "11")]
		public void ATQUNCHWZPR(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE62E0", Offset = "0x8EE52E0", VA = "0x188EE62E0")]
		private void EWZPNYRXUUN(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6450", Offset = "0x8EE5450", VA = "0x188EE6450")]
		private void FWODPNCAJRZ(TMDZFQKERCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6710", Offset = "0x8EE5710", VA = "0x188EE6710")]
		private void TQFQSBYMDYM(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class GJVOQPGFUWO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6B80", Offset = "0x8EE5B80", VA = "0x188EE6B80")]
		public static VVUGXARGAJU Lifecycle(this XJZTLTZGAWA impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class AVAORUVNIOC : QQEXSUJQEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints CSRIRHJEXQL;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool QFWLKDKKNRS
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC28220", Offset = "0xC27220", VA = "0x180C28220", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xFA2A10", Offset = "0xFA1A10", VA = "0x180FA2A10", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool SNXOYZKCVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xC28270", Offset = "0xC27270", VA = "0x180C28270", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xFA1F80", Offset = "0xFA0F80", VA = "0x180FA1F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints KKRNWXZCYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3AB0", Offset = "0x8EE2AB0", VA = "0x188EE3AB0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3BE0", Offset = "0x8EE2BE0", VA = "0x188EE3BE0")]
		public AVAORUVNIOC(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3A80", Offset = "0x8EE2A80", VA = "0x188EE3A80", Slot = "9")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3A50", Offset = "0x8EE2A50", VA = "0x188EE3A50", Slot = "10")]
		public void ACMSCDEEPOJ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class NAGRSKCRQAZ : CITIINMQJWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly XJZTLTZGAWA OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float UECLNWWWEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float YTGLAAQBOUD;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float LEENVEAOBNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB24B00", Offset = "0xB23B00", VA = "0x180B24B00", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8EEB660", Offset = "0x8EEA660", VA = "0x188EEB660", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float VHIKLXPOFIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB24910", Offset = "0xB23910", VA = "0x180B24910", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8EEB730", Offset = "0x8EEA730", VA = "0x188EEB730", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB850", Offset = "0x8EEA850", VA = "0x188EEB850")]
		public NAGRSKCRQAZ(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB800", Offset = "0x8EEA800", VA = "0x188EEB800", Slot = "8")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB5C0", Offset = "0x8EEA5C0", VA = "0x188EEB5C0", Slot = "9")]
		public void ACMSCDEEPOJ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class TBVIKFJFBFR : EEGCTYPDGNS
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log ASQPUYZMRKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool LWKXRPZZKWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool TPPGEYQMFVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int DMRLRMOLWYJ;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8EE70D0", Offset = "0x8EE60D0", VA = "0x188EE70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool KFGQBXPPNGU
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8EF4500", Offset = "0x8EF3500", VA = "0x188EF4500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private XJZTLTZGAWA JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8EF4A50", Offset = "0x8EF3A50", VA = "0x188EF4A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool MTVNYVEZJRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8EF4E20", Offset = "0x8EF3E20", VA = "0x188EF4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction IEFSZGIDFCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8EF4D80", Offset = "0x8EF3D80", VA = "0x188EF4D80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8EF4C70", Offset = "0x8EF3C70", VA = "0x188EF4C70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4F10", Offset = "0x8EF3F10", VA = "0x188EF4F10")]
		public TBVIKFJFBFR(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4470", Offset = "0x8EF3470", VA = "0x188EF4470", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4520", Offset = "0x8EF3520", VA = "0x188EF4520", Slot = "8")]
		public void GJRQMNCQZTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4320", Offset = "0x8EF3320", VA = "0x188EF4320", Slot = "7")]
		public bool ACHZMMPSYGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4AB0", Offset = "0x8EF3AB0", VA = "0x188EF4AB0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8EF47F0", Offset = "0x8EF37F0", VA = "0x188EF47F0", Slot = "13")]
		public void MBKWWJZFSMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4530", Offset = "0x8EF3530", VA = "0x188EF4530", Slot = "12")]
		public void JAGJZWQIODN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4D10", Offset = "0x8EF3D10", VA = "0x188EF4D10", Slot = "10")]
		public bool XRERRFEUHUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4B80", Offset = "0x8EF3B80", VA = "0x188EF4B80", Slot = "11")]
		public bool THPATHMDUVH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4890", Offset = "0x8EF3890", VA = "0x188EF4890")]
		private bool OQWRKKCQTFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4660", Offset = "0x8EF3660", VA = "0x188EF4660")]
		private void LTEZRBXBMWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class IEEEXXLOQDO : EYOAFWXEHHT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly VOFSXJFIEEZ PYLIXYWHIYQ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody GDJZRRGAVUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool MTVNYVEZJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8EEADB0", Offset = "0x8EE9DB0", VA = "0x188EEADB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool XTGUXUNCCRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1BCD0A0", Offset = "0x1BCC0A0", VA = "0x181BCD0A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEAE10", Offset = "0x8EE9E10", VA = "0x188EEAE10")]
		public IEEEXXLOQDO(XJZTLTZGAWA a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA610", Offset = "0x8EE9610", VA = "0x188EEA610", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA6B0", Offset = "0x8EE96B0", VA = "0x188EEA6B0", Slot = "7")]
		public void LAEYFUEGCRU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA860", Offset = "0x8EE9860", VA = "0x188EEA860", Slot = "8")]
		public void UGLHSYOEAXH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA890", Offset = "0x8EE9890", VA = "0x188EEA890", Slot = "9")]
		public void VVSHGFTLYXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8EEABC0", Offset = "0x8EE9BC0", VA = "0x188EEABC0", Slot = "10")]
		public void YLGFRXFVJTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA6E0", Offset = "0x8EE96E0", VA = "0x188EEA6E0", Slot = "11")]
		public void OUOKHVBDPWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class YGAHULGTRWP : FRAVEFYZJKG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly VZRLFVWCNBN OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly VOFSXJFIEEZ ETUMQKVHQXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float RFKOAWFMQQO;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public ENQIPYASMUS CMHQPJCCYML
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RRFQKYGWMGB DHTKKHZKWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 QZEZETLJXDO
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFDD20", Offset = "0x8EFCD20", VA = "0x188EFDD20", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8EFD960", Offset = "0x8EFC960", VA = "0x188EFD960", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 CCVHKZVVEKD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8EFE0C0", Offset = "0x8EFD0C0", VA = "0x188EFE0C0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC780", Offset = "0x8EFB780", VA = "0x188EFC780", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 GNRMVEDAEJS
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC5B0", Offset = "0x8EFB5B0", VA = "0x188EFC5B0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8EFE6B0", Offset = "0x8EFD6B0", VA = "0x188EFE6B0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 BSIHZNGLUDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8EFDB90", Offset = "0x8EFCB90", VA = "0x188EFDB90", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF9B0", Offset = "0x8EFE9B0", VA = "0x188EFF9B0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float GBLJCTNXKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB24CE0", Offset = "0xB23CE0", VA = "0x180B24CE0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC940", Offset = "0x8EFB940", VA = "0x188EFC940", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool ZXQJCAPJPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25FD740", Offset = "0x25FC740", VA = "0x1825FD740", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private SDDHIVXMGFW HDTVSGUUOCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8462CB0", Offset = "0x8461CB0", VA = "0x188462CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool KFGQBXPPNGU
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC590", Offset = "0x8EFB590", VA = "0x188EFC590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF9E0", Offset = "0x8EFE9E0", VA = "0x188EFF9E0")]
		public YGAHULGTRWP(XJZTLTZGAWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC4E0", Offset = "0x8EFB4E0", VA = "0x188EFC4E0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCA50", Offset = "0x8EFBA50", VA = "0x188EFCA50", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE580", Offset = "0x8EFD580", VA = "0x188EFE580", Slot = "28")]
		public void PGCLSGLMDDW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x19CF430", Offset = "0x19CE430", VA = "0x1819CF430", Slot = "20")]
		public void OJMHLQZOUJI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x19CEB60", Offset = "0x19CDB60", VA = "0x1819CEB60", Slot = "30")]
		public void XSXCYSAPQQJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDEE0", Offset = "0x8EFCEE0", VA = "0x188EFDEE0", Slot = "35")]
		public Vector3 MOQOGIJZMWK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD7A0", Offset = "0x8EFC7A0", VA = "0x188EFD7A0", Slot = "34")]
		public Vector3 GRFQMSNSDOU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC4E0", Offset = "0x8EFB4E0", VA = "0x188EFC4E0", Slot = "27")]
		public void YAFAPCTPCFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC300", Offset = "0x8EFB300", VA = "0x188EFC300", Slot = "25")]
		public void ANCITXHEJVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDA20", Offset = "0x8EFCA20", VA = "0x188EFDA20", Slot = "24")]
		public void HWMIHWBXVJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8EFEE50", Offset = "0x8EFDE50", VA = "0x188EFEE50", Slot = "33")]
		public void TDGUNAHJSQV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDB30", Offset = "0x8EFCB30", VA = "0x188EFDB30", Slot = "32")]
		public void LIPHXDEKFCI(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE3E0", Offset = "0x8EFD3E0", VA = "0x188EFE3E0", Slot = "31")]
		public void PDUJNJKGVPX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF300", Offset = "0x8EFE300", VA = "0x188EFF300", Slot = "22")]
		public void ZAFLRRHNGQJ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE770", Offset = "0x8EFD770", VA = "0x188EFE770", Slot = "21")]
		public void QVSLINJLLLK(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD3B0", Offset = "0x8EFC3B0", VA = "0x188EFD3B0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void FZYQDONGZPJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1AEC270", Offset = "0x1AEB270", VA = "0x181AEC270")]
		private static void GCQJAZYMKIF(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF090", Offset = "0x8EFE090", VA = "0x188EFF090", Slot = "29")]
		public Vector3 URKULLRUWFY(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC7B0", Offset = "0x8EFB7B0", VA = "0x188EFC7B0", Slot = "26")]
		public void BKRUGKJRXIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC940", Offset = "0x8EFB940", VA = "0x188EFC940")]
		private void JTAHWMQVZUQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE240", Offset = "0x8EFD240", VA = "0x188EFE240")]
		private void OMNMTPCCXHA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC360", Offset = "0x8EFB360", VA = "0x188EFC360")]
		private Vector3 AQETNDCXSKF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCF30", Offset = "0x8EFBF30", VA = "0x188EFCF30")]
		private void FOITTCBEJMJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF170", Offset = "0x8EFE170", VA = "0x188EFF170")]
		private Vector3 XBFMUHPXOVZ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCAB0", Offset = "0x8EFBAB0", VA = "0x188EFCAB0")]
		private void EQAODCWMIEH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE9F0", Offset = "0x8EFD9F0", VA = "0x188EFE9F0")]
		private void SENAGJEFJMU(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDA80", Offset = "0x8EFCA80", VA = "0x188EFDA80")]
		private void IKKEEIQQTRM()
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
