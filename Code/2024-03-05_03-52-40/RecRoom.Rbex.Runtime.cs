using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OLOBACIMOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x664CB70", Offset = "0x664B970", VA = "0x18664CB70", Slot = "4")]
		public override void GGPDGFKFIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : HEIIAPOGIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private CACBPJDHPME bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private CACBPJDHPME bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6054060", Offset = "0x6052E60", VA = "0x186054060", Slot = "5")]
		public override void IOHBBJLNCOL(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6659740", Offset = "0x6658540", VA = "0x186659740")]
		private void HMJIDFNNBOP(IFDICCAMNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6659310", Offset = "0x6658110", VA = "0x186659310")]
		private void BPHMHHNNMHA(IFDICCAMNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66598B0", Offset = "0x66586B0", VA = "0x1866598B0", Slot = "6")]
		public override void HPFNHBNDOAM(IFDICCAMNBA registry, [In] DNHMIHMAKPA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "8")]
		public override void LGPDKPMBCMB(HAPHBLIKDOL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6659AA0", Offset = "0x66588A0", VA = "0x186659AA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MKODNDEIKFD(RigidbodyEx PGDMHBHGIEG);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GKPBHDNOMJP(RigidbodyEx PGDMHBHGIEG, bool LAELABDCPLH = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CJEDJIBDIOF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FGNKOEGLBDC
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ILFHCPDPFEL
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BBPMGFLEEOB(typeof(NIABABAMHNJ), new string[] { "Ignore", "Mock" })]
public class IJIIHDELOGI : NIABABAMHNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LOHAADEBLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80B180", Offset = "0x809F80", VA = "0x18080B180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
	public void PGAAKIGINAA(string JCNMJFGAPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
	public void HLPDJFFAAPE(RigidbodyEx DLFJFELKBNN, Action CJMBDOEJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "7")]
	public JLAGBLLOIFH BIHFOKBKKPG(int ANKOKIKKIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "8")]
	public void KJLOAJODMOB(Vector3 JDCFGEAILAB, float NEOCEPFHNGB, Color DNOKCMICDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IJIIHDELOGI()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly IIFCCHIKGII EKCAPLHKHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool KOJPHOHBNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private EKNGNBEELEM JLIBJBJNEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[BHDMMFNDOKI(HLOGMCICCDP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[BHDMMFNDOKI(HLOGMCICCDP.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private FGNKOEGLBDC physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal EKNGNBEELEM BLPIGAFJNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6655310", Offset = "0x6654110", VA = "0x186655310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> LHMFCJHGBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8B0", Offset = "0x7BA6B0", VA = "0x1807BB8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx LDIGLOGGNII
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66569F0", Offset = "0x66557F0", VA = "0x1866569F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IJIEPIJIKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6656950", Offset = "0x6655750", VA = "0x186656950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx FEOGIMKDFKL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6657610", Offset = "0x6656410", VA = "0x186657610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6658B90", Offset = "0x6657990", VA = "0x186658B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BALOCIJLCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E28D0", Offset = "0x7E16D0", VA = "0x1807E28D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NCADACFJJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7E28D0", Offset = "0x7E16D0", VA = "0x1807E28D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GKNACHBKKDC EHEKHKHMKJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6656710", Offset = "0x6655510", VA = "0x186656710")]
			get
			{
				return default(GKNACHBKKDC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6658340", Offset = "0x6657140", VA = "0x186658340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BNLBIHKDJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6656CA0", Offset = "0x6655AA0", VA = "0x186656CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BHJGGOILJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6656830", Offset = "0x6655630", VA = "0x186656830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IHLGIAOCIPD EMFLGKMMEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6656BE0", Offset = "0x66559E0", VA = "0x186656BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6658500", Offset = "0x6657300", VA = "0x186658500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CLIMPEFKHLB OHKPBGMCHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6656B80", Offset = "0x6655980", VA = "0x186656B80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6658490", Offset = "0x6657290", VA = "0x186658490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PIEDFPMOMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6656AD0", Offset = "0x66558D0", VA = "0x186656AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody ILLBONGHMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6656B30", Offset = "0x6655930", VA = "0x186656B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PNJKJBNLGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6656890", Offset = "0x6655690", VA = "0x186656890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x66583B0", Offset = "0x66571B0", VA = "0x1866583B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GNLAMCNAKCB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5E4AF90", Offset = "0x5E49D90", VA = "0x185E4AF90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A7A0", Offset = "0x5E495A0", VA = "0x185E4A7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float ILEFJDHNBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x66575B0", Offset = "0x66563B0", VA = "0x1866575B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ILCGOBBKFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6657550", Offset = "0x6656350", VA = "0x186657550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6658B20", Offset = "0x6657920", VA = "0x186658B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float FPONOBPJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6656F00", Offset = "0x6655D00", VA = "0x186656F00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x66587A0", Offset = "0x66575A0", VA = "0x1866587A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KBFMHMBPEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6656D00", Offset = "0x6655B00", VA = "0x186656D00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6658570", Offset = "0x6657370", VA = "0x186658570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DAMFNIJKBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6657B70", Offset = "0x6656970", VA = "0x186657B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66590F0", Offset = "0x6657EF0", VA = "0x1866590F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 MHEHOPBBDME
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6657330", Offset = "0x6656130", VA = "0x186657330")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x66588F0", Offset = "0x66576F0", VA = "0x1866588F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 JDCFGEAILAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6657CB0", Offset = "0x6656AB0", VA = "0x186657CB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OOHIKGJGDAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6656E40", Offset = "0x6655C40", VA = "0x186656E40")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66586C0", Offset = "0x66574C0", VA = "0x1866586C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PEENFABEOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x66568F0", Offset = "0x66556F0", VA = "0x1866568F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6658420", Offset = "0x6657220", VA = "0x186658420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints CPCGIPGIALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6656EA0", Offset = "0x6655CA0", VA = "0x186656EA0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6658730", Offset = "0x6657530", VA = "0x186658730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 COINIHLFCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x66576B0", Offset = "0x66564B0", VA = "0x1866576B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 IOJNPHLLKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x66576B0", Offset = "0x66564B0", VA = "0x1866576B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6658ED0", Offset = "0x6657CD0", VA = "0x186658ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LHLKKEFCLAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6657410", Offset = "0x6656210", VA = "0x186657410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x66589D0", Offset = "0x66577D0", VA = "0x1866589D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CACAABOCOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6657B10", Offset = "0x6656910", VA = "0x186657B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6659080", Offset = "0x6657E80", VA = "0x186659080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion NKFCCKNKLPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6657790", Offset = "0x6656590", VA = "0x186657790")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6658C50", Offset = "0x6657A50", VA = "0x186658C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion HLEBNEBJJHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6657A30", Offset = "0x6656830", VA = "0x186657A30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6658FB0", Offset = "0x6657DB0", VA = "0x186658FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 AIELDCKHCBG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6657870", Offset = "0x6656670", VA = "0x186657870")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6658D20", Offset = "0x6657B20", VA = "0x186658D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion EPHDIGHNPGL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6657950", Offset = "0x6656750", VA = "0x186657950")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6658E00", Offset = "0x6657C00", VA = "0x186658E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HEHJKNMAHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6657BD0", Offset = "0x66569D0", VA = "0x186657BD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6659160", Offset = "0x6657F60", VA = "0x186659160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 IBOFICAFDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6657470", Offset = "0x6656270", VA = "0x186657470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6658A40", Offset = "0x6657840", VA = "0x186658A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BCFCIEMLLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6656D60", Offset = "0x6655B60", VA = "0x186656D60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66585E0", Offset = "0x66573E0", VA = "0x1866585E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BBMLLNFGHID
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6657250", Offset = "0x6656050", VA = "0x186657250")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6658810", Offset = "0x6657610", VA = "0x186658810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IGGLLNEODMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6657110", Offset = "0x6655F10", VA = "0x186657110")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion OFOFMMKJPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6657030", Offset = "0x6655E30", VA = "0x186657030")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JLEPBAHIFLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6657E70", Offset = "0x6656C70", VA = "0x186657E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HEAKMEGCOHO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6657D90", Offset = "0x6656B90", VA = "0x186657D90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool AJNCKLAJJJP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66571F0", Offset = "0x6655FF0", VA = "0x1866571F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MFMIECDOBIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6656C40", Offset = "0x6655A40", VA = "0x186656C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JIMGHKOABOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66567D0", Offset = "0x66555D0", VA = "0x1866567D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MHNDGCMFIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6656770", Offset = "0x6655570", VA = "0x186656770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BLGHFJEJCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66566B0", Offset = "0x66554B0", VA = "0x1866566B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DKMKMPKPLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6656F60", Offset = "0x6655D60", VA = "0x186656F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AMNKABLPIGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x51E3920", Offset = "0x51E2720", VA = "0x1851E3920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MKODNDEIKFD LGJPFHJBOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66565D0", Offset = "0x66553D0", VA = "0x1866565D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6658260", Offset = "0x6657060", VA = "0x186658260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GKPBHDNOMJP FNPLKCHPCNO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6656560", Offset = "0x6655360", VA = "0x186656560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x66581F0", Offset = "0x6656FF0", VA = "0x1866581F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MKODNDEIKFD NLKOJAALPNB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66562C0", Offset = "0x66550C0", VA = "0x1866562C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6657F50", Offset = "0x6656D50", VA = "0x186657F50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MKODNDEIKFD KDKNBNIPDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6656330", Offset = "0x6655130", VA = "0x186656330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6657FC0", Offset = "0x6656DC0", VA = "0x186657FC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event MKODNDEIKFD ACIBABODEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6656480", Offset = "0x6655280", VA = "0x186656480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6658110", Offset = "0x6656F10", VA = "0x186658110")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6656410", Offset = "0x6655210", VA = "0x186656410")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66580A0", Offset = "0x6656EA0", VA = "0x1866580A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MKODNDEIKFD ENIBIGBPCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66564F0", Offset = "0x66552F0", VA = "0x1866564F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6658180", Offset = "0x6656F80", VA = "0x186658180")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MKODNDEIKFD DKKPJCJNOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6656640", Offset = "0x6655440", VA = "0x186656640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66582D0", Offset = "0x66570D0", VA = "0x1866582D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event MKODNDEIKFD JDMBMPLNABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x66563A0", Offset = "0x66551A0", VA = "0x1866563A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6658030", Offset = "0x6656E30", VA = "0x186658030")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		internal void ILHPIBPPLCH(EKNGNBEELEM EJHNGBHNBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6654F50", Offset = "0x6653D50", VA = "0x186654F50")]
		internal void HHENBPGPLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6655FE0", Offset = "0x6654DE0", VA = "0x186655FE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody MDFKLOIBCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6655CB0", Offset = "0x6654AB0", VA = "0x186655CB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) LOPDMLFNDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6654A80", Offset = "0x6653880", VA = "0x186654A80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6655310", Offset = "0x6654110", VA = "0x186655310")]
		private EKNGNBEELEM MOGKIJFHPDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6653DA0", Offset = "0x6652BA0", VA = "0x186653DA0")]
		private void AAEOMMPCBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6655480", Offset = "0x6654280", VA = "0x186655480")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6654F50", Offset = "0x6653D50", VA = "0x186654F50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6655420", Offset = "0x6654220", VA = "0x186655420")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66554E0", Offset = "0x66542E0", VA = "0x1866554E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6654130", Offset = "0x6652F30", VA = "0x186654130")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6655540", Offset = "0x6654340", VA = "0x186655540")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6654CD0", Offset = "0x6653AD0", VA = "0x186654CD0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66553C0", Offset = "0x66541C0", VA = "0x1866553C0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6655E10", Offset = "0x6654C10", VA = "0x186655E10")]
		public void SetParent(RigidbodyEx MAEBFBHFPDE, bool LAELABDCPLH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6655850", Offset = "0x6654650", VA = "0x186655850")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6654FE0", Offset = "0x6653DE0", VA = "0x186654FE0")]
		public bool IsRigidbodyAncestor(RigidbodyEx CJOKDMOFNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x66550C0", Offset = "0x6653EC0", VA = "0x1866550C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx BIGFEHDHJAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x66543A0", Offset = "0x66531A0", VA = "0x1866543A0")]
		public void AddInterpolationRestriction(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66555B0", Offset = "0x66543B0", VA = "0x1866555B0")]
		public void RemoveInterpolationRestriction(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6654AF0", Offset = "0x66538F0", VA = "0x186654AF0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6654410", Offset = "0x6653210", VA = "0x186654410")]
		public void AddKinematic(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6655620", Offset = "0x6654420", VA = "0x186655620")]
		public void RemoveKinematic(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6655D90", Offset = "0x6654B90", VA = "0x186655D90")]
		public void SetKinematic(object BNAJMHPOOCG, bool FBNCDEJLKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6655BB0", Offset = "0x66549B0", VA = "0x186655BB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 HCGFAHICBEM, Quaternion EIFHDMPFMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6655AB0", Offset = "0x66548B0", VA = "0x186655AB0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MHKDPJJENKK, Quaternion NHFABNFJDOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6654E40", Offset = "0x6653C40", VA = "0x186654E40")]
		public Vector3 GetConstrainedVelocity(Vector3 HEHJKNMAHHJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6654D30", Offset = "0x6653B30", VA = "0x186654D30")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BCFCIEMLLAJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66542B0", Offset = "0x66530B0", VA = "0x1866542B0")]
		public void AddForce(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66541A0", Offset = "0x6652FA0", VA = "0x1866541A0")]
		public void AddForceAtPosition(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66545E0", Offset = "0x66533E0", VA = "0x1866545E0")]
		public void AddTorque(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6654480", Offset = "0x6653280", VA = "0x186654480")]
		public void AddRelativeTorque(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66560B0", Offset = "0x6654EB0", VA = "0x1866560B0")]
		public Vector3 WorldToLocalVelocity(Vector3 AILJOHDBLOJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6655200", Offset = "0x6654000", VA = "0x186655200")]
		public Vector3 LocalToWorldVelocity(Vector3 IBOFICAFDGP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6654C70", Offset = "0x6653A70", VA = "0x186654C70")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6654C10", Offset = "0x6653A10", VA = "0x186654C10")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6654BB0", Offset = "0x66539B0", VA = "0x186654BB0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6654B50", Offset = "0x6653950", VA = "0x186654B50")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66559B0", Offset = "0x66547B0", VA = "0x1866559B0")]
		public void ResetVelocityWorldSpace(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66558B0", Offset = "0x66546B0", VA = "0x1866558B0")]
		public void ResetVelocityLocalSpace(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6655770", Offset = "0x6654570", VA = "0x186655770")]
		public void ResetLinearVelocityLocalSpace(Vector3 CCNMGEIHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6655F40", Offset = "0x6654D40", VA = "0x186655F40")]
		public bool SweepTest(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66551A0", Offset = "0x6653FA0", VA = "0x1866551A0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6655EE0", Offset = "0x6654CE0", VA = "0x186655EE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6656050", Offset = "0x6654E50", VA = "0x186656050")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6654570", Offset = "0x6653370", VA = "0x186654570")]
		public void AddShouldHaveUnityRigidbodyToken(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6655690", Offset = "0x6654490", VA = "0x186655690")]
		public void RemoveShouldHaveUnityRigidbodyToken(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6654910", Offset = "0x6653710", VA = "0x186654910")]
		public void ApplyForceVelocityChange(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6654870", Offset = "0x6653670", VA = "0x186654870")]
		public void ApplyAngularVelocityChange(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x66549D0", Offset = "0x66537D0", VA = "0x1866549D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x66547A0", Offset = "0x66535A0", VA = "0x1866547A0")]
		public bool AllowedScaleChange(float JMABOANLGPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x66546D0", Offset = "0x66534D0", VA = "0x1866546D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx JBNKFGBAEBL, object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6655700", Offset = "0x6654500", VA = "0x186655700")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6656250", Offset = "0x6655050", VA = "0x186656250")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class NKGMEPFMPGM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6652180", Offset = "0x6650F80", VA = "0x186652180")]
	public static EKNGNBEELEM BLPIGAFJNHA(this RigidbodyEx DLFJFELKBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NNOHFOFGAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody CEJHPNDBGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView ILHEGIMINLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 CLOIDDBPCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 CEPMDHGMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FGNKOEGLBDC FGCJPOAPAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool EANCHKKOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool EGDMMJODIII;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BBPMGFLEEOB(typeof(KNJKFALBANK), new string[] { })]
public class PNMBGGMCGMG : KNJKFALBANK, PKPNKDMNHCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KBFGGFOMOIA CLABDCIHJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NIABABAMHNJ GKPFGLIAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HMLJEHKIEJG PMBFJOKOBMB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NIABABAMHNJ NFONMFLKBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HMLJEHKIEJG PGCLJKONDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6653760", Offset = "0x6652560", VA = "0x186653760", Slot = "8")]
	public void InitReferences(IMCGAAIAFJE EKLNKMPEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66538C0", Offset = "0x66526C0", VA = "0x1866538C0", Slot = "6")]
	public EDLOHAABCGP LLPBHKPJOAM(RigidbodyEx DLFJFELKBNN)
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x66537F0", Offset = "0x66525F0", VA = "0x1866537F0")]
	private static EDLOHAABCGP LDFLGMCKJGC(RigidbodyEx DLFJFELKBNN)
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x66536C0", Offset = "0x66524C0", VA = "0x1866536C0", Slot = "7")]
	public EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PNMBGGMCGMG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static CGNODMPJOCB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IIFFECNGCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int KKDLEEGKNDG;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6653C00", Offset = "0x6652A00", VA = "0x186653C00")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6653C40", Offset = "0x6652A40", VA = "0x186653C40")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6653C20", Offset = "0x6652A20", VA = "0x186653C20")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LJCDGDONMLD, [Optional] UnityEngine.Object KMABAKEMFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LJCDGDONMLD, [Optional] UnityEngine.Object KMABAKEMFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6653D50", Offset = "0x6652B50", VA = "0x186653D50")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IJNEFGGFOIF
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6644940", Offset = "0x6643740", VA = "0x186644940")]
	public static void PIHIKPPEGLP(this Rigidbody MDFKLOIBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6644810", Offset = "0x6643610", VA = "0x186644810")]
	public static void PIHIKPPEGLP(this Rigidbody MDFKLOIBCGJ, Vector3 JJPHLHNNMDI, Quaternion OFOFMMKJPBA, Vector3 EDDBFEDFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xC7FF90", Offset = "0xC7ED90", VA = "0x180C7FF90")]
	public static void GJOGJJHHJPC(Vector3 HEHJKNMAHHJ, Vector3 BKELBBDDNIG, [Out] Vector3 EMNACDKGKMD, [Out] Vector3 CHDIACHAOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DCLFIDHLBIA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IFCIBGGKJIL : IHLGIAOCIPD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C9990", Offset = "0x7C8790", VA = "0x1807C9990", Slot = "4")]
		public Vector3 JJPDPBFPBIL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C9990", Offset = "0x7C8790", VA = "0x1807C9990", Slot = "5")]
		public Vector3 DMBGBPOBNKD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IFCIBGGKJIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static IHLGIAOCIPD BMKNDANDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6632620", Offset = "0x6631420", VA = "0x186632620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHJMPFEALEF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPAHPMMKDGO(bool AJNCKLAJJJP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICOMEJCLJBF(bool AJNCKLAJJJP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IMEFEPNFNJN : IDisposable, EMNKEBKLFCH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFJKDHNFJKM();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface HMLJEHKIEJG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNCIHMBDFJF MOFLCGGDKPK(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POCOHDNDLLG FEGIFHKELGB(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGCKALLEMHH CEAEFAAILEL(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCOKCPKDNKE NMHJGCJDFPP(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGAPMFLBKGG GHDDDHMBBOF(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMEFEPNFNJN AKOGHICPGOC(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PGJKKEBGPFO LNJFGEDJECL(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHAABNAFIMA FKMHLFALDPO(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NHJMPFEALEF LEHELPIFAFG(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OJIJDKGMOBN FANFNGELLNE(EKNGNBEELEM EJHNGBHNBFP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KFPEKBNCNGH BHBHEPIFGPL(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OIEEGPKJHPH GKJDMOMLAJH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DBMMHILOPGH KDLCIKOGHKF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DPHCAIJIIDN GFMMJIMNAAG(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IPFGDCNIMFJ FNMADPPCHNF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL, KNJKFALBANK LIDMLHOMNDK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AHAABNAFIMA
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OJIJDKGMOBN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJNEOJGOACH(Rigidbody CEJHPNDBGHF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LNCIHMBDFJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MKODNDEIKFD NLKOJAALPNB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MKODNDEIKFD KDKNBNIPDMD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GKPBHDNOMJP KHBDGEOPMKK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action DGCELBACGEA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action CDMCNIPOKDO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EKNGNBEELEM> AKINDBHKFON;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<EKNGNBEELEM> MKPGIMBBNKB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action NBBEFKICPIO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<EKNGNBEELEM> MLLFBILLLMG;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JAEGHPCAKDE(EKNGNBEELEM EIECDKIPGGN, bool LAELABDCPLH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FGCKALLEMHH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONNIDCOBFLO(EKNGNBEELEM FEOGIMKDFKL, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONIPFECGKGL(object BNAJMHPOOCG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DPHCAIJIIDN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MKODNDEIKFD PBKLPLHGAIP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LGGGGBCFCJO();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FMLLABBOOPP();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FKFIAJJNIOB();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IJNEOJGOACH(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFPHLLAPCHH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DBMMHILOPGH
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDHMINGNOPL(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMCEGGKJDPH(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNEDOMBKCKD(EKNGNBEELEM DLFJFELKBNN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLIIAPONACG(EKNGNBEELEM DLFJFELKBNN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJJAILNEGFP();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PGJKKEBGPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MKODNDEIKFD NCJKJKICPFD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEEOPEFCAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGHOOFFDJFI(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDKDBHMMJKH(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable OKBLANKECFG();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMCLMIODOFF(Rigidbody BNKGAHAACAL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IJNEOJGOACH(Rigidbody CEJHPNDBGHF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OIEEGPKJHPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MKODNDEIKFD JGPLFDNHEEK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMPHMEGJCIO(EKNGNBEELEM FEOGIMKDFKL);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKPOJPMLCGK(EKNGNBEELEM FEOGIMKDFKL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IPFGDCNIMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MDGPCKONMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IJNEOJGOACH(Rigidbody CEJHPNDBGHF);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CCOKCPKDNKE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJNEOJGOACH(Rigidbody CEJHPNDBGHF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NGEJAOJBNMA
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx ENABCPNCNIA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KGAPMFLBKGG
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event MKODNDEIKFD CLKLEMKDPED;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GELNOGMHIKN();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPCKMMJJKKJ();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IBLHLILINEH();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNDJMOGDHKH();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODPIPGKNKMC();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMAJCBAAIFC(bool GDPLLHKJJCM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KFPEKBNCNGH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool CLNFHKAFHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLKPLNMNING(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFPFGCEJILE(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOGLFJNJIMP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOLGKKKAAIC();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface POCOHDNDLLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HGLOCMLJLIH(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EJGNCMLPKCK();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NHOHNNKMDCO();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MOAGBAPFAID();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CPAKHEIBFJG();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MMCLMIODOFF(Rigidbody CEJHPNDBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 LGEANPJHOEE(Vector3 HEHJKNMAHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DNCHHEDCCIA(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PALENGMMLOH(Vector3 PKKBKANJNDI);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface NIABABAMHNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LOHAADEBLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGAAKIGINAA(string JCNMJFGAPPH);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLPDJFFAAPE(RigidbodyEx DLFJFELKBNN, Action CJMBDOEJJJI);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLAGBLLOIFH BIHFOKBKKPG(int ANKOKIKKIPG);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJLOAJODMOB(Vector3 JDCFGEAILAB, float NEOCEPFHNGB, Color DNOKCMICDIP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface KNJKFALBANK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NIABABAMHNJ NFONMFLKBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HMLJEHKIEJG PGCLJKONDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDLOHAABCGP LLPBHKPJOAM(RigidbodyEx DLFJFELKBNN);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CLIMPEFKHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPAKBGOGCBA(Vector3 ELFOELMDGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCBHEPPEMKJ(Vector3 BCFCIEMLLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLFFKGNMGGP(Vector3 ELFOELMDGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALLABPHLABK(Vector3 BCFCIEMLLAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IHLGIAOCIPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JJPDPBFPBIL();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DMBGBPOBNKD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EKNGNBEELEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx NHLFJPMHIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MHNDGCMFIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool BLGHFJEJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform NCADACFJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 FMPGPGNHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float ELCMGEHFOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float OJOPHILOEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion NAMNFFMILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool MFMIECDOBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event MKODNDEIKFD NLKOJAALPNB;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event MKODNDEIKFD KDKNBNIPDMD;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GKPBHDNOMJP KHBDGEOPMKK;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event MKODNDEIKFD JGPLFDNHEEK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event MKODNDEIKFD ACIBABODEMD;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event MKODNDEIKFD CLKLEMKDPED;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event MKODNDEIKFD NCJKJKICPFD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event MKODNDEIKFD JDMBMPLNABO;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void OJFJHCNMLCE();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void BGFBIMOBIKP();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void IBLHLILINEH();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void JAEGHPCAKDE(EKNGNBEELEM MAEBFBHFPDE, bool LAELABDCPLH = false);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void FOCCHACLHNK(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void MJHDJGGKBIE(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void CPAKHEIBFJG();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void NHOHNNKMDCO();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void EJGNCMLPKCK();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void PALENGMMLOH(Vector3 PKKBKANJNDI);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 LGEANPJHOEE(Vector3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 MLOEFPGGDFD(Vector3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MOAGBAPFAID();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void EKLPACMKGDA(EKNGNBEELEM JBNKFGBAEBL, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void FEJLNLBNNLH(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FMLLABBOOPP();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LGGGGBCFCJO();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FKFIAJJNIOB();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool GELNOGMHIKN();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void ODPIPGKNKMC();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable OKBLANKECFG();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IGHOOFFDJFI(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void NDKDBHMMJKH(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void IBDGJIMPHPN(Vector3 HCGFAHICBEM, Quaternion EIFHDMPFMIM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PJOCHMOADEM(Vector3 MHKDPJJENKK, Quaternion NHFABNFJDOF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool ILCLNNNCNBN(float JMABOANLGPK);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void HDNLFBILLAE(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NMHHEMEEGFF(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void BLKPLNMNING(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void JFPFGCEJILE(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LFPHLLAPCHH();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HFAPLIEMKLB : EKNGNBEELEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly KNJKFALBANK LIDMLHOMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal LNCIHMBDFJF ECOODAPNMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal DBMMHILOPGH FLHHOHILLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal OIEEGPKJHPH HKAKKBDPGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal POCOHDNDLLG HEHJKNMAHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal FGCKALLEMHH GKDDKBGDAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DPHCAIJIIDN FDLEIKBEDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CCOKCPKDNKE JKKCDAGOGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal OJIJDKGMOBN PLLBLMENJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal KGAPMFLBKGG OEPJCBALDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal IMEFEPNFNJN MGMBDNFEBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal PGJKKEBGPFO NIMFPIJDAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal AHAABNAFIMA CPEDIDFIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IPFGDCNIMFJ KOAAPNPCHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal KFPEKBNCNGH CEJHPNDBGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal NHJMPFEALEF ICNEAPBPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable LEJGCCENIGC;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx NHLFJPMHIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCD0", Offset = "0x7BEAD0", VA = "0x1807BFCD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB70", Offset = "0x7BE970", VA = "0x1807BFB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x862FB0", Offset = "0x861DB0", VA = "0x180862FB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8630D0", Offset = "0x861ED0", VA = "0x1808630D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x663DAB0", Offset = "0x663C8B0", VA = "0x18663DAB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x663FAD0", Offset = "0x663E8D0", VA = "0x18663FAD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x663FB80", Offset = "0x663E980", VA = "0x18663FB80", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6641DE0", Offset = "0x6640BE0", VA = "0x186641DE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x663E2E0", Offset = "0x663D0E0", VA = "0x18663E2E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x663F720", Offset = "0x663E520", VA = "0x18663F720", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x663F330", Offset = "0x663E130", VA = "0x18663F330", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6640F30", Offset = "0x663FD30", VA = "0x186640F30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x663D7F0", Offset = "0x663C5F0", VA = "0x18663D7F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x663E290", Offset = "0x663D090", VA = "0x18663E290", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6640ED0", Offset = "0x663FCD0", VA = "0x186640ED0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6641170", Offset = "0x663FF70", VA = "0x186641170", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x66404E0", Offset = "0x663F2E0", VA = "0x1866404E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6641120", Offset = "0x663FF20", VA = "0x186641120", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6640E70", Offset = "0x663FC70", VA = "0x186640E70", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6640D90", Offset = "0x663FB90", VA = "0x186640D90", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x66403F0", Offset = "0x663F1F0", VA = "0x1866403F0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x663EB30", Offset = "0x663D930", VA = "0x18663EB30", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x663F130", Offset = "0x663DF30", VA = "0x18663F130", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x663E540", Offset = "0x663D340", VA = "0x18663E540", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6641E40", Offset = "0x6640C40", VA = "0x186641E40", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6641810", Offset = "0x6640610", VA = "0x186641810", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x663EF80", Offset = "0x663DD80", VA = "0x18663EF80", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JIMGHKOABOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6641BC0", Offset = "0x66409C0", VA = "0x186641BC0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MHNDGCMFIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x663D690", Offset = "0x663C490", VA = "0x18663D690", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BLGHFJEJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x663DB40", Offset = "0x663C940", VA = "0x18663DB40", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6640540", Offset = "0x663F340", VA = "0x186640540", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x663F060", Offset = "0x663DE60", VA = "0x18663F060", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6640990", Offset = "0x663F790", VA = "0x186640990", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6640CB0", Offset = "0x663FAB0", VA = "0x186640CB0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x663FC30", Offset = "0x663EA30", VA = "0x18663FC30", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x663CF90", Offset = "0x663BD90", VA = "0x18663CF90", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6640050", Offset = "0x663EE50", VA = "0x186640050", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6642650", Offset = "0x6641450", VA = "0x186642650", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x66416E0", Offset = "0x66404E0", VA = "0x1866416E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x663FD70", Offset = "0x663EB70", VA = "0x18663FD70", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x663D1F0", Offset = "0x663BFF0", VA = "0x18663D1F0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x663D2C0", Offset = "0x663C0C0", VA = "0x18663D2C0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x663FBD0", Offset = "0x663E9D0", VA = "0x18663FBD0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x663F770", Offset = "0x663E570", VA = "0x18663F770", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x663E360", Offset = "0x663D160", VA = "0x18663E360", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x663D7A0", Offset = "0x663C5A0", VA = "0x18663D7A0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x66418F0", Offset = "0x66406F0", VA = "0x1866418F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6640940", Offset = "0x663F740", VA = "0x186640940", Slot = "48")]
		get
		{
			return default(BBFONOIEIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6642270", Offset = "0x6641070", VA = "0x186642270", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x663D310", Offset = "0x663C110", VA = "0x18663D310", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform NCADACFJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x66404D0", Offset = "0x663F2D0", VA = "0x1866404D0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 FMPGPGNHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x663EC60", Offset = "0x663DA60", VA = "0x18663EC60", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x663FA10", Offset = "0x663E810", VA = "0x18663FA10", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float ELCMGEHFOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6641DC0", Offset = "0x6640BC0", VA = "0x186641DC0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6641740", Offset = "0x6640540", VA = "0x186641740", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float OJOPHILOEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x663D920", Offset = "0x663C720", VA = "0x18663D920", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6641590", Offset = "0x6640390", VA = "0x186641590", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion NAMNFFMILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x66402F0", Offset = "0x663F0F0", VA = "0x1866402F0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x663DD60", Offset = "0x663CB60", VA = "0x18663DD60", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66403A0", Offset = "0x663F1A0", VA = "0x1866403A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x663CE90", Offset = "0x663BC90", VA = "0x18663CE90", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6640A70", Offset = "0x663F870", VA = "0x186640A70", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x66423E0", Offset = "0x66411E0", VA = "0x1866423E0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x663FF60", Offset = "0x663ED60", VA = "0x18663FF60", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x663D740", Offset = "0x663C540", VA = "0x18663D740", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x663C880", Offset = "0x663B680", VA = "0x18663C880", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x663EEC0", Offset = "0x663DCC0", VA = "0x18663EEC0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x663F5C0", Offset = "0x663E3C0", VA = "0x18663F5C0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x663C970", Offset = "0x663B770", VA = "0x18663C970", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool AMLCEMALNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x663CD50", Offset = "0x663BB50", VA = "0x18663CD50", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MFMIECDOBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x663D070", Offset = "0x663BE70", VA = "0x18663D070", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool HAEGEPLNPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x66408A0", Offset = "0x663F6A0", VA = "0x1866408A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool OLNIIHBIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x663E330", Offset = "0x663D130", VA = "0x18663E330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MKODNDEIKFD NLKOJAALPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6641530", Offset = "0x6640330", VA = "0x186641530", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6640F80", Offset = "0x663FD80", VA = "0x186640F80", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MKODNDEIKFD KDKNBNIPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6641B60", Offset = "0x6640960", VA = "0x186641B60", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6641B00", Offset = "0x6640900", VA = "0x186641B00", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GKPBHDNOMJP KHBDGEOPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x663DD00", Offset = "0x663CB00", VA = "0x18663DD00", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x663E480", Offset = "0x663D280", VA = "0x18663E480", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event MKODNDEIKFD JGPLFDNHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x663CCF0", Offset = "0x663BAF0", VA = "0x18663CCF0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x66405F0", Offset = "0x663F3F0", VA = "0x1866405F0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event MKODNDEIKFD ACIBABODEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x663E4E0", Offset = "0x663D2E0", VA = "0x18663E4E0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x663C820", Offset = "0x663B620", VA = "0x18663C820", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event MKODNDEIKFD CLKLEMKDPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6641D60", Offset = "0x6640B60", VA = "0x186641D60", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x663E720", Offset = "0x663D520", VA = "0x18663E720", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x663EF20", Offset = "0x663DD20", VA = "0x18663EF20", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6640590", Offset = "0x663F390", VA = "0x186640590", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event MKODNDEIKFD NCJKJKICPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x663EAD0", Offset = "0x663D8D0", VA = "0x18663EAD0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6640AB0", Offset = "0x663F8B0", VA = "0x186640AB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event MKODNDEIKFD JDMBMPLNABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x663EDC0", Offset = "0x663DBC0", VA = "0x18663EDC0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6642000", Offset = "0x6640E00", VA = "0x186642000", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x66387E0", Offset = "0x66375E0", VA = "0x1866387E0")]
	public HFAPLIEMKLB(GameObject EAPMMKKAJGJ, RigidbodyEx NGKHKGGOJGN, KNJKFALBANK LIDMLHOMNDK, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x663E7E0", Offset = "0x663D5E0", VA = "0x18663E7E0", Slot = "135")]
	protected virtual void FENNHPNEJJO(KNJKFALBANK LIDMLHOMNDK, NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x663DE50", Offset = "0x663CC50", VA = "0x18663DE50", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x663F390", Offset = "0x663E190", VA = "0x18663F390", Slot = "71")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x663D6F0", Offset = "0x663C4F0", VA = "0x18663D6F0", Slot = "72")]
	public void OJFJHCNMLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x663D360", Offset = "0x663C160", VA = "0x18663D360", Slot = "73")]
	public void BGFBIMOBIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6641950", Offset = "0x6640750", VA = "0x186641950")]
	private void OANLENBHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x663FEF0", Offset = "0x663ECF0", VA = "0x18663FEF0", Slot = "81")]
	public void JAEGHPCAKDE(EKNGNBEELEM MAEBFBHFPDE, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x663ED60", Offset = "0x663DB60", VA = "0x18663ED60", Slot = "84")]
	public void FOCCHACLHNK(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6640FE0", Offset = "0x663FDE0", VA = "0x186640FE0", Slot = "85")]
	public void MJHDJGGKBIE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x663E620", Offset = "0x663D420", VA = "0x18663E620", Slot = "86")]
	public Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6641C10", Offset = "0x6640A10", VA = "0x186641C10", Slot = "87")]
	public Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x663D6F0", Offset = "0x663C4F0", VA = "0x18663D6F0", Slot = "88")]
	public void CPAKHEIBFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6641690", Offset = "0x6640490", VA = "0x186641690", Slot = "89")]
	public void NHOHNNKMDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x663E3C0", Offset = "0x663D1C0", VA = "0x18663E3C0", Slot = "90")]
	public void EJGNCMLPKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x66413E0", Offset = "0x66401E0", VA = "0x1866413E0", Slot = "91")]
	public void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x663F4D0", Offset = "0x663E2D0", VA = "0x18663F4D0", Slot = "92")]
	public void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6641F20", Offset = "0x6640D20", VA = "0x186641F20", Slot = "93")]
	public void PALENGMMLOH(Vector3 PKKBKANJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x663F210", Offset = "0x663E010", VA = "0x18663F210", Slot = "94")]
	public void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x663C8D0", Offset = "0x663B6D0", VA = "0x18663C8D0", Slot = "95")]
	public void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6641A00", Offset = "0x6640800", VA = "0x186641A00", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6640B60", Offset = "0x663F960", VA = "0x186640B60", Slot = "97")]
	public Vector3 LGEANPJHOEE(Vector3 MAEBFBHFPDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x66411C0", Offset = "0x663FFC0", VA = "0x1866411C0", Slot = "98")]
	public Vector3 MLOEFPGGDFD(Vector3 MAEBFBHFPDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6641390", Offset = "0x6640190", VA = "0x186641390", Slot = "99")]
	public void MOAGBAPFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x663E410", Offset = "0x663D210", VA = "0x18663E410", Slot = "100")]
	public void EKLPACMKGDA(EKNGNBEELEM JBNKFGBAEBL, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x663E780", Offset = "0x663D580", VA = "0x18663E780", Slot = "101")]
	public void FEJLNLBNNLH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x663D5B0", Offset = "0x663C3B0", VA = "0x18663D5B0", Slot = "41")]
	public void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x663ED10", Offset = "0x663DB10", VA = "0x18663ED10", Slot = "104")]
	public void FMLLABBOOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6640C60", Offset = "0x663FA60", VA = "0x186640C60", Slot = "105")]
	public void LGGGGBCFCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x663EC10", Offset = "0x663DA10", VA = "0x18663EC10", Slot = "106")]
	public void FKFIAJJNIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x663EE70", Offset = "0x663DC70", VA = "0x18663EE70", Slot = "109")]
	public bool GELNOGMHIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x663F9C0", Offset = "0x663E7C0", VA = "0x18663F9C0", Slot = "74")]
	public void IBLHLILINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6641AB0", Offset = "0x66408B0", VA = "0x186641AB0", Slot = "110")]
	public void ODPIPGKNKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6641D10", Offset = "0x6640B10", VA = "0x186641D10", Slot = "115")]
	public IDisposable OKBLANKECFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x663FB20", Offset = "0x663E920", VA = "0x18663FB20", Slot = "116")]
	public void IGHOOFFDJFI(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x66414D0", Offset = "0x66402D0", VA = "0x1866414D0", Slot = "117")]
	public void NDKDBHMMJKH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6640650", Offset = "0x663F450", VA = "0x186640650", Slot = "118")]
	public void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x663F7C0", Offset = "0x663E5C0", VA = "0x18663F7C0", Slot = "121")]
	public void IBDGJIMPHPN(Vector3 HCGFAHICBEM, Quaternion EIFHDMPFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6642420", Offset = "0x6641220", VA = "0x186642420", Slot = "122")]
	public void PJOCHMOADEM(Vector3 MHKDPJJENKK, Quaternion NHFABNFJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x663FD10", Offset = "0x663EB10", VA = "0x18663FD10", Slot = "123")]
	public bool ILCLNNNCNBN(float JMABOANLGPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x663F2D0", Offset = "0x663E0D0", VA = "0x18663F2D0", Slot = "124")]
	public void HDNLFBILLAE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x66417B0", Offset = "0x66405B0", VA = "0x1866417B0", Slot = "125")]
	public void NMHHEMEEGFF(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x663D450", Offset = "0x663C250", VA = "0x18663D450", Slot = "126")]
	public void BLKPLNMNING(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x66400A0", Offset = "0x663EEA0", VA = "0x1866400A0", Slot = "127")]
	public void JFPFGCEJILE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6641040", Offset = "0x663FE40", VA = "0x186641040", Slot = "128")]
	public void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x66422D0", Offset = "0x66410D0", VA = "0x1866422D0", Slot = "129")]
	public void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6642570", Offset = "0x6641370", VA = "0x186642570", Slot = "130")]
	public void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x663D840", Offset = "0x663C640", VA = "0x18663D840", Slot = "131")]
	public void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x663FFB0", Offset = "0x663EDB0", VA = "0x18663FFB0", Slot = "132")]
	public bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6640B10", Offset = "0x663F910", VA = "0x186640B10", Slot = "133")]
	public void LFPHLLAPCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x66426A0", Offset = "0x66414A0", VA = "0x1866426A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x663DC20", Offset = "0x663CA20", VA = "0x18663DC20")]
	private void DOGCBIPFJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x663F610", Offset = "0x663E410", VA = "0x18663F610")]
	private void HLANGGCGHIB(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6640100", Offset = "0x663EF00", VA = "0x186640100")]
	private void JHEOOKGPMEG(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x663CEE0", Offset = "0x663BCE0", VA = "0x18663CEE0")]
	private void AODMNACEKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x663D4B0", Offset = "0x663C2B0", VA = "0x18663D4B0")]
	private void CADCBEGKKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x66406C0", Offset = "0x663F4C0", VA = "0x1866406C0")]
	private void KPKICFAKODM(EKNGNBEELEM CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x66412C0", Offset = "0x66400C0", VA = "0x1866412C0")]
	private void MMPHMEGJCIO(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x663D380", Offset = "0x663C180", VA = "0x18663D380")]
	private void BKPOJPMLCGK(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x663D940", Offset = "0x663C740", VA = "0x18663D940")]
	private void DLAGAGOAOHP(RigidbodyEx FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x66420B0", Offset = "0x6640EB0", VA = "0x1866420B0", Slot = "140")]
	protected virtual void PFOECPCOFBM(RigidbodyEx DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x663C9D0", Offset = "0x663B7D0", VA = "0x18663C9D0")]
	protected void AKLPMAEHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x663DF20", Offset = "0x663CD20", VA = "0x18663DF20")]
	protected void EACLNHAPFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x663FE50", Offset = "0x663EC50", VA = "0x18663FE50", Slot = "141")]
	protected virtual IDisposable IPDIALDJNKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BHFDCMCHJPK
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6630160", Offset = "0x662EF60", VA = "0x186630160")]
	public static EKNGNBEELEM NPIHAMKKCHL(this EKNGNBEELEM DLFJFELKBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6630090", Offset = "0x662EE90", VA = "0x186630090")]
	public static bool MMKAPELEBME(this EKNGNBEELEM DLFJFELKBNN, EKNGNBEELEM CJOKDMOFNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6630210", Offset = "0x662F010", VA = "0x186630210")]
	public static bool OKOIKJFNAJE(this EKNGNBEELEM DLFJFELKBNN, EKNGNBEELEM BIGFEHDHJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6630110", Offset = "0x662EF10", VA = "0x186630110")]
	public static RigidbodyEx NHLFJPMHIMJ(this EKNGNBEELEM BLPIGAFJNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6630010", Offset = "0x662EE10", VA = "0x186630010")]
	public static HFAPLIEMKLB CGJIEJGLGFM(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class CGFMNONIIFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool OFJKLDDBIOI;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6632300", Offset = "0x6631100", VA = "0x186632300")]
	public CGFMNONIIFG(HFAPLIEMKLB HLPGBAHMLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x66322A0", Offset = "0x66310A0", VA = "0x1866322A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class EKLAHCMHPMH : MDFDBNIIINK, NHJMPFEALEF
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode MAAAMFAFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6633650", Offset = "0x6632450", VA = "0x186633650")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6633B50", Offset = "0x6632950", VA = "0x186633B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x66338D0", Offset = "0x66326D0", VA = "0x1866338D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x66336B0", Offset = "0x66324B0", VA = "0x1866336B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public EKLAHCMHPMH(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6633780", Offset = "0x6632580", VA = "0x186633780", Slot = "6")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6633D30", Offset = "0x6632B30", VA = "0x186633D30", Slot = "9")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6633770", Offset = "0x6632570", VA = "0x186633770", Slot = "7")]
	public void DPAHPMMKDGO(bool AJNCKLAJJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x66339E0", Offset = "0x66327E0", VA = "0x1866339E0", Slot = "8")]
	public void ICOMEJCLJBF(bool AJNCKLAJJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66339F0", Offset = "0x66327F0", VA = "0x1866339F0", Slot = "10")]
	public bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6633BC0", Offset = "0x66329C0", VA = "0x186633BC0")]
	private void LHMHPGMLEEF(bool AJNCKLAJJJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BLPHPEMELGH : MDFDBNIIINK, IMEFEPNFNJN, IDisposable, EMNKEBKLFCH
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BBFONOIEIIB HMAAAPJNAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6631260", Offset = "0x6630060", VA = "0x186631260")]
		get
		{
			return default(BBFONOIEIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x66315F0", Offset = "0x66303F0", VA = "0x1866315F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x66313F0", Offset = "0x66301F0", VA = "0x1866313F0", Slot = "6")]
		get
		{
			return default(BBFONOIEIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x66315F0", Offset = "0x66303F0", VA = "0x1866315F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform DDJNMOCGHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x66311B0", Offset = "0x662FFB0", VA = "0x1866311B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6631340", Offset = "0x6630140", VA = "0x186631340", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public BLPHPEMELGH(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x66316E0", Offset = "0x66304E0", VA = "0x1866316E0", Slot = "11")]
	public void OnChangedDistanceBand(IMIGBJOIFIN ILMCAINDAOO, IMIGBJOIFIN JCLDAPCPAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "12")]
	public void OnChangedVisibility(bool EEPDJDHMPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "8")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class BIKMHGOKDOM : MDFDBNIIINK, AHAABNAFIMA
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6630290", Offset = "0x662F090", VA = "0x186630290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x66307A0", Offset = "0x662F5A0", VA = "0x1866307A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6630850", Offset = "0x662F650", VA = "0x186630850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public BIKMHGOKDOM(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6630990", Offset = "0x662F790", VA = "0x186630990", Slot = "4")]
	public void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6630AF0", Offset = "0x662F8F0", VA = "0x186630AF0")]
	private void NACEJLKHKAD(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6630DD0", Offset = "0x662FBD0", VA = "0x186630DD0", Slot = "5")]
	public void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6631050", Offset = "0x662FE50", VA = "0x186631050", Slot = "6")]
	public void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x66302E0", Offset = "0x662F0E0", VA = "0x1866302E0")]
	private void DDPHPAEGJAK(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6630540", Offset = "0x662F340", VA = "0x186630540", Slot = "7")]
	public void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x66308B0", Offset = "0x662F6B0", VA = "0x1866308B0")]
	private void INBEFCGIFMO(string LJCDGDONMLD, UnityEngine.Object KMABAKEMFMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class KDDOLKNBEDE : MDFDBNIIINK, OJIJDKGMOBN
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6648A00", Offset = "0x6647800", VA = "0x186648A00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6648AF0", Offset = "0x66478F0", VA = "0x186648AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public KDDOLKNBEDE(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6648A60", Offset = "0x6647860", VA = "0x186648A60", Slot = "6")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6632380", Offset = "0x6631180", VA = "0x186632380", Slot = "7")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class KLKIPPOIDAG : MDFDBNIIINK, LNCIHMBDFJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly IIFCCHIKGII DDKEDFBBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly LFLKKOOONFC LIGNOCDLIIG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x664A6A0", Offset = "0x66494A0", VA = "0x18664A6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public EDLOHAABCGP HIOBKEGHEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x664A3F0", Offset = "0x66491F0", VA = "0x18664A3F0")]
		get
		{
			return default(EDLOHAABCGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x664AE90", Offset = "0x6649C90", VA = "0x18664AE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x664AE20", Offset = "0x6649C20", VA = "0x18664AE20", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x664B850", Offset = "0x664A650", VA = "0x18664B850", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public EDLOHAABCGP DAMJBGDCJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x664AF00", Offset = "0x6649D00", VA = "0x18664AF00")]
		get
		{
			return default(EDLOHAABCGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x664B8C0", Offset = "0x664A6C0", VA = "0x18664B8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x664ADB0", Offset = "0x6649BB0", VA = "0x18664ADB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8B0", Offset = "0x7BA6B0", VA = "0x1807BB8B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MKODNDEIKFD NLKOJAALPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x664B310", Offset = "0x664A110", VA = "0x18664B310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x664B270", Offset = "0x664A070", VA = "0x18664B270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MKODNDEIKFD KDKNBNIPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x664B700", Offset = "0x664A500", VA = "0x18664B700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x664B460", Offset = "0x664A260", VA = "0x18664B460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GKPBHDNOMJP KHBDGEOPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x664A6D0", Offset = "0x66494D0", VA = "0x18664A6D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x664A8A0", Offset = "0x66496A0", VA = "0x18664A8A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action DGCELBACGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6649CD0", Offset = "0x6648AD0", VA = "0x186649CD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x664AD10", Offset = "0x6649B10", VA = "0x18664AD10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action CDMCNIPOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x664AA90", Offset = "0x6649890", VA = "0x18664AA90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6649B80", Offset = "0x6648980", VA = "0x186649B80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<EKNGNBEELEM> AKINDBHKFON
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x664A9E0", Offset = "0x66497E0", VA = "0x18664A9E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6649D70", Offset = "0x6648B70", VA = "0x186649D70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<EKNGNBEELEM> MKPGIMBBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x664B7A0", Offset = "0x664A5A0", VA = "0x18664B7A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x664B0D0", Offset = "0x6649ED0", VA = "0x18664B0D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action NBBEFKICPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x664B930", Offset = "0x664A730", VA = "0x18664B930", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x664A2A0", Offset = "0x66490A0", VA = "0x18664A2A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<EKNGNBEELEM> MLLFBILLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x664B3B0", Offset = "0x664A1B0", VA = "0x18664B3B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x664A340", Offset = "0x6649140", VA = "0x18664A340", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x664BA60", Offset = "0x664A860", VA = "0x18664BA60")]
	public KLKIPPOIDAG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x664A770", Offset = "0x6649570", VA = "0x18664A770", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x664AFB0", Offset = "0x6649DB0", VA = "0x18664AFB0", Slot = "26")]
	public void JAEGHPCAKDE(EKNGNBEELEM EIECDKIPGGN, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x664AF60", Offset = "0x6649D60", VA = "0x18664AF60")]
	private void JAEGHPCAKDE(HBFKBFMEJII EIECDKIPGGN, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6649E20", Offset = "0x6648C20", VA = "0x186649E20")]
	private void BKBKJCLNFEL(HBFKBFMEJII EIECDKIPGGN, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x664A450", Offset = "0x6649250", VA = "0x18664A450")]
	private void CHEPJKHPLDP(HBFKBFMEJII CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x664B500", Offset = "0x664A300", VA = "0x18664B500")]
	private void OINOFALIPJA(HBFKBFMEJII CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x664AB30", Offset = "0x6649930", VA = "0x18664AB30")]
	private void GIJCLGMCNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6649C20", Offset = "0x6648A20", VA = "0x186649C20")]
	private void ABPBFPBAJPM(HBFKBFMEJII CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x664B180", Offset = "0x6649F80", VA = "0x18664B180")]
	private void LKGFKALJPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x664B030", Offset = "0x6649E30", VA = "0x18664B030")]
	private void JLFICOCDFDA(HBFKBFMEJII DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x664A940", Offset = "0x6649740", VA = "0x18664A940")]
	private void FEONMMPMKDG(HBFKBFMEJII DLFJFELKBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LIFAIBFGBCP
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x664CAE0", Offset = "0x664B8E0", VA = "0x18664CAE0")]
	public static KLKIPPOIDAG PDPEJBHJGKB(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class HKFDPDBCKEL : MDFDBNIIINK, FGCKALLEMHH
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6642D40", Offset = "0x6641B40", VA = "0x186642D40", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6642D70", Offset = "0x6641B70", VA = "0x186642D70", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6642AF0", Offset = "0x66418F0", VA = "0x186642AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private EKNGNBEELEM FJBDHKDGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6642BE0", Offset = "0x66419E0", VA = "0x186642BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public HKFDPDBCKEL(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6643120", Offset = "0x6641F20", VA = "0x186643120", Slot = "6")]
	public void ONNIDCOBFLO(EKNGNBEELEM FEOGIMKDFKL, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6643010", Offset = "0x6641E10", VA = "0x186643010")]
	private void ONNIDCOBFLO(HBFKBFMEJII FEOGIMKDFKL, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6642FA0", Offset = "0x6641DA0", VA = "0x186642FA0", Slot = "7")]
	public void ONIPFECGKGL(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x66426E0", Offset = "0x66414E0", VA = "0x1866426E0")]
	private Vector3 ANHEKOOMCDF()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class BFFBDINGJAA
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x662FF80", Offset = "0x662ED80", VA = "0x18662FF80")]
	public static HKFDPDBCKEL ENDCBOOEPKJ(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HBPBHMJIPMB : MDFDBNIIINK, DPHCAIJIIDN
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x663BB00", Offset = "0x663A900", VA = "0x18663BB00", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x663AA80", Offset = "0x6639880", VA = "0x18663AA80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 AOINMDOLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6638AD0", Offset = "0x66378D0", VA = "0x186638AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 EPHJPHNAPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x663B9D0", Offset = "0x663A7D0", VA = "0x18663B9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x66388B0", Offset = "0x66376B0", VA = "0x1866388B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x663B020", Offset = "0x6639E20", VA = "0x18663B020", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float GDOOJCIFOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x663BCC0", Offset = "0x663AAC0", VA = "0x18663BCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x663BF20", Offset = "0x663AD20", VA = "0x18663BF20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x6638E10", Offset = "0x6637C10", VA = "0x186638E10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x663AFF0", Offset = "0x6639DF0", VA = "0x18663AFF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6638AA0", Offset = "0x66378A0", VA = "0x186638AA0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event MKODNDEIKFD PBKLPLHGAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x66391B0", Offset = "0x6637FB0", VA = "0x1866391B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6638ED0", Offset = "0x6637CD0", VA = "0x186638ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x663BF80", Offset = "0x663AD80", VA = "0x18663BF80")]
	public HBPBHMJIPMB(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x663A960", Offset = "0x6639760", VA = "0x18663A960")]
	public float3 IGPHJPACFFC()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6638B80", Offset = "0x6637980", VA = "0x186638B80", Slot = "14")]
	public void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x66392B0", Offset = "0x66380B0", VA = "0x1866392B0", Slot = "16")]
	public void FMLLABBOOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x663B680", Offset = "0x663A480", VA = "0x18663B680", Slot = "15")]
	public void LGGGGBCFCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x663BBB0", Offset = "0x663A9B0", VA = "0x18663BBB0", Slot = "18")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x663AC00", Offset = "0x6639A00", VA = "0x18663AC00", Slot = "19")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6639250", Offset = "0x6638050", VA = "0x186639250", Slot = "17")]
	public void FKFIAJJNIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x663B080", Offset = "0x6639E80", VA = "0x18663B080", Slot = "20")]
	public void LFPHLLAPCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x663BC80", Offset = "0x663AA80", VA = "0x18663BC80")]
	public void MPBBBHOLFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x663AA80", Offset = "0x6639880", VA = "0x18663AA80")]
	private void NJPGLJENNJL(Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x663BD40", Offset = "0x663AB40", VA = "0x18663BD40")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 NMGOCBHIPGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6638E10", Offset = "0x6637C10", VA = "0x186638E10")]
	private void CDPGMHEHDAO(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x663A700", Offset = "0x6639500", VA = "0x18663A700")]
	private Vector3 HABCKBGOIPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6638F70", Offset = "0x6637D70", VA = "0x186638F70")]
	private Quaternion DJHONDCLONF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x66394A0", Offset = "0x66382A0", VA = "0x1866394A0")]
	internal (float, Vector3) GPDOAPNPIAC(Rigidbody DOBLLGCNKOP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class FGNCFLGKJGH
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6633F20", Offset = "0x6632D20", VA = "0x186633F20")]
	public static HBPBHMJIPMB FNOJCLHJNJL(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GHGPAIBPNOA : MDFDBNIIINK, DBMMHILOPGH
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool ENMGLIPEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6635700", Offset = "0x6634500", VA = "0x186635700", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JDKPCKNKNHD FNJBAIPLHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6635760", Offset = "0x6634560", VA = "0x186635760", Slot = "11")]
		get
		{
			return default(JDKPCKNKNHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private JDKPCKNKNHD MNEHIOHOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6635760", Offset = "0x6634560", VA = "0x186635760")]
		get
		{
			return default(JDKPCKNKNHD);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6635690", Offset = "0x6634490", VA = "0x186635690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6635C40", Offset = "0x6634A40", VA = "0x186635C40")]
	public GHGPAIBPNOA(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6635510", Offset = "0x6634310", VA = "0x186635510", Slot = "4")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6635AE0", Offset = "0x66348E0", VA = "0x186635AE0")]
	private bool OALOEKIHHOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6635A60", Offset = "0x6634860", VA = "0x186635A60", Slot = "5")]
	public void NDHMINGNOPL(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6635330", Offset = "0x6634130", VA = "0x186635330", Slot = "6")]
	public void AMCEGGKJDPH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x66353B0", Offset = "0x66341B0", VA = "0x1866353B0", Slot = "9")]
	public void DJJAILNEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x66357C0", Offset = "0x66345C0", VA = "0x1866357C0")]
	private void MKPLFCLKFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x66358C0", Offset = "0x66346C0", VA = "0x1866358C0")]
	private void NDDOJENDOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6635BC0", Offset = "0x66349C0", VA = "0x186635BC0", Slot = "8")]
	public void PLIIAPONACG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6635610", Offset = "0x6634410", VA = "0x186635610", Slot = "7")]
	public void JNEDOMBKCKD(EKNGNBEELEM DLFJFELKBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KEMNOPJBDNE : MDFDBNIIINK, PGJKKEBGPFO
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6648C40", Offset = "0x6647A40", VA = "0x186648C40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool EPMDJPOEJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x66490B0", Offset = "0x6647EB0", VA = "0x1866490B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event MKODNDEIKFD NCJKJKICPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6648CA0", Offset = "0x6647AA0", VA = "0x186648CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6648F30", Offset = "0x6647D30", VA = "0x186648F30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public KEMNOPJBDNE(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6649120", Offset = "0x6647F20", VA = "0x186649120", Slot = "11")]
	public IDisposable OKBLANKECFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6648D40", Offset = "0x6647B40", VA = "0x186648D40", Slot = "8")]
	public void IGHOOFFDJFI(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6649110", Offset = "0x6647F10", VA = "0x186649110", Slot = "9")]
	public void NDKDBHMMJKH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6648E30", Offset = "0x6647C30", VA = "0x186648E30", Slot = "10")]
	public void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6648FD0", Offset = "0x6647DD0", VA = "0x186648FD0", Slot = "12")]
	public void MMCLMIODOFF(Rigidbody BNKGAHAACAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6648D50", Offset = "0x6647B50", VA = "0x186648D50", Slot = "13")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x663BC80", Offset = "0x663AA80", VA = "0x18663BC80", Slot = "6")]
	public void OEEOPEFCAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PHCEJAMJLEO : MDFDBNIIINK, OIEEGPKJHPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView ILHEGIMINLK;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6644FB0", Offset = "0x6643DB0", VA = "0x186644FB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6652B50", Offset = "0x6651950", VA = "0x186652B50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event MKODNDEIKFD JGPLFDNHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x66528B0", Offset = "0x66516B0", VA = "0x1866528B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6652E70", Offset = "0x6651C70", VA = "0x186652E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6653600", Offset = "0x6652400", VA = "0x186653600")]
	public PHCEJAMJLEO(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6652D40", Offset = "0x6651B40", VA = "0x186652D40", Slot = "8")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6652BE0", Offset = "0x66519E0", VA = "0x186652BE0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6652F10", Offset = "0x6651D10", VA = "0x186652F10", Slot = "9")]
	public void MMPHMEGJCIO(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6652950", Offset = "0x6651750", VA = "0x186652950", Slot = "10")]
	public void BKPOJPMLCGK(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6653110", Offset = "0x6651F10", VA = "0x186653110")]
	private void NFKOPHGIPAB(PhotonView BALHKBPJBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x66534B0", Offset = "0x66522B0", VA = "0x1866534B0")]
	private void PBPCEMPMGDH(RigidbodyEx HDBBJADBDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x66532F0", Offset = "0x66520F0", VA = "0x1866532F0")]
	private void OAGIPMKBKKN(PhotonView NCLDNLDGDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class CNKDIBNHKNJ
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x66325C0", Offset = "0x66313C0", VA = "0x1866325C0")]
	public static PHCEJAMJLEO PHNDFPBPPAB(this HFAPLIEMKLB EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class NOJENDHNHOA : MDFDBNIIINK, IPFGDCNIMFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x66521F0", Offset = "0x6650FF0", VA = "0x1866521F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x66524A0", Offset = "0x66512A0", VA = "0x1866524A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool MDGPCKONMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6652250", Offset = "0x6651050", VA = "0x186652250", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6652430", Offset = "0x6651230", VA = "0x186652430")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6652590", Offset = "0x6651390", VA = "0x186652590", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x66522B0", Offset = "0x66510B0", VA = "0x1866522B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6652680", Offset = "0x6651480", VA = "0x186652680")]
	public NOJENDHNHOA(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x66525F0", Offset = "0x66513F0", VA = "0x1866525F0", Slot = "9")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6652510", Offset = "0x6651310", VA = "0x186652510", Slot = "10")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class BFCKFOPHFKH : MDFDBNIIINK, CCOKCPKDNKE
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x662F9C0", Offset = "0x662E7C0", VA = "0x18662F9C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x662FBD0", Offset = "0x662E9D0", VA = "0x18662FBD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x662FB70", Offset = "0x662E970", VA = "0x18662FB70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x662FA20", Offset = "0x662E820", VA = "0x18662FA20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public BFCKFOPHFKH(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x662FDF0", Offset = "0x662EBF0", VA = "0x18662FDF0", Slot = "8")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x662FD20", Offset = "0x662EB20", VA = "0x18662FD20", Slot = "9")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[BBPMGFLEEOB(typeof(MNLLKBFCAPO), new string[] { })]
public sealed class IBOJADEJEEF : PKPNKDMNHCJ, MNLLKBFCAPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NJFFPBKFAFF]
	private FLCMMALDFNG DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool OFJKLDDBIOI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x66435F0", Offset = "0x66423F0", VA = "0x1866435F0", Slot = "4")]
	public void InitReferences(IMCGAAIAFJE EKLNKMPEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6643270", Offset = "0x6642070", VA = "0x186643270", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6643390", Offset = "0x6642190", VA = "0x186643390", Slot = "6")]
	public void GPDOAPNPIAC(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x66437F0", Offset = "0x66425F0", VA = "0x1866437F0", Slot = "7")]
	public void MPPLJOHKILN(EDLOHAABCGP JNDMOGCGEKD, bool FPPHPEGJLHC, bool GGONLGGMLDI, bool BEFGMEEOGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6643A10", Offset = "0x6642810", VA = "0x186643A10", Slot = "8")]
	public void PDANOBCNBIH(EDLOHAABCGP JNDMOGCGEKD, float3 IBOFICAFDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x66434B0", Offset = "0x66422B0", VA = "0x1866434B0", Slot = "9")]
	public void IJPPEPBIGNG(EDLOHAABCGP JNDMOGCGEKD, float3 BBMLLNFGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6643640", Offset = "0x6642440", VA = "0x186643640")]
	private bool LHAEJIDFGCN(EDLOHAABCGP JNDMOGCGEKD, [Out] HBFKBFMEJII EJHNGBHNBFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x66432A0", Offset = "0x66420A0", VA = "0x1866432A0")]
	private bool FFDEAEMGLEF(EDLOHAABCGP JNDMOGCGEKD, [Out] HBPBHMJIPMB MHPDDHFCFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6643700", Offset = "0x6642500", VA = "0x186643700")]
	private bool LJDBDHABMIC(EDLOHAABCGP JNDMOGCGEKD, [Out] NFDMDEPKLKO ENOLEKNOENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IBOJADEJEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class LCNCADMEDGA : MDFDBNIIINK, KGAPMFLBKGG
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool AMLCEMALNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x664BC40", Offset = "0x664AA40", VA = "0x18664BC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x664C330", Offset = "0x664B130", VA = "0x18664C330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x664C0D0", Offset = "0x664AED0", VA = "0x18664C0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool IEAOHAIANIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x664C400", Offset = "0x664B200", VA = "0x18664C400")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x664BC60", Offset = "0x664AA60", VA = "0x18664BC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool EFMMNJANKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x664C1E0", Offset = "0x664AFE0", VA = "0x18664C1E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x664BCD0", Offset = "0x664AAD0", VA = "0x18664BCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int CKKFGJPOMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x664BEC0", Offset = "0x664ACC0", VA = "0x18664BEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event MKODNDEIKFD CLKLEMKDPED
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x664C5A0", Offset = "0x664B3A0", VA = "0x18664C5A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x664BE20", Offset = "0x664AC20", VA = "0x18664BE20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x664C640", Offset = "0x664B440", VA = "0x18664C640")]
	public LCNCADMEDGA(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x664C130", Offset = "0x664AF30", VA = "0x18664C130", Slot = "6")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x664C390", Offset = "0x664B190", VA = "0x18664C390", Slot = "8")]
	public void JPCKMMJJKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x664BF30", Offset = "0x664AD30", VA = "0x18664BF30", Slot = "7")]
	public bool GELNOGMHIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x664C240", Offset = "0x664B040", VA = "0x18664C240", Slot = "9")]
	public void IBLHLILINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x663BC80", Offset = "0x663AA80", VA = "0x18663BC80", Slot = "12")]
	public void IMAJCBAAIFC(bool GDPLLHKJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x664C460", Offset = "0x664B260", VA = "0x18664C460", Slot = "11")]
	public void ODPIPGKNKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "10")]
	public void HNDJMOGDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x664BD40", Offset = "0x664AB40", VA = "0x18664BD40")]
	private void EHNCCLIHBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class MDECDEJBABB : MDFDBNIIINK, KFPEKBNCNGH
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x664D040", Offset = "0x664BE40", VA = "0x18664D040", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x664D680", Offset = "0x664C480", VA = "0x18664D680")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x66307A0", Offset = "0x662F5A0", VA = "0x1866307A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool CLNFHKAFHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x664D620", Offset = "0x664C420", VA = "0x18664D620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x664D770", Offset = "0x664C570", VA = "0x18664D770")]
	public MDECDEJBABB(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x664CF90", Offset = "0x664BD90", VA = "0x18664CF90", Slot = "5")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x664CF10", Offset = "0x664BD10", VA = "0x18664CF10", Slot = "7")]
	public void BLKPLNMNING(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x664D120", Offset = "0x664BF20", VA = "0x18664D120", Slot = "8")]
	public void JFPFGCEJILE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x664D400", Offset = "0x664C200", VA = "0x18664D400", Slot = "9")]
	public void JOGLFJNJIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x664D1A0", Offset = "0x664BFA0", VA = "0x18664D1A0", Slot = "11")]
	public void JKANGDJJKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x664CD40", Offset = "0x664BB40", VA = "0x18664CD40", Slot = "12")]
	public void AHDLLPDIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "10")]
	public void JOLGKKKAAIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class NFDMDEPKLKO : MDFDBNIIINK, POCOHDNDLLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x664F2B0", Offset = "0x664E0B0", VA = "0x18664F2B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6650A80", Offset = "0x664F880", VA = "0x186650A80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6650B50", Offset = "0x664F950", VA = "0x186650B50", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x66504D0", Offset = "0x664F2D0", VA = "0x1866504D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x664F3C0", Offset = "0x664E1C0", VA = "0x18664F3C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6651940", Offset = "0x6650740", VA = "0x186651940", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6650A50", Offset = "0x664F850", VA = "0x186650A50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x66504A0", Offset = "0x664F2A0", VA = "0x1866504A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6651250", Offset = "0x6650050", VA = "0x186651250", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x664FBA0", Offset = "0x664E9A0", VA = "0x18664FBA0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x664FB70", Offset = "0x664E970", VA = "0x18664FB70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x664FC60", Offset = "0x664EA60", VA = "0x18664FC60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6650AF0", Offset = "0x664F8F0", VA = "0x186650AF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6650900", Offset = "0x664F700", VA = "0x186650900", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6650540", Offset = "0x664F340", VA = "0x186650540", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private AHAABNAFIMA HAKFCIHKMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5F96370", Offset = "0x5F95170", VA = "0x185F96370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool AMLCEMALNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x664BC40", Offset = "0x664AA40", VA = "0x18664BC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public NFDMDEPKLKO(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6650430", Offset = "0x664F230", VA = "0x186650430", Slot = "20")]
	public void HGLOCMLJLIH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x664F180", Offset = "0x664DF80", VA = "0x18664F180", Slot = "30")]
	public void DNCHHEDCCIA(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x664EE40", Offset = "0x664DC40", VA = "0x18664EE40", Slot = "19")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x664F1F0", Offset = "0x664DFF0", VA = "0x18664F1F0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6650C00", Offset = "0x664FA00", VA = "0x186650C00", Slot = "28")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x664F990", Offset = "0x664E790", VA = "0x18664F990", Slot = "35")]
	public Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6651720", Offset = "0x6650520", VA = "0x186651720", Slot = "34")]
	public Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x664EE40", Offset = "0x664DC40", VA = "0x18664EE40", Slot = "27")]
	public void CPAKHEIBFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6651140", Offset = "0x664FF40", VA = "0x186651140", Slot = "25")]
	public void NHOHNNKMDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x664F360", Offset = "0x664E160", VA = "0x18664F360", Slot = "24")]
	public void EJGNCMLPKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6650F00", Offset = "0x664FD00", VA = "0x186650F00", Slot = "33")]
	public void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x66503D0", Offset = "0x664F1D0", VA = "0x1866503D0", Slot = "32")]
	public void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6651A00", Offset = "0x6650800", VA = "0x186651A00", Slot = "31")]
	public void PALENGMMLOH(Vector3 PKKBKANJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x664FC90", Offset = "0x664EA90", VA = "0x18664FC90", Slot = "22")]
	public void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x664EB90", Offset = "0x664D990", VA = "0x18664EB90", Slot = "21")]
	public void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6651310", Offset = "0x6650110", VA = "0x186651310", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6650820", Offset = "0x664F620", VA = "0x186650820", Slot = "29")]
	public Vector3 LGEANPJHOEE(Vector3 HEHJKNMAHHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6650D70", Offset = "0x664FB70", VA = "0x186650D70", Slot = "26")]
	public void MOAGBAPFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6650900", Offset = "0x664F700", VA = "0x186650900")]
	private void LNAMPMODJNM(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6650200", Offset = "0x664F000", VA = "0x186650200")]
	private void HDFOPEFJDHP(Vector3 DBGMHHNHFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x66505A0", Offset = "0x664F3A0", VA = "0x1866505A0")]
	private Vector3 LDELEFMKCLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x664E610", Offset = "0x664D410", VA = "0x18664E610")]
	private void ABNLNNJBNDG(Vector3 IBOFICAFDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x664EEF0", Offset = "0x664DCF0", VA = "0x18664EEF0")]
	private Vector3 DMBGBPOBNKD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x664F420", Offset = "0x664E220", VA = "0x18664F420")]
	private void FCBHEPPEMKJ(Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x66512B0", Offset = "0x66500B0", VA = "0x1866512B0")]
	private void NONLEEJKDKA(Vector3 HEHJKNMAHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x66518E0", Offset = "0x66506E0", VA = "0x1866518E0")]
	private void OMKLAMDAIAD(Vector3 BCFCIEMLLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6651BD0", Offset = "0x66509D0", VA = "0x186651BD0")]
	private void PGGOIJBOJNM(string NJNLGFCMJMA, Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x66511A0", Offset = "0x664FFA0", VA = "0x1866511A0")]
	private void NJOCMKDOADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class MDFDBNIIINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly HBFKBFMEJII DLFJFELKBNN;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected FLCMMALDFNG KKHGLHGIKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x574EB30", Offset = "0x574D930", VA = "0x18574EB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x574EB70", Offset = "0x574D970", VA = "0x18574EB70")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x662FEE0", Offset = "0x662ECE0", VA = "0x18662FEE0")]
	public MDFDBNIIINK(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x664D830", Offset = "0x664C630", VA = "0x18664D830")]
	protected EKNGNBEELEM AGNMAMHEFPG(EDLOHAABCGP PDDIPEOJCBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EFOFEGEIKDA : HMLJEHKIEJG
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6633510", Offset = "0x6632310", VA = "0x186633510", Slot = "4")]
	public LNCIHMBDFJF MOFLCGGDKPK(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6632E10", Offset = "0x6631C10", VA = "0x186632E10", Slot = "5")]
	public POCOHDNDLLG FEGIFHKELGB(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x66329D0", Offset = "0x66317D0", VA = "0x1866329D0", Slot = "6")]
	public FGCKALLEMHH CEAEFAAILEL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6633570", Offset = "0x6632370", VA = "0x186633570", Slot = "7")]
	public CCOKCPKDNKE NMHJGCJDFPP(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x66331E0", Offset = "0x6631FE0", VA = "0x1866331E0", Slot = "8")]
	public KGAPMFLBKGG GHDDDHMBBOF(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x66326F0", Offset = "0x66314F0", VA = "0x1866326F0", Slot = "9")]
	public IMEFEPNFNJN AKOGHICPGOC(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6633430", Offset = "0x6632230", VA = "0x186633430", Slot = "10")]
	public PGJKKEBGPFO LNJFGEDJECL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6632EF0", Offset = "0x6631CF0", VA = "0x186632EF0", Slot = "11")]
	public AHAABNAFIMA FKMHLFALDPO(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6633350", Offset = "0x6632150", VA = "0x186633350", Slot = "12")]
	public NHJMPFEALEF LEHELPIFAFG(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6632C00", Offset = "0x6631A00", VA = "0x186632C00", Slot = "13")]
	public OJIJDKGMOBN FANFNGELLNE(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x66328D0", Offset = "0x66316D0", VA = "0x1866328D0")]
	public KFPEKBNCNGH BHBHEPIFGPL(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x66327D0", Offset = "0x66315D0", VA = "0x1866327D0")]
	public OIEEGPKJHPH GKJDMOMLAJH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6632AC0", Offset = "0x66318C0", VA = "0x186632AC0")]
	public DBMMHILOPGH KDLCIKOGHKF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6633170", Offset = "0x6631F70", VA = "0x186633170")]
	public DPHCAIJIIDN GFMMJIMNAAG(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6632FD0", Offset = "0x6631DD0", VA = "0x186632FD0")]
	public IPFGDCNIMFJ FNMADPPCHNF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6632CE0", Offset = "0x6631AE0", VA = "0x186632CE0", Slot = "19")]
	public EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL, KNJKFALBANK LIDMLHOMNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EFOFEGEIKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x66328D0", Offset = "0x66316D0", VA = "0x1866328D0", Slot = "14")]
	private KFPEKBNCNGH HFHHHBMEMAF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x66327D0", Offset = "0x66315D0", VA = "0x1866327D0", Slot = "15")]
	private OIEEGPKJHPH BEOIGBALLMC(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6632AC0", Offset = "0x66318C0", VA = "0x186632AC0", Slot = "16")]
	private DBMMHILOPGH EEGEGKEJKCH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6633170", Offset = "0x6631F70", VA = "0x186633170", Slot = "17")]
	private DPHCAIJIIDN HHPDOOKNBDJ(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6632AB0", Offset = "0x66318B0", VA = "0x186632AB0", Slot = "18")]
	private IPFGDCNIMFJ DGHANIOBKOK(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class LFLKKOOONFC : IReadOnlyList<EKNGNBEELEM>, IEnumerable<EKNGNBEELEM>, IEnumerable, IReadOnlyCollection<EKNGNBEELEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly FLCMMALDFNG CKIHFBFKLLB;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x664CA90", Offset = "0x664B890", VA = "0x18664CA90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public EKNGNBEELEM GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x664C830", Offset = "0x664B630", VA = "0x18664C830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x34FE8A0", Offset = "0x34FD6A0", VA = "0x1834FE8A0")]
	public LFLKKOOONFC(EDLOHAABCGP PDDIPEOJCBN, FLCMMALDFNG CKIHFBFKLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x664C980", Offset = "0x664B780", VA = "0x18664C980", Slot = "6")]
	public IEnumerator<EKNGNBEELEM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x664C980", Offset = "0x664B780", VA = "0x18664C980", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x664C830", Offset = "0x664B630", VA = "0x18664C830")]
	[CompilerGenerated]
	private EKNGNBEELEM DEDFFGBPBKN(int GKGOKFIMAIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BBPMGFLEEOB(typeof(HMLJEHKIEJG), new string[] { })]
public class FKPDBIJDMKM : HMLJEHKIEJG, PKPNKDMNHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HMLJEHKIEJG GMJODLBAJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HMLJEHKIEJG HJGBBLOLKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private KBFGGFOMOIA CLABDCIHJCG;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private HMLJEHKIEJG PGCLJKONDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x6634AA0", Offset = "0x66338A0", VA = "0x186634AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x66347D0", Offset = "0x66335D0", VA = "0x1866347D0", Slot = "20")]
	public void InitReferences(IMCGAAIAFJE EKLNKMPEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6634960", Offset = "0x6633760", VA = "0x186634960", Slot = "4")]
	public LNCIHMBDFJF MOFLCGGDKPK(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6634540", Offset = "0x6633340", VA = "0x186634540", Slot = "5")]
	public POCOHDNDLLG FEGIFHKELGB(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x66341B0", Offset = "0x6632FB0", VA = "0x1866341B0", Slot = "6")]
	public FGCKALLEMHH CEAEFAAILEL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6634A00", Offset = "0x6633800", VA = "0x186634A00", Slot = "7")]
	public CCOKCPKDNKE NMHJGCJDFPP(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6634730", Offset = "0x6633530", VA = "0x186634730", Slot = "8")]
	public KGAPMFLBKGG GHDDDHMBBOF(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6633FB0", Offset = "0x6632DB0", VA = "0x186633FB0", Slot = "9")]
	public IMEFEPNFNJN AKOGHICPGOC(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x66348C0", Offset = "0x66336C0", VA = "0x1866348C0", Slot = "10")]
	public PGJKKEBGPFO LNJFGEDJECL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x66345E0", Offset = "0x66333E0", VA = "0x1866345E0", Slot = "11")]
	public AHAABNAFIMA FKMHLFALDPO(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6634820", Offset = "0x6633620", VA = "0x186634820", Slot = "12")]
	public NHJMPFEALEF LEHELPIFAFG(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x66343B0", Offset = "0x66331B0", VA = "0x1866343B0", Slot = "13")]
	public OJIJDKGMOBN FANFNGELLNE(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6634100", Offset = "0x6632F00", VA = "0x186634100")]
	public KFPEKBNCNGH BHBHEPIFGPL(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6634050", Offset = "0x6632E50", VA = "0x186634050")]
	public OIEEGPKJHPH GKJDMOMLAJH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6634300", Offset = "0x6633100", VA = "0x186634300")]
	public DBMMHILOPGH KDLCIKOGHKF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6634680", Offset = "0x6633480", VA = "0x186634680")]
	public DPHCAIJIIDN GFMMJIMNAAG(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6634250", Offset = "0x6633050", VA = "0x186634250")]
	public IPFGDCNIMFJ FNMADPPCHNF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6634450", Offset = "0x6633250", VA = "0x186634450", Slot = "19")]
	public EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL, KNJKFALBANK LIDMLHOMNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6634B00", Offset = "0x6633900", VA = "0x186634B00")]
	public FKPDBIJDMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6634100", Offset = "0x6632F00", VA = "0x186634100", Slot = "14")]
	private KFPEKBNCNGH HFHHHBMEMAF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6634050", Offset = "0x6632E50", VA = "0x186634050", Slot = "15")]
	private OIEEGPKJHPH BEOIGBALLMC(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6634300", Offset = "0x6633100", VA = "0x186634300", Slot = "16")]
	private DBMMHILOPGH EEGEGKEJKCH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6634680", Offset = "0x6633480", VA = "0x186634680", Slot = "17")]
	private DPHCAIJIIDN HHPDOOKNBDJ(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6634250", Offset = "0x6633050", VA = "0x186634250", Slot = "18")]
	private IPFGDCNIMFJ DGHANIOBKOK(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class LELICEPLCGP : EKNGNBEELEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LELICEPLCGP ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx NHLFJPMHIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x862FA0", Offset = "0x861DA0", VA = "0x180862FA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8045F0", Offset = "0x8033F0", VA = "0x1808045F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8D0", Offset = "0x7BA6D0", VA = "0x1807BB8D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7BB840", Offset = "0x7BA640", VA = "0x1807BB840", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB880", Offset = "0x7BA680", VA = "0x1807BB880", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7BB860", Offset = "0x7BA660", VA = "0x1807BB860", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA57100", Offset = "0xA55F00", VA = "0x180A57100", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9227D0", Offset = "0x9215D0", VA = "0x1809227D0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1BE96E0", Offset = "0x1BE84E0", VA = "0x181BE96E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4772860", Offset = "0x4771660", VA = "0x184772860", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x48C1B50", Offset = "0x48C0950", VA = "0x1848C1B50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x48BF070", Offset = "0x48BDE70", VA = "0x1848BF070", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD820", Offset = "0x3FBC620", VA = "0x183FBD820", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD180", Offset = "0x3FBBF80", VA = "0x183FBD180", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MHNDGCMFIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5F10", Offset = "0x9B4D10", VA = "0x1809B5F10", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool BLGHFJEJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x18022C0", Offset = "0x18010C0", VA = "0x1818022C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF52D0", Offset = "0x5EF40D0", VA = "0x185EF52D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD160", Offset = "0x3FBBF60", VA = "0x183FBD160", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x98A930", Offset = "0x989730", VA = "0x18098A930", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x664C770", Offset = "0x664B570", VA = "0x18664C770", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1AEC0E0", Offset = "0x1AEAEE0", VA = "0x181AEC0E0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8AC370", VA = "0x1808AD570", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x80B0D0", Offset = "0x809ED0", VA = "0x18080B0D0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8AC370", VA = "0x1808AD570", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8AC370", VA = "0x1808AD570", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "48")]
		get
		{
			return default(BBFONOIEIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xD44700", Offset = "0xD43500", VA = "0x180D44700", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform NCADACFJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA085F0", Offset = "0xA073F0", VA = "0x180A085F0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 FMPGPGNHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float ELCMGEHFOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8AC370", VA = "0x1808AD570", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float OJOPHILOEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8AC370", VA = "0x1808AD570", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion NAMNFFMILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9EF3E0", Offset = "0x9EE1E0", VA = "0x1809EF3E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF3E0", Offset = "0x9EE1E0", VA = "0x1809EF3E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool MFMIECDOBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x930580", Offset = "0x92F380", VA = "0x180930580", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event MKODNDEIKFD NLKOJAALPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event MKODNDEIKFD KDKNBNIPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event GKPBHDNOMJP KHBDGEOPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event MKODNDEIKFD JGPLFDNHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event MKODNDEIKFD ACIBABODEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event MKODNDEIKFD CLKLEMKDPED
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event MKODNDEIKFD NCJKJKICPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event MKODNDEIKFD JDMBMPLNABO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "41")]
	public void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "71")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "72")]
	public void OJFJHCNMLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "73")]
	public void BGFBIMOBIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "74")]
	public void IBLHLILINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "81")]
	public void JAEGHPCAKDE(EKNGNBEELEM MAEBFBHFPDE, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "84")]
	public void FOCCHACLHNK(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "85")]
	public void MJHDJGGKBIE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "86")]
	public Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "87")]
	public Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "88")]
	public void CPAKHEIBFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "89")]
	public void NHOHNNKMDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "90")]
	public void EJGNCMLPKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "91")]
	public void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "92")]
	public void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "93")]
	public void PALENGMMLOH(Vector3 PKKBKANJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "94")]
	public void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "95")]
	public void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "96")]
	public void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "97")]
	public Vector3 LGEANPJHOEE(Vector3 MAEBFBHFPDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xB83F70", Offset = "0xB82D70", VA = "0x180B83F70", Slot = "98")]
	public Vector3 MLOEFPGGDFD(Vector3 MAEBFBHFPDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "99")]
	public void MOAGBAPFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "100")]
	public void EKLPACMKGDA(EKNGNBEELEM JBNKFGBAEBL, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "101")]
	public void FEJLNLBNNLH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "104")]
	public void FMLLABBOOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "105")]
	public void LGGGGBCFCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "106")]
	public void FKFIAJJNIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "109")]
	public bool GELNOGMHIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "110")]
	public void ODPIPGKNKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "115")]
	public IDisposable OKBLANKECFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "116")]
	public void IGHOOFFDJFI(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "117")]
	public void NDKDBHMMJKH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "118")]
	public void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "121")]
	public void IBDGJIMPHPN(Vector3 HCGFAHICBEM, Quaternion EIFHDMPFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "122")]
	public void PJOCHMOADEM(Vector3 MHKDPJJENKK, Quaternion NHFABNFJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "123")]
	public bool ILCLNNNCNBN(float JMABOANLGPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "124")]
	public void HDNLFBILLAE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "125")]
	public void NMHHEMEEGFF(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "126")]
	public void BLKPLNMNING(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "127")]
	public void JFPFGCEJILE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "128")]
	public void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "129")]
	public void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "130")]
	public void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "131")]
	public void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x664C790", Offset = "0x664B590", VA = "0x18664C790", Slot = "132")]
	public bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "133")]
	public void LFPHLLAPCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public LELICEPLCGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class HBFKBFMEJII : HFAPLIEMKLB, EBHOAKANDLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal FLCMMALDFNG JGJPMILGNOO;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x66387E0", Offset = "0x66375E0", VA = "0x1866387E0")]
	public HBFKBFMEJII(GameObject EAPMMKKAJGJ, RigidbodyEx NGKHKGGOJGN, KNJKFALBANK LIDMLHOMNDK, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6638150", Offset = "0x6636F50", VA = "0x186638150", Slot = "135")]
	protected override void FENNHPNEJJO(KNJKFALBANK LIDMLHOMNDK, NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "141")]
	protected override IDisposable IPDIALDJNKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6637F20", Offset = "0x6636D20", VA = "0x186637F20", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x66384E0", Offset = "0x66372E0", VA = "0x1866384E0", Slot = "142")]
	public void LLNFIAMJPLK(BBBOLAEIGKI ILMCAINDAOO, BBBOLAEIGKI JCLDAPCPAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6638090", Offset = "0x6636E90", VA = "0x186638090", Slot = "143")]
	public void ECHKEMNBLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6638420", Offset = "0x6637220", VA = "0x186638420", Slot = "144")]
	public void KGMHAAFDHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x66383C0", Offset = "0x66371C0", VA = "0x1866383C0", Slot = "145")]
	public void IMAJCBAAIFC(bool GDPLLHKJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6637D90", Offset = "0x6636B90", VA = "0x186637D90", Slot = "146")]
	public bool DONALGPPIKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6637D30", Offset = "0x6636B30", VA = "0x186637D30", Slot = "147")]
	public void DNDIMEIDCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "140")]
	protected override void PFOECPCOFBM(RigidbodyEx FGIPEOJEGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x66385B0", Offset = "0x66373B0", VA = "0x1866385B0")]
	private void OPBCGINOLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class FCPHJNOOILB
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6633E10", Offset = "0x6632C10", VA = "0x186633E10")]
	public static HFAPLIEMKLB MDFLJBIKANN(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PBDDGKCLIOL : LNCIHMBDFJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLFICOCDFDA(EKNGNBEELEM DLFJFELKBNN);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEONMMPMKDG(EKNGNBEELEM DLFJFELKBNN);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHEPJKHPLDP(EKNGNBEELEM CENKKDIGFIL);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OINOFALIPJA(EKNGNBEELEM CENKKDIGFIL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JHNKIFPCDEK : FGCKALLEMHH
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	BCHMIAILHAN<EKNGNBEELEM> LMDLANMLPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	EKNGNBEELEM FJBDHKDGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LPMANFECNHD : DPHCAIJIIDN
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) GPDOAPNPIAC(Rigidbody DOBLLGCNKOP);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MKPILMBOJKF : OIEEGPKJHPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView PFJPJJLMMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class HEDNAIABDEI : NHJMPFEALEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode OELPLALNLPI;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode GIDGJOGOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x663C400", Offset = "0x663B200", VA = "0x18663C400", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x663C270", Offset = "0x663B070", VA = "0x18663C270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6632530", Offset = "0x6631330", VA = "0x186632530")]
	public HEDNAIABDEI(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x663C2F0", Offset = "0x663B0F0", VA = "0x18663C2F0", Slot = "6")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x663C7A0", Offset = "0x663B5A0", VA = "0x18663C7A0", Slot = "9")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x663C2E0", Offset = "0x663B0E0", VA = "0x18663C2E0", Slot = "7")]
	public void DPAHPMMKDGO(bool AJNCKLAJJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x663C510", Offset = "0x663B310", VA = "0x18663C510", Slot = "8")]
	public void ICOMEJCLJBF(bool AJNCKLAJJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x663C520", Offset = "0x663B320", VA = "0x18663C520", Slot = "10")]
	public bool JDNJHMHJDAK(Vector3 JMFPDJFKFGP, [Out] RaycastHit EPIFMOACHGP, float CCDDMHMFCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x663C680", Offset = "0x663B480", VA = "0x18663C680")]
	private void LHMHPGMLEEF(bool AJNCKLAJJJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class FOFGNPHPJGG : IMEFEPNFNJN, IDisposable, EMNKEBKLFCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BBFONOIEIIB HKDOFFDHGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JLAGBLLOIFH MHILOKNBBLL;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public BBFONOIEIIB EHEKHKHMKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6635080", Offset = "0x6633E80", VA = "0x186635080", Slot = "6")]
		get
		{
			return default(BBFONOIEIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x66351D0", Offset = "0x6633FD0", VA = "0x1866351D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform DDJNMOCGHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6634BB0", Offset = "0x66339B0", VA = "0x186634BB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<IMIGBJOIFIN, IMIGBJOIFIN> PPEAOLECCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6634C20", Offset = "0x6633A20", VA = "0x186634C20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6634FD0", Offset = "0x6633DD0", VA = "0x186634FD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x66352A0", Offset = "0x66340A0", VA = "0x1866352A0")]
	public FOFGNPHPJGG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6634CD0", Offset = "0x6633AD0", VA = "0x186634CD0", Slot = "8")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6634BD0", Offset = "0x66339D0", VA = "0x186634BD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1C6CB70", Offset = "0x1C6B970", VA = "0x181C6CB70", Slot = "11")]
	private void PDLBFLABHPN(IMIGBJOIFIN JCCAIAGCGGH, IMIGBJOIFIN MGHFFGCLDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "12")]
	private void HJPBIKHEPPE(bool EEPDJDHMPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class IDDGHGOALHK : AHAABNAFIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6630800", Offset = "0x662F600", VA = "0x186630800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6630290", Offset = "0x662F090", VA = "0x186630290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x66307A0", Offset = "0x662F5A0", VA = "0x1866307A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6644010", Offset = "0x6642E10", VA = "0x186644010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6632530", Offset = "0x6631330", VA = "0x186632530")]
	public IDDGHGOALHK(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6644070", Offset = "0x6642E70", VA = "0x186644070", Slot = "4")]
	public void MLBOEDNOLDL(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x66441D0", Offset = "0x6642FD0", VA = "0x1866441D0")]
	private void NACEJLKHKAD(Vector3 CPEDIDFIAIE, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6644430", Offset = "0x6643230", VA = "0x186644430", Slot = "5")]
	public void PJFFFFGDEFH(Vector3 CPEDIDFIAIE, Vector3 AJFNKFFNDBD, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66446B0", Offset = "0x66434B0", VA = "0x1866446B0", Slot = "6")]
	public void PLHKIMKDPKB(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6643B50", Offset = "0x6642950", VA = "0x186643B50")]
	private void DDPHPAEGJAK(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6643DB0", Offset = "0x6642BB0", VA = "0x186643DB0", Slot = "7")]
	public void DEEGOFAEHBH(Vector3 EIMAFAOJLGB, ForceMode ILMAKJMGACG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class CMBAENMNAPJ : OJIJDKGMOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool DAMFNIJKBMO;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool ABOIDHLDNON
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6632420", Offset = "0x6631220", VA = "0x186632420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6632530", Offset = "0x6631330", VA = "0x186632530")]
	public CMBAENMNAPJ(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x66323F0", Offset = "0x66311F0", VA = "0x1866323F0", Slot = "6")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6632380", Offset = "0x6631180", VA = "0x186632380", Slot = "7")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class GOAFOECOAMP : PBDDGKCLIOL, LNCIHMBDFJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly EKNGNBEELEM DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<EKNGNBEELEM> KBNPJABPGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private EKNGNBEELEM GOKLEGFJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private EKNGNBEELEM FEOGIMKDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform EHOHGFJEHDI;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6636580", Offset = "0x6635380", VA = "0x186636580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8A0", Offset = "0x7BA6A0", VA = "0x1807BB8A0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6637BC0", Offset = "0x66369C0", VA = "0x186637BC0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public EKNGNBEELEM IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BB850", Offset = "0x7BA650", VA = "0x1807BB850", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<EKNGNBEELEM> CLDEGOGBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8B0", Offset = "0x7BA6B0", VA = "0x1807BB8B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event MKODNDEIKFD NLKOJAALPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6637600", Offset = "0x6636400", VA = "0x186637600", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6637560", Offset = "0x6636360", VA = "0x186637560", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event MKODNDEIKFD KDKNBNIPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6637A70", Offset = "0x6636870", VA = "0x186637A70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6637750", Offset = "0x6636550", VA = "0x186637750", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event GKPBHDNOMJP KHBDGEOPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x66365E0", Offset = "0x66353E0", VA = "0x1866365E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6636720", Offset = "0x6635520", VA = "0x186636720", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action DGCELBACGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6635F30", Offset = "0x6634D30", VA = "0x186635F30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6636B80", Offset = "0x6635980", VA = "0x186636B80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action CDMCNIPOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6636910", Offset = "0x6635710", VA = "0x186636910", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6635E50", Offset = "0x6634C50", VA = "0x186635E50", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<EKNGNBEELEM> AKINDBHKFON
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6636860", Offset = "0x6635660", VA = "0x186636860", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6636110", Offset = "0x6634F10", VA = "0x186636110", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<EKNGNBEELEM> MKPGIMBBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6637B10", Offset = "0x6636910", VA = "0x186637B10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6637290", Offset = "0x6636090", VA = "0x186637290", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action NBBEFKICPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6637BD0", Offset = "0x66369D0", VA = "0x186637BD0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x66361C0", Offset = "0x6634FC0", VA = "0x1866361C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<EKNGNBEELEM> MLLFBILLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x66376A0", Offset = "0x66364A0", VA = "0x1866376A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6636260", Offset = "0x6635060", VA = "0x186636260", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6637C70", Offset = "0x6636A70", VA = "0x186637C70")]
	public GOAFOECOAMP(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6636680", Offset = "0x6635480", VA = "0x186636680", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6636C20", Offset = "0x6635A20", VA = "0x186636C20", Slot = "30")]
	public void JAEGHPCAKDE(EKNGNBEELEM EIECDKIPGGN, bool LAELABDCPLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6636310", Offset = "0x6635110", VA = "0x186636310", Slot = "6")]
	public void CHEPJKHPLDP(EKNGNBEELEM CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x66377F0", Offset = "0x66365F0", VA = "0x1866377F0", Slot = "7")]
	public void OINOFALIPJA(EKNGNBEELEM CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x66371A0", Offset = "0x6635FA0", VA = "0x1866371A0", Slot = "4")]
	public void JLFICOCDFDA(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x66367C0", Offset = "0x66355C0", VA = "0x1866367C0", Slot = "5")]
	public void FEONMMPMKDG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x66369B0", Offset = "0x66357B0", VA = "0x1866369B0")]
	private void GIJCLGMCNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6635EF0", Offset = "0x6634CF0", VA = "0x186635EF0")]
	private void ABPBFPBAJPM(EKNGNBEELEM CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6635FD0", Offset = "0x6634DD0", VA = "0x186635FD0")]
	private void BGMBCPKHJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6637340", Offset = "0x6636140", VA = "0x186637340")]
	private void LKGFKALJPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6636A50", Offset = "0x6635850", VA = "0x186636A50")]
	private void HAGLNLCEGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6637470", Offset = "0x6636270", VA = "0x186637470")]
	[CompilerGenerated]
	private object LLALEEDHGAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OKHDHLNJPPI
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x66527F0", Offset = "0x66515F0", VA = "0x1866527F0")]
	public static PBDDGKCLIOL PDPEJBHJGKB(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class MIGBMDFOPOC : JHNKIFPCDEK, FGCKALLEMHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BCHMIAILHAN<EKNGNBEELEM> BPGNAMBLJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool JHJBIPENIOD;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public BCHMIAILHAN<EKNGNBEELEM> LMDLANMLPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 NDINBAEINIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x664E190", Offset = "0x664CF90", VA = "0x18664E190", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 CGJLHCBMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x664E1C0", Offset = "0x664CFC0", VA = "0x18664E1C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x664DC60", Offset = "0x664CA60", VA = "0x18664DC60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public EKNGNBEELEM FJBDHKDGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x664DD50", Offset = "0x664CB50", VA = "0x18664DD50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x664E450", Offset = "0x664D250", VA = "0x18664E450")]
	public MIGBMDFOPOC(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x664E3E0", Offset = "0x664D1E0", VA = "0x18664E3E0", Slot = "8")]
	public void ONNIDCOBFLO(EKNGNBEELEM FEOGIMKDFKL, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x664E380", Offset = "0x664D180", VA = "0x18664E380", Slot = "9")]
	public void ONIPFECGKGL(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x664D8D0", Offset = "0x664C6D0", VA = "0x18664D8D0")]
	private Vector3 ANHEKOOMCDF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x664DE00", Offset = "0x664CC00", VA = "0x18664DE00")]
	private void GCNCABMHGMD(EKNGNBEELEM NFCANCEGHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FGHJCAENIOA
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6633E60", Offset = "0x6632C60", VA = "0x186633E60")]
	public static JHNKIFPCDEK ENDCBOOEPKJ(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class KCFOMOBCHHH : LPMANFECNHD, DPHCAIJIIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 CLOIDDBPCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 CEPMDHGMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float ILCGOBBKFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float ILEFJDHNBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 MHEHOPBBDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? IGGLLNEODMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? OFOFMMKJPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool COOPLFMIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool ECPNCFEBHGF;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 MFHLLFDBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10EDAE0", Offset = "0x10EC8E0", VA = "0x1810EDAE0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6647CF0", Offset = "0x6646AF0", VA = "0x186647CF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 DNBPAHJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x6645FF0", Offset = "0x6644DF0", VA = "0x186645FF0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float EBIOBIEOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8A50", Offset = "0x11C7850", VA = "0x1811C8A50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x6645EE0", Offset = "0x6644CE0", VA = "0x186645EE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float GOIMIEABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xC0FCC0", Offset = "0xC0EAC0", VA = "0x180C0FCC0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x66464A0", Offset = "0x66452A0", VA = "0x1866464A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 PMMNLNDNANC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6648030", Offset = "0x6646E30", VA = "0x186648030", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion DCAOIBCMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x66460F0", Offset = "0x6644EF0", VA = "0x1866460F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x6631DE0", Offset = "0x6630BE0", VA = "0x186631DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event MKODNDEIKFD PBKLPLHGAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6646770", Offset = "0x6645570", VA = "0x186646770", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6646550", Offset = "0x6645350", VA = "0x186646550", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6648910", Offset = "0x6647710", VA = "0x186648910")]
	public KCFOMOBCHHH(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6646980", Offset = "0x6645780", VA = "0x186646980", Slot = "17")]
	public void FMLLABBOOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6648660", Offset = "0x6647460", VA = "0x186648660", Slot = "16")]
	public void LGGGGBCFCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6648740", Offset = "0x6647540", VA = "0x186648740", Slot = "19")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6647DA0", Offset = "0x6646BA0", VA = "0x186647DA0", Slot = "20")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6646810", Offset = "0x6645610", VA = "0x186646810", Slot = "18")]
	public void FKFIAJJNIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x66481C0", Offset = "0x6646FC0", VA = "0x1866481C0", Slot = "21")]
	public void LFPHLLAPCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6647CF0", Offset = "0x6646AF0", VA = "0x186647CF0")]
	private void JEFKGPPJPMC(Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6648820", Offset = "0x6647620", VA = "0x186648820")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 NMGOCBHIPGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6645EE0", Offset = "0x6644CE0", VA = "0x186645EE0")]
	private void NCEJLMFNKFI(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x66464A0", Offset = "0x66452A0", VA = "0x1866464A0")]
	private void CDPGMHEHDAO(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6647B50", Offset = "0x6646950", VA = "0x186647B50")]
	private Vector3 HABCKBGOIPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6646270", Offset = "0x6645070", VA = "0x186646270", Slot = "15")]
	public void CBLCKJAMFLP((Quaternion rot, Vector3 moments) LOPDMLFNDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x66465F0", Offset = "0x66453F0", VA = "0x1866465F0")]
	private Quaternion DJHONDCLONF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6646B30", Offset = "0x6645930", VA = "0x186646B30")]
	public void GPDOAPNPIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6646C00", Offset = "0x6645A00", VA = "0x186646C00", Slot = "4")]
	public (float, Vector3) GPDOAPNPIAC(Rigidbody DOBLLGCNKOP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class MBJMGDCMOJJ
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x664CC80", Offset = "0x664BA80", VA = "0x18664CC80")]
	public static LPMANFECNHD FNOJCLHJNJL(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class KHKHAMKDNEA : DBMMHILOPGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly IGJOIAOJFFC JLAMCGHPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly JDKPCKNKNHD FGCJPOAPAMO;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool ENMGLIPEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xD3A6B0", Offset = "0xD394B0", VA = "0x180D3A6B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public JDKPCKNKNHD FNJBAIPLHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0", Slot = "11")]
		get
		{
			return default(JDKPCKNKNHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6649A80", Offset = "0x6648880", VA = "0x186649A80")]
	public KHKHAMKDNEA(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x66495D0", Offset = "0x66483D0", VA = "0x1866495D0", Slot = "4")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x66499A0", Offset = "0x66487A0", VA = "0x1866499A0")]
	private bool OALOEKIHHOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6649970", Offset = "0x6648770", VA = "0x186649970", Slot = "5")]
	public void NDHMINGNOPL(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6649460", Offset = "0x6648260", VA = "0x186649460", Slot = "6")]
	public void AMCEGGKJDPH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6649490", Offset = "0x6648290", VA = "0x186649490", Slot = "9")]
	public void DJJAILNEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x66496E0", Offset = "0x66484E0", VA = "0x1866496E0")]
	private void MKPLFCLKFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6649800", Offset = "0x6648600", VA = "0x186649800")]
	private void NDDOJENDOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6649A40", Offset = "0x6648840", VA = "0x186649A40", Slot = "8")]
	public void PLIIAPONACG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x66496A0", Offset = "0x66484A0", VA = "0x1866496A0", Slot = "7")]
	public void JNEDOMBKCKD(EKNGNBEELEM DLFJFELKBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class JCELJODMAPB : PGJKKEBGPFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly IGJOIAOJFFC KGCBPJAPMKN;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool MHNIFJEJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6645730", Offset = "0x6644530", VA = "0x186645730", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event MKODNDEIKFD NCJKJKICPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x66457E0", Offset = "0x66445E0", VA = "0x1866457E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x66459D0", Offset = "0x66447D0", VA = "0x1866459D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6645BB0", Offset = "0x66449B0", VA = "0x186645BB0")]
	public JCELJODMAPB(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6645B40", Offset = "0x6644940", VA = "0x186645B40", Slot = "11")]
	public IDisposable OKBLANKECFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6645880", Offset = "0x6644680", VA = "0x186645880", Slot = "8")]
	public void IGHOOFFDJFI(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6645AF0", Offset = "0x66448F0", VA = "0x186645AF0", Slot = "9")]
	public void NDKDBHMMJKH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x66458C0", Offset = "0x66446C0", VA = "0x1866458C0", Slot = "10")]
	public void KNKKAHPHLGI(object BNAJMHPOOCG, bool FBNCDEJLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6645B00", Offset = "0x6644900", VA = "0x186645B00", Slot = "6")]
	public void OEEOPEFCAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6645A70", Offset = "0x6644870", VA = "0x186645A70", Slot = "12")]
	public void MMCLMIODOFF(Rigidbody BNKGAHAACAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6645890", Offset = "0x6644690", VA = "0x186645890", Slot = "13")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JAIMJPOGMOM : MKPILMBOJKF, OIEEGPKJHPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView ILHEGIMINLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool EJENAAJFDAK;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView PFJPJJLMMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool BNLBIHKDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6644FB0", Offset = "0x6643DB0", VA = "0x186644FB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool BHJGGOILJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F00", Offset = "0x8DFD00", VA = "0x1808E0F00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event MKODNDEIKFD JGPLFDNHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6644AD0", Offset = "0x66438D0", VA = "0x186644AD0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6644F10", Offset = "0x6643D10", VA = "0x186644F10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x6645680", Offset = "0x6644480", VA = "0x186645680")]
	public JAIMJPOGMOM(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x6644DE0", Offset = "0x6643BE0", VA = "0x186644DE0", Slot = "9")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x6644CE0", Offset = "0x6643AE0", VA = "0x186644CE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6644FD0", Offset = "0x6643DD0", VA = "0x186644FD0", Slot = "10")]
	public void MMPHMEGJCIO(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x6644B70", Offset = "0x6643970", VA = "0x186644B70", Slot = "11")]
	public void BKPOJPMLCGK(EKNGNBEELEM FEOGIMKDFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x6645140", Offset = "0x6643F40", VA = "0x186645140")]
	private void NFKOPHGIPAB(PhotonView BALHKBPJBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x6645520", Offset = "0x6644320", VA = "0x186645520")]
	private void PBPCEMPMGDH(RigidbodyEx HDBBJADBDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x66452B0", Offset = "0x66440B0", VA = "0x1866452B0")]
	private void OAGIPMKBKKN(PhotonView NCLDNLDGDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class MMNPPJABJDP
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x664E550", Offset = "0x664D350", VA = "0x18664E550")]
	public static MKPILMBOJKF PHNDFPBPPAB(this EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JPKCLFIKLBO : IPFGDCNIMFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints CPCGIPGIALE;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool PNJKJBNLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xB5F3F0", Offset = "0xB5E1F0", VA = "0x180B5F3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3E74F50", Offset = "0x3E73D50", VA = "0x183E74F50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool MDGPCKONMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDB7640", Offset = "0xDB6440", VA = "0x180DB7640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3E74F40", Offset = "0x3E73D40", VA = "0x183E74F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints PABCMDFJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6645CA0", Offset = "0x6644AA0", VA = "0x186645CA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6645E30", Offset = "0x6644C30", VA = "0x186645E30")]
	public JPKCLFIKLBO(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6645E00", Offset = "0x6644C00", VA = "0x186645E00", Slot = "9")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6645DD0", Offset = "0x6644BD0", VA = "0x186645DD0", Slot = "10")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class KGINBCHHJLK : CCOKCPKDNKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly EKNGNBEELEM DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float FPONOBPJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float KBFMHMBPEKC;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float OPGOFONHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x922D40", Offset = "0x921B40", VA = "0x180922D40", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6649260", Offset = "0x6648060", VA = "0x186649260", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float BCDNFHBJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5B0", Offset = "0x9BB3B0", VA = "0x1809BC5B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6649190", Offset = "0x6647F90", VA = "0x186649190", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6649420", Offset = "0x6648220", VA = "0x186649420")]
	public KGINBCHHJLK(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x66493D0", Offset = "0x66481D0", VA = "0x1866493D0", Slot = "8")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6649330", Offset = "0x6648130", VA = "0x186649330", Slot = "9")]
	public void IJNEOJGOACH(Rigidbody CEJHPNDBGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class CADKFMHCNMP : KGAPMFLBKGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool JEDJPFHIKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool AMNNOKMJMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int EBBHMPPOANE;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6631DE0", Offset = "0x6630BE0", VA = "0x186631DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool AMLCEMALNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6631700", Offset = "0x6630500", VA = "0x186631700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private EKNGNBEELEM GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6631E30", Offset = "0x6630C30", VA = "0x186631E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6631AA0", Offset = "0x66308A0", VA = "0x186631AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event MKODNDEIKFD CLKLEMKDPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6632170", Offset = "0x6630F70", VA = "0x186632170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x66318B0", Offset = "0x66306B0", VA = "0x1866318B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6632210", Offset = "0x6631010", VA = "0x186632210")]
	public CADKFMHCNMP(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6631B00", Offset = "0x6630900", VA = "0x186631B00", Slot = "6")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6631EE0", Offset = "0x6630CE0", VA = "0x186631EE0", Slot = "8")]
	public void JPCKMMJJKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6631950", Offset = "0x6630750", VA = "0x186631950", Slot = "7")]
	public bool GELNOGMHIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6631D40", Offset = "0x6630B40", VA = "0x186631D40", Slot = "9")]
	public void IBLHLILINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x66320D0", Offset = "0x6630ED0", VA = "0x1866320D0", Slot = "11")]
	public void ODPIPGKNKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6631E90", Offset = "0x6630C90", VA = "0x186631E90", Slot = "12")]
	public void IMAJCBAAIFC(bool GDPLLHKJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6631B90", Offset = "0x6630990", VA = "0x186631B90", Slot = "10")]
	public void HNDJMOGDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6631EF0", Offset = "0x6630CF0", VA = "0x186631EF0")]
	private bool KPDCENFGPNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6631720", Offset = "0x6630520", VA = "0x186631720")]
	private void EHNCCLIHBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class INHPKJMHJIK : KFPEKBNCNGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly IGJOIAOJFFC ECAGEEMAODN;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody ILLBONGHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool JFEDOFGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x665D920", Offset = "0x665C720", VA = "0x18665D920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool CLNFHKAFHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xD3A6B0", Offset = "0xD394B0", VA = "0x180D3A6B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x665E3E0", Offset = "0x665D1E0", VA = "0x18665E3E0")]
	public INHPKJMHJIK(EKNGNBEELEM DLFJFELKBNN, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x665D940", Offset = "0x665C740", VA = "0x18665D940", Slot = "5")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x665D5F0", Offset = "0x665C3F0", VA = "0x18665D5F0", Slot = "7")]
	public void BLKPLNMNING(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x665D9E0", Offset = "0x665C7E0", VA = "0x18665D9E0", Slot = "8")]
	public void JFPFGCEJILE(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x665DC00", Offset = "0x665CA00", VA = "0x18665DC00", Slot = "9")]
	public void JOGLFJNJIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x665DA10", Offset = "0x665C810", VA = "0x18665DA10", Slot = "11")]
	public void JKANGDJJKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x665D470", Offset = "0x665C270", VA = "0x18665D470", Slot = "12")]
	public void AHDLLPDIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x665DED0", Offset = "0x665CCD0", VA = "0x18665DED0", Slot = "10")]
	public void JOLGKKKAAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x665D620", Offset = "0x665C420", VA = "0x18665D620")]
	private void CHILKMMMENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x665D7A0", Offset = "0x665C5A0", VA = "0x18665D7A0")]
	private void DMGAPKADHDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class CIAMMHLCHBG : POCOHDNDLLG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly HFAPLIEMKLB DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IGJOIAOJFFC PBAKEMEDDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float BOBBJPNMAMG;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IHLGIAOCIPD EMFLGKMMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public CLIMPEFKHLB OHKPBGMCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 OBLHNAKCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x665AD90", Offset = "0x6659B90", VA = "0x18665AD90", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x665D1A0", Offset = "0x665BFA0", VA = "0x18665D1A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 CDMJNIAPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x665C160", Offset = "0x665AF60", VA = "0x18665C160", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x665BE40", Offset = "0x665AC40", VA = "0x18665BE40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 JMFBAGBBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x665C700", Offset = "0x665B500", VA = "0x18665C700", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x665B550", Offset = "0x665A350", VA = "0x18665B550", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 PMHPPAALNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x665B460", Offset = "0x665A260", VA = "0x18665B460", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x665B610", Offset = "0x665A410", VA = "0x18665B610", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float PEENFABEOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D490", VA = "0x18097E690", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x665C0B0", Offset = "0x665AEB0", VA = "0x18665C0B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PIEDFPMOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x16FF710", Offset = "0x16FE510", VA = "0x1816FF710", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private AHAABNAFIMA HAKFCIHKMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5F96370", Offset = "0x5F95170", VA = "0x185F96370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool AMLCEMALNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x664BC40", Offset = "0x664AA40", VA = "0x18664BC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x665D3D0", Offset = "0x665C1D0", VA = "0x18665D3D0")]
	public CIAMMHLCHBG(EKNGNBEELEM DLFJFELKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x665AB40", Offset = "0x6659940", VA = "0x18665AB40", Slot = "19")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x665ACD0", Offset = "0x6659AD0", VA = "0x18665ACD0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x665C250", Offset = "0x665B050", VA = "0x18665C250", Slot = "28")]
	public void MMCLMIODOFF(Rigidbody CEJHPNDBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8D6F0", VA = "0x180B8E8F0", Slot = "20")]
	public void HGLOCMLJLIH(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xB8ED00", Offset = "0xB8DB00", VA = "0x180B8ED00", Slot = "30")]
	public void DNCHHEDCCIA(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x665B2F0", Offset = "0x665A0F0", VA = "0x18665B2F0", Slot = "35")]
	public Vector3 FDFFIIPFIOH(Vector3 AILJOHDBLOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x665D050", Offset = "0x665BE50", VA = "0x18665D050", Slot = "34")]
	public Vector3 OKAAAHFDIMH(Vector3 IBOFICAFDGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x665AB40", Offset = "0x6659940", VA = "0x18665AB40", Slot = "27")]
	public void CPAKHEIBFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x665C5F0", Offset = "0x665B3F0", VA = "0x18665C5F0", Slot = "25")]
	public void NHOHNNKMDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x665AD30", Offset = "0x6659B30", VA = "0x18665AD30", Slot = "24")]
	public void EJGNCMLPKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x665C450", Offset = "0x665B250", VA = "0x18665C450", Slot = "33")]
	public void MPNNMODKIOO(Vector3 APNPBCPPCIE, Vector3 MDALJLLGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x665BDE0", Offset = "0x665ABE0", VA = "0x18665BDE0", Slot = "32")]
	public void HGLMDICABLI(Vector3 CCNMGEIHJLK, Vector3 BBMLLNFGHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x665D260", Offset = "0x665C060", VA = "0x18665D260", Slot = "31")]
	public void PALENGMMLOH(Vector3 PKKBKANJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x665B640", Offset = "0x665A440", VA = "0x18665B640", Slot = "22")]
	public void HDFLOMCCGIK(CJEDJIBDIOF MOJPOCIHIKN, Vector3 PJKGHICIFOI, float DMJOPIDCMKL, float JFPPBPBOABP = 8f, float GOGJIGKBCKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x665A8B0", Offset = "0x66596B0", VA = "0x18665A8B0", Slot = "21")]
	public void AFEBDNOKOAJ(ILFHCPDPFEL NBHIGMDLGAO, Vector3 DBGMHHNHFBL, float MFPNFOKIBBF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x665CCB0", Offset = "0x665BAB0", VA = "0x18665CCB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OCOMGINKLLI(ILFHCPDPFEL NBHIGMDLGAO, Vector3 OKEJHHGCFPM, float EGDADDHGAKE = 7f, float NOKKDJFAEED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x665BF50", Offset = "0x665AD50", VA = "0x18665BF50", Slot = "29")]
	public Vector3 LGEANPJHOEE(Vector3 HEHJKNMAHHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x665C320", Offset = "0x665B120", VA = "0x18665C320", Slot = "26")]
	public void MOAGBAPFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x665C0B0", Offset = "0x665AEB0", VA = "0x18665C0B0")]
	private void LNAMPMODJNM(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x665BC70", Offset = "0x665AA70", VA = "0x18665BC70")]
	private void HDFOPEFJDHP(Vector3 DBGMHHNHFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x665BE70", Offset = "0x665AC70", VA = "0x18665BE70")]
	private Vector3 LDELEFMKCLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x665A450", Offset = "0x6659250", VA = "0x18665A450")]
	private void ABNLNNJBNDG(Vector3 IBOFICAFDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x665ABF0", Offset = "0x66599F0", VA = "0x18665ABF0")]
	private Vector3 DMBGBPOBNKD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x665AEB0", Offset = "0x6659CB0", VA = "0x18665AEB0")]
	private void FCBHEPPEMKJ(Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x665C820", Offset = "0x665B620", VA = "0x18665C820")]
	private void NONLEEJKDKA(Vector3 IBOFICAFDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x665C650", Offset = "0x665B450", VA = "0x18665C650")]
	private void NJOCMKDOADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AAGNBLNDEIO : HMLJEHKIEJG
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x665A390", Offset = "0x6659190", VA = "0x18665A390", Slot = "4")]
	public LNCIHMBDFJF MOFLCGGDKPK(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x665A0C0", Offset = "0x6658EC0", VA = "0x18665A0C0", Slot = "5")]
	public POCOHDNDLLG FEGIFHKELGB(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6659E70", Offset = "0x6658C70", VA = "0x186659E70", Slot = "6")]
	public FGCKALLEMHH CEAEFAAILEL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x665A3F0", Offset = "0x66591F0", VA = "0x18665A3F0", Slot = "7")]
	public CCOKCPKDNKE NMHJGCJDFPP(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x665A270", Offset = "0x6659070", VA = "0x18665A270", Slot = "8")]
	public KGAPMFLBKGG GHDDDHMBBOF(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6659CB0", Offset = "0x6658AB0", VA = "0x186659CB0", Slot = "9")]
	public IMEFEPNFNJN AKOGHICPGOC(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x665A330", Offset = "0x6659130", VA = "0x18665A330", Slot = "10")]
	public PGJKKEBGPFO LNJFGEDJECL(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x665A1A0", Offset = "0x6658FA0", VA = "0x18665A1A0", Slot = "11")]
	public AHAABNAFIMA FKMHLFALDPO(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x665A2D0", Offset = "0x66590D0", VA = "0x18665A2D0", Slot = "12")]
	public NHJMPFEALEF LEHELPIFAFG(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6659FB0", Offset = "0x6658DB0", VA = "0x186659FB0", Slot = "13")]
	public OJIJDKGMOBN FANFNGELLNE(EKNGNBEELEM EJHNGBHNBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6659D80", Offset = "0x6658B80", VA = "0x186659D80")]
	public KFPEKBNCNGH BHBHEPIFGPL(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6659D10", Offset = "0x6658B10", VA = "0x186659D10")]
	public OIEEGPKJHPH GKJDMOMLAJH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6659F40", Offset = "0x6658D40", VA = "0x186659F40")]
	public DBMMHILOPGH KDLCIKOGHKF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x665A200", Offset = "0x6659000", VA = "0x18665A200")]
	public DPHCAIJIIDN GFMMJIMNAAG(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6659ED0", Offset = "0x6658CD0", VA = "0x186659ED0")]
	public IPFGDCNIMFJ FNMADPPCHNF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x665A010", Offset = "0x6658E10", VA = "0x18665A010", Slot = "19")]
	public EKNGNBEELEM FDOJNBAEAMC(RigidbodyEx DLFJFELKBNN, NNOHFOFGAFD EEDANCJJEPL, KNJKFALBANK LIDMLHOMNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public AAGNBLNDEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6659D80", Offset = "0x6658B80", VA = "0x186659D80", Slot = "14")]
	private KFPEKBNCNGH HFHHHBMEMAF(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6659D10", Offset = "0x6658B10", VA = "0x186659D10", Slot = "15")]
	private OIEEGPKJHPH BEOIGBALLMC(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6659F40", Offset = "0x6658D40", VA = "0x186659F40", Slot = "16")]
	private DBMMHILOPGH EEGEGKEJKCH(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x665A200", Offset = "0x6659000", VA = "0x18665A200", Slot = "17")]
	private DPHCAIJIIDN HHPDOOKNBDJ(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6659ED0", Offset = "0x6658CD0", VA = "0x186659ED0", Slot = "18")]
	private IPFGDCNIMFJ DGHANIOBKOK(EKNGNBEELEM EJHNGBHNBFP, [In] NNOHFOFGAFD EEDANCJJEPL)
	{
		return null;
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
