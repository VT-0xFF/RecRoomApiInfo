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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		[Cpp2IlInjected.Address(RVA = "0xA19A510", Offset = "0xA198F10", VA = "0x18A19A510", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B78E90", Offset = "0x9B77890", VA = "0x189B78E90", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1A53B0", Offset = "0xA1A3DB0", VA = "0x18A1A53B0")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5350", Offset = "0xA1A3D50", VA = "0x18A1A5350", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5690", Offset = "0xA1A4090", VA = "0x18A1A5690")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, QPQCJTUZEKK, YVVTQPZHVXT, BLJXLPZXGFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log QVSDGTVEWHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool YVROBGPGTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private XDKPDVFGOFK GFAUAXWHGGP;

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
		private Transform GZAWWSQTFEF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal XDKPDVFGOFK QDBVPLSAZIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA19EBE0", Offset = "0xA19D5E0", VA = "0x18A19EBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private XDKPDVFGOFK ERKSKOPJOUH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LMPCHQDGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA1A05B0", Offset = "0xA19EFB0", VA = "0x18A1A05B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IZOQGLOFHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0910", Offset = "0xA19F310", VA = "0x18A1A0910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0850", Offset = "0xA19F250", VA = "0x18A1A0850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx WKYFTFFHETD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1510", Offset = "0xA19FF10", VA = "0x18A1A1510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2A10", Offset = "0xA1A1410", VA = "0x18A1A2A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x951DA40", Offset = "0x951C440", VA = "0x18951DA40", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x951DB90", Offset = "0x951C590", VA = "0x18951DB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform TKCNCOJLDNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x261CB50", Offset = "0x261B550", VA = "0x18261CB50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform WUGKRHXYUUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x261CB50", Offset = "0x261B550", VA = "0x18261CB50", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform JTQPGKDHPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x261CB50", Offset = "0x261B550", VA = "0x18261CB50", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0610", Offset = "0xA19F010", VA = "0x18A1A0610")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A21C0", Offset = "0xA1A0BC0", VA = "0x18A1A21C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0C20", Offset = "0xA19F620", VA = "0x18A1A0C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0730", Offset = "0xA19F130", VA = "0x18A1A0730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0B60", Offset = "0xA19F560", VA = "0x18A1A0B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2380", Offset = "0xA1A0D80", VA = "0x18A1A2380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0B00", Offset = "0xA19F500", VA = "0x18A1A0B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2310", Offset = "0xA1A0D10", VA = "0x18A1A2310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0A50", Offset = "0xA19F450", VA = "0x18A1A0A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0AB0", Offset = "0xA19F4B0", VA = "0x18A1A0AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0790", Offset = "0xA19F190", VA = "0x18A1A0790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2230", Offset = "0xA1A0C30", VA = "0x18A1A2230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool XRLWASFFWFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A49190", Offset = "0x1A47B90", VA = "0x181A49190", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float SIVHJSWSRMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1A14B0", Offset = "0xA19FEB0", VA = "0x18A1A14B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TQWBWKTQQCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1450", Offset = "0xA19FE50", VA = "0x18A1A1450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A29A0", Offset = "0xA1A13A0", VA = "0x18A1A29A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OYJMGFVZVRR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0E80", Offset = "0xA19F880", VA = "0x18A1A0E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2620", Offset = "0xA1A1020", VA = "0x18A1A2620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SOFNTCVHTMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0C80", Offset = "0xA19F680", VA = "0x18A1A0C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A23F0", Offset = "0xA1A0DF0", VA = "0x18A1A23F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool QCABZPGCPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1A60", Offset = "0xA1A0460", VA = "0x18A1A1A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2F50", Offset = "0xA1A1950", VA = "0x18A1A2F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 PIUUOJATRJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1230", Offset = "0xA19FC30", VA = "0x18A1A1230")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2770", Offset = "0xA1A1170", VA = "0x18A1A2770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 WZQHFSGVAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1BA0", Offset = "0xA1A05A0", VA = "0x18A1A1BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode CIXPXIUSJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0DC0", Offset = "0xA19F7C0", VA = "0x18A1A0DC0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2540", Offset = "0xA1A0F40", VA = "0x18A1A2540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA1A07F0", Offset = "0xA19F1F0", VA = "0x18A1A07F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1A22A0", Offset = "0xA1A0CA0", VA = "0x18A1A22A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints SPNQCTQRWGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0E20", Offset = "0xA19F820", VA = "0x18A1A0E20")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1A25B0", Offset = "0xA1A0FB0", VA = "0x18A1A25B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 HPLQHPQDJJT
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A15D0", Offset = "0xA19FFD0", VA = "0x18A1A15D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EDGKIPSHQCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A15D0", Offset = "0xA19FFD0", VA = "0x18A1A15D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2D30", Offset = "0xA1A1730", VA = "0x18A1A2D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float SNGWOZXULZY
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1310", Offset = "0xA19FD10", VA = "0x18A1A1310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2850", Offset = "0xA1A1250", VA = "0x18A1A2850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float VLFORICXUZF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1A00", Offset = "0xA1A0400", VA = "0x18A1A1A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2EE0", Offset = "0xA1A18E0", VA = "0x18A1A2EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion QODMEPZHBPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA1A16B0", Offset = "0xA1A00B0", VA = "0x18A1A16B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2AB0", Offset = "0xA1A14B0", VA = "0x18A1A2AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion WHSQAFDDPNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1930", Offset = "0xA1A0330", VA = "0x18A1A1930")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2E10", Offset = "0xA1A1810", VA = "0x18A1A2E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 YHEUZOXZCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1780", Offset = "0xA1A0180", VA = "0x18A1A1780")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2B80", Offset = "0xA1A1580", VA = "0x18A1A2B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion ATXEOCVIBDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1860", Offset = "0xA1A0260", VA = "0x18A1A1860")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2C60", Offset = "0xA1A1660", VA = "0x18A1A2C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HLJQEHWQTDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1AC0", Offset = "0xA1A04C0", VA = "0x18A1A1AC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2FC0", Offset = "0xA1A19C0", VA = "0x18A1A2FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ZFOUAGMARLF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1370", Offset = "0xA19FD70", VA = "0x18A1A1370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A28C0", Offset = "0xA1A12C0", VA = "0x18A1A28C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NLAJIDIDBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0CE0", Offset = "0xA19F6E0", VA = "0x18A1A0CE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2460", Offset = "0xA1A0E60", VA = "0x18A1A2460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MNFBITAOKVP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1150", Offset = "0xA19FB50", VA = "0x18A1A1150")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2690", Offset = "0xA1A1090", VA = "0x18A1A2690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NTTBJMCTPQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1010", Offset = "0xA19FA10", VA = "0x18A1A1010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion JGZHECCIWXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0F40", Offset = "0xA19F940", VA = "0x18A1A0F40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 PMUZQDDIJYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1D60", Offset = "0xA1A0760", VA = "0x18A1A1D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 UBBWKGSNQTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1C80", Offset = "0xA1A0680", VA = "0x18A1A1C80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LVVJDFPCLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1A10F0", Offset = "0xA19FAF0", VA = "0x18A1A10F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool QZMYDJZELNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0BC0", Offset = "0xA19F5C0", VA = "0x18A1A0BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LSUOEYYLJXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA1A06D0", Offset = "0xA19F0D0", VA = "0x18A1A06D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool VUHNUVYJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0670", Offset = "0xA19F070", VA = "0x18A1A0670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OHULPTRHOII
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0550", Offset = "0xA19EF50", VA = "0x18A1A0550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool SWCVYKRBGRV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0EE0", Offset = "0xA19F8E0", VA = "0x18A1A0EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE45C20", Offset = "0xE44620", VA = "0x180E45C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction QQSSQJBWUCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0470", Offset = "0xA19EE70", VA = "0x18A1A0470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA1A20E0", Offset = "0xA1A0AE0", VA = "0x18A1A20E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA1A01E0", Offset = "0xA19EBE0", VA = "0x18A1A01E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1E40", Offset = "0xA1A0840", VA = "0x18A1A1E40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0240", Offset = "0xA19EC40", VA = "0x18A1A0240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1EB0", Offset = "0xA1A08B0", VA = "0x18A1A1EB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction DGWSQUNKABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0390", Offset = "0xA19ED90", VA = "0x18A1A0390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2000", Offset = "0xA1A0A00", VA = "0x18A1A2000")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0320", Offset = "0xA19ED20", VA = "0x18A1A0320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1F90", Offset = "0xA1A0990", VA = "0x18A1A1F90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction GDBAJZJISNI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0400", Offset = "0xA19EE00", VA = "0x18A1A0400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2070", Offset = "0xA1A0A70", VA = "0x18A1A2070")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction PAEERFHNIXS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A04E0", Offset = "0xA19EEE0", VA = "0x18A1A04E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2150", Offset = "0xA1A0B50", VA = "0x18A1A2150")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction POXMWURXFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A02B0", Offset = "0xA19ECB0", VA = "0x18A1A02B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1F20", Offset = "0xA1A0920", VA = "0x18A1A1F20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530", Slot = "8")]
		private void MWZBNWUXDTH(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA19EB50", Offset = "0xA19D550", VA = "0x18A19EB50", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA19F000", Offset = "0xA19DA00", VA = "0x18A19F000")]
		internal void MFGHLKIKPUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA19FF00", Offset = "0xA19E900", VA = "0x18A19FF00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA19E8A0", Offset = "0xA19D2A0", VA = "0x18A19E8A0")]
		public QPQCJTUZEKK GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA19FB60", Offset = "0xA19E560", VA = "0x18A19FB60")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA19E4F0", Offset = "0xA19CEF0", VA = "0x18A19E4F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA19FDF0", Offset = "0xA19E7F0", VA = "0x18A19FDF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA19EBE0", Offset = "0xA19D5E0", VA = "0x18A19EBE0")]
		private XDKPDVFGOFK HVPKJSVXJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA19F270", Offset = "0xA19DC70", VA = "0x18A19F270")]
		private void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA19F1B0", Offset = "0xA19DBB0", VA = "0x18A19F1B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA19F0F0", Offset = "0xA19DAF0", VA = "0x18A19F0F0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA19F000", Offset = "0xA19DA00", VA = "0x18A19F000")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA19F150", Offset = "0xA19DB50", VA = "0x18A19F150")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA19F210", Offset = "0xA19DC10", VA = "0x18A19F210")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA19DAE0", Offset = "0xA19C4E0", VA = "0x18A19DAE0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA19F3F0", Offset = "0xA19DDF0", VA = "0x18A19F3F0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA19E840", Offset = "0xA19D240", VA = "0x18A19E840")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA19F090", Offset = "0xA19DA90", VA = "0x18A19F090")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA19FCC0", Offset = "0xA19E6C0", VA = "0x18A19FCC0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA19F700", Offset = "0xA19E100", VA = "0x18A19F700")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA19EC90", Offset = "0xA19D690", VA = "0x18A19EC90")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA19ED90", Offset = "0xA19D790", VA = "0x18A19ED90")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA19DD50", Offset = "0xA19C750", VA = "0x18A19DD50")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA19F460", Offset = "0xA19DE60", VA = "0x18A19F460")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA19DDC0", Offset = "0xA19C7C0", VA = "0x18A19DDC0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA19F4D0", Offset = "0xA19DED0", VA = "0x18A19F4D0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA19FC40", Offset = "0xA19E640", VA = "0x18A19FC40")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA19FA60", Offset = "0xA19E460", VA = "0x18A19FA60")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA19F960", Offset = "0xA19E360", VA = "0x18A19F960")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA19EA40", Offset = "0xA19D440", VA = "0x18A19EA40")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA19E930", Offset = "0xA19D330", VA = "0x18A19E930")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA19DC60", Offset = "0xA19C660", VA = "0x18A19DC60")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA19DB50", Offset = "0xA19C550", VA = "0x18A19DB50")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA19DF90", Offset = "0xA19C990", VA = "0x18A19DF90")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA19DE30", Offset = "0xA19C830", VA = "0x18A19DE30")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA19FFD0", Offset = "0xA19E9D0", VA = "0x18A19FFD0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA19EEF0", Offset = "0xA19D8F0", VA = "0x18A19EEF0")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA19E7E0", Offset = "0xA19D1E0", VA = "0x18A19E7E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA19E780", Offset = "0xA19D180", VA = "0x18A19E780")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA19E720", Offset = "0xA19D120", VA = "0x18A19E720")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA19E6C0", Offset = "0xA19D0C0", VA = "0x18A19E6C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA19F860", Offset = "0xA19E260", VA = "0x18A19F860")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA19F760", Offset = "0xA19E160", VA = "0x18A19F760")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA19F620", Offset = "0xA19E020", VA = "0x18A19F620")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA19FE00", Offset = "0xA19E800", VA = "0x18A19FE00")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA19EE90", Offset = "0xA19D890", VA = "0x18A19EE90")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA19FD90", Offset = "0xA19E790", VA = "0x18A19FD90")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA19FF70", Offset = "0xA19E970", VA = "0x18A19FF70")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA19DF20", Offset = "0xA19C920", VA = "0x18A19DF20")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA19F540", Offset = "0xA19DF40", VA = "0x18A19F540")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA19E320", Offset = "0xA19CD20", VA = "0x18A19E320")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA19E220", Offset = "0xA19CC20", VA = "0x18A19E220")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA19E3E0", Offset = "0xA19CDE0", VA = "0x18A19E3E0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA19E150", Offset = "0xA19CB50", VA = "0x18A19E150")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA19E080", Offset = "0xA19CA80", VA = "0x18A19E080")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA19F5B0", Offset = "0xA19DFB0", VA = "0x18A19F5B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC760", Offset = "0x8DAB160", VA = "0x188DAC760", Slot = "13")]
		private void CVZNLIRWQMC(LRDITXVMCHW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0170", Offset = "0xA19EB70", VA = "0x18A1A0170")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x153A6D0", Offset = "0x15390D0", VA = "0x18153A6D0", Slot = "4")]
		private GameObject KMPIXWTIJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD3C930", Offset = "0xD3B330", VA = "0x180D3C930", Slot = "10")]
		private bool NWWERDTVSXE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class SLJTHDOOQQX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3590", Offset = "0xA1A1F90", VA = "0x18A1A3590")]
		public static XDKPDVFGOFK QDBVPLSAZIH(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(FCZRZYWQJRH), new string[] { })]
	public class RigidbodyExManager : FCZRZYWQJRH, YWYIFNCKTFV
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private VJYADRDFHKG BGDHEBCZSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private GFSHHAICVPH IVQJNLXDFIV;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public VJYADRDFHKG XCEZNPPPYEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA19D810", Offset = "0xA19C210", VA = "0x18A19D810", Slot = "7")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA19D880", Offset = "0xA19C280", VA = "0x18A19D880", Slot = "6")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DYNHRMPGIXT UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BOUWOKGBNLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int QWASQJJOXJP;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA19B7C0", Offset = "0xA19A1C0", VA = "0x18A19B7C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA19B840", Offset = "0xA19A240", VA = "0x18A19B840")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA19B7E0", Offset = "0xA19A1E0", VA = "0x18A19B7E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA19B940", Offset = "0xA19A340", VA = "0x18A19B940")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class MSHUNPRZOPH
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class IGFVCSDSJFX : HDDJQUXOAWW, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD20460", Offset = "0xD1EE60", VA = "0x180D20460", Slot = "4")]
			public Vector3 JLHJTBXRBDC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD20460", Offset = "0xD1EE60", VA = "0x180D20460", Slot = "5")]
			public Vector3 IDKSPSNPIXV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "6")]
			public bool HKBHQWQXQXM(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public IGFVCSDSJFX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static HDDJQUXOAWW CQNMGFIEKYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA19A6D0", Offset = "0xA1990D0", VA = "0x18A19A6D0")]
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
	public interface LQSEGCRROWG
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode KWWCQHRIDVL
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
		void WSJWUHQEGGH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FKNGFDCVJRU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QBIGZYPSMTR : IDisposable, JRMZITKTWCL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SXCVSPRDTLW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NPQPCPZEPCZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool VSFABRCABNY
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface OAZXDJYJUWI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<XDKPDVFGOFK> UWJZIMKMPEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction ICUBVGDMBRD;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction RDLNGAGGJAT;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction ILKEMHRFFPF;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action UBNLFUZOTEC;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action JYMRFMLYEAX;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<XDKPDVFGOFK> WQRQGCTHDGG;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<XDKPDVFGOFK> JYSFKEUXZIB;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action UNXRNKLKGZM;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<XDKPDVFGOFK> JJXZXBNRGGT;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(XDKPDVFGOFK newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface WSBCCCPFUUH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WBLEKNPLYYY(XDKPDVFGOFK a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SREKNKJLLPP(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface RESOWLLUWXN
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction SLRBIDUQSRR;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GWJEKIVMKDP();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XHZCAUKHNPM();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void LOXIYFMFRJS();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void VSIVIBEZXAV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NPJQOEFKIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZQCENFLIOTY(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WBSEVKPEKPT(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QXMBABPCSHT(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FYVCDNBCFHO(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NFTOUJDAKDL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface EVFGQKPYFLA
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction LJVLHYINPRI;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WVSRRFVENQZ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PWSJSLYVASG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PLORMZKPNME(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FZPHAAVUQBZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction XRUORDVSSXK;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DKDXBVHNABF(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OWYAIQTJUPV(XDKPDVFGOFK a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NGYLGUWSWCH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool UTQCTIVQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints PLHIPBVAQGT
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LDPQNIZZQXG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float PIQMEIKTJPR
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JFLTWRSMKHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool LHEYSDOJCUA;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction REUZHCXVZYM;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZXQJNWFYETO();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ODLGHJZSHAS();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool YEUOKZMPIEU();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TIAQGQSKQQZ();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KBLCRAWEBAH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DKZBOGCQDUA();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface UFFXESXPRCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool THMHIMFQJPG
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
		void HEJFIFOXNLU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PDQFADQHMKZ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GIFZYXYUGIA();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface YBVLSZTJXGO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool ETNHVNIQBZK
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
		void CEQZQIBUQEC(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void SNEKHQMKOJV();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KONNPWBFTAM();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void FVYSROMJIMB();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void TRLIIBNVRMJ();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 YIWWEIZGLWS(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void CPUBGBNQCWV(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void PEVFMJBEDZD(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void SEZPMDFOUBO(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void RGRXZTJGEJD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 BWKMVMIGISA(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 OTBAGGXPLFQ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VJYADRDFHKG
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool SPLZRBBUOHP
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GGQNZSEEUBB(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NKETQZJJBJE(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PDFHAFPZZPA IWOOHZQYBTL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EZBHVOJKXBF(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FCZRZYWQJRH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		VJYADRDFHKG XCEZNPPPYEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class CGICJSTLYPF : XDKPDVFGOFK, IDisposable, WIZVBGOCJRN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly FCZRZYWQJRH OHQUMFIDCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal OAZXDJYJUWI IFFYBAZUSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal NPJQOEFKIGN BJQFGEGZDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal FZPHAAVUQBZ IZVDVWEGGVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal YBVLSZTJXGO HLJQEHWQTDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal WSBCCCPFUUH EJBMKELXKSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal RESOWLLUWXN EGBXTUZJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal LDPQNIZZQXG UKGITRXFRBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal NPQPCPZEPCZ RMAODKQBYIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal JFLTWRSMKHO ANHFCZQDLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal QBIGZYPSMTR TZOOIQGRDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal EVFGQKPYFLA AMCNVULZIXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal SXCVSPRDTLW FKKSVYWKPHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal NGYLGUWSWCH KLQCERKUMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal UFFXESXPRCN YQDUDRNNFYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal LQSEGCRROWG GLGGZLQAYXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable DUYJMKSZAYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool CIQVTHMNLXT;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId FXJADZEOZOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public QPQCJTUZEKK VHFLMTZOGCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDE3320", Offset = "0xDE1D20", VA = "0x180DE3320", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEA1370", Offset = "0xE9FD70", VA = "0x180EA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject YQYZFFQUMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD13E60", Offset = "0xD12860", VA = "0x180D13E60", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xD13E70", Offset = "0xD12870", VA = "0x180D13E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEC39C0", Offset = "0xEC23C0", VA = "0x180EC39C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x102EA40", Offset = "0x102D440", VA = "0x18102EA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA1911E0", Offset = "0xA18FBE0", VA = "0x18A1911E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA18C580", Offset = "0xA18AF80", VA = "0x18A18C580", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA18D610", Offset = "0xA18C010", VA = "0x18A18D610", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LMPCHQDGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA18D380", Offset = "0xA18BD80", VA = "0x18A18D380", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA18F140", Offset = "0xA18DB40", VA = "0x18A18F140", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA18DC10", Offset = "0xA18C610", VA = "0x18A18DC10", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA18CA50", Offset = "0xA18B450", VA = "0x18A18CA50", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA1916F0", Offset = "0xA1900F0", VA = "0x18A1916F0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA18EF80", Offset = "0xA18D980", VA = "0x18A18EF80", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA1910F0", Offset = "0xA18FAF0", VA = "0x18A1910F0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA18CF50", Offset = "0xA18B950", VA = "0x18A18CF50", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA190800", Offset = "0xA18F200", VA = "0x18A190800", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA190200", Offset = "0xA18EC00", VA = "0x18A190200", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA1920D0", Offset = "0xA190AD0", VA = "0x18A1920D0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA18D480", Offset = "0xA18BE80", VA = "0x18A18D480", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA18DF30", Offset = "0xA18C930", VA = "0x18A18DF30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA18ED80", Offset = "0xA18D780", VA = "0x18A18ED80", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA190C10", Offset = "0xA18F610", VA = "0x18A190C10", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA1927B0", Offset = "0xA1911B0", VA = "0x18A1927B0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA191FF0", Offset = "0xA1909F0", VA = "0x18A191FF0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA18FF70", Offset = "0xA18E970", VA = "0x18A18FF70", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA191530", Offset = "0xA18FF30", VA = "0x18A191530", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool LSUOEYYLJXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA192AD0", Offset = "0xA1914D0", VA = "0x18A192AD0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool VUHNUVYJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA18D1C0", Offset = "0xA18BBC0", VA = "0x18A18D1C0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool OHULPTRHOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA18E010", Offset = "0xA18CA10", VA = "0x18A18E010", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA1914E0", Offset = "0xA18FEE0", VA = "0x18A1914E0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA18EEB0", Offset = "0xA18D8B0", VA = "0x18A18EEB0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA18CFA0", Offset = "0xA18B9A0", VA = "0x18A18CFA0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA192B20", Offset = "0xA191520", VA = "0x18A192B20", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA18CDB0", Offset = "0xA18B7B0", VA = "0x18A18CDB0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA1929F0", Offset = "0xA1913F0", VA = "0x18A1929F0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA191A10", Offset = "0xA190410", VA = "0x18A191A10", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA190390", Offset = "0xA18ED90", VA = "0x18A190390", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA191090", Offset = "0xA18FA90", VA = "0x18A191090", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA18EAD0", Offset = "0xA18D4D0", VA = "0x18A18EAD0", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA190DA0", Offset = "0xA18F7A0", VA = "0x18A190DA0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA191660", Offset = "0xA190060", VA = "0x18A191660", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA1919B0", Offset = "0xA1903B0", VA = "0x18A1919B0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float PIQMEIKTJPR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA190730", Offset = "0xA18F130", VA = "0x18A190730", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA18DD70", Offset = "0xA18C770", VA = "0x18A18DD70", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool VSFABRCABNY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA18ECD0", Offset = "0xA18D6D0", VA = "0x18A18ECD0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA18F0E0", Offset = "0xA18DAE0", VA = "0x18A18F0E0", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA1925C0", Offset = "0xA190FC0", VA = "0x18A1925C0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA18D560", Offset = "0xA18BF60", VA = "0x18A18D560", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA190490", Offset = "0xA18EE90", VA = "0x18A190490", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform JTQPGKDHPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEC39C0", Offset = "0xEC23C0", VA = "0x180EC39C0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 UUZOEMAAMGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA192890", Offset = "0xA191290", VA = "0x18A192890", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA18F390", Offset = "0xA18DD90", VA = "0x18A18F390", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float CZFKYAZTUDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA1925B0", Offset = "0xA190FB0", VA = "0x18A1925B0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA1904E0", Offset = "0xA18EEE0", VA = "0x18A1904E0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float MHEXLZZNCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA191E40", Offset = "0xA190840", VA = "0x18A191E40", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA18DDD0", Offset = "0xA18C7D0", VA = "0x18A18DDD0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion GCTNCJVDRCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA190F60", Offset = "0xA18F960", VA = "0x18A190F60", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA192130", Offset = "0xA190B30", VA = "0x18A192130", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 RIRFUTNLMYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA192710", Offset = "0xA191110", VA = "0x18A192710", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA191050", Offset = "0xA18FA50", VA = "0x18A191050", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion JNDLMIYHMJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA18CD70", Offset = "0xA18B770", VA = "0x18A18CD70", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA18D3F0", Offset = "0xA18BDF0", VA = "0x18A18D3F0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints PLHIPBVAQGT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA190570", Offset = "0xA18EF70", VA = "0x18A190570", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA191A60", Offset = "0xA190460", VA = "0x18A191A60", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA18F880", Offset = "0xA18E280", VA = "0x18A18F880", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA18C7B0", Offset = "0xA18B1B0", VA = "0x18A18C7B0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode KWWCQHRIDVL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA192940", Offset = "0xA191340", VA = "0x18A192940", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA18C6F0", Offset = "0xA18B0F0", VA = "0x18A18C6F0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA191E50", Offset = "0xA190850", VA = "0x18A191E50", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool QZMYDJZELNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA190860", Offset = "0xA18F260", VA = "0x18A190860", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA192990", Offset = "0xA191390", VA = "0x18A192990", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA18E8B0", Offset = "0xA18D2B0", VA = "0x18A18E8B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA18E400", Offset = "0xA18CE00", VA = "0x18A18E400", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA18CEF0", Offset = "0xA18B8F0", VA = "0x18A18CEF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction ILKEMHRFFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA1912F0", Offset = "0xA18FCF0", VA = "0x18A1912F0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA18D670", Offset = "0xA18C070", VA = "0x18A18D670", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction XRUORDVSSXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA18ED20", Offset = "0xA18D720", VA = "0x18A18ED20", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA18D320", Offset = "0xA18BD20", VA = "0x18A18D320", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction DGWSQUNKABH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA190AD0", Offset = "0xA18F4D0", VA = "0x18A190AD0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA18CCB0", Offset = "0xA18B6B0", VA = "0x18A18CCB0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction REUZHCXVZYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA191DE0", Offset = "0xA1907E0", VA = "0x18A191DE0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA1906D0", Offset = "0xA18F0D0", VA = "0x18A1906D0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA18EFD0", Offset = "0xA18D9D0", VA = "0x18A18EFD0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA192750", Offset = "0xA191150", VA = "0x18A192750", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction LJVLHYINPRI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA18E910", Offset = "0xA18D310", VA = "0x18A18E910", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA18CE90", Offset = "0xA18B890", VA = "0x18A18CE90", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction POXMWURXFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA1903E0", Offset = "0xA18EDE0", VA = "0x18A1903E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA190CF0", Offset = "0xA18F6F0", VA = "0x18A190CF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA192C50", Offset = "0xA191650", VA = "0x18A192C50")]
		public CGICJSTLYPF(GameObject a, RigidbodyEx b, FCZRZYWQJRH c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA192270", Offset = "0xA190C70", VA = "0x18A192270", Slot = "139")]
		protected virtual void XGGFVIYJLDT(FCZRZYWQJRH a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA18D220", Offset = "0xA18BC20", VA = "0x18A18D220", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA18C810", Offset = "0xA18B210", VA = "0x18A18C810", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA18FEE0", Offset = "0xA18E8E0", VA = "0x18A18FEE0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA18FE30", Offset = "0xA18E830", VA = "0x18A18FE30", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA18FE10", Offset = "0xA18E810", VA = "0x18A18FE10", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA18E620", Offset = "0xA18D020", VA = "0x18A18E620")]
		private void KBLCRAWEBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA190780", Offset = "0xA18F180", VA = "0x18A190780")]
		private void QVQNLMKANHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA191480", Offset = "0xA18FE80", VA = "0x18A191480")]
		private void TIAQGQSKQQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA18EA50", Offset = "0xA18D450", VA = "0x18A18EA50", Slot = "30")]
		public XDKPDVFGOFK KMTFXKABZGL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA191230", Offset = "0xA18FC30", VA = "0x18A191230", Slot = "98")]
		public void SetParent(XDKPDVFGOFK value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA18C750", Offset = "0xA18B150", VA = "0x18A18C750", Slot = "99")]
		public void AYMKAHRFLGI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA18CD10", Offset = "0xA18B710", VA = "0x18A18CD10", Slot = "100")]
		public void CKWXFZHLGIT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA18FAD0", Offset = "0xA18E4D0", VA = "0x18A18FAD0", Slot = "101")]
		public Vector3 OTBAGGXPLFQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA18CAA0", Offset = "0xA18B4A0", VA = "0x18A18CAA0", Slot = "102")]
		public Vector3 BWKMVMIGISA(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA191610", Offset = "0xA190010", VA = "0x18A191610", Slot = "103")]
		public void TRLIIBNVRMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA18EBB0", Offset = "0xA18D5B0", VA = "0x18A18EBB0", Slot = "104")]
		public void KONNPWBFTAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA191000", Offset = "0xA18FA00", VA = "0x18A191000", Slot = "105")]
		public void SNEKHQMKOJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1909E0", Offset = "0xA18F3E0", VA = "0x18A1909E0", Slot = "106")]
		public void RGRXZTJGEJD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA190E70", Offset = "0xA18F870", VA = "0x18A190E70", Slot = "107")]
		public void SEZPMDFOUBO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1900B0", Offset = "0xA18EAB0", VA = "0x18A1900B0", Slot = "108")]
		public void PEVFMJBEDZD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA191740", Offset = "0xA190140", VA = "0x18A191740", Slot = "109")]
		public void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA18C950", Offset = "0xA18B350", VA = "0x18A18C950", Slot = "110")]
		public void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA18D7B0", Offset = "0xA18C1B0", VA = "0x18A18D7B0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA192610", Offset = "0xA191010", VA = "0x18A192610", Slot = "112")]
		public Vector3 YIWWEIZGLWS(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA18F290", Offset = "0xA18DC90", VA = "0x18A18F290", Slot = "113")]
		public Vector3 NQAMZICCDKW(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA18D5C0", Offset = "0xA18BFC0", VA = "0x18A18D5C0", Slot = "114")]
		public void FVYSROMJIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA18E5B0", Offset = "0xA18CFB0", VA = "0x18A18E5B0", Slot = "115")]
		public void JWMNWCDOBYB(XDKPDVFGOFK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA18D420", Offset = "0xA18BE20", VA = "0x18A18D420", Slot = "116")]
		public void ETCJCMXKEFE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA190250", Offset = "0xA18EC50", VA = "0x18A190250", Slot = "63")]
		public void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA192560", Offset = "0xA190F60", VA = "0x18A192560", Slot = "117")]
		public void XHZCAUKHNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA18DC70", Offset = "0xA18C670", VA = "0x18A18DC70", Slot = "118")]
		public void GWJEKIVMKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA18EE60", Offset = "0xA18D860", VA = "0x18A18EE60", Slot = "119")]
		public void LOXIYFMFRJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA192C00", Offset = "0xA191600", VA = "0x18A192C00", Slot = "120")]
		public bool ZXQJNWFYETO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1912A0", Offset = "0xA18FCA0", VA = "0x18A1912A0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA18D150", Offset = "0xA18BB50", VA = "0x18A18D150", Slot = "121")]
		public void DKZBOGCQDUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA192210", Offset = "0xA190C10", VA = "0x18A192210", Slot = "122")]
		public void WVSRRFVENQZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA190330", Offset = "0xA18ED30", VA = "0x18A190330", Slot = "123")]
		public void PWSJSLYVASG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA190190", Offset = "0xA18EB90", VA = "0x18A190190", Slot = "124")]
		public void PLORMZKPNME(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA18F8D0", Offset = "0xA18E2D0", VA = "0x18A18F8D0", Slot = "125")]
		public void OGCYMNXOKTS(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA18E2D0", Offset = "0xA18CCD0", VA = "0x18A18E2D0", Slot = "126")]
		public void IWYHPALLJAU(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA18DCC0", Offset = "0xA18C6C0", VA = "0x18A18DCC0", Slot = "127")]
		public bool HCIZMAESUPV(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA18DED0", Offset = "0xA18C8D0", VA = "0x18A18DED0", Slot = "128")]
		public void IMCWNIJTWXC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA191F90", Offset = "0xA190990", VA = "0x18A191F90", Slot = "129")]
		public void VVHXBGYKUWV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA18DD10", Offset = "0xA18C710", VA = "0x18A18DD10", Slot = "130")]
		public void HEJFIFOXNLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA190050", Offset = "0xA18EA50", VA = "0x18A190050", Slot = "131")]
		public void PDQFADQHMKZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA190B30", Offset = "0xA18F530", VA = "0x18A190B30", Slot = "132")]
		public void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA1905C0", Offset = "0xA18EFC0", VA = "0x18A1905C0", Slot = "133")]
		public void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA18D6D0", Offset = "0xA18C0D0", VA = "0x18A18D6D0", Slot = "134")]
		public void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA18E970", Offset = "0xA18D370", VA = "0x18A18E970", Slot = "135")]
		public void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA18F190", Offset = "0xA18DB90", VA = "0x18A18F190", Slot = "136")]
		public bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA18FE90", Offset = "0xA18E890", VA = "0x18A18FE90", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA1916B0", Offset = "0xA1900B0", VA = "0x18A1916B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA18EC00", Offset = "0xA18D600", VA = "0x18A18EC00")]
		private void KPIBPYDCJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA18CBA0", Offset = "0xA18B5A0", VA = "0x18A18CBA0")]
		private void CEOMOZKCYAX(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA18E0F0", Offset = "0xA18CAF0", VA = "0x18A18E0F0")]
		private void IVTCNAWLYJW(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA18F030", Offset = "0xA18DA30", VA = "0x18A18F030")]
		private void NAOUGKVUHQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA191350", Offset = "0xA18FD50", VA = "0x18A191350")]
		private void TFOUONISAES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA191800", Offset = "0xA190200", VA = "0x18A191800")]
		private void UINJWKWKBBS(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA18D080", Offset = "0xA18BA80", VA = "0x18A18D080")]
		private void DKDXBVHNABF(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA18FBD0", Offset = "0xA18E5D0", VA = "0x18A18FBD0")]
		private void OWYAIQTJUPV(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA18E460", Offset = "0xA18CE60", VA = "0x18A18E460")]
		private void JSAXISXCTEK(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA18F440", Offset = "0xA18DE40", VA = "0x18A18F440", Slot = "142")]
		protected virtual void OCMFTABHFID(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA191AC0", Offset = "0xA1904C0", VA = "0x18A191AC0")]
		protected void UYLFOOVTVJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA18D8C0", Offset = "0xA18C2C0", VA = "0x18A18D8C0")]
		protected void GDGQRXBRWAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA18C5D0", Offset = "0xA18AFD0", VA = "0x18A18C5D0")]
		private void AJUOJELOCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA18FCA0", Offset = "0xA18E6A0", VA = "0x18A18FCA0")]
		private void OYMRJVDQEZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class SNZABMYKHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3800", Offset = "0xA1A2200", VA = "0x18A1A3800")]
		public static XDKPDVFGOFK XLZMDEMKEMO(this XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3760", Offset = "0xA1A2160", VA = "0x18A1A3760")]
		public static bool HSQYCTJKTGV(this XDKPDVFGOFK a, XDKPDVFGOFK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA1A36C0", Offset = "0xA1A20C0", VA = "0x18A1A36C0")]
		public static bool EEJHOEYAGKP(this XDKPDVFGOFK a, XDKPDVFGOFK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3600", Offset = "0xA1A2000", VA = "0x18A1A3600")]
		public static QPQCJTUZEKK AVVDJHUUNRJ(this XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3650", Offset = "0xA1A2050", VA = "0x18A1A3650")]
		public static CGICJSTLYPF Base(this XDKPDVFGOFK impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DFACHIOZIBQ : GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA193DF0", Offset = "0xA1927F0", VA = "0x18A193DF0", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DFACHIOZIBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(GFSHHAICVPH), new string[] { })]
	public class ZYBLEOGPURV : GFSHHAICVPH, YWYIFNCKTFV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly GFSHHAICVPH EUBDSRTSPBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly GFSHHAICVPH CEHEDSLBLXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private QQNVIVNKCIN QEIIJOPYLYM;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A4DD0", Offset = "0xA1A37D0", VA = "0x18A1A4DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A49B0", Offset = "0xA1A33B0", VA = "0x18A1A49B0", Slot = "20")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5020", Offset = "0xA1A3A20", VA = "0x18A1A5020", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4C90", Offset = "0xA1A3690", VA = "0x18A1A4C90", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA1A47B0", Offset = "0xA1A31B0", VA = "0x18A1A47B0", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4A00", Offset = "0xA1A3400", VA = "0x18A1A4A00", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA1A50C0", Offset = "0xA1A3AC0", VA = "0x18A1A50C0", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4ED0", Offset = "0xA1A38D0", VA = "0x18A1A4ED0", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4D30", Offset = "0xA1A3730", VA = "0x18A1A4D30", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4B40", Offset = "0xA1A3540", VA = "0x18A1A4B40", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4E30", Offset = "0xA1A3830", VA = "0x18A1A4E30", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4AA0", Offset = "0xA1A34A0", VA = "0x18A1A4AA0", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4700", Offset = "0xA1A3100", VA = "0x18A1A4700")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4900", Offset = "0xA1A3300", VA = "0x18A1A4900")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4F70", Offset = "0xA1A3970", VA = "0x18A1A4F70")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4850", Offset = "0xA1A3250", VA = "0x18A1A4850")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4BE0", Offset = "0xA1A35E0", VA = "0x18A1A4BE0")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5160", Offset = "0xA1A3B60", VA = "0x18A1A5160", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA1A52B0", Offset = "0xA1A3CB0", VA = "0x18A1A52B0")]
		public ZYBLEOGPURV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4700", Offset = "0xA1A3100", VA = "0x18A1A4700", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4900", Offset = "0xA1A3300", VA = "0x18A1A4900", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4F70", Offset = "0xA1A3970", VA = "0x18A1A4F70", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4850", Offset = "0xA1A3250", VA = "0x18A1A4850", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4BE0", Offset = "0xA1A35E0", VA = "0x18A1A4BE0", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface UIXEWRGBGEN : OAZXDJYJUWI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BICMCWKPHLE(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EOMKGWFKIHD(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JRXRFQQIFMI(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OZVDCNYRLLH(XDKPDVFGOFK a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface TVTQXYYOBWS : WSBCCCPFUUH
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		TNYRCSLYBCO<XDKPDVFGOFK> YEVTMPZTTZX
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		XDKPDVFGOFK XJWLTUIIPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface AFNWSZNIONG : RESOWLLUWXN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) IBOQPRVOCKV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface WSTLQIGIDKG : FZPHAAVUQBZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView GTUIIBIREKS
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class VLWOMEVQZHN : LQSEGCRROWG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode CPAGSNZALGZ;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA199640", Offset = "0xA198040", VA = "0x18A199640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode KWWCQHRIDVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA1A3F10", Offset = "0xA1A2910", VA = "0x18A1A3F10", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA1A3A70", Offset = "0xA1A2470", VA = "0x18A1A3A70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA1998F0", Offset = "0xA1982F0", VA = "0x18A1998F0")]
		public VLWOMEVQZHN(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3AE0", Offset = "0xA1A24E0", VA = "0x18A1A3AE0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3C00", Offset = "0xA1A2600", VA = "0x18A1A3C00", Slot = "9")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3F00", Offset = "0xA1A2900", VA = "0x18A1A3F00", Slot = "7")]
		public void WSJWUHQEGGH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3BF0", Offset = "0xA1A25F0", VA = "0x18A1A3BF0", Slot = "8")]
		public void FKNGFDCVJRU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3C80", Offset = "0xA1A2680", VA = "0x18A1A3C80", Slot = "10")]
		public bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3DE0", Offset = "0xA1A27E0", VA = "0x18A1A3DE0")]
		private void QUJGTBBFEWN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class YGTHUFAPGBG : QBIGZYPSMTR, IDisposable, JRMZITKTWCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate WQTAGHHPQSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private PDFHAFPZZPA EXKSTGJEWZU;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A4480", Offset = "0xA1A2E80", VA = "0x18A1A4480", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A42E0", Offset = "0xA1A2CE0", VA = "0x18A1A42E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform PNBZSMYWYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A4460", Offset = "0xA1A2E60", VA = "0x18A1A4460", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA1A43B0", Offset = "0xA1A2DB0", VA = "0x18A1A43B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA1A45C0", Offset = "0xA1A2FC0", VA = "0x18A1A45C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4670", Offset = "0xA1A3070", VA = "0x18A1A4670")]
		public YGTHUFAPGBG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4020", Offset = "0xA1A2A20", VA = "0x18A1A4020", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4290", Offset = "0xA1A2C90", VA = "0x18A1A4290", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13DBF80", Offset = "0x13DA980", VA = "0x1813DBF80", Slot = "11")]
		private void GGIFVPNTPPY(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "12")]
		private void OHEWXGYBBJM(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DFACHIOZIBQ : GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA193B10", Offset = "0xA192510", VA = "0x18A193B10", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA193490", Offset = "0xA191E90", VA = "0x18A193490", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA192F20", Offset = "0xA191920", VA = "0x18A192F20", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA1931D0", Offset = "0xA191BD0", VA = "0x18A1931D0", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA193BF0", Offset = "0xA1925F0", VA = "0x18A193BF0", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA193930", Offset = "0xA192330", VA = "0x18A193930", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA1935A0", Offset = "0xA191FA0", VA = "0x18A1935A0", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA193300", Offset = "0xA191D00", VA = "0x18A193300", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA193870", Offset = "0xA192270", VA = "0x18A193870", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA193240", Offset = "0xA191C40", VA = "0x18A193240", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA192E00", Offset = "0xA191800", VA = "0x18A192E00")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA1936B0", Offset = "0xA1920B0", VA = "0x18A1936B0")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA1939F0", Offset = "0xA1923F0", VA = "0x18A1939F0")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA193040", Offset = "0xA191A40", VA = "0x18A193040")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA1933C0", Offset = "0xA191DC0", VA = "0x18A1933C0")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA193CB0", Offset = "0xA1926B0", VA = "0x18A193CB0", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DFACHIOZIBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA192E00", Offset = "0xA191800", VA = "0x18A192E00", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA1931C0", Offset = "0xA191BC0", VA = "0x18A1931C0", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA1939F0", Offset = "0xA1923F0", VA = "0x18A1939F0", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA193040", Offset = "0xA191A40", VA = "0x18A193040", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA1933C0", Offset = "0xA191DC0", VA = "0x18A1933C0", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class GNHCUSYRXYT : SXCVSPRDTLW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA199640", Offset = "0xA198040", VA = "0x18A199640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA198FB0", Offset = "0xA1979B0", VA = "0x18A198FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA198CF0", Offset = "0xA1976F0", VA = "0x18A198CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA198B30", Offset = "0xA197530", VA = "0x18A198B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA1998F0", Offset = "0xA1982F0", VA = "0x18A1998F0")]
		public GNHCUSYRXYT(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA199280", Offset = "0xA197C80", VA = "0x18A199280", Slot = "4")]
		public void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA1993E0", Offset = "0xA197DE0", VA = "0x18A1993E0")]
		private void SODXCECPSDU(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA199000", Offset = "0xA197A00", VA = "0x18A199000", Slot = "5")]
		public void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA198B90", Offset = "0xA197590", VA = "0x18A198B90", Slot = "6")]
		public void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA199690", Offset = "0xA198090", VA = "0x18A199690")]
		private void TENMJZHMANT(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA198D50", Offset = "0xA197750", VA = "0x18A198D50", Slot = "7")]
		public void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class UUSPXDRIPQG : NPQPCPZEPCZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool QCABZPGCPAC;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool VSFABRCABNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA1A38F0", Offset = "0xA1A22F0", VA = "0x18A1A38F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA1998F0", Offset = "0xA1982F0", VA = "0x18A1998F0")]
		public UUSPXDRIPQG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA1A38C0", Offset = "0xA1A22C0", VA = "0x18A1A38C0", Slot = "6")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3A00", Offset = "0xA1A2400", VA = "0x18A1A3A00", Slot = "7")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : UIXEWRGBGEN, OAZXDJYJUWI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly XDKPDVFGOFK SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<XDKPDVFGOFK> LJNSXJHVHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private XDKPDVFGOFK NEXPSVAOOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private XDKPDVFGOFK WKYFTFFHETD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform QQDXLOVDUAA;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA19C150", Offset = "0xA19AB50", VA = "0x18A19C150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA19C000", Offset = "0xA19AA00", VA = "0x18A19C000", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<XDKPDVFGOFK> UWJZIMKMPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA19D620", Offset = "0xA19C020", VA = "0x18A19D620", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA19C4C0", Offset = "0xA19AEC0", VA = "0x18A19C4C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA19C1B0", Offset = "0xA19ABB0", VA = "0x18A19C1B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA19BC90", Offset = "0xA19A690", VA = "0x18A19BC90", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction ILKEMHRFFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA19D060", Offset = "0xA19BA60", VA = "0x18A19D060", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA19C010", Offset = "0xA19AA10", VA = "0x18A19C010", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action UBNLFUZOTEC
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA19C890", Offset = "0xA19B290", VA = "0x18A19C890", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA19BD30", Offset = "0xA19A730", VA = "0x18A19BD30", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action JYMRFMLYEAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA19D6C0", Offset = "0xA19C0C0", VA = "0x18A19D6C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA19BA50", Offset = "0xA19A450", VA = "0x18A19BA50", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<XDKPDVFGOFK> WQRQGCTHDGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA19C560", Offset = "0xA19AF60", VA = "0x18A19C560", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA19BDD0", Offset = "0xA19A7D0", VA = "0x18A19BDD0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<XDKPDVFGOFK> JYSFKEUXZIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA19D1A0", Offset = "0xA19BBA0", VA = "0x18A19D1A0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA19D250", Offset = "0xA19BC50", VA = "0x18A19D250", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action UNXRNKLKGZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA19C0B0", Offset = "0xA19AAB0", VA = "0x18A19C0B0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA19C930", Offset = "0xA19B330", VA = "0x18A19C930", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<XDKPDVFGOFK> JJXZXBNRGGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA19BBE0", Offset = "0xA19A5E0", VA = "0x18A19BBE0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA19D430", Offset = "0xA19BE30", VA = "0x18A19D430", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA19D760", Offset = "0xA19C160", VA = "0x18A19D760")]
		public RbexHierarchy(XDKPDVFGOFK rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA19BE80", Offset = "0xA19A880", VA = "0x18A19BE80", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA19CAF0", Offset = "0xA19B4F0", VA = "0x18A19CAF0", Slot = "30")]
		public void SetParent(XDKPDVFGOFK newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA19C250", Offset = "0xA19AC50", VA = "0x18A19C250", Slot = "6")]
		public void JRXRFQQIFMI(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA19C610", Offset = "0xA19B010", VA = "0x18A19C610", Slot = "7")]
		public void OZVDCNYRLLH(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA19BAF0", Offset = "0xA19A4F0", VA = "0x18A19BAF0", Slot = "4")]
		public void BICMCWKPHLE(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA19BF20", Offset = "0xA19A920", VA = "0x18A19BF20", Slot = "5")]
		public void EOMKGWFKIHD(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA19D100", Offset = "0xA19BB00", VA = "0x18A19D100")]
		private void TKQXXGUKMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA19BFC0", Offset = "0xA19A9C0", VA = "0x18A19BFC0")]
		private void FYXIULZBBDJ(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA19D4E0", Offset = "0xA19BEE0", VA = "0x18A19D4E0")]
		private void XTQLZASGOZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA19D300", Offset = "0xA19BD00", VA = "0x18A19D300")]
		private void VFOXRYOXYHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA19C9D0", Offset = "0xA19B3D0", VA = "0x18A19C9D0")]
		private void SZWWATXVMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA19B990", Offset = "0xA19A390", VA = "0x18A19B990")]
		[CompilerGenerated]
		private object AJVQVWZUPCB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class CWBGXHNHPND
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA192D40", Offset = "0xA191740", VA = "0x18A192D40")]
		public static UIXEWRGBGEN EBHQKPMKXQA(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class FGWANOGIWVG : TVTQXYYOBWS, WSBCCCPFUUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly TNYRCSLYBCO<XDKPDVFGOFK> VQHNVAAVBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool XBJJOCERCQS;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public TNYRCSLYBCO<XDKPDVFGOFK> YEVTMPZTTZX
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA195B20", Offset = "0xA194520", VA = "0x18A195B20", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA1958B0", Offset = "0xA1942B0", VA = "0x18A1958B0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA195FC0", Offset = "0xA1949C0", VA = "0x18A195FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public XDKPDVFGOFK XJWLTUIIPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA195A70", Offset = "0xA194470", VA = "0x18A195A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1960B0", Offset = "0xA194AB0", VA = "0x18A1960B0")]
		public FGWANOGIWVG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA195F50", Offset = "0xA194950", VA = "0x18A195F50", Slot = "8")]
		public void WBLEKNPLYYY(XDKPDVFGOFK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA195EF0", Offset = "0xA1948F0", VA = "0x18A195EF0", Slot = "9")]
		public void SREKNKJLLPP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA195510", Offset = "0xA193F10", VA = "0x18A195510")]
		private Vector3 BNCTUNGUITO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA195B50", Offset = "0xA194550", VA = "0x18A195B50")]
		private void QSMTMRDSWGB(XDKPDVFGOFK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class HOOXGTZLJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA199BB0", Offset = "0xA1985B0", VA = "0x18A199BB0")]
		public static TVTQXYYOBWS EXNMBFCGZLV(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class GCFNIFCFGUS : AFNWSZNIONG, RESOWLLUWXN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 OSRCMBJTTGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 PAULDXCAQNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float TQWBWKTQQCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float SIVHJSWSRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 PIUUOJATRJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? NTTBJMCTPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? JGZHECCIWXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool HAAAJVZUWRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool OGRBZUVWEGG;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EF93A0", Offset = "0x1EF7DA0", VA = "0x181EF93A0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA1964E0", Offset = "0xA194EE0", VA = "0x18A1964E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA1988B0", Offset = "0xA1972B0", VA = "0x18A1988B0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD621A0", Offset = "0xD60BA0", VA = "0x180D621A0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA1978B0", Offset = "0xA1962B0", VA = "0x18A1978B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD621B0", Offset = "0xD60BB0", VA = "0x180D621B0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA197800", Offset = "0xA196200", VA = "0x18A197800", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA1979C0", Offset = "0xA1963C0", VA = "0x18A1979C0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA1983E0", Offset = "0xA196DE0", VA = "0x18A1983E0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA198560", Offset = "0xA196F60", VA = "0x18A198560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction SLRBIDUQSRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA196440", Offset = "0xA194E40", VA = "0x18A196440", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA196590", Offset = "0xA194F90", VA = "0x18A196590", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA1989D0", Offset = "0xA1973D0", VA = "0x18A1989D0")]
		public GCFNIFCFGUS(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA198790", Offset = "0xA197190", VA = "0x18A198790", Slot = "17")]
		public void XHZCAUKHNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA196630", Offset = "0xA195030", VA = "0x18A196630", Slot = "16")]
		public void GWJEKIVMKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA197720", Offset = "0xA196120", VA = "0x18A197720", Slot = "19")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1985B0", Offset = "0xA196FB0", VA = "0x18A1985B0", Slot = "20")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA197B50", Offset = "0xA196550", VA = "0x18A197B50", Slot = "18")]
		public void LOXIYFMFRJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA197CF0", Offset = "0xA1966F0", VA = "0x18A197CF0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA1964E0", Offset = "0xA194EE0", VA = "0x18A1964E0")]
		private void PEBNNAXGHQC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA196320", Offset = "0xA194D20", VA = "0x18A196320")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 BVXFBOOINWF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1978B0", Offset = "0xA1962B0", VA = "0x18A1978B0")]
		private void KFBNBRUEASP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA197800", Offset = "0xA196200", VA = "0x18A197800")]
		private void JOYOORZWWKU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA197580", Offset = "0xA195F80", VA = "0x18A197580")]
		private Vector3 ITLPUFRBFQW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1981B0", Offset = "0xA196BB0", VA = "0x18A1981B0", Slot = "15")]
		public void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1961A0", Offset = "0xA194BA0", VA = "0x18A1961A0")]
		private Quaternion AZLZXVPUBPW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA196710", Offset = "0xA195110", VA = "0x18A196710")]
		public void IBOQPRVOCKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1967E0", Offset = "0xA1951E0", VA = "0x18A1967E0", Slot = "4")]
		public (float, Vector3) IBOQPRVOCKV(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class NIZIDNBWXGQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA19B430", Offset = "0xA199E30", VA = "0x18A19B430")]
		public static AFNWSZNIONG KKICRCIZOJR(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class EGYZBKPYUEK : NPJQOEFKIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly CFODDVOSBJL LKGFQHAYKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode KUSSYZBSNOE;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool TLOVCHEVLGI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B8C190", Offset = "0x1B8AB90", VA = "0x181B8C190", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode FZKHSZNZYHI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA194490", Offset = "0xA192E90", VA = "0x18A194490")]
		public EGYZBKPYUEK(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA193E80", Offset = "0xA192880", VA = "0x18A193E80", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA193F90", Offset = "0xA192990", VA = "0x18A193F90")]
		private bool KCOMSPKZVUG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA194460", Offset = "0xA192E60", VA = "0x18A194460", Slot = "5")]
		public void ZQCENFLIOTY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA1942B0", Offset = "0xA192CB0", VA = "0x18A1942B0", Slot = "6")]
		public void WBSEVKPEKPT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA194140", Offset = "0xA192B40", VA = "0x18A194140", Slot = "9")]
		public void NFTOUJDAKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA194030", Offset = "0xA192A30", VA = "0x18A194030")]
		private void LTRULCROELU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA1942E0", Offset = "0xA192CE0", VA = "0x18A1942E0")]
		private void WNKAXFGJYKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA193F50", Offset = "0xA192950", VA = "0x18A193F50", Slot = "8")]
		public void FYVCDNBCFHO(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA194270", Offset = "0xA192C70", VA = "0x18A194270", Slot = "7")]
		public void QXMBABPCSHT(XDKPDVFGOFK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class SLBADPVUVEN : EVFGQKPYFLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly CFODDVOSBJL VTSKUEXHLTK;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA1A3380", Offset = "0xA1A1D80", VA = "0x18A1A3380", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction LJVLHYINPRI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA1A31C0", Offset = "0xA1A1BC0", VA = "0x18A1A31C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA1A30A0", Offset = "0xA1A1AA0", VA = "0x18A1A30A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA1A34B0", Offset = "0xA1A1EB0", VA = "0x18A1A34B0")]
		public SLBADPVUVEN(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA1A34A0", Offset = "0xA1A1EA0", VA = "0x18A1A34A0", Slot = "7")]
		public void WVSRRFVENQZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3370", Offset = "0xA1A1D70", VA = "0x18A1A3370", Slot = "8")]
		public void PWSJSLYVASG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3260", Offset = "0xA1A1C60", VA = "0x18A1A3260", Slot = "9")]
		public void PLORMZKPNME(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3430", Offset = "0xA1A1E30", VA = "0x18A1A3430", Slot = "12")]
		public void UBMBOMQJSHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3140", Offset = "0xA1A1B40", VA = "0x18A1A3140", Slot = "10")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3470", Offset = "0xA1A1E70", VA = "0x18A1A3470", Slot = "11")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class FANRVXYZOMY : WSTLQIGIDKG, FZPHAAVUQBZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<XDKPDVFGOFK> HGEOECXPIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView PEYTLAHKVZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool BIGWPVLURSH;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView GTUIIBIREKS
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA1946B0", Offset = "0xA1930B0", VA = "0x18A1946B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction XRUORDVSSXK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA194D70", Offset = "0xA193770", VA = "0x18A194D70", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA194CD0", Offset = "0xA1936D0", VA = "0x18A194CD0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA195370", Offset = "0xA193D70", VA = "0x18A195370")]
		public FANRVXYZOMY(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA194580", Offset = "0xA192F80", VA = "0x18A194580", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA1949A0", Offset = "0xA1933A0", VA = "0x18A1949A0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA194810", Offset = "0xA193210", VA = "0x18A194810", Slot = "10")]
		public void DKDXBVHNABF(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA194E10", Offset = "0xA193810", VA = "0x18A194E10", Slot = "11")]
		public void OWYAIQTJUPV(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA195200", Offset = "0xA193C00", VA = "0x18A195200")]
		private void YSFITUULUVL(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA1946C0", Offset = "0xA1930C0", VA = "0x18A1946C0")]
		private void DJWABVSWRKX(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA194F90", Offset = "0xA193990", VA = "0x18A194F90")]
		private void VZMMEXXLPCI(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class MRGOVTVGMFY
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA19A610", Offset = "0xA199010", VA = "0x18A19A610")]
		public static WSTLQIGIDKG Lifecycle(this XDKPDVFGOFK impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class GUGKEDRDNVQ : NGYLGUWSWCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints SPNQCTQRWGD;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xED9400", Offset = "0xED7E00", VA = "0x180ED9400", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool UTQCTIVQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xED9EA0", Offset = "0xED88A0", VA = "0x180ED9EA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xED9870", Offset = "0xED8270", VA = "0x180ED9870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints PLHIPBVAQGT
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1999B0", Offset = "0xA1983B0", VA = "0x18A1999B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA199B10", Offset = "0xA198510", VA = "0x18A199B10")]
		public GUGKEDRDNVQ(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA199980", Offset = "0xA198380", VA = "0x18A199980", Slot = "9")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA199AE0", Offset = "0xA1984E0", VA = "0x18A199AE0", Slot = "10")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class PQDJIMXZADD : LDPQNIZZQXG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly XDKPDVFGOFK SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float OYJMGFVZVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float SOFNTCVHTMH;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA19B610", Offset = "0xA19A010", VA = "0x18A19B610", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float PIQMEIKTJPR
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA19B4F0", Offset = "0xA199EF0", VA = "0x18A19B4F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA19B780", Offset = "0xA19A180", VA = "0x18A19B780")]
		public PQDJIMXZADD(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA19B5C0", Offset = "0xA199FC0", VA = "0x18A19B5C0", Slot = "8")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA19B6E0", Offset = "0xA19A0E0", VA = "0x18A19B6E0", Slot = "9")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class NIONFGFKOCL : JFLTWRSMKHO
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log XGXOPNOJKEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool ZLXHHBMETXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool MYTXODKUSSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int GNSFBIEDYUB;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA198560", Offset = "0xA196F60", VA = "0x18A198560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA19B130", Offset = "0xA199B30", VA = "0x18A19B130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA19A7A0", Offset = "0xA1991A0", VA = "0x18A19A7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA19A930", Offset = "0xA199330", VA = "0x18A19A930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction REUZHCXVZYM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA19AF00", Offset = "0xA199900", VA = "0x18A19AF00", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA19AAD0", Offset = "0xA1994D0", VA = "0x18A19AAD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA19B3A0", Offset = "0xA199DA0", VA = "0x18A19B3A0")]
		public NIONFGFKOCL(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA19A800", Offset = "0xA199200", VA = "0x18A19A800", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA19AAC0", Offset = "0xA1994C0", VA = "0x18A19AAC0", Slot = "8")]
		public void ODLGHJZSHAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA19B1C0", Offset = "0xA199BC0", VA = "0x18A19B1C0", Slot = "7")]
		public bool ZXQJNWFYETO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA19AD40", Offset = "0xA199740", VA = "0x18A19AD40", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA19A890", Offset = "0xA199290", VA = "0x18A19A890", Slot = "13")]
		public void DKZBOGCQDUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA19A990", Offset = "0xA199390", VA = "0x18A19A990", Slot = "12")]
		public void KBLCRAWEBAH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA19B150", Offset = "0xA199B50", VA = "0x18A19B150", Slot = "10")]
		public bool YEUOKZMPIEU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA19AE10", Offset = "0xA199810", VA = "0x18A19AE10", Slot = "11")]
		public bool TIAQGQSKQQZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA19AB70", Offset = "0xA199570", VA = "0x18A19AB70")]
		private bool RZZMFDQSDSX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA19AFA0", Offset = "0xA1999A0", VA = "0x18A19AFA0")]
		private void VCIIKVZMLAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class KVDNUQUVYQM : UFFXESXPRCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly CFODDVOSBJL RECXQFUTSZW;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA198CF0", Offset = "0xA1976F0", VA = "0x18A198CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool THMHIMFQJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B8C190", Offset = "0x1B8AB90", VA = "0x181B8C190", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA19A410", Offset = "0xA198E10", VA = "0x18A19A410")]
		public KVDNUQUVYQM(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA199C70", Offset = "0xA198670", VA = "0x18A199C70", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA19A040", Offset = "0xA198A40", VA = "0x18A19A040", Slot = "7")]
		public void HEJFIFOXNLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA19A070", Offset = "0xA198A70", VA = "0x18A19A070", Slot = "8")]
		public void PDQFADQHMKZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA199D10", Offset = "0xA198710", VA = "0x18A199D10", Slot = "9")]
		public void GIFZYXYUGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA19A0A0", Offset = "0xA198AA0", VA = "0x18A19A0A0", Slot = "10")]
		public void RVOLMTMFXHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA19A290", Offset = "0xA198C90", VA = "0x18A19A290", Slot = "11")]
		public void WUUCOHOVKYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class BWSZGSAMRVJ : YBVLSZTJXGO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CFODDVOSBJL TYEJUNLWXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float DSHCVNDGWOS;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA18C350", Offset = "0xA18AD50", VA = "0x18A18C350", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA18C1B0", Offset = "0xA18ABB0", VA = "0x18A18C1B0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA189D90", Offset = "0xA188790", VA = "0x18A189D90", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA18A840", Offset = "0xA189240", VA = "0x18A18A840", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA18B330", Offset = "0xA189D30", VA = "0x18A18B330", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA18BA70", Offset = "0xA18A470", VA = "0x18A18BA70", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA18AA00", Offset = "0xA189400", VA = "0x18A18AA00", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA18B980", Offset = "0xA18A380", VA = "0x18A18B980", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD777F0", Offset = "0xD761F0", VA = "0x180D777F0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA18B870", Offset = "0xA18A270", VA = "0x18A18B870", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2616FB0", Offset = "0x26159B0", VA = "0x182616FB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private SXCVSPRDTLW VIIEARTAJXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x96B7AD0", Offset = "0x96B64D0", VA = "0x1896B7AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA18C190", Offset = "0xA18AB90", VA = "0x18A18C190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA18C4A0", Offset = "0xA18AEA0", VA = "0x18A18C4A0")]
		public BWSZGSAMRVJ(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA189710", Offset = "0xA188110", VA = "0x18A189710", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA189C10", Offset = "0xA188610", VA = "0x18A189C10", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA18A870", Offset = "0xA189270", VA = "0x18A18A870", Slot = "28")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1931C70", Offset = "0x1930670", VA = "0x181931C70", Slot = "20")]
		public void CEQZQIBUQEC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1931800", Offset = "0x1930200", VA = "0x181931800", Slot = "30")]
		public void CPUBGBNQCWV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA18B150", Offset = "0xA189B50", VA = "0x18A18B150", Slot = "35")]
		public Vector3 OTBAGGXPLFQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA189A50", Offset = "0xA188450", VA = "0x18A189A50", Slot = "34")]
		public Vector3 BWKMVMIGISA(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA189710", Offset = "0xA188110", VA = "0x18A189710", Slot = "27")]
		public void TRLIIBNVRMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA18A9A0", Offset = "0xA1893A0", VA = "0x18A18A9A0", Slot = "25")]
		public void KONNPWBFTAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA18BA10", Offset = "0xA18A410", VA = "0x18A18BA10", Slot = "24")]
		public void SNEKHQMKOJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA18B630", Offset = "0xA18A030", VA = "0x18A18B630", Slot = "33")]
		public void RGRXZTJGEJD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA18B9B0", Offset = "0xA18A3B0", VA = "0x18A18B9B0", Slot = "32")]
		public void SEZPMDFOUBO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA18B490", Offset = "0xA189E90", VA = "0x18A18B490", Slot = "31")]
		public void PEVFMJBEDZD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA18BB30", Offset = "0xA18A530", VA = "0x18A18BB30", Slot = "22")]
		public void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA1897C0", Offset = "0xA1881C0", VA = "0x18A1897C0", Slot = "21")]
		public void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA18A040", Offset = "0xA188A40", VA = "0x18A18A040", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DE40", Offset = "0x1A8C840", VA = "0x181A8DE40")]
		private static void QDXVLIRARAB(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA18C270", Offset = "0xA18AC70", VA = "0x18A18C270", Slot = "29")]
		public Vector3 YIWWEIZGLWS(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA189EB0", Offset = "0xA1888B0", VA = "0x18A189EB0", Slot = "26")]
		public void FVYSROMJIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA18B870", Offset = "0xA18A270", VA = "0x18A18B870")]
		private void RHCYFADFAUM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA18AFB0", Offset = "0xA1899B0", VA = "0x18A18AFB0")]
		private void NRPOEHPZQFQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA189C70", Offset = "0xA188670", VA = "0x18A189C70")]
		private Vector3 EHIJOWFUQJX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA18A430", Offset = "0xA188E30", VA = "0x18A18A430")]
		private void HBRZFKUKOJL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA18A720", Offset = "0xA189120", VA = "0x18A18A720")]
		private Vector3 IDKSPSNPIXV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA18AB20", Offset = "0xA189520", VA = "0x18A18AB20")]
		private void LMFJTOJSFPN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void ROKTAZRVWQA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void WRQDNTKCQRA()
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
