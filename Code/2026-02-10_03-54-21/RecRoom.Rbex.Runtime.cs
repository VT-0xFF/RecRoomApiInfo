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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BE9C70", Offset = "0x8BE8E70", VA = "0x188BE9C70", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		private int[] ECEPPZWRAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset ROOEZRYFVRR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85DD550", Offset = "0x85DC750", VA = "0x1885DD550", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BFEA00", Offset = "0x8BFDC00", VA = "0x188BFEA00")]
		private void SZMWSWNXWRR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE9A0", Offset = "0x8BFDBA0", VA = "0x188BFE9A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BFECE0", Offset = "0x8BFDEE0", VA = "0x188BFECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, BCZKDCDLKFZ, QUPOBCOXOUG, AKCOJLSCMNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log KSNOLFQCSOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool TMQXPTBMRPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IEYSFSKDJLT DGTFABXVQQG;

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
		private Transform YNCFVFIVAQW;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal IEYSFSKDJLT VHQCMVIXGSW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0390", Offset = "0x8BEF590", VA = "0x188BF0390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IEYSFSKDJLT FZCLIKNWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MIMJQTPWTNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8BF15F0", Offset = "0x8BF07F0", VA = "0x188BF15F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx SSZLIASMEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1950", Offset = "0x8BF0B50", VA = "0x188BF1950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1890", Offset = "0x8BF0A90", VA = "0x188BF1890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NGCRDKEZGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2550", Offset = "0x8BF1750", VA = "0x188BF2550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3A50", Offset = "0x8BF2C50", VA = "0x188BF3A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7FA7940", Offset = "0x7FA6B40", VA = "0x187FA7940", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7FA7A90", Offset = "0x7FA6C90", VA = "0x187FA7A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform GCCZVOFBKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2382F60", Offset = "0x2382160", VA = "0x182382F60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OGVRURRQLJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2382F60", Offset = "0x2382160", VA = "0x182382F60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform KQYNMCSRKPV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2382F60", Offset = "0x2382160", VA = "0x182382F60", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate BTIZQQPMPYT
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1650", Offset = "0x8BF0850", VA = "0x188BF1650")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3200", Offset = "0x8BF2400", VA = "0x188BF3200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ETWTOIDSUMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1C60", Offset = "0x8BF0E60", VA = "0x188BF1C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PPLJCOEVRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1770", Offset = "0x8BF0970", VA = "0x188BF1770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MQFJCOUWAHP DOAAJTIXHOW
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1BA0", Offset = "0x8BF0DA0", VA = "0x188BF1BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8BF33C0", Offset = "0x8BF25C0", VA = "0x188BF33C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public VHZVCFPQQRK PBTTNENGFRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1B40", Offset = "0x8BF0D40", VA = "0x188BF1B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3350", Offset = "0x8BF2550", VA = "0x188BF3350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MWEDSCWZQHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1A90", Offset = "0x8BF0C90", VA = "0x188BF1A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1AF0", Offset = "0x8BF0CF0", VA = "0x188BF1AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JJYDVTMCCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8BF17D0", Offset = "0x8BF09D0", VA = "0x188BF17D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3270", Offset = "0x8BF2470", VA = "0x188BF3270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool RDEBEROUCNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x176CC00", Offset = "0x176BE00", VA = "0x18176CC00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float DPBYZPTUWYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8BF24F0", Offset = "0x8BF16F0", VA = "0x188BF24F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NVSZIWSYFZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2490", Offset = "0x8BF1690", VA = "0x188BF2490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF39E0", Offset = "0x8BF2BE0", VA = "0x188BF39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KVKFKFYEOIW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1EC0", Offset = "0x8BF10C0", VA = "0x188BF1EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3660", Offset = "0x8BF2860", VA = "0x188BF3660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float WAAYCRJXEVC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1CC0", Offset = "0x8BF0EC0", VA = "0x188BF1CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3430", Offset = "0x8BF2630", VA = "0x188BF3430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IFMPCWOFZAD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2AA0", Offset = "0x8BF1CA0", VA = "0x188BF2AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3F90", Offset = "0x8BF3190", VA = "0x188BF3F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 YXHKXCMPGFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2270", Offset = "0x8BF1470", VA = "0x188BF2270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8BF37B0", Offset = "0x8BF29B0", VA = "0x188BF37B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MAEDGPANARK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2BE0", Offset = "0x8BF1DE0", VA = "0x188BF2BE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode PEQEGDFRHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1E00", Offset = "0x8BF1000", VA = "0x188BF1E00")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3580", Offset = "0x8BF2780", VA = "0x188BF3580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float OMOMSMOUUBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1830", Offset = "0x8BF0A30", VA = "0x188BF1830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BF32E0", Offset = "0x8BF24E0", VA = "0x188BF32E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints CHPIKSQLUEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1E60", Offset = "0x8BF1060", VA = "0x188BF1E60")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8BF35F0", Offset = "0x8BF27F0", VA = "0x188BF35F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FIISJTFPOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2610", Offset = "0x8BF1810", VA = "0x188BF2610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 IHTAGXIZZAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2610", Offset = "0x8BF1810", VA = "0x188BF2610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3D70", Offset = "0x8BF2F70", VA = "0x188BF3D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NFZRQJSABNP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2350", Offset = "0x8BF1550", VA = "0x188BF2350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3890", Offset = "0x8BF2A90", VA = "0x188BF3890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float XSLLBLUPOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2A40", Offset = "0x8BF1C40", VA = "0x188BF2A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3F20", Offset = "0x8BF3120", VA = "0x188BF3F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion AFTXGHNOBUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8BF26F0", Offset = "0x8BF18F0", VA = "0x188BF26F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3AF0", Offset = "0x8BF2CF0", VA = "0x188BF3AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion ADBNYSUCIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2970", Offset = "0x8BF1B70", VA = "0x188BF2970")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3E50", Offset = "0x8BF3050", VA = "0x188BF3E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 VLCBQMZRUOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8BF27C0", Offset = "0x8BF19C0", VA = "0x188BF27C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3BC0", Offset = "0x8BF2DC0", VA = "0x188BF3BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion SQXEBRLEQVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8BF28A0", Offset = "0x8BF1AA0", VA = "0x188BF28A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3CA0", Offset = "0x8BF2EA0", VA = "0x188BF3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BXBPPTWCMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2B00", Offset = "0x8BF1D00", VA = "0x188BF2B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4000", Offset = "0x8BF3200", VA = "0x188BF4000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 VUHXOXMOJTO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF23B0", Offset = "0x8BF15B0", VA = "0x188BF23B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3900", Offset = "0x8BF2B00", VA = "0x188BF3900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 RBOMUXNDJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1D20", Offset = "0x8BF0F20", VA = "0x188BF1D20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF34A0", Offset = "0x8BF26A0", VA = "0x188BF34A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 RBLMESGEBZO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2190", Offset = "0x8BF1390", VA = "0x188BF2190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8BF36D0", Offset = "0x8BF28D0", VA = "0x188BF36D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BEPFHNSCMDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2050", Offset = "0x8BF1250", VA = "0x188BF2050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion AMSUPYTPCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1F80", Offset = "0x8BF1180", VA = "0x188BF1F80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 ZAOMVSUSDVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2DA0", Offset = "0x8BF1FA0", VA = "0x188BF2DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 RNEXUXDYUUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2CC0", Offset = "0x8BF1EC0", VA = "0x188BF2CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool QOBLGZPUYCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2130", Offset = "0x8BF1330", VA = "0x188BF2130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool XYJUZOQCXZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1C00", Offset = "0x8BF0E00", VA = "0x188BF1C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NCJOVACIJSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1710", Offset = "0x8BF0910", VA = "0x188BF1710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DHSWMCWVZPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BF16B0", Offset = "0x8BF08B0", VA = "0x188BF16B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MAPKXLRAAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1590", Offset = "0x8BF0790", VA = "0x188BF1590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IXACQTYSNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1F20", Offset = "0x8BF1120", VA = "0x188BF1F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBB1A30", Offset = "0xBB0C30", VA = "0x180BB1A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction UIBZHXZJGRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8BF14B0", Offset = "0x8BF06B0", VA = "0x188BF14B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3120", Offset = "0x8BF2320", VA = "0x188BF3120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction JQNNRJXYALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1220", Offset = "0x8BF0420", VA = "0x188BF1220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2E80", Offset = "0x8BF2080", VA = "0x188BF2E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction XOCRVOCFFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1280", Offset = "0x8BF0480", VA = "0x188BF1280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2EF0", Offset = "0x8BF20F0", VA = "0x188BF2EF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction IDGEHJKYIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8BF13D0", Offset = "0x8BF05D0", VA = "0x188BF13D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3040", Offset = "0x8BF2240", VA = "0x188BF3040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> DXGSCXULVKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1360", Offset = "0x8BF0560", VA = "0x188BF1360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2FD0", Offset = "0x8BF21D0", VA = "0x188BF2FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction OIPLMJNLTBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1440", Offset = "0x8BF0640", VA = "0x188BF1440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF30B0", Offset = "0x8BF22B0", VA = "0x188BF30B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction BOCHQQNYZNR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1520", Offset = "0x8BF0720", VA = "0x188BF1520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF3190", Offset = "0x8BF2390", VA = "0x188BF3190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction WXVOKWLGQRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF12F0", Offset = "0x8BF04F0", VA = "0x188BF12F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF2F60", Offset = "0x8BF2160", VA = "0x188BF2F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170", Slot = "8")]
		private void PUZKSIYGVKQ(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFB90", Offset = "0x8BEED90", VA = "0x188BEFB90", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFFA0", Offset = "0x8BEF1A0", VA = "0x188BEFFA0")]
		internal void MLZKASVRHYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0F50", Offset = "0x8BF0150", VA = "0x188BF0F50")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF8E0", Offset = "0x8BEEAE0", VA = "0x188BEF8E0")]
		public BCZKDCDLKFZ GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0BB0", Offset = "0x8BEFDB0", VA = "0x188BF0BB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF540", Offset = "0x8BEE740", VA = "0x188BEF540")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0E40", Offset = "0x8BF0040", VA = "0x188BF0E40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0390", Offset = "0x8BEF590", VA = "0x188BF0390")]
		private IEYSFSKDJLT VUJCEEJEAYK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0030", Offset = "0x8BEF230", VA = "0x188BF0030")]
		private void MPSAKZMSCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BF02D0", Offset = "0x8BEF4D0", VA = "0x188BF02D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0210", Offset = "0x8BEF410", VA = "0x188BF0210")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFFA0", Offset = "0x8BEF1A0", VA = "0x188BEFFA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0270", Offset = "0x8BEF470", VA = "0x188BF0270")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0330", Offset = "0x8BEF530", VA = "0x188BF0330")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEB30", Offset = "0x8BEDD30", VA = "0x188BEEB30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0440", Offset = "0x8BEF640", VA = "0x188BF0440")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF880", Offset = "0x8BEEA80", VA = "0x188BEF880")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BF01B0", Offset = "0x8BEF3B0", VA = "0x188BF01B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0D10", Offset = "0x8BEFF10", VA = "0x188BF0D10")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0750", Offset = "0x8BEF950", VA = "0x188BF0750")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC20", Offset = "0x8BEEE20", VA = "0x188BEFC20")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFD20", Offset = "0x8BEEF20", VA = "0x188BEFD20")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEDA0", Offset = "0x8BEDFA0", VA = "0x188BEEDA0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF04B0", Offset = "0x8BEF6B0", VA = "0x188BF04B0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEE10", Offset = "0x8BEE010", VA = "0x188BEEE10")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0520", Offset = "0x8BEF720", VA = "0x188BF0520")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0C90", Offset = "0x8BEFE90", VA = "0x188BF0C90")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0AB0", Offset = "0x8BEFCB0", VA = "0x188BF0AB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BF09B0", Offset = "0x8BEFBB0", VA = "0x188BF09B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFA80", Offset = "0x8BEEC80", VA = "0x188BEFA80")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF970", Offset = "0x8BEEB70", VA = "0x188BEF970")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BEECB0", Offset = "0x8BEDEB0", VA = "0x188BEECB0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEBA0", Offset = "0x8BEDDA0", VA = "0x188BEEBA0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEFE0", Offset = "0x8BEE1E0", VA = "0x188BEEFE0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEE80", Offset = "0x8BEE080", VA = "0x188BEEE80")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1020", Offset = "0x8BF0220", VA = "0x188BF1020")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFE90", Offset = "0x8BEF090", VA = "0x188BEFE90")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF820", Offset = "0x8BEEA20", VA = "0x188BEF820")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF7C0", Offset = "0x8BEE9C0", VA = "0x188BEF7C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF760", Offset = "0x8BEE960", VA = "0x188BEF760")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF700", Offset = "0x8BEE900", VA = "0x188BEF700")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BF08B0", Offset = "0x8BEFAB0", VA = "0x188BF08B0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BF07B0", Offset = "0x8BEF9B0", VA = "0x188BF07B0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0670", Offset = "0x8BEF870", VA = "0x188BF0670")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0E50", Offset = "0x8BF0050", VA = "0x188BF0E50")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFE20", Offset = "0x8BEF020", VA = "0x188BEFE20")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0DE0", Offset = "0x8BEFFE0", VA = "0x188BF0DE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0FC0", Offset = "0x8BF01C0", VA = "0x188BF0FC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEF70", Offset = "0x8BEE170", VA = "0x188BEEF70")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0590", Offset = "0x8BEF790", VA = "0x188BF0590")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF370", Offset = "0x8BEE570", VA = "0x188BEF370")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF270", Offset = "0x8BEE470", VA = "0x188BEF270")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF430", Offset = "0x8BEE630", VA = "0x188BEF430")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF1A0", Offset = "0x8BEE3A0", VA = "0x188BEF1A0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF0D0", Offset = "0x8BEE2D0", VA = "0x188BEF0D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0600", Offset = "0x8BEF800", VA = "0x188BF0600")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFE80", Offset = "0x8BEF080", VA = "0x188BEFE80", Slot = "13")]
		private void JEFZAFVJXBB(PTBSRHLLGAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF11B0", Offset = "0x8BF03B0", VA = "0x188BF11B0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x12A2EB0", Offset = "0x12A20B0", VA = "0x1812A2EB0", Slot = "4")]
		private GameObject XLTQVXFHNVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE3480", Offset = "0xAE2680", VA = "0x180AE3480", Slot = "10")]
		private bool UOTXHFMBKOF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class IGESOIZRBOY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D80", Offset = "0x8BE4F80", VA = "0x188BE5D80")]
		public static IEYSFSKDJLT VHQCMVIXGSW(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(ZDNQWULRURI), new string[] { })]
	public class RigidbodyExManager : ZDNQWULRURI, HSMOOTIZJVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private WMEZVEIACTP NQFDUPPEUOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private COVYYNHGDQY DMTIUCULTKS;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public WMEZVEIACTP XQQMNXABHXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public COVYYNHGDQY ZXQXODJKZXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEA40", Offset = "0x8BEDC40", VA = "0x188BEEA40", Slot = "7")]
		public void InitReferences(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE870", Offset = "0x8BEDA70", VA = "0x188BEE870", Slot = "6")]
		public IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static CVEDYLCEYBQ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int RHXNMPJXEXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int UDKSSLLRGAE;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9E30", Offset = "0x8BE9030", VA = "0x188BE9E30")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9EB0", Offset = "0x8BE90B0", VA = "0x188BE9EB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9E50", Offset = "0x8BE9050", VA = "0x188BE9E50")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9FA0", Offset = "0x8BE91A0", VA = "0x188BE9FA0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class YAQLPEPFRHC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GFEOPNCUBYA : MQFJCOUWAHP, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC64A0", Offset = "0xAC56A0", VA = "0x180AC64A0", Slot = "4")]
			public Vector3 UOKQXBSVDFH()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC64A0", Offset = "0xAC56A0", VA = "0x180AC64A0", Slot = "5")]
			public Vector3 ZWNFTLSEVDG()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "6")]
			public bool BMXMMENXALJ(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public GFEOPNCUBYA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static MQFJCOUWAHP DWUADPETHBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE8E0", Offset = "0x8BFDAE0", VA = "0x188BFE8E0")]
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
	public interface REYZHDGDWBD
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode ZBITUHDIRTG
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
		void FPLZBBMOTHW(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JNSFRVYHZAD(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PVRJOTOCNCI(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QMWPTTNTZSO : IDisposable, SEILEHPFETW
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate BTIZQQPMPYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> DXGSCXULVKM;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface COVYYNHGDQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YSBWHBQBYHX OBGSWPRBEXN(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CQWOLNKFHIF STIFEEOLHJN(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NEAYNYJJBRM ENXWURAVMHO(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CKPUTKDCDYH UXAZGIXIAPH(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		HAMSZOBKKUF VNIYOPSISDV(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QMWPTTNTZSO RHDNRLMIGQM(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		HTNHFSFSDBZ LMKGBFHUWKJ(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		TZDCXLKDXOZ SEFCVUJLJPZ(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		REYZHDGDWBD HMRYJLOHXBN(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		KBRQGVSAQUQ PBMQCBLUDUC(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		OGGIYYTNGQG LWRASZEPOKM(IEYSFSKDJLT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DJJQIUJHJNY EZFDAJMWNOE(IEYSFSKDJLT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ZALZQXLDEQI ZEPWVDWMGVU(IEYSFSKDJLT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		UXQBLMEKFEU JFFEVZTUNLM(IEYSFSKDJLT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		GKIBYCQTGDW IJXHZZCPACW(IEYSFSKDJLT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a, RigidbodyExData b, ZDNQWULRURI c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface TZDCXLKDXOZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LCVBNEOCBVM(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OYHNMUUFGHO(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AVMRPVCSACR(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MXKYPDYGWJT(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface KBRQGVSAQUQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool HIHKKOIFXCX
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
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IHOMJPOXKPI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface YSBWHBQBYHX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<IEYSFSKDJLT> FUFQEFKIOOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		IEYSFSKDJLT YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		IEYSFSKDJLT XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction JQNNRJXYALK;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction XOCRVOCFFPM;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction WPIMURTHKBG;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action BKBFJKKPPJH;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action QCCYXVXIHMO;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<IEYSFSKDJLT> PJBGKVIYKIH;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<IEYSFSKDJLT> DGZJJENJBHO;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action VWXEYROIAXZ;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<IEYSFSKDJLT> FUTERMDZAWE;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(IEYSFSKDJLT newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NEAYNYJJBRM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 DDOXLYTBMNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 FORUEBMLMJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KLIVCEDGBJZ(IEYSFSKDJLT a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SGOZEEVIIQM(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface UXQBLMEKFEU
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 VRKJXVCYHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 VFMTIBAGIGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float UPEBGWXMUFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float DQLIMXDHSZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 FTBKASODFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion EWGMFAKLDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction EVHUEJZMWVI;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NUDUUQIXEFR((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BRXGUJIPJVU();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BYXYCMXHMDD();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void HZKGTXGBRRJ();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void IHOMJPOXKPI(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ZALZQXLDEQI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GMAFEQRKQAL(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void THBDMTNEJCC(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VAZUABDNLMG(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IRYMMCUNCLX(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IUFSKFJIWAW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HTNHFSFSDBZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool LOLTVRSGCLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction JHDBBQYJVUT;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CQCVLGJTYBO(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RANJKXYZEXT(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AGEYPSKGISF(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IHOMJPOXKPI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface DJJQIUJHJNY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool ETWTOIDSUMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool PPLJCOEVRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction OLTAFOCTDJB;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CFHIWBWBEWY(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YUUVXLSRSTC(IEYSFSKDJLT a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface GKIBYCQTGDW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool JJYDVTMCCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool HHNRUUHXUUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints OTUZTHAMALK
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
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IHOMJPOXKPI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CKPUTKDCDYH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float UNUSEFGJXIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float AYNWROETSSI
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
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IHOMJPOXKPI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface HAMSZOBKKUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool EHXJONOOEGN;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction HRXRZTEOYHX;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JEZNSLNKIZH();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BUGPWFVUDOX();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool WHUPJUQOLYD();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NQWFPQWNRKK();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UHEWSAVDKRG(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void NGQVJTWBLSZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface OGGIYYTNGQG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool EVNAOQPASND
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
		void LNUMJQGOJYX(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TUFVMNTKHRU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HQDOPLWJOYT();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CQWOLNKFHIF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		MQFJCOUWAHP DOAAJTIXHOW
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		VHZVCFPQQRK PBTTNENGFRT
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 EKAVHDJHYML
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 ADKVRNPLFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 SWSPBSUDLYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 FIVNNPRGYDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float OMOMSMOUUBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool MWEDSCWZQHX
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
		void WFNTYHGNWNJ(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ZSTDUAHIRTT(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void NYWDWLQFXRW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void ZVMHVPSPULE(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void NVHKPHGLRHI();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void EUXVMKOBLSH();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void AUOPABDKXQG();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RGVHKICYEQG();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ZOYSVOLSAOB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 FAKAHLRMQKX(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ZPJDTOIYTQC(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void VRXPVDQNYPQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void SMBHDDCQQRZ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void FGVUZKRCGYW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 GWNWCUZPVPL(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 SLFFDNUKUIP(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WMEZVEIACTP
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool BTMRDMVIXBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ADZYIEBEENG(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DHQTTBJOUYH(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HDYEPOVFWPT LSERVADCMSW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OUGFLMPGHRY(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZDNQWULRURI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		WMEZVEIACTP XQQMNXABHXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		COVYYNHGDQY ZXQXODJKZXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class SQBJFBVEGOM : IEYSFSKDJLT, IDisposable, ELWRVYMEFRI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly ZDNQWULRURI JIYKLYRLQAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal YSBWHBQBYHX VZIPLRJOTWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal ZALZQXLDEQI SWZFXIXSTDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal DJJQIUJHJNY SYTXMAIHXTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal CQWOLNKFHIF BXBPPTWCMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal NEAYNYJJBRM RSGBWKWFPXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal UXQBLMEKFEU JAVWQIMKCSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal CKPUTKDCDYH HVKLUMJXPXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal KBRQGVSAQUQ UKEVVAZTZOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal HAMSZOBKKUF HDUTZCACIJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal QMWPTTNTZSO FQUWCWLZUDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal HTNHFSFSDBZ JCCXGMPLPRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal TZDCXLKDXOZ PKYMHWEGPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal GKIBYCQTGDW ZTGMIQJHPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal OGGIYYTNGQG FMVQYFOIMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal REYZHDGDWBD FMGFDYUDLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable BIUYSRMODAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool EZHXGQTCWOQ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId MDCWDRXMXSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public BCZKDCDLKFZ CZBIZLIHAQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB7B0F0", Offset = "0xB7A2F0", VA = "0x180B7B0F0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC34270", Offset = "0xC33470", VA = "0x180C34270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject QWPZZBFDYYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAC1930", Offset = "0xAC0B30", VA = "0x180AC1930", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAC1940", Offset = "0xAC0B40", VA = "0x180AC1940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform HUSVRZMONUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC6C490", Offset = "0xC6B690", VA = "0x180C6C490", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD9C200", Offset = "0xD9B400", VA = "0x180D9C200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6230", Offset = "0x8BF5430", VA = "0x188BF6230", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEYSFSKDJLT XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8F10", Offset = "0x8BF8110", VA = "0x188BF8F10", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA2E0", Offset = "0x8BF94E0", VA = "0x188BFA2E0", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int MIMJQTPWTNT
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5730", Offset = "0x8BF4930", VA = "0x188BF5730", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public IEYSFSKDJLT YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8110", Offset = "0x8BF7310", VA = "0x188BF8110", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool TIATPWOGWME
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA0E0", Offset = "0x8BF92E0", VA = "0x188BFA0E0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool ETWTOIDSUMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8BF55C0", Offset = "0x8BF47C0", VA = "0x188BF55C0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool PPLJCOEVRNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8BF80C0", Offset = "0x8BF72C0", VA = "0x188BF80C0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public MQFJCOUWAHP DOAAJTIXHOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8D60", Offset = "0x8BF7F60", VA = "0x188BF8D60", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9FF0", Offset = "0x8BF91F0", VA = "0x188BF9FF0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public VHZVCFPQQRK PBTTNENGFRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8600", Offset = "0x8BF7800", VA = "0x188BF8600", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF76A0", Offset = "0x8BF68A0", VA = "0x188BF76A0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float OMOMSMOUUBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5030", Offset = "0x8BF4230", VA = "0x188BF5030", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6130", Offset = "0x8BF5330", VA = "0x188BF6130", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 ADKVRNPLFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4E50", Offset = "0x8BF4050", VA = "0x188BF4E50", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4BF0", Offset = "0x8BF3DF0", VA = "0x188BF4BF0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 FIVNNPRGYDO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4610", Offset = "0x8BF3810", VA = "0x188BF4610", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7C60", Offset = "0x8BF6E60", VA = "0x188BF7C60", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 EKAVHDJHYML
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA340", Offset = "0x8BF9540", VA = "0x188BFA340", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8BF81C0", Offset = "0x8BF73C0", VA = "0x188BF81C0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 SWSPBSUDLYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6BD0", Offset = "0x8BF5DD0", VA = "0x188BF6BD0", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5F90", Offset = "0x8BF5190", VA = "0x188BF5F90", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool NCJOVACIJSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7C10", Offset = "0x8BF6E10", VA = "0x188BF7C10", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DHSWMCWVZPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8BF97D0", Offset = "0x8BF89D0", VA = "0x188BF97D0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool MAPKXLRAAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5960", Offset = "0x8BF4B60", VA = "0x188BF5960", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool MWEDSCWZQHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4500", Offset = "0x8BF3700", VA = "0x188BF4500", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 DDOXLYTBMNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6330", Offset = "0x8BF5530", VA = "0x188BF6330", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 FORUEBMLMJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4AC0", Offset = "0x8BF3CC0", VA = "0x188BF4AC0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 VRKJXVCYHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6FF0", Offset = "0x8BF61F0", VA = "0x188BF6FF0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8A90", Offset = "0x8BF7C90", VA = "0x188BF8A90", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 VFMTIBAGIGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF72D0", Offset = "0x8BF64D0", VA = "0x188BF72D0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float UPEBGWXMUFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6EE0", Offset = "0x8BF60E0", VA = "0x188BF6EE0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float DQLIMXDHSZN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9330", Offset = "0x8BF8530", VA = "0x188BF9330", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6070", Offset = "0x8BF5270", VA = "0x188BF6070", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 FTBKASODFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BF73B0", Offset = "0x8BF65B0", VA = "0x188BF73B0", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion EWGMFAKLDMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8F60", Offset = "0x8BF8160", VA = "0x188BF8F60", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float UNUSEFGJXIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAA30", Offset = "0x8BF9C30", VA = "0x188BFAA30", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9F30", Offset = "0x8BF9130", VA = "0x188BF9F30", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float AYNWROETSSI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4DA0", Offset = "0x8BF3FA0", VA = "0x188BF4DA0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5F30", Offset = "0x8BF5130", VA = "0x188BF5F30", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool HIHKKOIFXCX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5B30", Offset = "0x8BF4D30", VA = "0x188BF5B30", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF75E0", Offset = "0x8BF67E0", VA = "0x188BF75E0", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate BTIZQQPMPYT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4F30", Offset = "0x8BF4130", VA = "0x188BF4F30", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA280", Offset = "0x8BF9480", VA = "0x188BFA280", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool LOLTVRSGCLT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8BF86B0", Offset = "0x8BF78B0", VA = "0x188BF86B0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform KQYNMCSRKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC6C490", Offset = "0xC6B690", VA = "0x180C6C490", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 MUIIIRMSJVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4820", Offset = "0x8BF3A20", VA = "0x188BF4820", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF66F0", Offset = "0x8BF58F0", VA = "0x188BF66F0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float UQRQYLBZHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5850", Offset = "0x8BF4A50", VA = "0x188BF5850", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6DF0", Offset = "0x8BF5FF0", VA = "0x188BF6DF0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float QIIBLVQGWPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6ED0", Offset = "0x8BF60D0", VA = "0x188BF6ED0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9830", Offset = "0x8BF8A30", VA = "0x188BF9830", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion ANTHHSHEBFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9030", Offset = "0x8BF8230", VA = "0x188BF9030", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4420", Offset = "0x8BF3620", VA = "0x188BF4420", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 LFPTYUQAXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA640", Offset = "0x8BF9840", VA = "0x188BFA640", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8BF92F0", Offset = "0x8BF84F0", VA = "0x188BF92F0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion BIYFIYVAKRH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8ED0", Offset = "0x8BF80D0", VA = "0x188BF8ED0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4F80", Offset = "0x8BF4180", VA = "0x188BF4F80", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints OTUZTHAMALK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8BF61E0", Offset = "0x8BF53E0", VA = "0x188BF61E0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4A60", Offset = "0x8BF3C60", VA = "0x188BF4A60", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool JJYDVTMCCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6E80", Offset = "0x8BF6080", VA = "0x188BF6E80", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9F90", Offset = "0x8BF9190", VA = "0x188BF9F90", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode ZBITUHDIRTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA420", Offset = "0x8BF9620", VA = "0x188BFA420", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9A70", Offset = "0x8BF8C70", VA = "0x188BF9A70", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool ZICMJAKEGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7130", Offset = "0x8BF6330", VA = "0x188BF7130", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool XYJUZOQCXZM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9130", Offset = "0x8BF8330", VA = "0x188BF9130", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction JQNNRJXYALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8BF70D0", Offset = "0x8BF62D0", VA = "0x188BF70D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9B30", Offset = "0x8BF8D30", VA = "0x188BF9B30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction XOCRVOCFFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7D40", Offset = "0x8BF6F40", VA = "0x188BF7D40", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9A10", Offset = "0x8BF8C10", VA = "0x188BF9A10", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction WPIMURTHKBG
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9AD0", Offset = "0x8BF8CD0", VA = "0x188BF9AD0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8A30", Offset = "0x8BF7C30", VA = "0x188BF8A30", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction OLTAFOCTDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6F30", Offset = "0x8BF6130", VA = "0x188BF6F30", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7270", Offset = "0x8BF6470", VA = "0x188BF7270", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction IDGEHJKYIJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8BF57A0", Offset = "0x8BF49A0", VA = "0x188BF57A0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA760", Offset = "0x8BF9960", VA = "0x188BFA760", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction HRXRZTEOYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4550", Offset = "0x8BF3750", VA = "0x188BF4550", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA140", Offset = "0x8BF9340", VA = "0x188BFA140", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> DXGSCXULVKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8BF60D0", Offset = "0x8BF52D0", VA = "0x188BF60D0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8E70", Offset = "0x8BF8070", VA = "0x188BF8E70", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction JHDBBQYJVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6F90", Offset = "0x8BF6190", VA = "0x188BF6F90", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BF45B0", Offset = "0x8BF37B0", VA = "0x188BF45B0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction WXVOKWLGQRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7DA0", Offset = "0x8BF6FA0", VA = "0x188BF7DA0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5B80", Offset = "0x8BF4D80", VA = "0x188BF5B80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAA80", Offset = "0x8BF9C80", VA = "0x188BFAA80")]
		public SQBJFBVEGOM(GameObject a, RigidbodyEx b, ZDNQWULRURI c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6400", Offset = "0x8BF5600", VA = "0x188BF6400", Slot = "139")]
		protected virtual void IVNKEOSBTCU(ZDNQWULRURI a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF54C0", Offset = "0x8BF46C0", VA = "0x188BF54C0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF48D0", Offset = "0x8BF3AD0", VA = "0x188BF48D0", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8030", Offset = "0x8BF7230", VA = "0x188BF8030", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7F80", Offset = "0x8BF7180", VA = "0x188BF7F80", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7F60", Offset = "0x8BF7160", VA = "0x188BF7F60", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9380", Offset = "0x8BF8580", VA = "0x188BF9380")]
		private void UHEWSAVDKRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA200", Offset = "0x8BF9400", VA = "0x188BFA200")]
		private void XZOPCFSSOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7640", Offset = "0x8BF6840", VA = "0x188BF7640")]
		private void NQWFPQWNRKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4FB0", Offset = "0x8BF41B0", VA = "0x188BF4FB0", Slot = "30")]
		public IEYSFSKDJLT CZJJNPKDMFE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8DB0", Offset = "0x8BF7FB0", VA = "0x188BF8DB0", Slot = "98")]
		public void SetParent(IEYSFSKDJLT value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA1A0", Offset = "0x8BF93A0", VA = "0x188BFA1A0", Slot = "99")]
		public void XUIUMDVCTER(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA9D0", Offset = "0x8BF9BD0", VA = "0x188BFA9D0", Slot = "100")]
		public void ZZENAZLIVOE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8B70", Offset = "0x8BF7D70", VA = "0x188BF8B70", Slot = "101")]
		public Vector3 SLFFDNUKUIP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C30", Offset = "0x8BF4E30", VA = "0x188BF5C30", Slot = "102")]
		public Vector3 GWNWCUZPVPL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF85B0", Offset = "0x8BF77B0", VA = "0x188BF85B0", Slot = "103")]
		public void RGVHKICYEQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5800", Offset = "0x8BF4A00", VA = "0x188BF5800", Slot = "104")]
		public void EUXVMKOBLSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF77E0", Offset = "0x8BF69E0", VA = "0x188BF77E0", Slot = "105")]
		public void NVHKPHGLRHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5A40", Offset = "0x8BF4C40", VA = "0x188BF5A40", Slot = "106")]
		public void FGVUZKRCGYW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C70", Offset = "0x8BF7E70", VA = "0x188BF8C70", Slot = "107")]
		public void SMBHDDCQQRZ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9930", Offset = "0x8BF8B30", VA = "0x188BF9930", Slot = "108")]
		public void VRXPVDQNYPQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7830", Offset = "0x8BF6A30", VA = "0x188BF7830", Slot = "109")]
		public void NYWDWLQFXRW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA7C0", Offset = "0x8BF99C0", VA = "0x188BFA7C0", Slot = "110")]
		public void ZSTDUAHIRTT(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA8C0", Offset = "0x8BF9AC0", VA = "0x188BFA8C0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZVMHVPSPULE(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5860", Offset = "0x8BF4A60", VA = "0x188BF5860", Slot = "112")]
		public Vector3 FAKAHLRMQKX(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA470", Offset = "0x8BF9670", VA = "0x188BFA470", Slot = "113")]
		public Vector3 YSPYCJKXWIF(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF46F0", Offset = "0x8BF38F0", VA = "0x188BF46F0", Slot = "114")]
		public void AUOPABDKXQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6900", Offset = "0x8BF5B00", VA = "0x188BF6900", Slot = "115")]
		public void JFKIYBUTIBO(IEYSFSKDJLT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9600", Offset = "0x8BF8800", VA = "0x188BF9600", Slot = "116")]
		public void URWFQGYQIPT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7700", Offset = "0x8BF6900", VA = "0x188BF7700", Slot = "63")]
		public void NUDUUQIXEFR((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4BA0", Offset = "0x8BF3DA0", VA = "0x188BF4BA0", Slot = "117")]
		public void BYXYCMXHMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4A10", Offset = "0x8BF3C10", VA = "0x188BF4A10", Slot = "118")]
		public void BRXGUJIPJVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6190", Offset = "0x8BF5390", VA = "0x188BF6190", Slot = "119")]
		public void HZKGTXGBRRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF68B0", Offset = "0x8BF5AB0", VA = "0x188BF68B0", Slot = "120")]
		public bool JEZNSLNKIZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8E20", Offset = "0x8BF8020", VA = "0x188BF8E20", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7570", Offset = "0x8BF6770", VA = "0x188BF7570", Slot = "121")]
		public void NGQVJTWBLSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4DF0", Offset = "0x8BF3FF0", VA = "0x188BF4DF0", Slot = "122")]
		public void CQCVLGJTYBO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8550", Offset = "0x8BF7750", VA = "0x188BF8550", Slot = "123")]
		public void RANJKXYZEXT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF43B0", Offset = "0x8BF35B0", VA = "0x188BF43B0", Slot = "124")]
		public void AGEYPSKGISF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5D30", Offset = "0x8BF4F30", VA = "0x188BF5D30", Slot = "125")]
		public void GZYXLTZHSFR(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6970", Offset = "0x8BF5B70", VA = "0x188BF6970", Slot = "126")]
		public void JJBUJIGIQTZ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9B90", Offset = "0x8BF8D90", VA = "0x188BF9B90", Slot = "127")]
		public bool WOXJNHLQQVI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8160", Offset = "0x8BF7360", VA = "0x188BF8160", Slot = "128")]
		public void PRLKYQMXIOP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8650", Offset = "0x8BF7850", VA = "0x188BF8650", Slot = "129")]
		public void RTBRQMFVYWI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6D90", Offset = "0x8BF5F90", VA = "0x188BF6D90", Slot = "130")]
		public void LNUMJQGOJYX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF90D0", Offset = "0x8BF82D0", VA = "0x188BF90D0", Slot = "131")]
		public void TUFVMNTKHRU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6CB0", Offset = "0x8BF5EB0", VA = "0x188BF6CB0", Slot = "132")]
		public void LCVBNEOCBVM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7E50", Offset = "0x8BF7050", VA = "0x188BF7E50", Slot = "133")]
		public void OYHNMUUFGHO(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4740", Offset = "0x8BF3940", VA = "0x188BF4740", Slot = "134")]
		public void AVMRPVCSACR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7490", Offset = "0x8BF6690", VA = "0x188BF7490", Slot = "135")]
		public void MXKYPDYGWJT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF82A0", Offset = "0x8BF74A0", VA = "0x188BF82A0", Slot = "136")]
		public bool PVRJOTOCNCI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7FE0", Offset = "0x8BF71E0", VA = "0x188BF7FE0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF92B0", Offset = "0x8BF84B0", VA = "0x188BF92B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA680", Offset = "0x8BF9880", VA = "0x188BFA680")]
		private void ZBSNZJZHGTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF67A0", Offset = "0x8BF59A0", VA = "0x188BF67A0")]
		private void JEEHHMDZOJY(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8850", Offset = "0x8BF7A50", VA = "0x188BF8850")]
		private void SHQUFDZKPIN(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6280", Offset = "0x8BF5480", VA = "0x188BF6280")]
		private void IRRUVCVGRQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6AA0", Offset = "0x8BF5CA0", VA = "0x188BF6AA0")]
		private void KKDRLBHPASX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BF83A0", Offset = "0x8BF75A0", VA = "0x188BF83A0")]
		private void QMGCOIYGELN(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4CD0", Offset = "0x8BF3ED0", VA = "0x188BF4CD0")]
		private void CFHIWBWBEWY(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA570", Offset = "0x8BF9770", VA = "0x188BFA570")]
		private void YUUVXLSRSTC(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8700", Offset = "0x8BF7900", VA = "0x188BF8700")]
		private void SHQLALAXORP(BCZKDCDLKFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5080", Offset = "0x8BF4280", VA = "0x188BF5080", Slot = "142")]
		protected virtual void DXOELDYSPVU(BCZKDCDLKFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF78F0", Offset = "0x8BF6AF0", VA = "0x188BF78F0")]
		protected void NZECJTQUPMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9BE0", Offset = "0x8BF8DE0", VA = "0x188BF9BE0")]
		protected void WVQYTEEWWBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5610", Offset = "0x8BF4810", VA = "0x188BF5610")]
		private void ELJBFGKECNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9660", Offset = "0x8BF8860", VA = "0x188BF9660")]
		private void UXFTJNYLZAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class SMDLDDHHPAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4200", Offset = "0x8BF3400", VA = "0x188BF4200")]
		public static IEYSFSKDJLT NAFHEZPKCPB(this IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4160", Offset = "0x8BF3360", VA = "0x188BF4160")]
		public static bool ILTDYQMNOHY(this IEYSFSKDJLT a, IEYSFSKDJLT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4310", Offset = "0x8BF3510", VA = "0x188BF4310")]
		public static bool PXKRBKXBDGY(this IEYSFSKDJLT a, IEYSFSKDJLT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BF42C0", Offset = "0x8BF34C0", VA = "0x188BF42C0")]
		public static BCZKDCDLKFZ OMQDKQQEAZE(this IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8BF40E0", Offset = "0x8BF32E0", VA = "0x188BF40E0")]
		public static SQBJFBVEGOM Base(this IEYSFSKDJLT impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BGTCABVBBUR : COVYYNHGDQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3190", Offset = "0x8BE2390", VA = "0x188BE3190", Slot = "19")]
		public IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a, RigidbodyExData b, ZDNQWULRURI c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
		public YSBWHBQBYHX OBGSWPRBEXN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "5")]
		public CQWOLNKFHIF STIFEEOLHJN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "6")]
		public NEAYNYJJBRM ENXWURAVMHO(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "7")]
		public CKPUTKDCDYH UXAZGIXIAPH(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "8")]
		public HAMSZOBKKUF VNIYOPSISDV(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "9")]
		public QMWPTTNTZSO RHDNRLMIGQM(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "10")]
		public HTNHFSFSDBZ LMKGBFHUWKJ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "11")]
		public TZDCXLKDXOZ SEFCVUJLJPZ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "12")]
		public REYZHDGDWBD HMRYJLOHXBN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "13")]
		public KBRQGVSAQUQ PBMQCBLUDUC(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
		public OGGIYYTNGQG LWRASZEPOKM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
		public DJJQIUJHJNY EZFDAJMWNOE(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
		public ZALZQXLDEQI ZEPWVDWMGVU(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
		public UXQBLMEKFEU JFFEVZTUNLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
		public GKIBYCQTGDW IJXHZZCPACW(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public BGTCABVBBUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "14")]
		private OGGIYYTNGQG MOKJIIPJENG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "15")]
		private DJJQIUJHJNY HUSITKKXQBC(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "16")]
		private ZALZQXLDEQI AQIKRYQZPLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "17")]
		private UXQBLMEKFEU WQHVHEWIGYG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "18")]
		private GKIBYCQTGDW KZUGHOSNWNQ(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(COVYYNHGDQY), new string[] { })]
	public class TYBTMPNKUME : COVYYNHGDQY, HSMOOTIZJVU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly COVYYNHGDQY VAGTXEWWSIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly COVYYNHGDQY JRLHNBZTHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CUFWLUNXAFY FEJTGTEDGTL;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private COVYYNHGDQY ZXQXODJKZXA
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC940", Offset = "0x8BFBB40", VA = "0x188BFC940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC290", Offset = "0x8BFB490", VA = "0x188BFC290", Slot = "20")]
		public void InitReferences(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC4E0", Offset = "0x8BFB6E0", VA = "0x188BFC4E0", Slot = "4")]
		public YSBWHBQBYHX OBGSWPRBEXN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC760", Offset = "0x8BFB960", VA = "0x188BFC760", Slot = "5")]
		public CQWOLNKFHIF STIFEEOLHJN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBEA0", Offset = "0x8BFB0A0", VA = "0x188BFBEA0", Slot = "6")]
		public NEAYNYJJBRM ENXWURAVMHO(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC800", Offset = "0x8BFBA00", VA = "0x188BFC800", Slot = "7")]
		public CKPUTKDCDYH UXAZGIXIAPH(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC8A0", Offset = "0x8BFBAA0", VA = "0x188BFC8A0", Slot = "8")]
		public HAMSZOBKKUF VNIYOPSISDV(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC620", Offset = "0x8BFB820", VA = "0x188BFC620", Slot = "9")]
		public QMWPTTNTZSO RHDNRLMIGQM(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC390", Offset = "0x8BFB590", VA = "0x188BFC390", Slot = "10")]
		public HTNHFSFSDBZ LMKGBFHUWKJ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC6C0", Offset = "0x8BFB8C0", VA = "0x188BFC6C0", Slot = "11")]
		public TZDCXLKDXOZ SEFCVUJLJPZ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC140", Offset = "0x8BFB340", VA = "0x188BFC140", Slot = "12")]
		public REYZHDGDWBD HMRYJLOHXBN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC580", Offset = "0x8BFB780", VA = "0x188BFC580", Slot = "13")]
		public KBRQGVSAQUQ PBMQCBLUDUC(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC430", Offset = "0x8BFB630", VA = "0x188BFC430")]
		public OGGIYYTNGQG LWRASZEPOKM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBF40", Offset = "0x8BFB140", VA = "0x188BFBF40")]
		public DJJQIUJHJNY EZFDAJMWNOE(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBDF0", Offset = "0x8BFAFF0", VA = "0x188BFBDF0")]
		public ZALZQXLDEQI ZEPWVDWMGVU(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC2E0", Offset = "0x8BFB4E0", VA = "0x188BFC2E0")]
		public UXQBLMEKFEU JFFEVZTUNLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC1E0", Offset = "0x8BFB3E0", VA = "0x188BFC1E0")]
		public GKIBYCQTGDW IJXHZZCPACW(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBFF0", Offset = "0x8BFB1F0", VA = "0x188BFBFF0", Slot = "19")]
		public IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a, RigidbodyExData b, ZDNQWULRURI c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC9A0", Offset = "0x8BFBBA0", VA = "0x188BFC9A0")]
		public TYBTMPNKUME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC430", Offset = "0x8BFB630", VA = "0x188BFC430", Slot = "14")]
		private OGGIYYTNGQG MOKJIIPJENG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBF40", Offset = "0x8BFB140", VA = "0x188BFBF40", Slot = "15")]
		private DJJQIUJHJNY HUSITKKXQBC(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBDF0", Offset = "0x8BFAFF0", VA = "0x188BFBDF0", Slot = "16")]
		private ZALZQXLDEQI AQIKRYQZPLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC2E0", Offset = "0x8BFB4E0", VA = "0x188BFC2E0", Slot = "17")]
		private UXQBLMEKFEU WQHVHEWIGYG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC1E0", Offset = "0x8BFB3E0", VA = "0x188BFC1E0", Slot = "18")]
		private GKIBYCQTGDW KZUGHOSNWNQ(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface HHZJUQEXKBK : YSBWHBQBYHX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LEPZGRIDJSX(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AJYCGKULROC(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZEWBZXNKECB(IEYSFSKDJLT a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KHOTZJKCQOY(IEYSFSKDJLT a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface WVPNRKTUWHB : NEAYNYJJBRM
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		UKSZUUHAUVF<IEYSFSKDJLT> XUSOUFITXYO
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		IEYSFSKDJLT TOQLGSCKYPK
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface RZXDKTDWMNB : UXQBLMEKFEU
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) XVQUVZPKGHI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IXYWPLMFPTZ : DJJQIUJHJNY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView QLZUUFQYYIT
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class SUGDDCXRAHY : REYZHDGDWBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode BDQTHWZHLCW;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAC90", Offset = "0x8BF9E90", VA = "0x188BFAC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode ZBITUHDIRTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAFE0", Offset = "0x8BFA1E0", VA = "0x188BFAFE0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAF70", Offset = "0x8BFA170", VA = "0x188BFAF70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB170", Offset = "0x8BFA370", VA = "0x188BFB170")]
		public SUGDDCXRAHY(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAB70", Offset = "0x8BF9D70", VA = "0x188BFAB70", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB0F0", Offset = "0x8BFA2F0", VA = "0x188BFB0F0", Slot = "9")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAC80", Offset = "0x8BF9E80", VA = "0x188BFAC80", Slot = "7")]
		public void FPLZBBMOTHW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8BFACE0", Offset = "0x8BF9EE0", VA = "0x188BFACE0", Slot = "8")]
		public void JNSFRVYHZAD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8BFACF0", Offset = "0x8BF9EF0", VA = "0x188BFACF0", Slot = "10")]
		public bool PVRJOTOCNCI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAE50", Offset = "0x8BFA050", VA = "0x188BFAE50")]
		private void SLOMHFJCTVK(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IFLJZHYOCQL : QMWPTTNTZSO, IDisposable, SEILEHPFETW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate ODXKPYPWKRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HDYEPOVFWPT KSZBFWRXVZV;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate BTIZQQPMPYT
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5900", Offset = "0x8BE4B00", VA = "0x188BE5900", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5C20", Offset = "0x8BE4E20", VA = "0x188BE5C20", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform OPXUSYTTWIE
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5C00", Offset = "0x8BE4E00", VA = "0x188BE5C00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> DXGSCXULVKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5AA0", Offset = "0x8BE4CA0", VA = "0x188BE5AA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5B50", Offset = "0x8BE4D50", VA = "0x188BE5B50", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5CF0", Offset = "0x8BE4EF0", VA = "0x188BE5CF0")]
		public IFLJZHYOCQL(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5690", Offset = "0x8BE4890", VA = "0x188BE5690", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5A50", Offset = "0x8BE4C50", VA = "0x188BE5A50", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x11607B0", Offset = "0x115F9B0", VA = "0x1811607B0", Slot = "11")]
		private void CZOLRDGPSNV(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "12")]
		private void XDKKOSMQLXJ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BGTCABVBBUR : COVYYNHGDQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8BE38B0", Offset = "0x8BE2AB0", VA = "0x188BE38B0", Slot = "4")]
		public YSBWHBQBYHX OBGSWPRBEXN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3BD0", Offset = "0x8BE2DD0", VA = "0x188BE3BD0", Slot = "5")]
		public CQWOLNKFHIF STIFEEOLHJN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2EF0", Offset = "0x8BE20F0", VA = "0x188BE2EF0", Slot = "6")]
		public NEAYNYJJBRM ENXWURAVMHO(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3CE0", Offset = "0x8BE2EE0", VA = "0x188BE3CE0", Slot = "7")]
		public CKPUTKDCDYH UXAZGIXIAPH(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3D50", Offset = "0x8BE2F50", VA = "0x188BE3D50", Slot = "8")]
		public HAMSZOBKKUF VNIYOPSISDV(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3A50", Offset = "0x8BE2C50", VA = "0x188BE3A50", Slot = "9")]
		public QMWPTTNTZSO RHDNRLMIGQM(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3670", Offset = "0x8BE2870", VA = "0x188BE3670", Slot = "10")]
		public HTNHFSFSDBZ LMKGBFHUWKJ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3B10", Offset = "0x8BE2D10", VA = "0x188BE3B10", Slot = "11")]
		public TZDCXLKDXOZ SEFCVUJLJPZ(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3360", Offset = "0x8BE2560", VA = "0x188BE3360", Slot = "12")]
		public REYZHDGDWBD HMRYJLOHXBN(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3990", Offset = "0x8BE2B90", VA = "0x188BE3990", Slot = "13")]
		public KBRQGVSAQUQ PBMQCBLUDUC(IEYSFSKDJLT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3780", Offset = "0x8BE2980", VA = "0x188BE3780")]
		public OGGIYYTNGQG LWRASZEPOKM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3010", Offset = "0x8BE2210", VA = "0x188BE3010")]
		public DJJQIUJHJNY EZFDAJMWNOE(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2DD0", Offset = "0x8BE1FD0", VA = "0x188BE2DD0")]
		public ZALZQXLDEQI ZEPWVDWMGVU(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE34F0", Offset = "0x8BE26F0", VA = "0x188BE34F0")]
		public UXQBLMEKFEU JFFEVZTUNLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3420", Offset = "0x8BE2620", VA = "0x188BE3420")]
		public GKIBYCQTGDW IJXHZZCPACW(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3220", Offset = "0x8BE2420", VA = "0x188BE3220", Slot = "19")]
		public IEYSFSKDJLT GBWQRRBWBZY(RigidbodyEx a, RigidbodyExData b, ZDNQWULRURI c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public BGTCABVBBUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3780", Offset = "0x8BE2980", VA = "0x188BE3780", Slot = "14")]
		private OGGIYYTNGQG MOKJIIPJENG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3010", Offset = "0x8BE2210", VA = "0x188BE3010", Slot = "15")]
		private DJJQIUJHJNY HUSITKKXQBC(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2DD0", Offset = "0x8BE1FD0", VA = "0x188BE2DD0", Slot = "16")]
		private ZALZQXLDEQI AQIKRYQZPLM(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8BE34F0", Offset = "0x8BE26F0", VA = "0x188BE34F0", Slot = "17")]
		private UXQBLMEKFEU WQHVHEWIGYG(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3420", Offset = "0x8BE2620", VA = "0x188BE3420", Slot = "18")]
		private GKIBYCQTGDW KZUGHOSNWNQ(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class XVMNWGUKIUE : TZDCXLKDXOZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAC90", Offset = "0x8BF9E90", VA = "0x188BFAC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool LOLTVRSGCLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE390", Offset = "0x8BFD590", VA = "0x188BFE390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool TIATPWOGWME
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5260", Offset = "0x8BE4460", VA = "0x188BE5260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private IEYSFSKDJLT XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE3E0", Offset = "0x8BFD5E0", VA = "0x188BFE3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB170", Offset = "0x8BFA370", VA = "0x188BFB170")]
		public XVMNWGUKIUE(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDD50", Offset = "0x8BFCF50", VA = "0x188BFDD50", Slot = "4")]
		public void LCVBNEOCBVM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE440", Offset = "0x8BFD640", VA = "0x188BFE440")]
		private void WCNQHXSHOAJ(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE110", Offset = "0x8BFD310", VA = "0x188BFE110", Slot = "5")]
		public void OYHNMUUFGHO(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD990", Offset = "0x8BFCB90", VA = "0x188BFD990", Slot = "6")]
		public void AVMRPVCSACR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDAF0", Offset = "0x8BFCCF0", VA = "0x188BFDAF0")]
		private void GSEDIELBDWY(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDEB0", Offset = "0x8BFD0B0", VA = "0x188BFDEB0", Slot = "7")]
		public void MXKYPDYGWJT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class XPPMUISOQGB : KBRQGVSAQUQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool IFMPCWOFZAD;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool HIHKKOIFXCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD850", Offset = "0x8BFCA50", VA = "0x188BFD850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB170", Offset = "0x8BFA370", VA = "0x188BFB170")]
		public XPPMUISOQGB(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD960", Offset = "0x8BFCB60", VA = "0x188BFD960", Slot = "6")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD7E0", Offset = "0x8BFC9E0", VA = "0x188BFD7E0", Slot = "7")]
		public void IHOMJPOXKPI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : HHZJUQEXKBK, YSBWHBQBYHX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IEYSFSKDJLT YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<IEYSFSKDJLT> TTGADSRTPNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IEYSFSKDJLT OLVATFGKMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEYSFSKDJLT NGCRDKEZGTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform YHBCHDGTXCL;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform HUSVRZMONUM
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE190", Offset = "0x8BED390", VA = "0x188BEE190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public IEYSFSKDJLT XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xABF5C0", Offset = "0xABE7C0", VA = "0x180ABF5C0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE490", Offset = "0x8BED690", VA = "0x188BEE490", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public IEYSFSKDJLT YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xABF840", Offset = "0xABEA40", VA = "0x180ABF840", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<IEYSFSKDJLT> FUFQEFKIOOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xABC970", Offset = "0xABBB70", VA = "0x180ABC970", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction JQNNRJXYALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8BED620", Offset = "0x8BEC820", VA = "0x188BED620", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE290", Offset = "0x8BED490", VA = "0x188BEE290", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction XOCRVOCFFPM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8BED760", Offset = "0x8BEC960", VA = "0x188BED760", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE0F0", Offset = "0x8BED2F0", VA = "0x188BEE0F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction WPIMURTHKBG
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE1F0", Offset = "0x8BED3F0", VA = "0x188BEE1F0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8BED8B0", Offset = "0x8BECAB0", VA = "0x188BED8B0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action BKBFJKKPPJH
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8BECA90", Offset = "0x8BEBC90", VA = "0x188BECA90", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE330", Offset = "0x8BED530", VA = "0x188BEE330", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action QCCYXVXIHMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDF00", Offset = "0x8BED100", VA = "0x188BEDF00", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8BED6C0", Offset = "0x8BEC8C0", VA = "0x188BED6C0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<IEYSFSKDJLT> PJBGKVIYKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8BECC70", Offset = "0x8BEBE70", VA = "0x188BECC70", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8BED570", Offset = "0x8BEC770", VA = "0x188BED570", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<IEYSFSKDJLT> DGZJJENJBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE040", Offset = "0x8BED240", VA = "0x188BEE040", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8BEE710", Offset = "0x8BED910", VA = "0x188BEE710", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action VWXEYROIAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8BECBD0", Offset = "0x8BEBDD0", VA = "0x188BECBD0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8BED4D0", Offset = "0x8BEC6D0", VA = "0x188BED4D0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<IEYSFSKDJLT> FUTERMDZAWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8BED800", Offset = "0x8BECA00", VA = "0x188BED800", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8BECD20", Offset = "0x8BEBF20", VA = "0x188BECD20", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE7C0", Offset = "0x8BED9C0", VA = "0x188BEE7C0")]
		public RbexHierarchy(IEYSFSKDJLT rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8BECB30", Offset = "0x8BEBD30", VA = "0x188BECB30", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8BED950", Offset = "0x8BECB50", VA = "0x188BED950", Slot = "30")]
		public void SetParent(IEYSFSKDJLT newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE4A0", Offset = "0x8BED6A0", VA = "0x188BEE4A0", Slot = "6")]
		public void ZEWBZXNKECB(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8BECF00", Offset = "0x8BEC100", VA = "0x188BECF00", Slot = "7")]
		public void KHOTZJKCQOY(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8BED180", Offset = "0x8BEC380", VA = "0x188BED180", Slot = "4")]
		public void LEPZGRIDJSX(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC9F0", Offset = "0x8BEBBF0", VA = "0x188BEC9F0", Slot = "5")]
		public void AJYCGKULROC(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDFA0", Offset = "0x8BED1A0", VA = "0x188BEDFA0")]
		private void VIVJQVLUYPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDEC0", Offset = "0x8BED0C0", VA = "0x188BEDEC0")]
		private void TZXSZVZBXGE(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8BED390", Offset = "0x8BEC590", VA = "0x188BED390")]
		private void LLXNYPLIBUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8BECDD0", Offset = "0x8BEBFD0", VA = "0x188BECDD0")]
		private void GVKRYAFTJNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8BED270", Offset = "0x8BEC470", VA = "0x188BED270")]
		private void LKECIAGTZQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE3D0", Offset = "0x8BED5D0", VA = "0x188BEE3D0")]
		[CompilerGenerated]
		private object XZZEZZZNQKI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class LHSLYLQSIXE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9BB0", Offset = "0x8BE8DB0", VA = "0x188BE9BB0")]
		public static HHZJUQEXKBK MGIWXKBNMBN(this IEYSFSKDJLT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class LBSIDJYWBWT : WVPNRKTUWHB, NEAYNYJJBRM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly UKSZUUHAUVF<IEYSFSKDJLT> UJLOVOYTZJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool IBRUWCNQPYP;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public UKSZUUHAUVF<IEYSFSKDJLT> XUSOUFITXYO
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 DDOXLYTBMNP
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8BE90F0", Offset = "0x8BE82F0", VA = "0x188BE90F0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 FORUEBMLMJN
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8BE8DF0", Offset = "0x8BE7FF0", VA = "0x188BE8DF0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 EKAVHDJHYML
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8BE99E0", Offset = "0x8BE8BE0", VA = "0x188BE99E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public IEYSFSKDJLT TOQLGSCKYPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8BE9120", Offset = "0x8BE8320", VA = "0x188BE9120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9AC0", Offset = "0x8BE8CC0", VA = "0x188BE9AC0")]
		public LBSIDJYWBWT(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BE91D0", Offset = "0x8BE83D0", VA = "0x188BE91D0", Slot = "8")]
		public void KLIVCEDGBJZ(IEYSFSKDJLT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9240", Offset = "0x8BE8440", VA = "0x188BE9240", Slot = "9")]
		public void SGOZEEVIIQM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9640", Offset = "0x8BE8840", VA = "0x188BE9640")]
		private Vector3 YEYIJFDAZKV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BE92A0", Offset = "0x8BE84A0", VA = "0x188BE92A0")]
		private void TODJWRENZHQ(IEYSFSKDJLT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class RPHHQOBFPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC930", Offset = "0x8BEBB30", VA = "0x188BEC930")]
		public static WVPNRKTUWHB EEQHUFZHWBO(this IEYSFSKDJLT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class QRBBHGPLKPJ : RZXDKTDWMNB, UXQBLMEKFEU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 UPGIEOACCQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 VGWJHFDFNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float NVSZIWSYFZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float DPBYZPTUWYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 YXHKXCMPGFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? BEPFHNSCMDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? AMSUPYTPCCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool MABGVJRNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool NRPSZLFQBTD;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 VRKJXVCYHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C58410", Offset = "0x1C57610", VA = "0x181C58410", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BEB430", Offset = "0x8BEA630", VA = "0x188BEB430", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 VFMTIBAGIGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA980", Offset = "0x8BE9B80", VA = "0x188BEA980", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float UPEBGWXMUFC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB08BA0", Offset = "0xB07DA0", VA = "0x180B08BA0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BEB320", Offset = "0x8BEA520", VA = "0x188BEB320")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float DQLIMXDHSZN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB08BB0", Offset = "0xB07DB0", VA = "0x180B08BB0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA310", Offset = "0x8BE9510", VA = "0x188BEA310", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 FTBKASODFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAAA0", Offset = "0x8BE9CA0", VA = "0x188BEAAA0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion EWGMFAKLDMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BEB4E0", Offset = "0x8BEA6E0", VA = "0x188BEB4E0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BE3F50", Offset = "0x8BE3150", VA = "0x188BE3F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction EVHUEJZMWVI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8BEC730", Offset = "0x8BEB930", VA = "0x188BEC730", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA740", Offset = "0x8BE9940", VA = "0x188BEA740", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC7D0", Offset = "0x8BEB9D0", VA = "0x188BEC7D0")]
		public QRBBHGPLKPJ(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA0D0", Offset = "0x8BE92D0", VA = "0x188BEA0D0", Slot = "17")]
		public void BYXYCMXHMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9FF0", Offset = "0x8BE91F0", VA = "0x188BE9FF0", Slot = "16")]
		public void BRXGUJIPJVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC650", Offset = "0x8BEB850", VA = "0x188BEC650", Slot = "19")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA560", Offset = "0x8BE9760", VA = "0x188BEA560", Slot = "20")]
		public void IHOMJPOXKPI(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA3C0", Offset = "0x8BE95C0", VA = "0x188BEA3C0", Slot = "18")]
		public void HZKGTXGBRRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE60", Offset = "0x8BEA060", VA = "0x188BEAE60", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB430", Offset = "0x8BEA630", VA = "0x188BEB430")]
		private void SSPFCXMEHID(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA1F0", Offset = "0x8BE93F0", VA = "0x188BEA1F0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 DTUKRIWFTGY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB320", Offset = "0x8BEA520", VA = "0x188BEB320")]
		private void QYTDAXMAEYM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA310", Offset = "0x8BE9510", VA = "0x188BEA310")]
		private void GJRCBTYVQNV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA7E0", Offset = "0x8BE99E0", VA = "0x188BEA7E0")]
		private Vector3 JFIUEPOJJWH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAC30", Offset = "0x8BE9E30", VA = "0x188BEAC30", Slot = "15")]
		public void NUDUUQIXEFR((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC4D0", Offset = "0x8BEB6D0", VA = "0x188BEC4D0")]
		private Quaternion YIIIHUUJXRT()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB660", Offset = "0x8BEA860", VA = "0x188BEB660")]
		public void XVQUVZPKGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB730", Offset = "0x8BEA930", VA = "0x188BEB730", Slot = "4")]
		public (float, Vector3) XVQUVZPKGHI(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class WNSQKZWRHJT
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCA40", Offset = "0x8BFBC40", VA = "0x188BFCA40")]
		public static RZXDKTDWMNB UAMIFLBFVDY(this IEYSFSKDJLT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class TOUDADVDYBT : ZALZQXLDEQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly EWUFIVAODUW JPXMIJTWDKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode VYPCEVEFRKN;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool XRLWDZRVDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x18A8E50", Offset = "0x18A8050", VA = "0x1818A8E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode XKAEYZHICIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBD00", Offset = "0x8BFAF00", VA = "0x188BFBD00")]
		public TOUDADVDYBT(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB6F0", Offset = "0x8BFA8F0", VA = "0x188BFB6F0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBC60", Offset = "0x8BFAE60", VA = "0x188BFBC60")]
		private bool ZRFIWNIBMWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB7C0", Offset = "0x8BFA9C0", VA = "0x188BFB7C0", Slot = "5")]
		public void GMAFEQRKQAL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB960", Offset = "0x8BFAB60", VA = "0x188BFB960", Slot = "6")]
		public void THBDMTNEJCC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB830", Offset = "0x8BFAA30", VA = "0x188BFB830", Slot = "9")]
		public void IUFSKFJIWAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBB50", Offset = "0x8BFAD50", VA = "0x188BFBB50")]
		private void VHDUXQGXTQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB990", Offset = "0x8BFAB90", VA = "0x188BFB990")]
		private void TUHNSBTPXYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB7F0", Offset = "0x8BFA9F0", VA = "0x188BFB7F0", Slot = "8")]
		public void IRYMMCUNCLX(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBB10", Offset = "0x8BFAD10", VA = "0x188BFBB10", Slot = "7")]
		public void VAZUABDNLMG(IEYSFSKDJLT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class TLLLUOOZMGK : HTNHFSFSDBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly EWUFIVAODUW NJSXOXWFDCL;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool LOLTVRSGCLT
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB4E0", Offset = "0x8BFA6E0", VA = "0x188BFB4E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction JHDBBQYJVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB430", Offset = "0x8BFA630", VA = "0x188BFB430", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB310", Offset = "0x8BFA510", VA = "0x188BFB310", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB610", Offset = "0x8BFA810", VA = "0x188BFB610")]
		public TLLLUOOZMGK(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB3B0", Offset = "0x8BFA5B0", VA = "0x188BFB3B0", Slot = "7")]
		public void CQCVLGJTYBO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB4D0", Offset = "0x8BFA6D0", VA = "0x188BFB4D0", Slot = "8")]
		public void RANJKXYZEXT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB200", Offset = "0x8BFA400", VA = "0x188BFB200", Slot = "9")]
		public void AGEYPSKGISF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB3F0", Offset = "0x8BFA5F0", VA = "0x188BFB3F0", Slot = "12")]
		public void KCIPBLVICKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB590", Offset = "0x8BFA790", VA = "0x188BFB590", Slot = "10")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB3C0", Offset = "0x8BFA5C0", VA = "0x188BFB3C0", Slot = "11")]
		public void IHOMJPOXKPI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class XJTFAFHGNOX : IXYWPLMFPTZ, DJJQIUJHJNY, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView UWTVSAQUQZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool JFRCZDVGNJU;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView QLZUUFQYYIT
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool ETWTOIDSUMQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8BFCE90", Offset = "0x8BFC090", VA = "0x188BFCE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool PPLJCOEVRNU
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xB2D260", Offset = "0xB2C460", VA = "0x180B2D260", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction OLTAFOCTDJB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD160", Offset = "0x8BFC360", VA = "0x188BFD160", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD200", Offset = "0x8BFC400", VA = "0x188BFD200", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD680", Offset = "0x8BFC880", VA = "0x188BFD680")]
		public XJTFAFHGNOX(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCB00", Offset = "0x8BFBD00", VA = "0x188BFCB00", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCDA0", Offset = "0x8BFBFA0", VA = "0x188BFCDA0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCC30", Offset = "0x8BFBE30", VA = "0x188BFCC30", Slot = "10")]
		public void CFHIWBWBEWY(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD510", Offset = "0x8BFC710", VA = "0x188BFD510", Slot = "11")]
		public void YUUVXLSRSTC(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCEA0", Offset = "0x8BFC0A0", VA = "0x188BFCEA0")]
		private void HDPMHKSEKJO(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD010", Offset = "0x8BFC210", VA = "0x188BFD010")]
		private void IEGXTKGMLKU(BCZKDCDLKFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD2A0", Offset = "0x8BFC4A0", VA = "0x188BFD2A0")]
		private void YJABVPOLTDP(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class NQNJQCBUUNX
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9D70", Offset = "0x8BE8F70", VA = "0x188BE9D70")]
		public static IXYWPLMFPTZ Lifecycle(this IEYSFSKDJLT impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class XZGBIINYNYD : GKIBYCQTGDW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints CHPIKSQLUEY;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool JJYDVTMCCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC41720", Offset = "0xC40920", VA = "0x180C41720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xC41D30", Offset = "0xC40F30", VA = "0x180C41D30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool HHNRUUHXUUK
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xC41CB0", Offset = "0xC40EB0", VA = "0x180C41CB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xC417F0", Offset = "0xC409F0", VA = "0x180C417F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints OTUZTHAMALK
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE6A0", Offset = "0x8BFD8A0", VA = "0x188BFE6A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE830", Offset = "0x8BFDA30", VA = "0x188BFE830")]
		public XZGBIINYNYD(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE800", Offset = "0x8BFDA00", VA = "0x188BFE800", Slot = "9")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE7D0", Offset = "0x8BFD9D0", VA = "0x188BFE7D0", Slot = "10")]
		public void IHOMJPOXKPI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class GXWLIIFMWAQ : CKPUTKDCDYH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly IEYSFSKDJLT YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float KVKFKFYEOIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float WAAYCRJXEVC;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float UNUSEFGJXIK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB1BCB0", Offset = "0xB1AEB0", VA = "0x180B1BCB0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5530", Offset = "0x8BE4730", VA = "0x188BE5530", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float AYNWROETSSI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB1BCC0", Offset = "0xB1AEC0", VA = "0x180B1BCC0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BE53C0", Offset = "0x8BE45C0", VA = "0x188BE53C0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5650", Offset = "0x8BE4850", VA = "0x188BE5650")]
		public GXWLIIFMWAQ(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5600", Offset = "0x8BE4800", VA = "0x188BE5600", Slot = "8")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5490", Offset = "0x8BE4690", VA = "0x188BE5490", Slot = "9")]
		public void IHOMJPOXKPI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class BKDXFFNHUBO : HAMSZOBKKUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log YNVJBNVPKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool WEAGXRWHINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool JGSYDSJFJZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int SATEUFMSPBA;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8BE3F50", Offset = "0x8BE3150", VA = "0x188BE3F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool ZICMJAKEGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8BE42B0", Offset = "0x8BE34B0", VA = "0x188BE42B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private IEYSFSKDJLT XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8BE4530", Offset = "0x8BE3730", VA = "0x188BE4530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool TIATPWOGWME
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8BE48B0", Offset = "0x8BE3AB0", VA = "0x188BE48B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction HRXRZTEOYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BE3E10", Offset = "0x8BE3010", VA = "0x188BE3E10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8BE4910", Offset = "0x8BE3B10", VA = "0x188BE4910", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4A30", Offset = "0x8BE3C30", VA = "0x188BE4A30")]
		public BKDXFFNHUBO(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3EB0", Offset = "0x8BE30B0", VA = "0x188BE3EB0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3F40", Offset = "0x8BE3140", VA = "0x188BE3F40", Slot = "8")]
		public void BUGPWFVUDOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4160", Offset = "0x8BE3360", VA = "0x188BE4160", Slot = "7")]
		public bool JEZNSLNKIZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4460", Offset = "0x8BE3660", VA = "0x188BE4460", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8BE42D0", Offset = "0x8BE34D0", VA = "0x188BE42D0", Slot = "13")]
		public void NGQVJTWBLSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4590", Offset = "0x8BE3790", VA = "0x188BE4590", Slot = "12")]
		public void UHEWSAVDKRG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8BE46B0", Offset = "0x8BE38B0", VA = "0x188BE46B0", Slot = "10")]
		public bool WHUPJUQOLYD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4370", Offset = "0x8BE3570", VA = "0x188BE4370", Slot = "11")]
		public bool NQWFPQWNRKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3FA0", Offset = "0x8BE31A0", VA = "0x188BE3FA0")]
		private bool ISGZEZDDGZO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4720", Offset = "0x8BE3920", VA = "0x188BE4720")]
		private void XICVWAROCJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class FXSDEYXQHOB : OGGIYYTNGQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly EWUFIVAODUW JMZMBEJOPPL;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody YLHECKUZVZW
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool TIATPWOGWME
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5260", Offset = "0x8BE4460", VA = "0x188BE5260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool EVNAOQPASND
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x18A8E50", Offset = "0x18A8050", VA = "0x1818A8E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE52C0", Offset = "0x8BE44C0", VA = "0x188BE52C0")]
		public FXSDEYXQHOB(IEYSFSKDJLT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4AC0", Offset = "0x8BE3CC0", VA = "0x188BE4AC0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4E90", Offset = "0x8BE4090", VA = "0x188BE4E90", Slot = "7")]
		public void LNUMJQGOJYX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5040", Offset = "0x8BE4240", VA = "0x188BE5040", Slot = "8")]
		public void TUFVMNTKHRU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4B60", Offset = "0x8BE3D60", VA = "0x188BE4B60", Slot = "9")]
		public void HQDOPLWJOYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5070", Offset = "0x8BE4270", VA = "0x188BE5070", Slot = "10")]
		public void WBNSUPKMLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4EC0", Offset = "0x8BE40C0", VA = "0x188BE4EC0", Slot = "11")]
		public void QAVWFASYUIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class KJOSQOIODZE : CQWOLNKFHIF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly SQBJFBVEGOM YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly EWUFIVAODUW TNYDNCZFWVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float BDLLZZAJLRF;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public MQFJCOUWAHP DOAAJTIXHOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public VHZVCFPQQRK PBTTNENGFRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 EKAVHDJHYML
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8BE8020", Offset = "0x8BE7220", VA = "0x188BE8020", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7890", Offset = "0x8BE6A90", VA = "0x188BE7890", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 ADKVRNPLFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8BE62F0", Offset = "0x8BE54F0", VA = "0x188BE62F0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8BE62C0", Offset = "0x8BE54C0", VA = "0x188BE62C0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 SWSPBSUDLYR
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6AD0", Offset = "0x8BE5CD0", VA = "0x188BE6AD0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6A10", Offset = "0x8BE5C10", VA = "0x188BE6A10", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 FIVNNPRGYDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5DF0", Offset = "0x8BE4FF0", VA = "0x188BE5DF0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7860", Offset = "0x8BE6A60", VA = "0x188BE7860", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float OMOMSMOUUBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB1BED0", Offset = "0xB1B0D0", VA = "0x180B1BED0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6110", Offset = "0x8BE5310", VA = "0x188BE6110", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool MWEDSCWZQHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2377880", Offset = "0x2376A80", VA = "0x182377880", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private TZDCXLKDXOZ CLVKKHZQWVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x814E7B0", Offset = "0x814D9B0", VA = "0x18814E7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool ZICMJAKEGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7110", Offset = "0x8BE6310", VA = "0x188BE7110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8D10", Offset = "0x8BE7F10", VA = "0x188BE8D10")]
		public KJOSQOIODZE(IEYSFSKDJLT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6220", Offset = "0x8BE5420", VA = "0x188BE6220", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6470", Offset = "0x8BE5670", VA = "0x188BE6470", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8350", Offset = "0x8BE7550", VA = "0x188BE8350", Slot = "28")]
		public void ZOYSVOLSAOB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x16997A0", Offset = "0x16989A0", VA = "0x1816997A0", Slot = "20")]
		public void WFNTYHGNWNJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1698D40", Offset = "0x1697F40", VA = "0x181698D40", Slot = "30")]
		public void ZPJDTOIYTQC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7950", Offset = "0x8BE6B50", VA = "0x188BE7950", Slot = "35")]
		public Vector3 SLFFDNUKUIP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6850", Offset = "0x8BE5A50", VA = "0x188BE6850", Slot = "34")]
		public Vector3 GWNWCUZPVPL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6220", Offset = "0x8BE5420", VA = "0x188BE6220", Slot = "27")]
		public void RGVHKICYEQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE64D0", Offset = "0x8BE56D0", VA = "0x188BE64D0", Slot = "25")]
		public void EUXVMKOBLSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE72D0", Offset = "0x8BE64D0", VA = "0x188BE72D0", Slot = "24")]
		public void NVHKPHGLRHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6610", Offset = "0x8BE5810", VA = "0x188BE6610", Slot = "33")]
		public void FGVUZKRCGYW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7B30", Offset = "0x8BE6D30", VA = "0x188BE7B30", Slot = "32")]
		public void SMBHDDCQQRZ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7E80", Offset = "0x8BE7080", VA = "0x188BE7E80", Slot = "31")]
		public void VRXPVDQNYPQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7330", Offset = "0x8BE6530", VA = "0x188BE7330", Slot = "22")]
		public void NYWDWLQFXRW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8480", Offset = "0x8BE7680", VA = "0x188BE8480", Slot = "21")]
		public void ZSTDUAHIRTT(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8700", Offset = "0x8BE7900", VA = "0x188BE8700", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZVMHVPSPULE(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x17F5940", Offset = "0x17F4B40", VA = "0x1817F5940")]
		private static void VBYUAMAJSCK(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6530", Offset = "0x8BE5730", VA = "0x188BE6530", Slot = "29")]
		public Vector3 FAKAHLRMQKX(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5F80", Offset = "0x8BE5180", VA = "0x188BE5F80", Slot = "26")]
		public void AUOPABDKXQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6110", Offset = "0x8BE5310", VA = "0x188BE6110")]
		private void AZJUBYRKMYL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7130", Offset = "0x8BE6330", VA = "0x188BE7130")]
		private void NKWKILLUBAD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE81D0", Offset = "0x8BE73D0", VA = "0x188BE81D0")]
		private Vector3 ZFCUOWXHLUI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7B90", Offset = "0x8BE6D90", VA = "0x188BE7B90")]
		private void SPIBVNKVCOM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8B80", Offset = "0x8BE7D80", VA = "0x188BE8B80")]
		private Vector3 ZWNFTLSEVDG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6C90", Offset = "0x8BE5E90", VA = "0x188BE6C90")]
		private void LVJJUXAELHC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private void JSJHKUCZLWH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private void ZZLZDCJCTRH()
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
