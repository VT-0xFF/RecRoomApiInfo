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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C4D1D0", Offset = "0x8C4BFD0", VA = "0x188C4D1D0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8637160", Offset = "0x8635F60", VA = "0x188637160", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A240", Offset = "0x8C59040", VA = "0x188C5A240")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A1E0", Offset = "0x8C58FE0", VA = "0x188C5A1E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A520", Offset = "0x8C59320", VA = "0x188C5A520")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, JWEPENHIPYI, GDGVDDKKAVJ, PBJWDCWWANP
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log IRTPQAXXLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool OMDNNURZKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SBFKUYKXOTE FEUVPLHAWKB;

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
		private Transform FEYUNNPPHYH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal SBFKUYKXOTE JJTHRRBTRRL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8C516E0", Offset = "0x8C504E0", VA = "0x188C516E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private SBFKUYKXOTE XSOSWTCBHQV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WLHZPNODKWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C533A0", Offset = "0x8C521A0", VA = "0x188C533A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PUDBFNMNVML
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8C53700", Offset = "0x8C52500", VA = "0x188C53700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C53640", Offset = "0x8C52440", VA = "0x188C53640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx TNQRTSDCHDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C54310", Offset = "0x8C53110", VA = "0x188C54310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8C55840", Offset = "0x8C54640", VA = "0x188C55840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x802C7A0", Offset = "0x802B5A0", VA = "0x18802C7A0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x802C8F0", Offset = "0x802B6F0", VA = "0x18802C8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform QWGFNDFIQDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2587C80", Offset = "0x2586A80", VA = "0x182587C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform PNDGMXUJQVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2587C80", Offset = "0x2586A80", VA = "0x182587C80", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform YPDFLVIMCRY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2587C80", Offset = "0x2586A80", VA = "0x182587C80", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate ILQFYIZQUEM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C53400", Offset = "0x8C52200", VA = "0x188C53400")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8C54FF0", Offset = "0x8C53DF0", VA = "0x188C54FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IUVDVSDYVBP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8C53A10", Offset = "0x8C52810", VA = "0x188C53A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool QYGWXXOFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8C53520", Offset = "0x8C52320", VA = "0x188C53520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DLILUNFEYEI JJNYIFZBXGV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8C53950", Offset = "0x8C52750", VA = "0x188C53950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C551B0", Offset = "0x8C53FB0", VA = "0x188C551B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BCEQBJSIDBZ LCMFGRQEXGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8C538F0", Offset = "0x8C526F0", VA = "0x188C538F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8C55140", Offset = "0x8C53F40", VA = "0x188C55140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KHAOJJQZJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8C53840", Offset = "0x8C52640", VA = "0x188C53840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8C538A0", Offset = "0x8C526A0", VA = "0x188C538A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OZDQEMGQWDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8C53580", Offset = "0x8C52380", VA = "0x188C53580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8C55060", Offset = "0x8C53E60", VA = "0x188C55060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OFJVZINVDQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A243F0", Offset = "0x1A231F0", VA = "0x181A243F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float FBXHNJDHQNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8C542B0", Offset = "0x8C530B0", VA = "0x188C542B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ZHDYDZHCJUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8C54250", Offset = "0x8C53050", VA = "0x188C54250")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8C557D0", Offset = "0x8C545D0", VA = "0x188C557D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float QRSNSNIJAKR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8C53C70", Offset = "0x8C52A70", VA = "0x188C53C70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8C55450", Offset = "0x8C54250", VA = "0x188C55450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NQPOWXRLYBP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8C53A70", Offset = "0x8C52870", VA = "0x188C53A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8C55220", Offset = "0x8C54020", VA = "0x188C55220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ETGMNYNLBWU
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8C54890", Offset = "0x8C53690", VA = "0x188C54890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C55D80", Offset = "0x8C54B80", VA = "0x188C55D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 TXEICCAWUGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8C54030", Offset = "0x8C52E30", VA = "0x188C54030")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8C555A0", Offset = "0x8C543A0", VA = "0x188C555A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 HJJQZIXMWYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8C549D0", Offset = "0x8C537D0", VA = "0x188C549D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode FFPAPAOBIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C53BB0", Offset = "0x8C529B0", VA = "0x188C53BB0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8C55370", Offset = "0x8C54170", VA = "0x188C55370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float RYOEOXBFDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8C535E0", Offset = "0x8C523E0", VA = "0x188C535E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8C550D0", Offset = "0x8C53ED0", VA = "0x188C550D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OZRHKIZXNVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C53C10", Offset = "0x8C52A10", VA = "0x188C53C10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C553E0", Offset = "0x8C541E0", VA = "0x188C553E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 LSROCFITWPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8C543D0", Offset = "0x8C531D0", VA = "0x188C543D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 OFPDCKFPJEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8C543D0", Offset = "0x8C531D0", VA = "0x188C543D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8C55B60", Offset = "0x8C54960", VA = "0x188C55B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HXIKDYNNVGI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8C54110", Offset = "0x8C52F10", VA = "0x188C54110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8C55680", Offset = "0x8C54480", VA = "0x188C55680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ELNXFMRMUQN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C54830", Offset = "0x8C53630", VA = "0x188C54830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8C55D10", Offset = "0x8C54B10", VA = "0x188C55D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion VIOSLJFGYAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8C544B0", Offset = "0x8C532B0", VA = "0x188C544B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8C558E0", Offset = "0x8C546E0", VA = "0x188C558E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PDKJPUQKFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8C54750", Offset = "0x8C53550", VA = "0x188C54750")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8C55C40", Offset = "0x8C54A40", VA = "0x188C55C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HJBPNUSFLXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8C54590", Offset = "0x8C53390", VA = "0x188C54590")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8C559B0", Offset = "0x8C547B0", VA = "0x188C559B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion MKMGMSHXIZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8C54670", Offset = "0x8C53470", VA = "0x188C54670")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8C55A90", Offset = "0x8C54890", VA = "0x188C55A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DSLBTFYVPCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8C548F0", Offset = "0x8C536F0", VA = "0x188C548F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8C55DF0", Offset = "0x8C54BF0", VA = "0x188C55DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PGNLDZSDLAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8C54170", Offset = "0x8C52F70", VA = "0x188C54170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8C556F0", Offset = "0x8C544F0", VA = "0x188C556F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MBTLOJONJJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8C53AD0", Offset = "0x8C528D0", VA = "0x188C53AD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8C55290", Offset = "0x8C54090", VA = "0x188C55290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GIPRDXHKEZN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8C53F50", Offset = "0x8C52D50", VA = "0x188C53F50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8C554C0", Offset = "0x8C542C0", VA = "0x188C554C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HFXZLENVOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8C53E10", Offset = "0x8C52C10", VA = "0x188C53E10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion WHHTJGRBZAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8C53D30", Offset = "0x8C52B30", VA = "0x188C53D30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BHYDYQUWTRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8C54B90", Offset = "0x8C53990", VA = "0x188C54B90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 EYZORSQRZBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8C54AB0", Offset = "0x8C538B0", VA = "0x188C54AB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MRGQJRANJHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C53EF0", Offset = "0x8C52CF0", VA = "0x188C53EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BVRNSEADNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8C539B0", Offset = "0x8C527B0", VA = "0x188C539B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DFFNGCABOSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8C534C0", Offset = "0x8C522C0", VA = "0x188C534C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool SWZTKDOVQUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8C53460", Offset = "0x8C52260", VA = "0x188C53460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool USIPJPVZJDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8C53340", Offset = "0x8C52140", VA = "0x188C53340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool RVNDTDSRPLT
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8C53CD0", Offset = "0x8C52AD0", VA = "0x188C53CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE75500", Offset = "0xE74300", VA = "0x180E75500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction ZXNPYJKCLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C53260", Offset = "0x8C52060", VA = "0x188C53260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8C54F10", Offset = "0x8C53D10", VA = "0x188C54F10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction TNPRMYSCECX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8C52FD0", Offset = "0x8C51DD0", VA = "0x188C52FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8C54C70", Offset = "0x8C53A70", VA = "0x188C54C70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction XQTZDQNGHNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8C53030", Offset = "0x8C51E30", VA = "0x188C53030")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8C54CE0", Offset = "0x8C53AE0", VA = "0x188C54CE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction KOQQDXDOAIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8C53180", Offset = "0x8C51F80", VA = "0x188C53180")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8C54E30", Offset = "0x8C53C30", VA = "0x188C54E30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> PJATTIJUMTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8C53110", Offset = "0x8C51F10", VA = "0x188C53110")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8C54DC0", Offset = "0x8C53BC0", VA = "0x188C54DC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction IHPFGWBRZOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8C531F0", Offset = "0x8C51FF0", VA = "0x188C531F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C54EA0", Offset = "0x8C53CA0", VA = "0x188C54EA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction QUNMZJKSSVY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C532D0", Offset = "0x8C520D0", VA = "0x188C532D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8C54F80", Offset = "0x8C53D80", VA = "0x188C54F80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction IRTQMCXDPSB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C530A0", Offset = "0x8C51EA0", VA = "0x188C530A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8C54D50", Offset = "0x8C53B50", VA = "0x188C54D50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA0570", Offset = "0xA9F370", VA = "0x180AA0570", Slot = "8")]
		private void EVDMVEZEHEH(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A50", Offset = "0x8C50850", VA = "0x188C51A50", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C51EB0", Offset = "0x8C50CB0", VA = "0x188C51EB0")]
		internal void VHLSWBXXQMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C52B70", Offset = "0x8C51970", VA = "0x188C52B70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C517A0", Offset = "0x8C505A0", VA = "0x188C517A0")]
		public JWEPENHIPYI GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8C52830", Offset = "0x8C51630", VA = "0x188C52830")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51330", Offset = "0x8C50130", VA = "0x188C51330")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8C52AC0", Offset = "0x8C518C0", VA = "0x188C52AC0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8C516E0", Offset = "0x8C504E0", VA = "0x188C516E0")]
		private SBFKUYKXOTE EQPSXVOZCVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C52D50", Offset = "0x8C51B50", VA = "0x188C52D50")]
		private void YXKPQQSUPQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8C52000", Offset = "0x8C50E00", VA = "0x188C52000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8C51F40", Offset = "0x8C50D40", VA = "0x188C51F40")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8C51EB0", Offset = "0x8C50CB0", VA = "0x188C51EB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8C51FA0", Offset = "0x8C50DA0", VA = "0x188C51FA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C52060", Offset = "0x8C50E60", VA = "0x188C52060")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C509E0", Offset = "0x8C4F7E0", VA = "0x188C509E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8C520C0", Offset = "0x8C50EC0", VA = "0x188C520C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C51680", Offset = "0x8C50480", VA = "0x188C51680")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C51E50", Offset = "0x8C50C50", VA = "0x188C51E50")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C52990", Offset = "0x8C51790", VA = "0x188C52990")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8C523D0", Offset = "0x8C511D0", VA = "0x188C523D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C51AE0", Offset = "0x8C508E0", VA = "0x188C51AE0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51BE0", Offset = "0x8C509E0", VA = "0x188C51BE0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C50C50", Offset = "0x8C4FA50", VA = "0x188C50C50")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8C52130", Offset = "0x8C50F30", VA = "0x188C52130")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8C50CC0", Offset = "0x8C4FAC0", VA = "0x188C50CC0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8C521A0", Offset = "0x8C50FA0", VA = "0x188C521A0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8C52910", Offset = "0x8C51710", VA = "0x188C52910")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8C52730", Offset = "0x8C51530", VA = "0x188C52730")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C52630", Offset = "0x8C51430", VA = "0x188C52630")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8C51940", Offset = "0x8C50740", VA = "0x188C51940")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C51830", Offset = "0x8C50630", VA = "0x188C51830")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C50B60", Offset = "0x8C4F960", VA = "0x188C50B60")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C50A50", Offset = "0x8C4F850", VA = "0x188C50A50")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E90", Offset = "0x8C4FC90", VA = "0x188C50E90")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C50D30", Offset = "0x8C4FB30", VA = "0x188C50D30")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C52C40", Offset = "0x8C51A40", VA = "0x188C52C40")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C51D40", Offset = "0x8C50B40", VA = "0x188C51D40")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51620", Offset = "0x8C50420", VA = "0x188C51620")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8C515C0", Offset = "0x8C503C0", VA = "0x188C515C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C51560", Offset = "0x8C50360", VA = "0x188C51560")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8C51500", Offset = "0x8C50300", VA = "0x188C51500")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8C52530", Offset = "0x8C51330", VA = "0x188C52530")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C52430", Offset = "0x8C51230", VA = "0x188C52430")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C522F0", Offset = "0x8C510F0", VA = "0x188C522F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C52AD0", Offset = "0x8C518D0", VA = "0x188C52AD0")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8C51CE0", Offset = "0x8C50AE0", VA = "0x188C51CE0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C52A60", Offset = "0x8C51860", VA = "0x188C52A60")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C52BE0", Offset = "0x8C519E0", VA = "0x188C52BE0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E20", Offset = "0x8C4FC20", VA = "0x188C50E20")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8C52210", Offset = "0x8C51010", VA = "0x188C52210")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C511C0", Offset = "0x8C4FFC0", VA = "0x188C511C0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C51120", Offset = "0x8C4FF20", VA = "0x188C51120")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8C51280", Offset = "0x8C50080", VA = "0x188C51280")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51050", Offset = "0x8C4FE50", VA = "0x188C51050")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8C50F80", Offset = "0x8C4FD80", VA = "0x188C50F80")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8C52280", Offset = "0x8C51080", VA = "0x188C52280")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C51790", Offset = "0x8C50590", VA = "0x188C51790", Slot = "13")]
		private void GTTKDBKHAMU(WLYRVSLEATQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C52F60", Offset = "0x8C51D60", VA = "0x188C52F60")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBB2E80", Offset = "0xBB1C80", VA = "0x180BB2E80", Slot = "4")]
		private GameObject TVWQJLLROLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xACA9B0", Offset = "0xAC97B0", VA = "0x180ACA9B0", Slot = "10")]
		private bool PMVBHJCOWSI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class BGGVXKPHZRX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E750", Offset = "0x8C3D550", VA = "0x188C3E750")]
		public static SBFKUYKXOTE JJTHRRBTRRL(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(GSVAPJWYCOH), new string[] { })]
	public class RigidbodyExManager : GSVAPJWYCOH, LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DRCFUMLGMOY OKJTSMVEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private XATVNQELWGT XQRRFJUWDIP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public DRCFUMLGMOY UODYJOGPAPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public XATVNQELWGT QLMXAVAPVPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C508E0", Offset = "0x8C4F6E0", VA = "0x188C508E0", Slot = "7")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C507B0", Offset = "0x8C4F5B0", VA = "0x188C507B0", Slot = "6")]
		public SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static VYROOIAXTCX UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int PNBOKAHDGPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int PXMJNILTSFJ;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D2D0", Offset = "0x8C4C0D0", VA = "0x188C4D2D0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D350", Offset = "0x8C4C150", VA = "0x188C4D350")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D2F0", Offset = "0x8C4C0F0", VA = "0x188C4D2F0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D450", Offset = "0x8C4C250", VA = "0x188C4D450")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class FBECGMIFZFV
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class RUUPHJPGFDB : DLILUNFEYEI, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE4F0", Offset = "0xAAD2F0", VA = "0x180AAE4F0", Slot = "4")]
			public Vector3 BVDSEXIVSCW()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE4F0", Offset = "0xAAD2F0", VA = "0x180AAE4F0", Slot = "5")]
			public Vector3 UCABBOJCTQN()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "6")]
			public bool JZZWDMBQWEI(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public RUUPHJPGFDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DLILUNFEYEI HWWVLUPIBKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C45FD0", Offset = "0x8C44DD0", VA = "0x188C45FD0")]
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
	public interface IEZCLOGKHDC
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode KCGMTZAPAVB
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
		void FENSGLQBXNX(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EBCRRWPTMMI(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool QZEBEEUHMAZ(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ODZRFYNOYNH : IDisposable, MKHYVHNKDRP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate ILQFYIZQUEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> PJATTIJUMTX;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XATVNQELWGT
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CVUZYBXMHTM NVEFGKMZGUS(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DXXHIYYKVTS KLNGGMPTHCY(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AXFIFMXJTUJ XQWRTIKUZXH(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZQUUQMHTOQS SVCXPKFIHAK(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WHQTXEAAJQS BWLKMGOBTHQ(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ODZRFYNOYNH QTDLXSDWYZD(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		TCFIYAUXASI ABTQYHZRYJO(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		OMONHQWBMFE TXMAWOOJJDI(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEZCLOGKHDC IIDPVACBWPK(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		HDOROFHFPEP BDRIQDECMUX(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		MKDKYSBQPOD SFALUUHPRJR(SBFKUYKXOTE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		BKQQWDAGMDH SRKEVLVBZSZ(SBFKUYKXOTE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		KQMGGETYEZZ EWQSMHWIJHV(SBFKUYKXOTE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		TJUYGPXZTHD URNFDULAMXL(SBFKUYKXOTE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		AJUMGAOWDER YIEQPEEWRVT(SBFKUYKXOTE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a, RigidbodyExData b, GSVAPJWYCOH c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OMONHQWBMFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZVFSSNHUDYF(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XFIDADOUTRJ(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GZHEZOZSEHK(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DDZKMZOZRQU(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface HDOROFHFPEP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool TEKGJXGRBIA
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
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NTVMBNLLZDN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CVUZYBXMHTM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<SBFKUYKXOTE> BILLPEGHHEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		SBFKUYKXOTE RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		SBFKUYKXOTE XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction TNPRMYSCECX;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction XQTZDQNGHNX;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction QQNSTPQEDQB;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action WDMHAUVPBNC;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action BVGAPJJGIEZ;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<SBFKUYKXOTE> OFADTXOPTMI;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<SBFKUYKXOTE> NYKLBAVEBHB;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action SXKPUBPVBPW;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<SBFKUYKXOTE> DBVCDNUDSBP;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(SBFKUYKXOTE newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface AXFIFMXJTUJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 CCIDXQRNTFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 IGXZRQQWJNW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void REXQEOPPJJU(SBFKUYKXOTE a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XAKGFEUQNMX(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface TJUYGPXZTHD
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 JIIPHRANMIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 YMYTIHZGYVX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float TJQXSTXBJVF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float YVBPEQFEPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 QWBYTTHZVEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion ZNTPIAEEGBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction WZHNQNQLRDD;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ZXJKNLOIQQQ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void NEQOPSFYECL();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WDFFSGRMAJC();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void VGPRRJNNNVU();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void NTVMBNLLZDN(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface KQMGGETYEZZ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BVIINMZGKCQ(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CIWGZVQVGEP(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PWDQQWHOJVR(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YWBYPPBDTLE(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GKLLTFJKUSD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface TCFIYAUXASI
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool VLREQXCCSJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction RLCZRBKNELK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IMZQQOSHZHF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BTSEEDQYMBK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AAZDWLMKXLM(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NTVMBNLLZDN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BKQQWDAGMDH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool IUVDVSDYVBP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool QYGWXXOFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction UTAICBRQZVI;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SOQVEYPXTEV(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OCECCUNJOSV(SBFKUYKXOTE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AJUMGAOWDER
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool OZDQEMGQWDI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool TBUQCUOZPBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints JVDFPCLJVWN
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
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NTVMBNLLZDN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZQUUQMHTOQS
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float EZMDXYCCTSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float KBOXTUQWLSB
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
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NTVMBNLLZDN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface WHQTXEAAJQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool HVPTSHEVXIK;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction DWBOVZSNLFQ;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GAPDMUUMGHM();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ASNRCJDRQPG();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MECYKXXGXLQ();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ZFMDSHCSFDV();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OBANBVYOMDT(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WXYJKONTZRE();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface MKDKYSBQPOD
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool HYSJFNZZSYG
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
		void VRMOTGIJWBO(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XYGNGKFDLZJ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JXBPAOWOYKW();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface DXXHIYYKVTS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		DLILUNFEYEI JJNYIFZBXGV
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		BCEQBJSIDBZ LCMFGRQEXGM
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 FTDYHBAWEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 JUQSMCBUUCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 ZEYELOLDCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 TGNQTKUYUAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float RYOEOXBFDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool KHAOJJQZJCK
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
		void DWODYCDLSCE(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DARJYPVIODY(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void QXPUOUFNLNB(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void EKNHECQOFAJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ZHJNELGSLXL();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void WFOWDQTPUDY();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void FLVRCGMYOWX();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BWYHNJYKEZJ();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void QTZHCJYBEFU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 GTOVAWTMCHC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void IEMYPXYCONV(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void YADDEWADTPN(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void LXBMGBSEAAG(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void GJZNRXPFTOX(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 FWBJDEFBMHQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 WOMNNCKLBXO(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DRCFUMLGMOY
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool HTPWQZQUTFN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AXOYXJRRJLL(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HRLBEEDKKRC(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LFANGZQGQMU BUEXHTUXQQL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IBMSRLLOOHD(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GSVAPJWYCOH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		DRCFUMLGMOY UODYJOGPAPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		XATVNQELWGT QLMXAVAPVPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EBPEYFQNYPP : SBFKUYKXOTE, IDisposable, QFUOJSLJRMZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly GSVAPJWYCOH OSORFJKYMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal CVUZYBXMHTM DUTRZIKOGKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal KQMGGETYEZZ XWLUQMHDTBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal BKQQWDAGMDH ZLIOPUPXJWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal DXXHIYYKVTS DSLBTFYVPCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal AXFIFMXJTUJ KMUWAVXQMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal TJUYGPXZTHD LESJZTMDFCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal ZQUUQMHTOQS JEQUHCUBDRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal HDOROFHFPEP BDKMHAEDKWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal WHQTXEAAJQS KIIGMAENHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal ODZRFYNOYNH WWXQQASJWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal TCFIYAUXASI JGOXLRUPGEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal OMONHQWBMFE HOCTLSBEENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal AJUMGAOWDER FESQSFJACVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal MKDKYSBQPOD TWPYOZVBIQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal IEZCLOGKHDC NHHMQEJUOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable GFIJCVPMTNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool KHFPURCUCNB;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId CJVUHLHKDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public JWEPENHIPYI FDKNKSEOTJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBDB170", Offset = "0xBD9F70", VA = "0x180BDB170", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBDB100", Offset = "0xBD9F00", VA = "0x180BDB100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject LMMQGIQXTVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB8E0", VA = "0x180AACAE0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAACD70", Offset = "0xAABB70", VA = "0x180AACD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform VAENDOSSKUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xBDB180", Offset = "0xBD9F80", VA = "0x180BDB180", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBDB4E0", Offset = "0xBDA2E0", VA = "0x180BDB4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8C424D0", Offset = "0x8C412D0", VA = "0x188C424D0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public SBFKUYKXOTE XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8C40290", Offset = "0x8C3F090", VA = "0x188C40290", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8C41570", Offset = "0x8C40370", VA = "0x188C41570", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int WLHZPNODKWK
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8C44B80", Offset = "0x8C43980", VA = "0x188C44B80", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public SBFKUYKXOTE RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8C44A20", Offset = "0x8C43820", VA = "0x188C44A20", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool TFFYILZFRYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8C41C00", Offset = "0x8C40A00", VA = "0x188C41C00", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool IUVDVSDYVBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8C44300", Offset = "0x8C43100", VA = "0x188C44300", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool QYGWXXOFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FDC0", Offset = "0x8C3EBC0", VA = "0x188C3FDC0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public DLILUNFEYEI JJNYIFZBXGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8C44180", Offset = "0x8C42F80", VA = "0x188C44180", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F7C0", Offset = "0x8C3E5C0", VA = "0x188C3F7C0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BCEQBJSIDBZ LCMFGRQEXGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8C42950", Offset = "0x8C41750", VA = "0x188C42950", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FD60", Offset = "0x8C3EB60", VA = "0x188C3FD60", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float RYOEOXBFDEA
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E9B0", Offset = "0x8C3D7B0", VA = "0x188C3E9B0", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8C44120", Offset = "0x8C42F20", VA = "0x188C44120", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 JUQSMCBUUCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8C429A0", Offset = "0x8C417A0", VA = "0x188C429A0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8C43910", Offset = "0x8C42710", VA = "0x188C43910", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 TGNQTKUYUAX
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8C430F0", Offset = "0x8C41EF0", VA = "0x188C430F0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EE00", Offset = "0x8C3DC00", VA = "0x188C3EE00", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 FTDYHBAWEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8C415D0", Offset = "0x8C403D0", VA = "0x188C415D0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8C43B00", Offset = "0x8C42900", VA = "0x188C43B00", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 ZEYELOLDCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EA40", Offset = "0x8C3D840", VA = "0x188C3EA40", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8C40FB0", Offset = "0x8C3FDB0", VA = "0x188C40FB0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool DFFNGCABOSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FE10", Offset = "0x8C3EC10", VA = "0x188C3FE10", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool SWZTKDOVQUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8C43810", Offset = "0x8C42610", VA = "0x188C43810", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool USIPJPVZJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8C43F90", Offset = "0x8C42D90", VA = "0x188C43F90", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool KHAOJJQZJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8C42440", Offset = "0x8C41240", VA = "0x188C42440", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 CCIDXQRNTFS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C402E0", Offset = "0x8C3F0E0", VA = "0x188C402E0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 IGXZRQQWJNW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8C44220", Offset = "0x8C43020", VA = "0x188C44220", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 JIIPHRANMIW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8C411A0", Offset = "0x8C3FFA0", VA = "0x188C411A0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8C401B0", Offset = "0x8C3EFB0", VA = "0x188C401B0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 YMYTIHZGYVX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8C41990", Offset = "0x8C40790", VA = "0x188C41990", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float TJQXSTXBJVF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C425E0", Offset = "0x8C413E0", VA = "0x188C425E0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float YVBPEQFEPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C43D40", Offset = "0x8C42B40", VA = "0x188C43D40", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8C42AD0", Offset = "0x8C418D0", VA = "0x188C42AD0", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 QWBYTTHZVEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8C43500", Offset = "0x8C42300", VA = "0x188C43500", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion ZNTPIAEEGBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8C426C0", Offset = "0x8C414C0", VA = "0x188C426C0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float EZMDXYCCTSN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8C41150", Offset = "0x8C3FF50", VA = "0x188C41150", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8C41BA0", Offset = "0x8C409A0", VA = "0x188C41BA0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float KBOXTUQWLSB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EEE0", Offset = "0x8C3DCE0", VA = "0x188C3EEE0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8C42FE0", Offset = "0x8C41DE0", VA = "0x188C42FE0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool TEKGJXGRBIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8C44CD0", Offset = "0x8C43AD0", VA = "0x188C44CD0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C44070", Offset = "0x8C42E70", VA = "0x188C44070", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate ILQFYIZQUEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F8B0", Offset = "0x8C3E6B0", VA = "0x188C3F8B0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EB20", Offset = "0x8C3D920", VA = "0x188C3EB20", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool VLREQXCCSJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8C44D20", Offset = "0x8C43B20", VA = "0x188C44D20", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform YPDFLVIMCRY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xBDB180", Offset = "0xBD9F80", VA = "0x180BDB180", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 KDJZPHKQDKS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C43A50", Offset = "0x8C42850", VA = "0x188C43A50", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C44760", Offset = "0x8C43560", VA = "0x188C44760", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float TUAYXWDEUGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8C44A10", Offset = "0x8C43810", VA = "0x188C44A10", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8C42630", Offset = "0x8C41430", VA = "0x188C42630", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float ADAVJFGTHJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8C43750", Offset = "0x8C42550", VA = "0x188C43750", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FC60", Offset = "0x8C3EA60", VA = "0x188C3FC60", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion MMDZNSDBWCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FF60", Offset = "0x8C3ED60", VA = "0x188C3FF60", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8C3ED20", Offset = "0x8C3DB20", VA = "0x188C3ED20", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 NRXBGDQQKDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C421C0", Offset = "0x8C40FC0", VA = "0x188C421C0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EA00", Offset = "0x8C3D800", VA = "0x188C3EA00", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion BIIZEZOVXPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8C42490", Offset = "0x8C41290", VA = "0x188C42490", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C43D90", Offset = "0x8C42B90", VA = "0x188C43D90", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints JVDFPCLJVWN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8C43BE0", Offset = "0x8C429E0", VA = "0x188C43BE0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C41800", Offset = "0x8C40600", VA = "0x188C41800", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool OZDQEMGQWDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8C40F60", Offset = "0x8C3FD60", VA = "0x188C40F60", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8C41090", Offset = "0x8C3FE90", VA = "0x188C41090", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode KCGMTZAPAVB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8C43760", Offset = "0x8C42560", VA = "0x188C43760", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8C40DF0", Offset = "0x8C3FBF0", VA = "0x188C40DF0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool NMJATMWBNLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F300", Offset = "0x8C3E100", VA = "0x188C3F300", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool BVRNSEADNNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8C432B0", Offset = "0x8C420B0", VA = "0x188C432B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction TNPRMYSCECX
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8C42520", Offset = "0x8C41320", VA = "0x188C42520", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8C410F0", Offset = "0x8C3FEF0", VA = "0x188C410F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction XQTZDQNGHNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F0E0", Offset = "0x8C3DEE0", VA = "0x188C3F0E0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8C44580", Offset = "0x8C43380", VA = "0x188C44580", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction QQNSTPQEDQB
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E880", Offset = "0x8C3D680", VA = "0x188C3E880", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8C437B0", Offset = "0x8C425B0", VA = "0x188C437B0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction UTAICBRQZVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8C41860", Offset = "0x8C40660", VA = "0x188C41860", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8C439F0", Offset = "0x8C427F0", VA = "0x188C439F0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction KOQQDXDOAIX
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8C44950", Offset = "0x8C43750", VA = "0x188C44950", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C449B0", Offset = "0x8C437B0", VA = "0x188C449B0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction DWBOVZSNLFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8C43870", Offset = "0x8C42670", VA = "0x188C43870", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8C42280", Offset = "0x8C41080", VA = "0x188C42280", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> PJATTIJUMTX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8C417A0", Offset = "0x8C405A0", VA = "0x188C417A0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C43C80", Offset = "0x8C42A80", VA = "0x188C43C80", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction RLCZRBKNELK
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8C43DC0", Offset = "0x8C42BC0", VA = "0x188C43DC0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E950", Offset = "0x8C3D750", VA = "0x188C3E950", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction IRTQMCXDPSB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C436A0", Offset = "0x8C424A0", VA = "0x188C436A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C40EB0", Offset = "0x8C3FCB0", VA = "0x188C40EB0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8C44E50", Offset = "0x8C43C50", VA = "0x188C44E50")]
		public EBPEYFQNYPP(GameObject a, RigidbodyEx b, GSVAPJWYCOH c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8C41280", Offset = "0x8C40080", VA = "0x188C41280", Slot = "139")]
		protected virtual void LBFIJKUDFAH(GSVAPJWYCOH a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FE60", Offset = "0x8C3EC60", VA = "0x188C3FE60", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EB80", Offset = "0x8C3D980", VA = "0x188C3EB80", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8C423B0", Offset = "0x8C411B0", VA = "0x188C423B0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8C42300", Offset = "0x8C41100", VA = "0x188C42300", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8C422E0", Offset = "0x8C410E0", VA = "0x188C422E0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8C41E60", Offset = "0x8C40C60", VA = "0x188C41E60")]
		private void OBANBVYOMDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8C41910", Offset = "0x8C40710", VA = "0x188C41910")]
		private void NITFPKYKBUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8C44A70", Offset = "0x8C43870", VA = "0x188C44A70")]
		private void ZFMDSHCSFDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8C42200", Offset = "0x8C41000", VA = "0x188C42200", Slot = "30")]
		public SBFKUYKXOTE OOZHOLMUDFL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C435E0", Offset = "0x8C423E0", VA = "0x188C435E0", Slot = "98")]
		public void SetParent(SBFKUYKXOTE value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F760", Offset = "0x8C3E560", VA = "0x188C3F760", Slot = "99")]
		public void CMYQJSPGNYC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8C42580", Offset = "0x8C41380", VA = "0x188C42580", Slot = "100")]
		public void PQJEKXMADFT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8C44350", Offset = "0x8C43150", VA = "0x188C44350", Slot = "101")]
		public Vector3 WOMNNCKLBXO(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8C40850", Offset = "0x8C3F650", VA = "0x188C40850", Slot = "102")]
		public Vector3 FWBJDEFBMHQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F1A0", Offset = "0x8C3DFA0", VA = "0x188C3F1A0", Slot = "103")]
		public void BWYHNJYKEZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8C441D0", Offset = "0x8C42FD0", VA = "0x188C441D0", Slot = "104")]
		public void WFOWDQTPUDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8C44AD0", Offset = "0x8C438D0", VA = "0x188C44AD0", Slot = "105")]
		public void ZHJNELGSLXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C40AC0", Offset = "0x8C3F8C0", VA = "0x188C40AC0", Slot = "106")]
		public void GJZNRXPFTOX(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C416B0", Offset = "0x8C404B0", VA = "0x188C416B0", Slot = "107")]
		public void LXBMGBSEAAG(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C44870", Offset = "0x8C43670", VA = "0x188C44870", Slot = "108")]
		public void YADDEWADTPN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C42B30", Offset = "0x8C41930", VA = "0x188C42B30", Slot = "109")]
		public void QXPUOUFNLNB(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FAE0", Offset = "0x8C3E8E0", VA = "0x188C3FAE0", Slot = "110")]
		public void DARJYPVIODY(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C40100", Offset = "0x8C3EF00", VA = "0x188C40100", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void EKNHECQOFAJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C40BB0", Offset = "0x8C3F9B0", VA = "0x188C40BB0", Slot = "112")]
		public Vector3 GTOVAWTMCHC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C40000", Offset = "0x8C3EE00", VA = "0x188C40000", Slot = "113")]
		public Vector3 EHWILHKDVFO(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C403B0", Offset = "0x8C3F1B0", VA = "0x188C403B0", Slot = "114")]
		public void FLVRCGMYOWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C428E0", Offset = "0x8C416E0", VA = "0x188C428E0", Slot = "115")]
		public void QIPTAWKBRIH(SBFKUYKXOTE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C44B20", Offset = "0x8C43920", VA = "0x188C44B20", Slot = "116")]
		public void ZRBHVQYZUJS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C44D70", Offset = "0x8C43B70", VA = "0x188C44D70", Slot = "63")]
		public void ZXJKNLOIQQQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C440D0", Offset = "0x8C42ED0", VA = "0x188C440D0", Slot = "117")]
		public void WDFFSGRMAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C418C0", Offset = "0x8C406C0", VA = "0x188C418C0", Slot = "118")]
		public void NEQOPSFYECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C43C30", Offset = "0x8C42A30", VA = "0x188C43C30", Slot = "119")]
		public void VGPRRJNNNVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C40950", Offset = "0x8C3F750", VA = "0x188C40950", Slot = "120")]
		public bool GAPDMUUMGHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C43650", Offset = "0x8C42450", VA = "0x188C43650", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C445E0", Offset = "0x8C433E0", VA = "0x188C445E0", Slot = "121")]
		public void WXYJKONTZRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C40E50", Offset = "0x8C3FC50", VA = "0x188C40E50", Slot = "122")]
		public void IMZQQOSHZHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F140", Offset = "0x8C3DF40", VA = "0x188C3F140", Slot = "123")]
		public void BTSEEDQYMBK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E8E0", Offset = "0x8C3D6E0", VA = "0x188C3E8E0", Slot = "124")]
		public void AAZDWLMKXLM(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C41C60", Offset = "0x8C40A60", VA = "0x188C41C60", Slot = "125")]
		public void NYKXQJGWQHA(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C41A70", Offset = "0x8C40870", VA = "0x188C41A70", Slot = "126")]
		public void NMLGXVTDWKS(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C42A80", Offset = "0x8C41880", VA = "0x188C42A80", Slot = "127")]
		public bool QRPEVYNLHDD(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3ECC0", Offset = "0x8C3DAC0", VA = "0x188C3ECC0", Slot = "128")]
		public void BASGTQTZLUK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C40D90", Offset = "0x8C3FB90", VA = "0x188C40D90", Slot = "129")]
		public void HARHARKATSH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C43CE0", Offset = "0x8C42AE0", VA = "0x188C43CE0", Slot = "130")]
		public void VRMOTGIJWBO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C44810", Offset = "0x8C43610", VA = "0x188C44810", Slot = "131")]
		public void XYGNGKFDLZJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C44BF0", Offset = "0x8C439F0", VA = "0x188C44BF0", Slot = "132")]
		public void ZVFSSNHUDYF(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C44650", Offset = "0x8C43450", VA = "0x188C44650", Slot = "133")]
		public void XFIDADOUTRJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C40CB0", Offset = "0x8C3FAB0", VA = "0x188C40CB0", Slot = "134")]
		public void GZHEZOZSEHK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FB80", Offset = "0x8C3E980", VA = "0x188C3FB80", Slot = "135")]
		public void DDZKMZOZRQU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C42F40", Offset = "0x8C41D40", VA = "0x188C42F40", Slot = "136")]
		public bool QZEBEEUHMAZ(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C42360", Offset = "0x8C41160", VA = "0x188C42360", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C438D0", Offset = "0x8C426D0", VA = "0x188C438D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C431D0", Offset = "0x8C41FD0", VA = "0x188C431D0")]
		private void SAROTYDBBAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F1F0", Offset = "0x8C3DFF0", VA = "0x188C3F1F0")]
		private void BXBTRABTZCN(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F900", Offset = "0x8C3E700", VA = "0x188C3F900")]
		private void CWBUBKQIKEW(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C43040", Offset = "0x8C41E40", VA = "0x188C43040")]
		private void RNXLOMEVTGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C44450", Offset = "0x8C43250", VA = "0x188C44450")]
		private void WUTQPHVNLDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EF30", Offset = "0x8C3DD30", VA = "0x188C3EF30")]
		private void BNZBDUVNJZE(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C43430", Offset = "0x8C42230", VA = "0x188C43430")]
		private void SOQVEYPXTEV(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C420F0", Offset = "0x8C40EF0", VA = "0x188C420F0")]
		private void OCECCUNJOSV(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C42790", Offset = "0x8C41590", VA = "0x188C42790")]
		private void QDFEZIXYJYY(JWEPENHIPYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C40400", Offset = "0x8C3F200", VA = "0x188C40400", Slot = "142")]
		protected virtual void FMBAMRAIKEZ(JWEPENHIPYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F440", Offset = "0x8C3E240", VA = "0x188C3F440")]
		protected void CEBZPOTPJVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8C42BF0", Offset = "0x8C419F0", VA = "0x188C42BF0")]
		protected void QXVYHJCKNQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8C409A0", Offset = "0x8C3F7A0", VA = "0x188C409A0")]
		private void GDKPIMULYQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8C43E20", Offset = "0x8C42C20", VA = "0x188C43E20")]
		private void VZLTTMPQVNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class AQCHZZKKNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E550", Offset = "0x8C3D350", VA = "0x188C3E550")]
		public static SBFKUYKXOTE HBPFNGXMXOY(this SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E610", Offset = "0x8C3D410", VA = "0x188C3E610")]
		public static bool SHRCQMMKEUP(this SBFKUYKXOTE a, SBFKUYKXOTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E6B0", Offset = "0x8C3D4B0", VA = "0x188C3E6B0")]
		public static bool TKZSXTCXKGV(this SBFKUYKXOTE a, SBFKUYKXOTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E500", Offset = "0x8C3D300", VA = "0x188C3E500")]
		public static JWEPENHIPYI CKTABYFEQIR(this SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E480", Offset = "0x8C3D280", VA = "0x188C3E480")]
		public static EBPEYFQNYPP Base(this SBFKUYKXOTE impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class WUAXYMRIKDO : XATVNQELWGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8C59000", Offset = "0x8C57E00", VA = "0x188C59000", Slot = "19")]
		public SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a, RigidbodyExData b, GSVAPJWYCOH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
		public CVUZYBXMHTM NVEFGKMZGUS(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "5")]
		public DXXHIYYKVTS KLNGGMPTHCY(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "6")]
		public AXFIFMXJTUJ XQWRTIKUZXH(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "7")]
		public ZQUUQMHTOQS SVCXPKFIHAK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "8")]
		public WHQTXEAAJQS BWLKMGOBTHQ(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "9")]
		public ODZRFYNOYNH QTDLXSDWYZD(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "10")]
		public TCFIYAUXASI ABTQYHZRYJO(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "11")]
		public OMONHQWBMFE TXMAWOOJJDI(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "12")]
		public IEZCLOGKHDC IIDPVACBWPK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "13")]
		public HDOROFHFPEP BDRIQDECMUX(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
		public MKDKYSBQPOD SFALUUHPRJR(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
		public BKQQWDAGMDH SRKEVLVBZSZ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
		public KQMGGETYEZZ EWQSMHWIJHV(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
		public TJUYGPXZTHD URNFDULAMXL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
		public AJUMGAOWDER YIEQPEEWRVT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WUAXYMRIKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "14")]
		private MKDKYSBQPOD IKKKFDJIXLJ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "15")]
		private BKQQWDAGMDH IEPHJPUXHPT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "16")]
		private KQMGGETYEZZ TGAVHRPKEIL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "17")]
		private TJUYGPXZTHD EJMAOYUJELP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "18")]
		private AJUMGAOWDER BMTMKXJBKTP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(XATVNQELWGT), new string[] { })]
	public class HBAXFBARFDH : XATVNQELWGT, LYBXKQOLIUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly XATVNQELWGT VUBGSZMTPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly XATVNQELWGT YSEXGZWRUTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BXADVNGMIDN AHFRFINQFLQ;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private XATVNQELWGT QLMXAVAPVPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8C469E0", Offset = "0x8C457E0", VA = "0x188C469E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8C47070", Offset = "0x8C45E70", VA = "0x188C47070", Slot = "20")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8C47160", Offset = "0x8C45F60", VA = "0x188C47160", Slot = "4")]
		public CVUZYBXMHTM NVEFGKMZGUS(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8C470C0", Offset = "0x8C45EC0", VA = "0x188C470C0", Slot = "5")]
		public DXXHIYYKVTS KLNGGMPTHCY(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C473E0", Offset = "0x8C461E0", VA = "0x188C473E0", Slot = "6")]
		public AXFIFMXJTUJ XQWRTIKUZXH(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8C472A0", Offset = "0x8C460A0", VA = "0x188C472A0", Slot = "7")]
		public ZQUUQMHTOQS SVCXPKFIHAK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8C46B90", Offset = "0x8C45990", VA = "0x188C46B90", Slot = "8")]
		public WHQTXEAAJQS BWLKMGOBTHQ(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8C47200", Offset = "0x8C46000", VA = "0x188C47200", Slot = "9")]
		public ODZRFYNOYNH QTDLXSDWYZD(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8C46940", Offset = "0x8C45740", VA = "0x188C46940", Slot = "10")]
		public TCFIYAUXASI ABTQYHZRYJO(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8C47340", Offset = "0x8C46140", VA = "0x188C47340", Slot = "11")]
		public OMONHQWBMFE TXMAWOOJJDI(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8C46F20", Offset = "0x8C45D20", VA = "0x188C46F20", Slot = "12")]
		public IEZCLOGKHDC IIDPVACBWPK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8C46A40", Offset = "0x8C45840", VA = "0x188C46A40", Slot = "13")]
		public HDOROFHFPEP BDRIQDECMUX(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8C46FC0", Offset = "0x8C45DC0", VA = "0x188C46FC0")]
		public MKDKYSBQPOD SFALUUHPRJR(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C46E70", Offset = "0x8C45C70", VA = "0x188C46E70")]
		public BKQQWDAGMDH SRKEVLVBZSZ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8C46DC0", Offset = "0x8C45BC0", VA = "0x188C46DC0")]
		public KQMGGETYEZZ EWQSMHWIJHV(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8C46D10", Offset = "0x8C45B10", VA = "0x188C46D10")]
		public TJUYGPXZTHD URNFDULAMXL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8C46AE0", Offset = "0x8C458E0", VA = "0x188C46AE0")]
		public AJUMGAOWDER YIEQPEEWRVT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8C46C30", Offset = "0x8C45A30", VA = "0x188C46C30", Slot = "19")]
		public SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a, RigidbodyExData b, GSVAPJWYCOH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C47480", Offset = "0x8C46280", VA = "0x188C47480")]
		public HBAXFBARFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8C46FC0", Offset = "0x8C45DC0", VA = "0x188C46FC0", Slot = "14")]
		private MKDKYSBQPOD IKKKFDJIXLJ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8C46E70", Offset = "0x8C45C70", VA = "0x188C46E70", Slot = "15")]
		private BKQQWDAGMDH IEPHJPUXHPT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8C46DC0", Offset = "0x8C45BC0", VA = "0x188C46DC0", Slot = "16")]
		private KQMGGETYEZZ TGAVHRPKEIL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8C46D10", Offset = "0x8C45B10", VA = "0x188C46D10", Slot = "17")]
		private TJUYGPXZTHD EJMAOYUJELP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8C46AE0", Offset = "0x8C458E0", VA = "0x188C46AE0", Slot = "18")]
		private AJUMGAOWDER BMTMKXJBKTP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface PJVKENQBKTZ : CVUZYBXMHTM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BPHNXWVYNEE(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WDIMCTWMQFJ(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MDKZKYNLDGW(SBFKUYKXOTE a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PJOALKHXTSL(SBFKUYKXOTE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface CWSLSTCPBNC : AXFIFMXJTUJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		VCIHOBGXGZO<SBFKUYKXOTE> SWTVCCUUYWT
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		SBFKUYKXOTE HHYNBWFBILB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface WGADFCEAPXY : TJUYGPXZTHD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) DMXWTWQPWXF(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface SKBMETSBTAM : BKQQWDAGMDH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView AWTSSFQUFQU
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class HWUNAEAGXUJ : IEZCLOGKHDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode QXESBIPPAPZ;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8C45AC0", Offset = "0x8C448C0", VA = "0x188C45AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode KCGMTZAPAVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8C48650", Offset = "0x8C47450", VA = "0x188C48650", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8C482E0", Offset = "0x8C470E0", VA = "0x188C482E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8C45F40", Offset = "0x8C44D40", VA = "0x188C45F40")]
		public HWUNAEAGXUJ(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8C481B0", Offset = "0x8C46FB0", VA = "0x188C481B0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8C48470", Offset = "0x8C47270", VA = "0x188C48470", Slot = "9")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8C482D0", Offset = "0x8C470D0", VA = "0x188C482D0", Slot = "7")]
		public void FENSGLQBXNX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8C482C0", Offset = "0x8C470C0", VA = "0x188C482C0", Slot = "8")]
		public void EBCRRWPTMMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8C484F0", Offset = "0x8C472F0", VA = "0x188C484F0", Slot = "10")]
		public bool QZEBEEUHMAZ(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8C48350", Offset = "0x8C47150", VA = "0x188C48350")]
		private void KBZLISBXIVB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HZVQUACYYOS : ODZRFYNOYNH, IDisposable, MKHYVHNKDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate EYDOTFEUFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private LFANGZQGQMU PUPXODMJWUU;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate ILQFYIZQUEM
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8C48AA0", Offset = "0x8C478A0", VA = "0x188C48AA0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8C48760", Offset = "0x8C47560", VA = "0x188C48760", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform RJINUEODGYD
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8C48C40", Offset = "0x8C47A40", VA = "0x188C48C40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> PJATTIJUMTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8C48C60", Offset = "0x8C47A60", VA = "0x188C48C60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8C48D10", Offset = "0x8C47B10", VA = "0x188C48D10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8C48DC0", Offset = "0x8C47BC0", VA = "0x188C48DC0")]
		public HZVQUACYYOS(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8C48830", Offset = "0x8C47630", VA = "0x188C48830", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8C48BF0", Offset = "0x8C479F0", VA = "0x188C48BF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13FA2D0", Offset = "0x13F90D0", VA = "0x1813FA2D0", Slot = "11")]
		private void RLVRTTQXNXG(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "12")]
		private void GQZJCUVCSXS(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class WUAXYMRIKDO : XATVNQELWGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8C59900", Offset = "0x8C58700", VA = "0x188C59900", Slot = "4")]
		public CVUZYBXMHTM NVEFGKMZGUS(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8C597F0", Offset = "0x8C585F0", VA = "0x188C597F0", Slot = "5")]
		public DXXHIYYKVTS KLNGGMPTHCY(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8C59BD0", Offset = "0x8C589D0", VA = "0x188C59BD0", Slot = "6")]
		public AXFIFMXJTUJ XQWRTIKUZXH(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8C59AA0", Offset = "0x8C588A0", VA = "0x188C59AA0", Slot = "7")]
		public ZQUUQMHTOQS SVCXPKFIHAK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8C58F40", Offset = "0x8C57D40", VA = "0x188C58F40", Slot = "8")]
		public WHQTXEAAJQS BWLKMGOBTHQ(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8C599E0", Offset = "0x8C587E0", VA = "0x188C599E0", Slot = "9")]
		public ODZRFYNOYNH QTDLXSDWYZD(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8C58CA0", Offset = "0x8C57AA0", VA = "0x188C58CA0", Slot = "10")]
		public TCFIYAUXASI ABTQYHZRYJO(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8C59B10", Offset = "0x8C58910", VA = "0x188C59B10", Slot = "11")]
		public OMONHQWBMFE TXMAWOOJJDI(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8C59600", Offset = "0x8C58400", VA = "0x188C59600", Slot = "12")]
		public IEZCLOGKHDC IIDPVACBWPK(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8C58DB0", Offset = "0x8C57BB0", VA = "0x188C58DB0", Slot = "13")]
		public HDOROFHFPEP BDRIQDECMUX(SBFKUYKXOTE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8C596C0", Offset = "0x8C584C0", VA = "0x188C596C0")]
		public MKDKYSBQPOD SFALUUHPRJR(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8C59480", Offset = "0x8C58280", VA = "0x188C59480")]
		public BKQQWDAGMDH SRKEVLVBZSZ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8C59360", Offset = "0x8C58160", VA = "0x188C59360")]
		public KQMGGETYEZZ EWQSMHWIJHV(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8C591D0", Offset = "0x8C57FD0", VA = "0x188C591D0")]
		public TJUYGPXZTHD URNFDULAMXL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8C58E70", Offset = "0x8C57C70", VA = "0x188C58E70")]
		public AJUMGAOWDER YIEQPEEWRVT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8C59090", Offset = "0x8C57E90", VA = "0x188C59090", Slot = "19")]
		public SBFKUYKXOTE DYFHDYKARQF(RigidbodyEx a, RigidbodyExData b, GSVAPJWYCOH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WUAXYMRIKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8C596C0", Offset = "0x8C584C0", VA = "0x188C596C0", Slot = "14")]
		private MKDKYSBQPOD IKKKFDJIXLJ(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8C59480", Offset = "0x8C58280", VA = "0x188C59480", Slot = "15")]
		private BKQQWDAGMDH IEPHJPUXHPT(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8C59360", Offset = "0x8C58160", VA = "0x188C59360", Slot = "16")]
		private KQMGGETYEZZ TGAVHRPKEIL(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8C591D0", Offset = "0x8C57FD0", VA = "0x188C591D0", Slot = "17")]
		private TJUYGPXZTHD EJMAOYUJELP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8C58E70", Offset = "0x8C57C70", VA = "0x188C58E70", Slot = "18")]
		private AJUMGAOWDER BMTMKXJBKTP(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class ESHBSJGKNYV : OMONHQWBMFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8C45AC0", Offset = "0x8C448C0", VA = "0x188C45AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool VLREQXCCSJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8C45EF0", Offset = "0x8C44CF0", VA = "0x188C45EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool TFFYILZFRYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8C45A60", Offset = "0x8C44860", VA = "0x188C45A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private SBFKUYKXOTE XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8C453E0", Offset = "0x8C441E0", VA = "0x188C453E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8C45F40", Offset = "0x8C44D40", VA = "0x188C45F40")]
		public ESHBSJGKNYV(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8C45D90", Offset = "0x8C44B90", VA = "0x188C45D90", Slot = "4")]
		public void ZVFSSNHUDYF(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8C45800", Offset = "0x8C44600", VA = "0x188C45800")]
		private void MATMOZOVGVC(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8C45B10", Offset = "0x8C44910", VA = "0x188C45B10", Slot = "5")]
		public void XFIDADOUTRJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8C45440", Offset = "0x8C44240", VA = "0x188C45440", Slot = "6")]
		public void GZHEZOZSEHK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8C455A0", Offset = "0x8C443A0", VA = "0x188C455A0")]
		private void LLFJVMYOUWP(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8C45180", Offset = "0x8C43F80", VA = "0x188C45180", Slot = "7")]
		public void DDZKMZOZRQU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class SPGCWOHVMRG : HDOROFHFPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ETGMNYNLBWU;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool TEKGJXGRBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8C55F70", Offset = "0x8C54D70", VA = "0x188C55F70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8C45F40", Offset = "0x8C44D40", VA = "0x188C45F40")]
		public SPGCWOHVMRG(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8C55F40", Offset = "0x8C54D40", VA = "0x188C55F40", Slot = "6")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8C55ED0", Offset = "0x8C54CD0", VA = "0x188C55ED0", Slot = "7")]
		public void NTVMBNLLZDN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : PJVKENQBKTZ, CVUZYBXMHTM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly SBFKUYKXOTE NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<SBFKUYKXOTE> CTVTSFCKXEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private SBFKUYKXOTE DSTQIKJKEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private SBFKUYKXOTE TNQRTSDCHDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform UGREWHSCJHU;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform VAENDOSSKUR
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EEA0", Offset = "0x8C4DCA0", VA = "0x188C4EEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public SBFKUYKXOTE XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F080", Offset = "0x8C4DE80", VA = "0x188C4F080", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public SBFKUYKXOTE RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1970", Offset = "0xAA0770", VA = "0x180AA1970", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<SBFKUYKXOTE> BILLPEGHHEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAA1960", Offset = "0xAA0760", VA = "0x180AA1960", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction TNPRMYSCECX
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F830", Offset = "0x8C4E630", VA = "0x188C4F830", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EF00", Offset = "0x8C4DD00", VA = "0x188C4EF00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction XQTZDQNGHNX
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E9E0", Offset = "0x8C4D7E0", VA = "0x188C4E9E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8C505C0", Offset = "0x8C4F3C0", VA = "0x188C505C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction QQNSTPQEDQB
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E940", Offset = "0x8C4D740", VA = "0x188C4E940", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4FEE0", Offset = "0x8C4ECE0", VA = "0x188C4FEE0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action WDMHAUVPBNC
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4ECA0", Offset = "0x8C4DAA0", VA = "0x188C4ECA0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8C50660", Offset = "0x8C4F460", VA = "0x188C50660", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action BVGAPJJGIEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F8D0", Offset = "0x8C4E6D0", VA = "0x188C4F8D0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8C4ED40", Offset = "0x8C4DB40", VA = "0x188C4ED40", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<SBFKUYKXOTE> OFADTXOPTMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8C500B0", Offset = "0x8C4EEB0", VA = "0x188C500B0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8C50460", Offset = "0x8C4F260", VA = "0x188C50460", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<SBFKUYKXOTE> NYKLBAVEBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F090", Offset = "0x8C4DE90", VA = "0x188C4F090", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F500", Offset = "0x8C4E300", VA = "0x188C4F500", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action SXKPUBPVBPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EFA0", Offset = "0x8C4DDA0", VA = "0x188C4EFA0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F460", Offset = "0x8C4E260", VA = "0x188C4F460", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<SBFKUYKXOTE> DBVCDNUDSBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8C50510", Offset = "0x8C4F310", VA = "0x188C50510", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F3B0", Offset = "0x8C4E1B0", VA = "0x188C4F3B0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8C50700", Offset = "0x8C4F500", VA = "0x188C50700")]
		public RbexHierarchy(SBFKUYKXOTE rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EC00", Offset = "0x8C4DA00", VA = "0x188C4EC00", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F970", Offset = "0x8C4E770", VA = "0x188C4F970", Slot = "30")]
		public void SetParent(SBFKUYKXOTE newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F140", Offset = "0x8C4DF40", VA = "0x188C4F140", Slot = "6")]
		public void MDKZKYNLDGW(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F5B0", Offset = "0x8C4E3B0", VA = "0x188C4F5B0", Slot = "7")]
		public void PJOALKHXTSL(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EA80", Offset = "0x8C4D880", VA = "0x188C4EA80", Slot = "4")]
		public void BPHNXWVYNEE(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8C503C0", Offset = "0x8C4F1C0", VA = "0x188C503C0", Slot = "5")]
		public void WDIMCTWMQFJ(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EB60", Offset = "0x8C4D960", VA = "0x188C4EB60")]
		private void BTTJHXUBLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F040", Offset = "0x8C4DE40", VA = "0x188C4F040")]
		private void KVMXABFZCKR(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8C50160", Offset = "0x8C4EF60", VA = "0x188C50160")]
		private void VKQTTRGHDZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FF80", Offset = "0x8C4ED80", VA = "0x188C4FF80")]
		private void TUCYXYWXNYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8C502A0", Offset = "0x8C4F0A0", VA = "0x188C502A0")]
		private void VUPLRDRHBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EDE0", Offset = "0x8C4DBE0", VA = "0x188C4EDE0")]
		[CompilerGenerated]
		private object HBQFGPMADYP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class QRBKTHDSIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D4A0", Offset = "0x8C4C2A0", VA = "0x188C4D4A0")]
		public static PJVKENQBKTZ SIGATNSGOVY(this SBFKUYKXOTE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class HJVWROJVYJQ : CWSLSTCPBNC, AXFIFMXJTUJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly VCIHOBGXGZO<SBFKUYKXOTE> SNSNAAXMSIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool FPIMBOLQTWM;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public VCIHOBGXGZO<SBFKUYKXOTE> SWTVCCUUYWT
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 CCIDXQRNTFS
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8C47520", Offset = "0x8C46320", VA = "0x188C47520", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 IGXZRQQWJNW
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8C47EA0", Offset = "0x8C46CA0", VA = "0x188C47EA0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 FTDYHBAWEOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C478F0", Offset = "0x8C466F0", VA = "0x188C478F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public SBFKUYKXOTE HHYNBWFBILB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8C479E0", Offset = "0x8C467E0", VA = "0x188C479E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C480C0", Offset = "0x8C46EC0", VA = "0x188C480C0")]
		public HJVWROJVYJQ(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C47A90", Offset = "0x8C46890", VA = "0x188C47A90", Slot = "8")]
		public void REXQEOPPJJU(SBFKUYKXOTE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C48060", Offset = "0x8C46E60", VA = "0x188C48060", Slot = "9")]
		public void XAKGFEUQNMX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C47B00", Offset = "0x8C46900", VA = "0x188C47B00")]
		private Vector3 RQNQCRYWOVM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C47550", Offset = "0x8C46350", VA = "0x188C47550")]
		private void FXVRJKAYXAL(SBFKUYKXOTE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class IUPWPLWABQM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C48E50", Offset = "0x8C47C50", VA = "0x188C48E50")]
		public static CWSLSTCPBNC VMBBLCAMXGR(this SBFKUYKXOTE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class TVPPJUVQUDC : WGADFCEAPXY, TJUYGPXZTHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 GMBZVDEIQZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 GAVKOJZUPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float ZHDYDZHCJUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float FBXHNJDHQNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 TXEICCAWUGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? HFXZLENVOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? WHHTJGRBZAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool RBVCSXOVFRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool LKHEBKVFNJS;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 JIIPHRANMIW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C2E0", Offset = "0x1F9B0E0", VA = "0x181F9C2E0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8C56F00", Offset = "0x8C55D00", VA = "0x188C56F00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 YMYTIHZGYVX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8C577D0", Offset = "0x8C565D0", VA = "0x188C577D0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float TJQXSTXBJVF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAEE1B0", Offset = "0xAECFB0", VA = "0x180AEE1B0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C57380", Offset = "0x8C56180", VA = "0x188C57380")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float YVBPEQFEPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAEE1C0", Offset = "0xAECFC0", VA = "0x180AEE1C0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8C56FB0", Offset = "0x8C55DB0", VA = "0x188C56FB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 QWBYTTHZVEC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8C581F0", Offset = "0x8C56FF0", VA = "0x188C581F0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion ZNTPIAEEGBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C57F90", Offset = "0x8C56D90", VA = "0x188C57F90", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E4D0", Offset = "0x8C4D2D0", VA = "0x188C4E4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction WZHNQNQLRDD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8C57490", Offset = "0x8C56290", VA = "0x188C57490", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C57530", Offset = "0x8C56330", VA = "0x188C57530", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C58870", Offset = "0x8C57670", VA = "0x188C58870")]
		public TVPPJUVQUDC(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C58520", Offset = "0x8C57320", VA = "0x188C58520", Slot = "17")]
		public void WDFFSGRMAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C576F0", Offset = "0x8C564F0", VA = "0x188C576F0", Slot = "16")]
		public void NEQOPSFYECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C58110", Offset = "0x8C56F10", VA = "0x188C58110", Slot = "19")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C578F0", Offset = "0x8C566F0", VA = "0x188C578F0", Slot = "20")]
		public void NTVMBNLLZDN(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C58380", Offset = "0x8C57180", VA = "0x188C58380", Slot = "18")]
		public void VGPRRJNNNVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C57AD0", Offset = "0x8C568D0", VA = "0x188C57AD0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C56F00", Offset = "0x8C55D00", VA = "0x188C56F00")]
		private void MQKYMXDONAY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C575D0", Offset = "0x8C563D0", VA = "0x188C575D0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 KHWDIIJEMPJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C57380", Offset = "0x8C56180", VA = "0x188C57380")]
		private void IYONHIOQBSJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C56FB0", Offset = "0x8C55DB0", VA = "0x188C56FB0")]
		private void FGXKIQAJIEG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C57060", Offset = "0x8C55E60", VA = "0x188C57060")]
		private Vector3 GRNISJQHPJG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C58640", Offset = "0x8C57440", VA = "0x188C58640", Slot = "15")]
		public void ZXJKNLOIQQQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C57200", Offset = "0x8C56000", VA = "0x188C57200")]
		private Quaternion GVRURPQKVJU()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C56080", Offset = "0x8C54E80", VA = "0x188C56080")]
		public void DMXWTWQPWXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C56150", Offset = "0x8C54F50", VA = "0x188C56150", Slot = "4")]
		public (float, Vector3) DMXWTWQPWXF(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class LNZJHZKEGWW
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D110", Offset = "0x8C4BF10", VA = "0x188C4D110")]
		public static WGADFCEAPXY APVCRLIGAEB(this SBFKUYKXOTE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class QYVSFRPTAPC : KQMGGETYEZZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly NTWXEAAFYGD PEAQGHFWUSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode LEJEQNYKNMO;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool DFRCLEPHHUW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B4E160", Offset = "0x1B4CF60", VA = "0x181B4E160", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode EFYEADXIPJS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DB70", Offset = "0x8C4C970", VA = "0x188C4DB70")]
		public QYVSFRPTAPC(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D560", Offset = "0x8C4C360", VA = "0x188C4D560", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D690", Offset = "0x8C4C490", VA = "0x188C4D690")]
		private bool EKCKRUCKYMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D630", Offset = "0x8C4C430", VA = "0x188C4D630", Slot = "5")]
		public void BVIINMZGKCQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D660", Offset = "0x8C4C460", VA = "0x188C4D660", Slot = "6")]
		public void CIWGZVQVGEP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D730", Offset = "0x8C4C530", VA = "0x188C4D730", Slot = "9")]
		public void GKLLTFJKUSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D8A0", Offset = "0x8C4C6A0", VA = "0x188C4D8A0")]
		private void TNVVKJJCXUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D9B0", Offset = "0x8C4C7B0", VA = "0x188C4D9B0")]
		private void WKGLGMEKCSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DB30", Offset = "0x8C4C930", VA = "0x188C4DB30", Slot = "8")]
		public void YWBYPPBDTLE(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D860", Offset = "0x8C4C660", VA = "0x188C4D860", Slot = "7")]
		public void PWDQQWHOJVR(SBFKUYKXOTE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class YDXMDZTBQQX : TCFIYAUXASI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly NTWXEAAFYGD BDPEBJPMMPI;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool VLREQXCCSJS
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A050", Offset = "0x8C58E50", VA = "0x188C5A050", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction RLCZRBKNELK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C59FB0", Offset = "0x8C58DB0", VA = "0x188C59FB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8C59E00", Offset = "0x8C58C00", VA = "0x188C59E00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A100", Offset = "0x8C58F00", VA = "0x188C5A100")]
		public YDXMDZTBQQX(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C59EF0", Offset = "0x8C58CF0", VA = "0x188C59EF0", Slot = "7")]
		public void IMZQQOSHZHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C59EE0", Offset = "0x8C58CE0", VA = "0x188C59EE0", Slot = "8")]
		public void BTSEEDQYMBK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C59CF0", Offset = "0x8C58AF0", VA = "0x188C59CF0", Slot = "9")]
		public void AAZDWLMKXLM(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C59EA0", Offset = "0x8C58CA0", VA = "0x188C59EA0", Slot = "12")]
		public void BAISTIRSLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C59F30", Offset = "0x8C58D30", VA = "0x188C59F30", Slot = "10")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C59F00", Offset = "0x8C58D00", VA = "0x188C59F00", Slot = "11")]
		public void NTVMBNLLZDN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class JDXXJPBKQFE : SKBMETSBTAM, BKQQWDAGMDH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView EHFRFNTUGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool NTTLNJHLZKB;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView AWTSSFQUFQU
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool IUVDVSDYVBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C49A80", Offset = "0x8C48880", VA = "0x188C49A80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool QYGWXXOFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCB7060", Offset = "0xCB5E60", VA = "0x180CB7060", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction UTAICBRQZVI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C492A0", Offset = "0x8C480A0", VA = "0x188C492A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C49890", Offset = "0x8C48690", VA = "0x188C49890", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C49A90", Offset = "0x8C48890", VA = "0x188C49A90")]
		public JDXXJPBKQFE(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C48F10", Offset = "0x8C47D10", VA = "0x188C48F10", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C49040", Offset = "0x8C47E40", VA = "0x188C49040", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C49720", Offset = "0x8C48520", VA = "0x188C49720", Slot = "10")]
		public void SOQVEYPXTEV(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C495B0", Offset = "0x8C483B0", VA = "0x188C495B0", Slot = "11")]
		public void OCECCUNJOSV(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C49130", Offset = "0x8C47F30", VA = "0x188C49130")]
		private void HRWTEAYZZFV(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C49930", Offset = "0x8C48730", VA = "0x188C49930")]
		private void WBYKOCCZQAF(JWEPENHIPYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C49340", Offset = "0x8C48140", VA = "0x188C49340")]
		private void NYSAPARCKDE(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class CSNUCGOWWOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E7C0", Offset = "0x8C3D5C0", VA = "0x188C3E7C0")]
		public static SKBMETSBTAM Lifecycle(this SBFKUYKXOTE impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class EHWEOPQZUUE : AJUMGAOWDER
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints OZRHKIZXNVX;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool OZDQEMGQWDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xBCDA30", Offset = "0xBCC830", VA = "0x180BCDA30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xF47710", Offset = "0xF46510", VA = "0x180F47710", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool TBUQCUOZPBX
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xBCDA80", Offset = "0xBCC880", VA = "0x180BCDA80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xF474D0", Offset = "0xF462D0", VA = "0x180F474D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints JVDFPCLJVWN
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8C44F40", Offset = "0x8C43D40", VA = "0x188C44F40", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C450D0", Offset = "0x8C43ED0", VA = "0x188C450D0")]
		public EHWEOPQZUUE(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C450A0", Offset = "0x8C43EA0", VA = "0x188C450A0", Slot = "9")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C45070", Offset = "0x8C43E70", VA = "0x188C45070", Slot = "10")]
		public void NTVMBNLLZDN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class VPSMBRGICAL : ZQUUQMHTOQS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly SBFKUYKXOTE NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float QRSNSNIJAKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float NQPOWXRLYBP;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float EZMDXYCCTSN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAF9280", Offset = "0xAF8080", VA = "0x180AF9280", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8C58A70", Offset = "0x8C57870", VA = "0x188C58A70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float KBOXTUQWLSB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAF8EB0", Offset = "0xAF7CB0", VA = "0x180AF8EB0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8C58B90", Offset = "0x8C57990", VA = "0x188C58B90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C58C60", Offset = "0x8C57A60", VA = "0x188C58C60")]
		public VPSMBRGICAL(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C58B40", Offset = "0x8C57940", VA = "0x188C58B40", Slot = "8")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C589D0", Offset = "0x8C577D0", VA = "0x188C589D0", Slot = "9")]
		public void NTVMBNLLZDN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class RKUTTEZJNAZ : WHQTXEAAJQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log EMFWJNSQIQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool OLSURULZWYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool NDUYASEAHCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int MWXHJWVYMEL;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E4D0", Offset = "0x8C4D2D0", VA = "0x188C4E4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool NMJATMWBNLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8C4DED0", Offset = "0x8C4CCD0", VA = "0x188C4DED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private SBFKUYKXOTE XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8C4DEF0", Offset = "0x8C4CCF0", VA = "0x188C4DEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool TFFYILZFRYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E2A0", Offset = "0x8C4D0A0", VA = "0x188C4E2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction DWBOVZSNLFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E5F0", Offset = "0x8C4D3F0", VA = "0x188C4E5F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E430", Offset = "0x8C4D230", VA = "0x188C4E430", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E8B0", Offset = "0x8C4D6B0", VA = "0x188C4E8B0")]
		public RKUTTEZJNAZ(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC70", Offset = "0x8C4CA70", VA = "0x188C4DC70", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC60", Offset = "0x8C4CA60", VA = "0x188C4DC60", Slot = "8")]
		public void ASNRCJDRQPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DF50", Offset = "0x8C4CD50", VA = "0x188C4DF50", Slot = "7")]
		public bool GAPDMUUMGHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E520", Offset = "0x8C4D320", VA = "0x188C4E520", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E690", Offset = "0x8C4D490", VA = "0x188C4E690", Slot = "13")]
		public void WXYJKONTZRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E300", Offset = "0x8C4D100", VA = "0x188C4E300", Slot = "12")]
		public void OBANBVYOMDT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E230", Offset = "0x8C4D030", VA = "0x188C4E230", Slot = "10")]
		public bool MECYKXXGXLQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E730", Offset = "0x8C4D530", VA = "0x188C4E730", Slot = "11")]
		public bool ZFMDSHCSFDV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DD00", Offset = "0x8C4CB00", VA = "0x188C4DD00")]
		private bool BXTGMGGDWBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E0A0", Offset = "0x8C4CEA0", VA = "0x188C4E0A0")]
		private void HOQLRNSZEYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class FTCRCXVDVNY : MKDKYSBQPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NTWXEAAFYGD EMJBGJFJIEW;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody TWHNWZXBLAL
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool TFFYILZFRYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8C45A60", Offset = "0x8C44860", VA = "0x188C45A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HYSJFNZZSYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B4E160", Offset = "0x1B4CF60", VA = "0x181B4E160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8C46840", Offset = "0x8C45640", VA = "0x188C46840")]
		public FTCRCXVDVNY(SBFKUYKXOTE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8C460A0", Offset = "0x8C44EA0", VA = "0x188C460A0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8C467E0", Offset = "0x8C455E0", VA = "0x188C467E0", Slot = "7")]
		public void VRMOTGIJWBO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8C46810", Offset = "0x8C45610", VA = "0x188C46810", Slot = "8")]
		public void XYGNGKFDLZJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8C46140", Offset = "0x8C44F40", VA = "0x188C46140", Slot = "9")]
		public void JXBPAOWOYKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8C46470", Offset = "0x8C45270", VA = "0x188C46470", Slot = "10")]
		public void LVRPCQCHNXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8C46660", Offset = "0x8C45460", VA = "0x188C46660", Slot = "11")]
		public void OXUPMGXQULY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class JPBOPOIBTUN : DXXHIYYKVTS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly EBPEYFQNYPP NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NTWXEAAFYGD VWJRNQKVCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float YDSZYAETWZS;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public DLILUNFEYEI JJNYIFZBXGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAA0570", Offset = "0xA9F370", VA = "0x180AA0570", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public BCEQBJSIDBZ LCMFGRQEXGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 FTDYHBAWEOO
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4B3A0", Offset = "0x8C4A1A0", VA = "0x188C4B3A0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4C6A0", Offset = "0x8C4B4A0", VA = "0x188C4C6A0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 JUQSMCBUUCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8C4B670", Offset = "0x8C4A470", VA = "0x188C4B670", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4C550", Offset = "0x8C4B350", VA = "0x188C4C550", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 ZEYELOLDCMO
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8C49BF0", Offset = "0x8C489F0", VA = "0x188C49BF0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8C4B140", Offset = "0x8C49F40", VA = "0x188C4B140", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 TGNQTKUYUAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8C4C380", Offset = "0x8C4B180", VA = "0x188C4C380", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8C49E00", Offset = "0x8C48C00", VA = "0x188C49E00", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float RYOEOXBFDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8C4A570", Offset = "0x8C49370", VA = "0x188C4A570", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool KHAOJJQZJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2581490", Offset = "0x2580290", VA = "0x182581490", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private OMONHQWBMFE RQFIGZEOJXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x81CFC60", Offset = "0x81CEA60", VA = "0x1881CFC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool NMJATMWBNLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8C49E30", Offset = "0x8C48C30", VA = "0x188C49E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D030", Offset = "0x8C4BE30", VA = "0x188C4D030")]
		public JPBOPOIBTUN(SBFKUYKXOTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8C49D50", Offset = "0x8C48B50", VA = "0x188C49D50", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A680", Offset = "0x8C49480", VA = "0x188C4A680", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B790", Offset = "0x8C4A590", VA = "0x188C4B790", Slot = "28")]
		public void QTZHCJYBEFU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1949680", Offset = "0x1948480", VA = "0x181949680", Slot = "20")]
		public void DWODYCDLSCE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x194AD40", Offset = "0x1949B40", VA = "0x18194AD40", Slot = "30")]
		public void IEMYPXYCONV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C7C0", Offset = "0x8C4B5C0", VA = "0x188C4C7C0", Slot = "35")]
		public Vector3 WOMNNCKLBXO(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AC60", Offset = "0x8C49A60", VA = "0x188C4AC60", Slot = "34")]
		public Vector3 FWBJDEFBMHQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8C49D50", Offset = "0x8C48B50", VA = "0x188C49D50", Slot = "27")]
		public void BWYHNJYKEZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C760", Offset = "0x8C4B560", VA = "0x188C4C760", Slot = "25")]
		public void WFOWDQTPUDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CFD0", Offset = "0x8C4BDD0", VA = "0x188C4CFD0", Slot = "24")]
		public void ZHJNELGSLXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AE20", Offset = "0x8C49C20", VA = "0x188C4AE20", Slot = "33")]
		public void GJZNRXPFTOX(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B4F0", Offset = "0x8C4A2F0", VA = "0x188C4B4F0", Slot = "32")]
		public void LXBMGBSEAAG(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C9A0", Offset = "0x8C4B7A0", VA = "0x188C4C9A0", Slot = "31")]
		public void YADDEWADTPN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B8C0", Offset = "0x8C4A6C0", VA = "0x188C4B8C0", Slot = "22")]
		public void QXPUOUFNLNB(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8C49E50", Offset = "0x8C48C50", VA = "0x188C49E50", Slot = "21")]
		public void DARJYPVIODY(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A6E0", Offset = "0x8C494E0", VA = "0x188C4A6E0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void EKNHECQOFAJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A8FBD0", Offset = "0x1A8E9D0", VA = "0x181A8FBD0")]
		private static void YJXQMUEQRUH(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B060", Offset = "0x8C49E60", VA = "0x188C4B060", Slot = "29")]
		public Vector3 GTOVAWTMCHC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AAD0", Offset = "0x8C498D0", VA = "0x188C4AAD0", Slot = "26")]
		public void FLVRCGMYOWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A570", Offset = "0x8C49370", VA = "0x188C4A570")]
		private void DWHPPQLEXVE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B200", Offset = "0x8C4A000", VA = "0x188C4B200")]
		private void KRJEKAPOIJG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B550", Offset = "0x8C4A350", VA = "0x188C4B550")]
		private Vector3 PKCPDRCEQFV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A0E0", Offset = "0x8C48EE0", VA = "0x188C4A0E0")]
		private void DKIFTZOFJJV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C580", Offset = "0x8C4B380", VA = "0x188C4C580")]
		private Vector3 UCABBOJCTQN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB40", Offset = "0x8C4B940", VA = "0x188C4CB40")]
		private void YZQNNOXWGBT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BF20", Offset = "0x8C4AD20", VA = "0x188C4BF20")]
		private void RJQSXMXZBVI(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C4A0", Offset = "0x8C4B2A0", VA = "0x188C4C4A0")]
		private void RWCAMYICVUM()
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
