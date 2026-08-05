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
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void OPLLFGEIFBA(RigidbodyEx FIMDFNFDECM);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MBKKMCCOIPG(RigidbodyEx FIMDFNFDECM, bool MCPGFMFBGOC = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FAMJEMLEDEM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NLDKCAGALCE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LFHDNPMOEKP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PMDCDBMECJP(typeof(FJPJGOFOBAE), new string[] { "Ignore", "Mock" })]
public class MBOBAEEGJMP : FJPJGOFOBAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NEDIKDHIGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void IIAJEFJHELK(string HIFPPFEDDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void OEKKJBCOCDL(RigidbodyEx EBCLIMEMCGJ, Action IPGJPNDBCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "7")]
	public HNBDLINLDMG HJCFPFIKKMI(int HHAKDCGFEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "8")]
	public void HMPGJNKDJFL(Vector3 JCOCFJMNMNI, float LLFNLINHGCI, Color CEPDKAIKDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MBOBAEEGJMP()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly HICMFDICNOL HHOFIJKFKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool IMNKGDKCPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private AFHMHCLBGPL FANAOCMNHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[CMDEDFKOLHC(PBHAFHEAPLG.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[CMDEDFKOLHC(PBHAFHEAPLG.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private NLDKCAGALCE physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal AFHMHCLBGPL EJNKDKOJGBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x61E6B80", Offset = "0x61E5980", VA = "0x1861E6B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> FCCDIADKJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x760F20", Offset = "0x75FD20", VA = "0x180760F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx JNMMDEILJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61E8E10", Offset = "0x61E7C10", VA = "0x1861E8E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CCHJIKDEGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61E8D70", Offset = "0x61E7B70", VA = "0x1861E8D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LPDGANJNOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61E9A30", Offset = "0x61E8830", VA = "0x1861E9A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61EAFB0", Offset = "0x61E9DB0", VA = "0x1861EAFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform OJCNENCADOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x788120", Offset = "0x786F20", VA = "0x180788120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform PNPLLHEAAON
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x788120", Offset = "0x786F20", VA = "0x180788120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CANIILHKKMB HJMACGLHLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61E8B30", Offset = "0x61E7930", VA = "0x1861E8B30")]
			get
			{
				return default(CANIILHKKMB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61EA760", Offset = "0x61E9560", VA = "0x1861EA760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PMOILNEKMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61E90C0", Offset = "0x61E7EC0", VA = "0x1861E90C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FKOLKBFFJNL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x61E8C50", Offset = "0x61E7A50", VA = "0x1861E8C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EAICDDBCGGM GMAIBPBMGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x61E9000", Offset = "0x61E7E00", VA = "0x1861E9000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61EA920", Offset = "0x61E9720", VA = "0x1861EA920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MDFNBBCABMJ AODOJPBNBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61E8FA0", Offset = "0x61E7DA0", VA = "0x1861E8FA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61EA8B0", Offset = "0x61E96B0", VA = "0x1861EA8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CJDFJPEDNLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x61E8EF0", Offset = "0x61E7CF0", VA = "0x1861E8EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody DGCCHJJPLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x61E8F50", Offset = "0x61E7D50", VA = "0x1861E8F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NOHCGIHGCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x61E8CB0", Offset = "0x61E7AB0", VA = "0x1861E8CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x61EA7D0", Offset = "0x61E95D0", VA = "0x1861EA7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BKPFMMLKINH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1A525D0", Offset = "0x1A513D0", VA = "0x181A525D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5A732B0", Offset = "0x5A720B0", VA = "0x185A732B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float PBAFEEAKDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x61E99D0", Offset = "0x61E87D0", VA = "0x1861E99D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float DKINIKOLCGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x61E9970", Offset = "0x61E8770", VA = "0x1861E9970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x61EAF40", Offset = "0x61E9D40", VA = "0x1861EAF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JHJLCBLFJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x61E9320", Offset = "0x61E8120", VA = "0x1861E9320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x61EABC0", Offset = "0x61E99C0", VA = "0x1861EABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float JNJCPCMFNDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x61E9120", Offset = "0x61E7F20", VA = "0x1861E9120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x61EA990", Offset = "0x61E9790", VA = "0x1861EA990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NFDCFICNIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61E9F90", Offset = "0x61E8D90", VA = "0x1861E9F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x61EB510", Offset = "0x61EA310", VA = "0x1861EB510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 EILEFJOFIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x61E9750", Offset = "0x61E8550", VA = "0x1861E9750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x61EAD10", Offset = "0x61E9B10", VA = "0x1861EAD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JCOCFJMNMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x61EA0D0", Offset = "0x61E8ED0", VA = "0x1861EA0D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode FMHENENEFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x61E9260", Offset = "0x61E8060", VA = "0x1861E9260")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x61EAAE0", Offset = "0x61E98E0", VA = "0x1861EAAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float HNJDPJEIILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61E8D10", Offset = "0x61E7B10", VA = "0x1861E8D10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x61EA840", Offset = "0x61E9640", VA = "0x1861EA840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints AKPIKNNEDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x61E92C0", Offset = "0x61E80C0", VA = "0x1861E92C0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x61EAB50", Offset = "0x61E9950", VA = "0x1861EAB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 PFCBHCPEOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x61E9AD0", Offset = "0x61E88D0", VA = "0x1861E9AD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FJMHCMGPAKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x61E9AD0", Offset = "0x61E88D0", VA = "0x1861E9AD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61EB2F0", Offset = "0x61EA0F0", VA = "0x1861EB2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float IAHLFMLLBJD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x61E9830", Offset = "0x61E8630", VA = "0x1861E9830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61EADF0", Offset = "0x61E9BF0", VA = "0x1861EADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ANLGAJIADKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61E9F30", Offset = "0x61E8D30", VA = "0x1861E9F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x61EB4A0", Offset = "0x61EA2A0", VA = "0x1861EB4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion HGLCDPGIHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61E9BB0", Offset = "0x61E89B0", VA = "0x1861E9BB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x61EB070", Offset = "0x61E9E70", VA = "0x1861EB070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion PDELHCKGAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x61E9E50", Offset = "0x61E8C50", VA = "0x1861E9E50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x61EB3D0", Offset = "0x61EA1D0", VA = "0x1861EB3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 AMPALEJNGNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x61E9C90", Offset = "0x61E8A90", VA = "0x1861E9C90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x61EB140", Offset = "0x61E9F40", VA = "0x1861EB140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LALAOICPOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x61E9D70", Offset = "0x61E8B70", VA = "0x1861E9D70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x61EB220", Offset = "0x61EA020", VA = "0x1861EB220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 JIJAOBLIPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x61E9FF0", Offset = "0x61E8DF0", VA = "0x1861E9FF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61EB580", Offset = "0x61EA380", VA = "0x1861EB580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PFHKDIPHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x61E9890", Offset = "0x61E8690", VA = "0x1861E9890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x61EAE60", Offset = "0x61E9C60", VA = "0x1861EAE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PCFFHDKFCBP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x61E9180", Offset = "0x61E7F80", VA = "0x1861E9180")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x61EAA00", Offset = "0x61E9800", VA = "0x1861EAA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PHGPAJDKPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x61E9670", Offset = "0x61E8470", VA = "0x1861E9670")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61EAC30", Offset = "0x61E9A30", VA = "0x1861EAC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FLGPPHOOBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x61E9530", Offset = "0x61E8330", VA = "0x1861E9530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion JALLMMLFEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x61E9450", Offset = "0x61E8250", VA = "0x1861E9450")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ENEDBEPJKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61EA290", Offset = "0x61E9090", VA = "0x1861EA290")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CNNOBCJGPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x61EA1B0", Offset = "0x61E8FB0", VA = "0x1861EA1B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool MOJBMAEBGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x61E9610", Offset = "0x61E8410", VA = "0x1861E9610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CLDEONKBEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x61E9060", Offset = "0x61E7E60", VA = "0x1861E9060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IPAFIEPPIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x61E8BF0", Offset = "0x61E79F0", VA = "0x1861E8BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CMJDNEDLFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x61E8B90", Offset = "0x61E7990", VA = "0x1861E8B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BDPGIFJOMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x61E8AD0", Offset = "0x61E78D0", VA = "0x1861E8AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DOAFOOFFFGB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x61E9380", Offset = "0x61E8180", VA = "0x1861E9380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NCHMLMBHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4E43F50", Offset = "0x4E42D50", VA = "0x184E43F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OPLLFGEIFBA DEAFBHBGHMF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x61E89F0", Offset = "0x61E77F0", VA = "0x1861E89F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x61EA680", Offset = "0x61E9480", VA = "0x1861EA680")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MBKKMCCOIPG BKBANCCDDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x61E8980", Offset = "0x61E7780", VA = "0x1861E8980")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x61EA610", Offset = "0x61E9410", VA = "0x1861EA610")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OPLLFGEIFBA NHEANGMCKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x61E86E0", Offset = "0x61E74E0", VA = "0x1861E86E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x61EA370", Offset = "0x61E9170", VA = "0x1861EA370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OPLLFGEIFBA OKHMBPMOOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x61E8750", Offset = "0x61E7550", VA = "0x1861E8750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x61EA3E0", Offset = "0x61E91E0", VA = "0x1861EA3E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OPLLFGEIFBA CFHBGAIBAOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x61E88A0", Offset = "0x61E76A0", VA = "0x1861E88A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x61EA530", Offset = "0x61E9330", VA = "0x1861EA530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x61E8830", Offset = "0x61E7630", VA = "0x1861E8830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x61EA4C0", Offset = "0x61E92C0", VA = "0x1861EA4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OPLLFGEIFBA IOCDGJLALKO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x61E8910", Offset = "0x61E7710", VA = "0x1861E8910")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x61EA5A0", Offset = "0x61E93A0", VA = "0x1861EA5A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OPLLFGEIFBA CDPDBONBILN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x61E8A60", Offset = "0x61E7860", VA = "0x1861E8A60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x61EA6F0", Offset = "0x61E94F0", VA = "0x1861EA6F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event OPLLFGEIFBA EHEJIDGBADF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61E87C0", Offset = "0x61E75C0", VA = "0x1861E87C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61EA450", Offset = "0x61E9250", VA = "0x1861EA450")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		internal void POKCNEOIPEJ(AFHMHCLBGPL IIJDENGNPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61E77B0", Offset = "0x61E65B0", VA = "0x1861E77B0")]
		internal void PAIBMEINKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61E8400", Offset = "0x61E7200", VA = "0x1861E8400")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody MKBDEAJHHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61E80D0", Offset = "0x61E6ED0", VA = "0x1861E80D0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61E6B10", Offset = "0x61E5910", VA = "0x1861E6B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61E6B80", Offset = "0x61E5980", VA = "0x1861E6B80")]
		private AFHMHCLBGPL OMEKEHLMPLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61E72B0", Offset = "0x61E60B0", VA = "0x1861E72B0")]
		private void LKOIJBFKMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x61E78A0", Offset = "0x61E66A0", VA = "0x1861E78A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61E77B0", Offset = "0x61E65B0", VA = "0x1861E77B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61E7840", Offset = "0x61E6640", VA = "0x1861E7840")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61E7900", Offset = "0x61E6700", VA = "0x1861E7900")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61E61C0", Offset = "0x61E4FC0", VA = "0x1861E61C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61E7960", Offset = "0x61E6760", VA = "0x1861E7960")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61E6E10", Offset = "0x61E5C10", VA = "0x1861E6E10")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61E7750", Offset = "0x61E6550", VA = "0x1861E7750")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x61E8230", Offset = "0x61E7030", VA = "0x1861E8230")]
		public void SetParent(RigidbodyEx POACLGOFKAJ, bool MCPGFMFBGOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61E7C70", Offset = "0x61E6A70", VA = "0x1861E7C70")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61E7090", Offset = "0x61E5E90", VA = "0x1861E7090")]
		public bool IsRigidbodyAncestor(RigidbodyEx POLPGGJPPNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61E7170", Offset = "0x61E5F70", VA = "0x1861E7170")]
		public bool IsRigidbodyDescendant(RigidbodyEx BHDJFEBFLKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61E6430", Offset = "0x61E5230", VA = "0x1861E6430")]
		public void AddInterpolationRestriction(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61E79D0", Offset = "0x61E67D0", VA = "0x1861E79D0")]
		public void RemoveInterpolationRestriction(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61E6C30", Offset = "0x61E5A30", VA = "0x1861E6C30")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61E64A0", Offset = "0x61E52A0", VA = "0x1861E64A0")]
		public void AddKinematic(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61E7A40", Offset = "0x61E6840", VA = "0x1861E7A40")]
		public void RemoveKinematic(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61E81B0", Offset = "0x61E6FB0", VA = "0x1861E81B0")]
		public void SetKinematic(object EKDHBKMFLGI, bool PACNNAFJCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61E7FD0", Offset = "0x61E6DD0", VA = "0x1861E7FD0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AJMCFPCIEEJ, Quaternion FLNKDKBDHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61E7ED0", Offset = "0x61E6CD0", VA = "0x1861E7ED0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PPDEPMDHBIE, Quaternion AGPEIIIHNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61E6F80", Offset = "0x61E5D80", VA = "0x1861E6F80")]
		public Vector3 GetConstrainedVelocity(Vector3 JIJAOBLIPMH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61E6E70", Offset = "0x61E5C70", VA = "0x1861E6E70")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 PCFFHDKFCBP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61E6340", Offset = "0x61E5140", VA = "0x1861E6340")]
		public void AddForce(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61E6230", Offset = "0x61E5030", VA = "0x1861E6230")]
		public void AddForceAtPosition(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61E6670", Offset = "0x61E5470", VA = "0x1861E6670")]
		public void AddTorque(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61E6510", Offset = "0x61E5310", VA = "0x1861E6510")]
		public void AddRelativeTorque(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61E84D0", Offset = "0x61E72D0", VA = "0x1861E84D0")]
		public Vector3 WorldToLocalVelocity(Vector3 FGPAGLKAPID)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61E7640", Offset = "0x61E6440", VA = "0x1861E7640")]
		public Vector3 LocalToWorldVelocity(Vector3 PFHKDIPHHDE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61E6DB0", Offset = "0x61E5BB0", VA = "0x1861E6DB0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61E6D50", Offset = "0x61E5B50", VA = "0x1861E6D50")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61E6CF0", Offset = "0x61E5AF0", VA = "0x1861E6CF0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61E6C90", Offset = "0x61E5A90", VA = "0x1861E6C90")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61E7DD0", Offset = "0x61E6BD0", VA = "0x1861E7DD0")]
		public void ResetVelocityWorldSpace(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61E7CD0", Offset = "0x61E6AD0", VA = "0x1861E7CD0")]
		public void ResetVelocityLocalSpace(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x61E7B90", Offset = "0x61E6990", VA = "0x1861E7B90")]
		public void ResetLinearVelocityLocalSpace(Vector3 MFOHPHLHCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61E8360", Offset = "0x61E7160", VA = "0x1861E8360")]
		public bool SweepTest(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61E7250", Offset = "0x61E6050", VA = "0x1861E7250")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61E8300", Offset = "0x61E7100", VA = "0x1861E8300")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61E8470", Offset = "0x61E7270", VA = "0x1861E8470")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61E6600", Offset = "0x61E5400", VA = "0x1861E6600")]
		public void AddShouldHaveUnityRigidbodyToken(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61E7AB0", Offset = "0x61E68B0", VA = "0x1861E7AB0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61E69A0", Offset = "0x61E57A0", VA = "0x1861E69A0")]
		public void ApplyForceVelocityChange(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x61E6900", Offset = "0x61E5700", VA = "0x1861E6900")]
		public void ApplyAngularVelocityChange(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61E6A60", Offset = "0x61E5860", VA = "0x1861E6A60")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61E6830", Offset = "0x61E5630", VA = "0x1861E6830")]
		public bool AllowedScaleChange(float DGEJJEICPCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61E6760", Offset = "0x61E5560", VA = "0x1861E6760")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx EKKBLJBHBHE, object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61E7B20", Offset = "0x61E6920", VA = "0x1861E7B20")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EKDHBKMFLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61E8670", Offset = "0x61E7470", VA = "0x1861E8670")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DHPBFFPFCOF
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61CC3E0", Offset = "0x61CB1E0", VA = "0x1861CC3E0")]
	public static AFHMHCLBGPL EJNKDKOJGBP(this RigidbodyEx EBCLIMEMCGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GJIHNGPJMHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody IMDIIOPGPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView HIFKLECGFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 BGABOHGMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 NEIHEGNBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NLDKCAGALCE EPFHBFGFNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool BAJPFDKOHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool EKLGOMFPMNF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PMDCDBMECJP(typeof(OBIMNGPJPFI), new string[] { })]
public class JLMICEJNDBD : OBIMNGPJPFI, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LLDCKPPKNLB BMJPGJOIFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FJPJGOFOBAE JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private DNCFLFJNBGK OMLFBGOEAGP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FJPJGOFOBAE HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DNCFLFJNBGK LPKEFNMBODP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61DD640", Offset = "0x61DC440", VA = "0x1861DD640", Slot = "8")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61DD390", Offset = "0x61DC190", VA = "0x1861DD390", Slot = "6")]
	public EPCANLGBBON HDBBDENKEGP(RigidbodyEx EBCLIMEMCGJ)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61DD6D0", Offset = "0x61DC4D0", VA = "0x1861DD6D0")]
	private static EPCANLGBBON MGOMAJIKHHM(RigidbodyEx EBCLIMEMCGJ)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61DD2F0", Offset = "0x61DC0F0", VA = "0x1861DD2F0", Slot = "7")]
	public AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JLMICEJNDBD()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static HJOHDOIHOEL UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int MODAPHIPNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int LMGEMMKFKBE;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61E6020", Offset = "0x61E4E20", VA = "0x1861E6020")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61E6060", Offset = "0x61E4E60", VA = "0x1861E6060")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61E6040", Offset = "0x61E4E40", VA = "0x1861E6040")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BLAOEBOMGGP, [Optional] UnityEngine.Object DDMHMHFODEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BLAOEBOMGGP, [Optional] UnityEngine.Object DDMHMHFODEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x61E6170", Offset = "0x61E4F70", VA = "0x1861E6170")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KGIFOHFIEBH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61DDEC0", Offset = "0x61DCCC0", VA = "0x1861DDEC0")]
	public static void GALIINJCMMP(this Rigidbody MKBDEAJHHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61DE050", Offset = "0x61DCE50", VA = "0x1861DE050")]
	public static void GALIINJCMMP(this Rigidbody MKBDEAJHHMH, Vector3 GKLNLMPPPOG, Quaternion JALLMMLFEHC, Vector3 MMJEPDHJOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB3A9B0", Offset = "0xB397B0", VA = "0x180B3A9B0")]
	public static void GCOGDICNIKN(Vector3 JIJAOBLIPMH, Vector3 ABLMGKFECDN, [Out] Vector3 ACBFBKHGDPF, [Out] Vector3 AJMDMIMMONB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CCLNENICLJB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class GDCELKAEBOP : EAICDDBCGGM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E990", Offset = "0x76D790", VA = "0x18076E990", Slot = "4")]
		public Vector3 MEOLMOHJCIP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x76E990", Offset = "0x76D790", VA = "0x18076E990", Slot = "5")]
		public Vector3 KJBHKLGJEKN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GDCELKAEBOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static EAICDDBCGGM LOOGJCGCNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61C9320", Offset = "0x61C8120", VA = "0x1861C9320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CDAIFLEPMCD
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGLFDNPNEOI(bool MOJBMAEBGOB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHMDIAEIIED(bool MOJBMAEBGOB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AJDCFLFHENI : IDisposable, FHMMDJEGHBP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBKJIACAHLC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
public interface DNCFLFJNBGK
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACKPPMBHNPB FLHJOIDNMBF(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJCBHAEKLLK JOMLJJNHEFD(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGPMOHBFCIK PMCNMDAMJPA(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KCMJCMMJLOM DDECDGMLLLN(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCBDEJNLIBE HBHHEHGGIBP(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AJDCFLFHENI MBFCIJLEHOM(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GCLEAEBJEJA KDFDKAKHHPL(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLIDKDJAIPG MABLEBGNIEP(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CDAIFLEPMCD AFNAGMMCLBG(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DKIHIGMFBHJ MPJCIOHIADF(AFHMHCLBGPL IIJDENGNPJH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NMIMBODNLJI FFLIPKGEEDG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FNJBMNDKPLN HOAMBNLCLLB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ACBNPECKOAN IENBAJNMOIH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GDFECGMIEMM KHJMLFGPIAP(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FOCHNEJJMDO JLHGMBPIGAB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP, OBIMNGPJPFI AMCDJKCDDEF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CLIDKDJAIPG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DKIHIGMFBHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ACKPPMBHNPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OPLLFGEIFBA NHEANGMCKDF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OPLLFGEIFBA OKHMBPMOOPI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MBKKMCCOIPG GLBJKAKEGCD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CLOLLEOLJNH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action MPKDJHNAIEK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AFHMHCLBGPL> BOBLLFGOFEF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<AFHMHCLBGPL> MKFMCBJCGNA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action CEKGJANOJPB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<AFHMHCLBGPL> JILPDOBNMIE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AIEIBGACDCB(AFHMHCLBGPL CEBKCILOOLP, bool MCPGFMFBGOC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IGPMOHBFCIK
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGEKNDEFMEI(AFHMHCLBGPL LPDGANJNOMK, object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEINGDGJHID(object EKDHBKMFLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GDFECGMIEMM
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OPLLFGEIFBA LNECMPPGONO;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DOHEBIHADFN();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FICIDNHDLOK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GFEBEDIHENK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IJJLIEINFAF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ACBNPECKOAN
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFBNOFDAPGG(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGBFHLHBONF(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMGIAAHKJIC(AFHMHCLBGPL EBCLIMEMCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHLNCEAFEDH(AFHMHCLBGPL EBCLIMEMCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEOOKHEPDLK();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GCLEAEBJEJA
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OPLLFGEIFBA EKGBOJKJJNC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJDDCAMEMAD();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEJDCJEGLEE(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHGHHIKNMIH(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable CJDNPCMAGDJ();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHMAEOCCFDI(Rigidbody ANDHNALLMFE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FNJBMNDKPLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event OPLLFGEIFBA FPOFAHOLBEM;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMFHFOICOHL(AFHMHCLBGPL LPDGANJNOMK);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOGDNBGBPBH(AFHMHCLBGPL LPDGANJNOMK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FOCHNEJJMDO
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EJFLOBHJLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KCMJCMMJLOM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CBMKPOKICLK
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx OJACFBINKBG);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PCBDEJNLIBE
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event OPLLFGEIFBA IPEEDOMDGDB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHDICAKHBGB();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAGDCCCGKMP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEFEOLICJHK();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIFDDHHFGON();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LKLMCLDBKDN();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCOAOEOCLOG(bool GEFNNEJLOOB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NMIMBODNLJI
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CLMAJLBDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPBJBLDHMLC(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOMCGDIDDGE(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFFOHPOCDLK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHPIHHCBCFO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KJCBHAEKLLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MNGJMFIPKKA(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IKKFNLBJCOO();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PBLACPABIDH();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PCPELMIIDHL();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EIKGJPKGMFH();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KBMECCIPCJF(Vector3 JIJAOBLIPMH);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DGMECMMNNNM(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NANGECNGOHL(Vector3 EHHHOADEPAD);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
public interface FJPJGOFOBAE
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NEDIKDHIGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIAJEFJHELK(string HIFPPFEDDLE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEKKJBCOCDL(RigidbodyEx EBCLIMEMCGJ, Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNBDLINLDMG HJCFPFIKKMI(int HHAKDCGFEPD);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMPGJNKDJFL(Vector3 JCOCFJMNMNI, float LLFNLINHGCI, Color CEPDKAIKDOH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
public interface OBIMNGPJPFI
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FJPJGOFOBAE HGMDPNHJIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	DNCFLFJNBGK LPKEFNMBODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EPCANLGBBON HDBBDENKEGP(RigidbodyEx EBCLIMEMCGJ);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MDFNBBCABMJ
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFFOEILFDKG(Vector3 DMOGAIDCGDF);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFPGHDMLPDF(Vector3 PCFFHDKFCBP);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJJCPOJMENP(Vector3 DMOGAIDCGDF);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBDCBMMNJJJ(Vector3 PCFFHDKFCBP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EAICDDBCGGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MEOLMOHJCIP();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KJBHKLGJEKN();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AFHMHCLBGPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx PIEGHOBIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject NOMLNDHBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool CMJDNEDLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool BDPGIFJOMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform PNPLLHEAAON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 FJLCOOOFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float MECGPNGIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float CFPAPCLNAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion GPHPDBHPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 LCPDOLOFPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion AEJINJPKNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool CLDEONKBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event OPLLFGEIFBA NHEANGMCKDF;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event OPLLFGEIFBA OKHMBPMOOPI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MBKKMCCOIPG GLBJKAKEGCD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event OPLLFGEIFBA FPOFAHOLBEM;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event OPLLFGEIFBA CFHBGAIBAOO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event OPLLFGEIFBA IPEEDOMDGDB;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event OPLLFGEIFBA EKGBOJKJJNC;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event OPLLFGEIFBA EHEJIDGBADF;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void GBKJIACAHLC();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DLBGPCKLDEJ();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AJFAFEMLEHI();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void LEFEOLICJHK();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void AIEIBGACDCB(AFHMHCLBGPL POACLGOFKAJ, bool MCPGFMFBGOC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void BLOEJDKJNDB(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void PHDEHILJHEH(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void EIKGJPKGMFH();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void PBLACPABIDH();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void IKKFNLBJCOO();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NANGECNGOHL(Vector3 EHHHOADEPAD);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 KBMECCIPCJF(Vector3 POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JEHIJLJANBD(Vector3 POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PCPELMIIDHL();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MMJPJMKAPFF(AFHMHCLBGPL EKKBLJBHBHE, object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void CIBBIFNDEKN(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FICIDNHDLOK();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void DOHEBIHADFN();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GFEBEDIHENK();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool CHDICAKHBGB();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LKLMCLDBKDN();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable CJDNPCMAGDJ();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HEJDCJEGLEE(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void JHGHHIKNMIH(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void EFNDFHFPFMG(Vector3 AJMCFPCIEEJ, Quaternion FLNKDKBDHOM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void KCBCOHDEPPK(Vector3 PPDEPMDHBIE, Quaternion AGPEIIIHNMN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool LHFIODPLHAN(float DGEJJEICPCE);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void PBHJHBLHANJ(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void MOLNEBLHJPG(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void MPBJBLDHMLC(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void JOMCGDIDDGE(object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IJJLIEINFAF();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EHIGKANDEAP : AFHMHCLBGPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly OBIMNGPJPFI AMCDJKCDDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ACKPPMBHNPB MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal ACBNPECKOAN KFAKPEGHCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FNJBMNDKPLN NAMNFILNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal KJCBHAEKLLK JIJAOBLIPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IGPMOHBFCIK ADJJODLCDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal GDFECGMIEMM GPLHNLKLPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal KCMJCMMJLOM JFLOCOEPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal DKIHIGMFBHJ BGKGMJOPICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PCBDEJNLIBE NIAJJDECILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal AJDCFLFHENI GEJFNFOGDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal GCLEAEBJEJA ALMNJCDKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CLIDKDJAIPG PIOPLCOODHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal FOCHNEJJMDO IGLJMEFFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal NMIMBODNLJI IMDIIOPGPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal CDAIFLEPMCD NAFIEFCNHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable KFCBCNDNHEF;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx PIEGHOBIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x767990", Offset = "0x766790", VA = "0x180767990", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7679D0", Offset = "0x7667D0", VA = "0x1807679D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject NOMLNDHBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x89EB10", Offset = "0x89D910", VA = "0x18089EB10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x89FCC0", Offset = "0x89EAC0", VA = "0x18089FCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x61D2010", Offset = "0x61D0E10", VA = "0x1861D2010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61D6030", Offset = "0x61D4E30", VA = "0x1861D6030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x61D1D90", Offset = "0x61D0B90", VA = "0x1861D1D90", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x61D2BB0", Offset = "0x61D19B0", VA = "0x1861D2BB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x61D6960", Offset = "0x61D5760", VA = "0x1861D6960", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x61D4370", Offset = "0x61D3170", VA = "0x1861D4370", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x61D6FC0", Offset = "0x61D5DC0", VA = "0x1861D6FC0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x61D4500", Offset = "0x61D3300", VA = "0x1861D4500", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x61D2C70", Offset = "0x61D1A70", VA = "0x1861D2C70", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x61D4AB0", Offset = "0x61D38B0", VA = "0x1861D4AB0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x61D3EE0", Offset = "0x61D2CE0", VA = "0x1861D3EE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x61D1680", Offset = "0x61D0480", VA = "0x1861D1680", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x61D60F0", Offset = "0x61D4EF0", VA = "0x1861D60F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x61D5170", Offset = "0x61D3F70", VA = "0x1861D5170", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x61D2540", Offset = "0x61D1340", VA = "0x1861D2540", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x61D4670", Offset = "0x61D3470", VA = "0x1861D4670", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x61D3320", Offset = "0x61D2120", VA = "0x1861D3320", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x61D1E80", Offset = "0x61D0C80", VA = "0x1861D1E80", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x61D1450", Offset = "0x61D0250", VA = "0x1861D1450", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x61D16D0", Offset = "0x61D04D0", VA = "0x1861D16D0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x61D6880", Offset = "0x61D5680", VA = "0x1861D6880", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x61D5B60", Offset = "0x61D4960", VA = "0x1861D5B60", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x61D5090", Offset = "0x61D3E90", VA = "0x1861D5090", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool IPAFIEPPIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6E30", Offset = "0x61D5C30", VA = "0x1861D6E30", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CMJDNEDLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x61D4BE0", Offset = "0x61D39E0", VA = "0x1861D4BE0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BDPGIFJOMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x61D3F90", Offset = "0x61D2D90", VA = "0x1861D3F90", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x61D3CF0", Offset = "0x61D2AF0", VA = "0x1861D3CF0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x61D42A0", Offset = "0x61D30A0", VA = "0x1861D42A0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x61D3DA0", Offset = "0x61D2BA0", VA = "0x1861D3DA0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x61D2690", Offset = "0x61D1490", VA = "0x1861D2690", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x61D4B00", Offset = "0x61D3900", VA = "0x1861D4B00", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x61D5EB0", Offset = "0x61D4CB0", VA = "0x1861D5EB0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x61D1400", Offset = "0x61D0200", VA = "0x1861D1400", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x61D24F0", Offset = "0x61D12F0", VA = "0x1861D24F0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x61D4240", Offset = "0x61D3040", VA = "0x1861D4240", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6E80", Offset = "0x61D5C80", VA = "0x1861D6E80", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x61D3520", Offset = "0x61D2320", VA = "0x1861D3520", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x61D3650", Offset = "0x61D2450", VA = "0x1861D3650", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x61D2260", Offset = "0x61D1060", VA = "0x1861D2260", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x61D2970", Offset = "0x61D1770", VA = "0x1861D2970", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x61D31B0", Offset = "0x61D1FB0", VA = "0x1861D31B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x61D2D10", Offset = "0x61D1B10", VA = "0x1861D2D10", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x61D2200", Offset = "0x61D1000", VA = "0x1861D2200", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x61D20A0", Offset = "0x61D0EA0", VA = "0x1861D20A0", Slot = "48")]
		get
		{
			return default(NJDNLEIDKBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x61D5C40", Offset = "0x61D4A40", VA = "0x1861D5C40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x61D36A0", Offset = "0x61D24A0", VA = "0x1861D36A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform PNPLLHEAAON
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x61D13D0", Offset = "0x61D01D0", VA = "0x1861D13D0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 FJLCOOOFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x61D29C0", Offset = "0x61D17C0", VA = "0x1861D29C0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x61D5690", Offset = "0x61D4490", VA = "0x1861D5690", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float MECGPNGIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x61D60D0", Offset = "0x61D4ED0", VA = "0x1861D60D0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x61D2430", Offset = "0x61D1230", VA = "0x1861D2430", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float CFPAPCLNAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x61D2670", Offset = "0x61D1470", VA = "0x1861D2670", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x61D5590", Offset = "0x61D4390", VA = "0x1861D5590", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion GPHPDBHPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x61D5750", Offset = "0x61D4550", VA = "0x1861D5750", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x61D1590", Offset = "0x61D0390", VA = "0x1861D1590", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 LCPDOLOFPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x61D2F70", Offset = "0x61D1D70", VA = "0x1861D2F70", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x61D4F80", Offset = "0x61D3D80", VA = "0x1861D4F80", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion AEJINJPKNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x61D43C0", Offset = "0x61D31C0", VA = "0x1861D43C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x61D34E0", Offset = "0x61D22E0", VA = "0x1861D34E0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x61D6C80", Offset = "0x61D5A80", VA = "0x1861D6C80", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x61D5210", Offset = "0x61D4010", VA = "0x1861D5210", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6080", Offset = "0x61D4E80", VA = "0x1861D6080", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x61D6CD0", Offset = "0x61D5AD0", VA = "0x1861D6CD0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x61D5B10", Offset = "0x61D4910", VA = "0x1861D5B10", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x61D1530", Offset = "0x61D0330", VA = "0x1861D1530", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HGHFLMAHMON
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x61D4DF0", Offset = "0x61D3BF0", VA = "0x1861D4DF0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CLDEONKBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x61D6640", Offset = "0x61D5440", VA = "0x1861D6640", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NIDEIKDFBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x61D6D30", Offset = "0x61D5B30", VA = "0x1861D6D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PJEBLLNNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6150", Offset = "0x61D4F50", VA = "0x1861D6150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OPLLFGEIFBA NHEANGMCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x61D32C0", Offset = "0x61D20C0", VA = "0x1861D32C0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x61D67C0", Offset = "0x61D55C0", VA = "0x1861D67C0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OPLLFGEIFBA OKHMBPMOOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x61D65E0", Offset = "0x61D53E0", VA = "0x1861D65E0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x61D5030", Offset = "0x61D3E30", VA = "0x1861D5030", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MBKKMCCOIPG GLBJKAKEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x61D3260", Offset = "0x61D2060", VA = "0x1861D3260", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x61D11A0", Offset = "0x61CFFA0", VA = "0x1861D11A0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event OPLLFGEIFBA FPOFAHOLBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x61D45B0", Offset = "0x61D33B0", VA = "0x1861D45B0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x61D2B50", Offset = "0x61D1950", VA = "0x1861D2B50", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event OPLLFGEIFBA CFHBGAIBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x61D3D40", Offset = "0x61D2B40", VA = "0x1861D3D40", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x61D1200", Offset = "0x61D0000", VA = "0x1861D1200", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event OPLLFGEIFBA IPEEDOMDGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x61D4D90", Offset = "0x61D3B90", VA = "0x1861D4D90", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x61D4D30", Offset = "0x61D3B30", VA = "0x1861D4D30", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x61D6F60", Offset = "0x61D5D60", VA = "0x1861D6F60", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E80", Offset = "0x61D2C80", VA = "0x1861D3E80", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event OPLLFGEIFBA EKGBOJKJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x61D2C10", Offset = "0x61D1A10", VA = "0x1861D2C10", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x61D6820", Offset = "0x61D5620", VA = "0x1861D6820", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event OPLLFGEIFBA EHEJIDGBADF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x61D5A60", Offset = "0x61D4860", VA = "0x1861D5A60", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x61D1F60", Offset = "0x61D0D60", VA = "0x1861D1F60", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x61CC310", Offset = "0x61CB110", VA = "0x1861CC310")]
	public EHIGKANDEAP(GameObject LEMKPNELLPI, RigidbodyEx IILFEDCNOPF, OBIMNGPJPFI AMCDJKCDDEF, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x61D1900", Offset = "0x61D0700", VA = "0x1861D1900", Slot = "135")]
	protected virtual void CHAFGEIHJHP(OBIMNGPJPFI AMCDJKCDDEF, GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x61D25A0", Offset = "0x61D13A0", VA = "0x1861D25A0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x61D3070", Offset = "0x61D1E70", VA = "0x1861D3070", Slot = "71")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x61D21B0", Offset = "0x61D0FB0", VA = "0x1861D21B0", Slot = "72")]
	public void DLBGPCKLDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61D13E0", Offset = "0x61D01E0", VA = "0x1861D13E0", Slot = "73")]
	public void AJFAFEMLEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D40C0", Offset = "0x61D2EC0", VA = "0x1861D40C0")]
	private void ILGLEEIALCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x61D1360", Offset = "0x61D0160", VA = "0x1861D1360", Slot = "81")]
	public void AIEIBGACDCB(AFHMHCLBGPL POACLGOFKAJ, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x61D18A0", Offset = "0x61D06A0", VA = "0x1861D18A0", Slot = "84")]
	public void BLOEJDKJNDB(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x61D6DD0", Offset = "0x61D5BD0", VA = "0x1861D6DD0", Slot = "85")]
	public void PHDEHILJHEH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x61D1260", Offset = "0x61D0060", VA = "0x1861D1260", Slot = "86")]
	public Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x61D69B0", Offset = "0x61D57B0", VA = "0x1861D69B0", Slot = "87")]
	public Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x61D21B0", Offset = "0x61D0FB0", VA = "0x1861D21B0", Slot = "88")]
	public void EIKGJPKGMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x61D6BE0", Offset = "0x61D59E0", VA = "0x1861D6BE0", Slot = "89")]
	public void PBLACPABIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x61D4070", Offset = "0x61D2E70", VA = "0x1861D4070", Slot = "90")]
	public void IKKFNLBJCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61D4C40", Offset = "0x61D3A40", VA = "0x1861D4C40", Slot = "91")]
	public void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x61D17B0", Offset = "0x61D05B0", VA = "0x1861D17B0", Slot = "92")]
	public void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x61D5DD0", Offset = "0x61D4BD0", VA = "0x1861D5DD0", Slot = "93")]
	public void NANGECNGOHL(Vector3 EHHHOADEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x61D20F0", Offset = "0x61D0EF0", VA = "0x1861D20F0", Slot = "94")]
	public void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x61D5F90", Offset = "0x61D4D90", VA = "0x1861D5F90", Slot = "95")]
	public void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x61D2FC0", Offset = "0x61D1DC0", VA = "0x1861D2FC0", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x61D4750", Offset = "0x61D3550", VA = "0x1861D4750", Slot = "97")]
	public Vector3 KBMECCIPCJF(Vector3 POACLGOFKAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x61D4400", Offset = "0x61D3200", VA = "0x1861D4400", Slot = "98")]
	public Vector3 JEHIJLJANBD(Vector3 POACLGOFKAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x61D6C30", Offset = "0x61D5A30", VA = "0x1861D6C30", Slot = "99")]
	public void PCPELMIIDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x61D5CA0", Offset = "0x61D4AA0", VA = "0x1861D5CA0", Slot = "100")]
	public void MMJPJMKAPFF(AFHMHCLBGPL EKKBLJBHBHE, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x61D1C40", Offset = "0x61D0A40", VA = "0x1861D1C40", Slot = "101")]
	public void CIBBIFNDEKN(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x61D3400", Offset = "0x61D2200", VA = "0x1861D3400", Slot = "41")]
	public void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x61D2CC0", Offset = "0x61D1AC0", VA = "0x1861D2CC0", Slot = "104")]
	public void FICIDNHDLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x61D24A0", Offset = "0x61D12A0", VA = "0x1861D24A0", Slot = "105")]
	public void DOHEBIHADFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x61D3210", Offset = "0x61D2010", VA = "0x1861D3210", Slot = "106")]
	public void GFEBEDIHENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x61D1BF0", Offset = "0x61D09F0", VA = "0x1861D1BF0", Slot = "109")]
	public bool CHDICAKHBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x61D4F30", Offset = "0x61D3D30", VA = "0x1861D4F30", Slot = "74")]
	public void LEFEOLICJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x61D51C0", Offset = "0x61D3FC0", VA = "0x1861D51C0", Slot = "110")]
	public void LKLMCLDBKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x61D1CA0", Offset = "0x61D0AA0", VA = "0x1861D1CA0", Slot = "115")]
	public IDisposable CJDNPCMAGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x61D35F0", Offset = "0x61D23F0", VA = "0x1861D35F0", Slot = "116")]
	public void HEJDCJEGLEE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x61D4550", Offset = "0x61D3350", VA = "0x1861D4550", Slot = "117")]
	public void JHGHHIKNMIH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x61D5800", Offset = "0x61D4600", VA = "0x1861D5800", Slot = "118")]
	public void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x61D2770", Offset = "0x61D1570", VA = "0x1861D2770", Slot = "121")]
	public void EFNDFHFPFMG(Vector3 AJMCFPCIEEJ, Quaternion FLNKDKBDHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x61D4850", Offset = "0x61D3650", VA = "0x1861D4850", Slot = "122")]
	public void KCBCOHDEPPK(Vector3 PPDEPMDHBIE, Quaternion AGPEIIIHNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x61D4FD0", Offset = "0x61D3DD0", VA = "0x1861D4FD0", Slot = "123")]
	public bool LHFIODPLHAN(float DGEJJEICPCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x61D6B80", Offset = "0x61D5980", VA = "0x1861D6B80", Slot = "124")]
	public void PBHJHBLHANJ(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x61D5D10", Offset = "0x61D4B10", VA = "0x1861D5D10", Slot = "125")]
	public void MOLNEBLHJPG(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x61D5D70", Offset = "0x61D4B70", VA = "0x1861D5D70", Slot = "126")]
	public void MPBJBLDHMLC(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x61D4610", Offset = "0x61D3410", VA = "0x1861D4610", Slot = "127")]
	public void JOMCGDIDDGE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x61D2A70", Offset = "0x61D1870", VA = "0x1861D2A70", Slot = "128")]
	public void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x61D2E60", Offset = "0x61D1C60", VA = "0x1861D2E60", Slot = "129")]
	public void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x61D6420", Offset = "0x61D5220", VA = "0x1861D6420", Slot = "130")]
	public void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x61D6500", Offset = "0x61D5300", VA = "0x1861D6500", Slot = "131")]
	public void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x61D1DE0", Offset = "0x61D0BE0", VA = "0x1861D1DE0", Slot = "132")]
	public bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x61D3F40", Offset = "0x61D2D40", VA = "0x1861D3F40", Slot = "133")]
	public void IJJLIEINFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x61D7020", Offset = "0x61D5E20", VA = "0x1861D7020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x61D6180", Offset = "0x61D4F80", VA = "0x1861D6180")]
	private void NNLDMJAPEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x61D49A0", Offset = "0x61D37A0", VA = "0x1861D49A0")]
	private void KDKEAMIIMEJ(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x61D5870", Offset = "0x61D4670", VA = "0x1861D5870")]
	private void MHHLHHFEDLO(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x61D36F0", Offset = "0x61D24F0", VA = "0x1861D36F0")]
	private void HMALCOPCAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x61D2D60", Offset = "0x61D1B60", VA = "0x1861D2D60")]
	private void FLJBAPAFBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x61D3B10", Offset = "0x61D2910", VA = "0x1861D3B10")]
	private void HPAFIIOFAAK(AFHMHCLBGPL JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x61D6AB0", Offset = "0x61D58B0", VA = "0x1861D6AB0")]
	private void OMFHFOICOHL(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x61D4170", Offset = "0x61D2F70", VA = "0x1861D4170")]
	private void IOGDNBGBPBH(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x61D22C0", Offset = "0x61D10C0", VA = "0x1861D22C0")]
	private void DNNHBAKMPAN(RigidbodyEx LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x61D6260", Offset = "0x61D5060", VA = "0x1861D6260", Slot = "140")]
	protected virtual void OAOLAJCMMLM(RigidbodyEx EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x61D5270", Offset = "0x61D4070", VA = "0x1861D5270")]
	protected void MBEENBLODHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x61D37A0", Offset = "0x61D25A0", VA = "0x1861D37A0")]
	protected void HNIKONGIIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x61D1CF0", Offset = "0x61D0AF0", VA = "0x1861D1CF0", Slot = "141")]
	protected virtual IDisposable CODFCGJGKKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class KKDNKHCMKOD
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x61DE210", Offset = "0x61DD010", VA = "0x1861DE210")]
	public static AFHMHCLBGPL BJLLDNCOOGH(this AFHMHCLBGPL EBCLIMEMCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x61DE340", Offset = "0x61DD140", VA = "0x1861DE340")]
	public static bool PDLJEKHLCKE(this AFHMHCLBGPL EBCLIMEMCGJ, AFHMHCLBGPL POLPGGJPPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x61DE2C0", Offset = "0x61DD0C0", VA = "0x1861DE2C0")]
	public static bool CKJCIDLLJBF(this AFHMHCLBGPL EBCLIMEMCGJ, AFHMHCLBGPL BHDJFEBFLKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x61DE3C0", Offset = "0x61DD1C0", VA = "0x1861DE3C0")]
	public static RigidbodyEx PIEGHOBIHKL(this AFHMHCLBGPL EJNKDKOJGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x61DE410", Offset = "0x61DD210", VA = "0x1861DE410")]
	public static EHIGKANDEAP PNMGMODOAOO(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class KAKPMEGMLLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x61DD890", Offset = "0x61DC690", VA = "0x1861DD890")]
	public KAKPMEGMLLC(EHIGKANDEAP CAAEKLGIBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x61DD830", Offset = "0x61DC630", VA = "0x1861DD830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class NBOODMOKAII : ALCNMNBHEIP, CDAIFLEPMCD
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode GNNJLDDMPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x61DFD20", Offset = "0x61DEB20", VA = "0x1861DFD20")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x61DFAC0", Offset = "0x61DE8C0", VA = "0x1861DFAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x61DFC10", Offset = "0x61DEA10", VA = "0x1861DFC10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x61DF5C0", Offset = "0x61DE3C0", VA = "0x1861DF5C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public NBOODMOKAII(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x61DF950", Offset = "0x61DE750", VA = "0x1861DF950", Slot = "6")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x61DFB30", Offset = "0x61DE930", VA = "0x1861DFB30", Slot = "9")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x61DFAA0", Offset = "0x61DE8A0", VA = "0x1861DFAA0", Slot = "7")]
	public void HGLFDNPNEOI(bool MOJBMAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x61DFAB0", Offset = "0x61DE8B0", VA = "0x1861DFAB0", Slot = "8")]
	public void IHMDIAEIIED(bool MOJBMAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x61DF7F0", Offset = "0x61DE5F0", VA = "0x1861DF7F0", Slot = "10")]
	public bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x61DF680", Offset = "0x61DE480", VA = "0x1861DF680")]
	private void CNGNHCPHDGC(bool MOJBMAEBGOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FCLOAJJMHPH : ALCNMNBHEIP, AJDCFLFHENI, IDisposable, FHMMDJEGHBP
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public NJDNLEIDKBA PCLNDFHJBML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x61D7400", Offset = "0x61D6200", VA = "0x1861D7400")]
		get
		{
			return default(NJDNLEIDKBA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x61D7060", Offset = "0x61D5E60", VA = "0x1861D7060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x61D7150", Offset = "0x61D5F50", VA = "0x1861D7150", Slot = "6")]
		get
		{
			return default(NJDNLEIDKBA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x61D7060", Offset = "0x61D5E60", VA = "0x1861D7060", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform PPHPAGGBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x61D7500", Offset = "0x61D6300", VA = "0x1861D7500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x61D7350", Offset = "0x61D6150", VA = "0x1861D7350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public FCLOAJJMHPH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x61D74E0", Offset = "0x61D62E0", VA = "0x1861D74E0", Slot = "11")]
	public void OnChangedDistanceBand(CMHABJECOFN ICMOHCKEJOO, CMHABJECOFN LMBCAMGCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "12")]
	public void OnChangedVisibility(bool KMOAILLCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "8")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class NHNGPFPBACB : ALCNMNBHEIP, CLIDKDJAIPG
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x61D07F0", Offset = "0x61CF5F0", VA = "0x1861D07F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x61C1850", Offset = "0x61C0650", VA = "0x1861C1850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x61DFE60", Offset = "0x61DEC60", VA = "0x1861DFE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public NHNGPFPBACB(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x61DFEC0", Offset = "0x61DECC0", VA = "0x1861DFEC0", Slot = "4")]
	public void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x61E08C0", Offset = "0x61DF6C0", VA = "0x1861E08C0")]
	private void OPFBHIANODA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x61E0020", Offset = "0x61DEE20", VA = "0x1861E0020", Slot = "5")]
	public void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x61E0500", Offset = "0x61DF300", VA = "0x1861E0500", Slot = "6")]
	public void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x61E02A0", Offset = "0x61DF0A0", VA = "0x1861E02A0")]
	private void MDPJFPPKMFN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x61E0660", Offset = "0x61DF460", VA = "0x1861E0660", Slot = "7")]
	public void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x61DFD80", Offset = "0x61DEB80", VA = "0x1861DFD80")]
	private void BPAIBICBBJL(string BLAOEBOMGGP, UnityEngine.Object DDMHMHFODEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FJAKMPMJFLH : ALCNMNBHEIP, DKIHIGMFBHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x61D7700", Offset = "0x61D6500", VA = "0x1861D7700", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x61D75B0", Offset = "0x61D63B0", VA = "0x1861D75B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public FJAKMPMJFLH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x61D77D0", Offset = "0x61D65D0", VA = "0x1861D77D0", Slot = "6")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x61D7760", Offset = "0x61D6560", VA = "0x1861D7760", Slot = "7")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class DLGFMILEFKB : ALCNMNBHEIP, ACKPPMBHNPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly HICMFDICNOL CMBJEDBHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JFDIMPAOFEM ODMBECMGKIA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x61CDEB0", Offset = "0x61CCCB0", VA = "0x1861CDEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EPCANLGBBON OJDFPNLFGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x61CEF50", Offset = "0x61CDD50", VA = "0x1861CEF50")]
		get
		{
			return default(EPCANLGBBON);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x61CE960", Offset = "0x61CD760", VA = "0x1861CE960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x61CDDD0", Offset = "0x61CCBD0", VA = "0x1861CDDD0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x61CE3B0", Offset = "0x61CD1B0", VA = "0x1861CE3B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public EPCANLGBBON BFEDAMNKNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x61CEDA0", Offset = "0x61CDBA0", VA = "0x1861CEDA0")]
		get
		{
			return default(EPCANLGBBON);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x61CDE40", Offset = "0x61CCC40", VA = "0x1861CDE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x61CE8F0", Offset = "0x61CD6F0", VA = "0x1861CE8F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event OPLLFGEIFBA NHEANGMCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x61CE6B0", Offset = "0x61CD4B0", VA = "0x1861CE6B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x61CF1A0", Offset = "0x61CDFA0", VA = "0x1861CF1A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OPLLFGEIFBA OKHMBPMOOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x61CF100", Offset = "0x61CDF00", VA = "0x1861CF100", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x61CEB20", Offset = "0x61CD920", VA = "0x1861CEB20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MBKKMCCOIPG GLBJKAKEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x61CE610", Offset = "0x61CD410", VA = "0x1861CE610", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x61CD5F0", Offset = "0x61CC3F0", VA = "0x1861CD5F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action CLOLLEOLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x61CE4C0", Offset = "0x61CD2C0", VA = "0x1861CE4C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x61CDC90", Offset = "0x61CCA90", VA = "0x1861CDC90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action MPKDJHNAIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x61CF060", Offset = "0x61CDE60", VA = "0x1861CF060", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x61CE9D0", Offset = "0x61CD7D0", VA = "0x1861CE9D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<AFHMHCLBGPL> BOBLLFGOFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x61CEFB0", Offset = "0x61CDDB0", VA = "0x1861CEFB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x61CEA70", Offset = "0x61CD870", VA = "0x1861CEA70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<AFHMHCLBGPL> MKFMCBJCGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x61CEEA0", Offset = "0x61CDCA0", VA = "0x1861CEEA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x61CDEE0", Offset = "0x61CCCE0", VA = "0x1861CDEE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action CEKGJANOJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x61CDF90", Offset = "0x61CCD90", VA = "0x1861CDF90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x61CEE00", Offset = "0x61CDC00", VA = "0x1861CEE00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<AFHMHCLBGPL> JILPDOBNMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x61CDBE0", Offset = "0x61CC9E0", VA = "0x1861CDBE0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x61CE840", Offset = "0x61CD640", VA = "0x1861CE840", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x61CF4D0", Offset = "0x61CE2D0", VA = "0x1861CF4D0")]
	public DLGFMILEFKB(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x61CE030", Offset = "0x61CCE30", VA = "0x1861CE030", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x61CD690", Offset = "0x61CC490", VA = "0x1861CD690", Slot = "26")]
	public void AIEIBGACDCB(AFHMHCLBGPL CEBKCILOOLP, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x61CD710", Offset = "0x61CC510", VA = "0x1861CD710")]
	private void AIEIBGACDCB(DGIEOHABIDE CEBKCILOOLP, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x61CD760", Offset = "0x61CC560", VA = "0x1861CD760")]
	private void APDLOMDAMNE(DGIEOHABIDE CEBKCILOOLP, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x61CE160", Offset = "0x61CCF60", VA = "0x1861CE160")]
	private void EEDFLOLKLOA(DGIEOHABIDE JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x61CF240", Offset = "0x61CE040", VA = "0x1861CF240")]
	private void PEMLNCIGAOK(DGIEOHABIDE JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x61CEBC0", Offset = "0x61CD9C0", VA = "0x1861CEBC0")]
	private void LPNKHEODFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x61CE560", Offset = "0x61CD360", VA = "0x1861CE560")]
	private void FOEMEFHAPHB(DGIEOHABIDE JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x61CE750", Offset = "0x61CD550", VA = "0x1861CE750")]
	private void HCKLGHIPGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x61CDD30", Offset = "0x61CCB30", VA = "0x1861CDD30")]
	private void CLPCBEDDCDJ(DGIEOHABIDE EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x61CE420", Offset = "0x61CD220", VA = "0x1861CE420")]
	private void FAGKNOIOPHJ(DGIEOHABIDE EBCLIMEMCGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class OBCJCDJACMN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x61E36C0", Offset = "0x61E24C0", VA = "0x1861E36C0")]
	public static DLGFMILEFKB FNJKBCLLLBP(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IPIKFHCDOFB : ALCNMNBHEIP, IGPMOHBFCIK
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x61DCA70", Offset = "0x61DB870", VA = "0x1861DCA70", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x61DC840", Offset = "0x61DB640", VA = "0x1861DC840", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x61DC1E0", Offset = "0x61DAFE0", VA = "0x1861DC1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private AFHMHCLBGPL BINELINNCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x61DC6E0", Offset = "0x61DB4E0", VA = "0x1861DC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public IPIKFHCDOFB(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x61DCB10", Offset = "0x61DB910", VA = "0x1861DCB10", Slot = "6")]
	public void PGEKNDEFMEI(AFHMHCLBGPL LPDGANJNOMK, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x61DCC60", Offset = "0x61DBA60", VA = "0x1861DCC60")]
	private void PGEKNDEFMEI(DGIEOHABIDE LPDGANJNOMK, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x61DCAA0", Offset = "0x61DB8A0", VA = "0x1861DCAA0", Slot = "7")]
	public void KEINGDGJHID(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x61DC2D0", Offset = "0x61DB0D0", VA = "0x1861DC2D0")]
	private Vector3 DHACMAMEFFN()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FJKFJPBCHHO
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x61D7860", Offset = "0x61D6660", VA = "0x1861D7860")]
	public static IPIKFHCDOFB IJMFICNKAOE(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class HHOMDDKLJAM : ALCNMNBHEIP, GDFECGMIEMM
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x61D9940", Offset = "0x61D8740", VA = "0x1861D9940", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x61DA3F0", Offset = "0x61D91F0", VA = "0x1861DA3F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 IMGFOAANCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x61D99F0", Offset = "0x61D87F0", VA = "0x1861D99F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 PEMGFPKPPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x61DB2C0", Offset = "0x61DA0C0", VA = "0x1861DB2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x61DB0D0", Offset = "0x61D9ED0", VA = "0x1861DB0D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x61D7E10", Offset = "0x61D6C10", VA = "0x1861D7E10", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float GCNECHEBHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x61DB3F0", Offset = "0x61DA1F0", VA = "0x1861DB3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x61D98E0", Offset = "0x61D86E0", VA = "0x1861D98E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x61D7E70", Offset = "0x61D6C70", VA = "0x1861D7E70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x61DB470", Offset = "0x61DA270", VA = "0x1861DB470", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x61D9F80", Offset = "0x61D8D80", VA = "0x1861D9F80", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event OPLLFGEIFBA LNECMPPGONO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x61D7F30", Offset = "0x61D6D30", VA = "0x1861D7F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x61DB030", Offset = "0x61D9E30", VA = "0x1861DB030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x61DB4A0", Offset = "0x61DA2A0", VA = "0x1861DB4A0")]
	public HHOMDDKLJAM(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x61D9470", Offset = "0x61D8270", VA = "0x1861D9470")]
	public float3 DKBHFGKJEAK()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x61D9CF0", Offset = "0x61D8AF0", VA = "0x1861D9CF0", Slot = "14")]
	public void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x61D9AA0", Offset = "0x61D88A0", VA = "0x1861D9AA0", Slot = "16")]
	public void FICIDNHDLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x61D9590", Offset = "0x61D8390", VA = "0x1861D9590", Slot = "15")]
	public void DOHEBIHADFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x61DAF60", Offset = "0x61D9D60", VA = "0x1861DAF60", Slot = "18")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x61DAB70", Offset = "0x61D9970", VA = "0x1861DAB70", Slot = "19")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x61D9C90", Offset = "0x61D8A90", VA = "0x1861D9C90", Slot = "17")]
	public void GFEBEDIHENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x61DA570", Offset = "0x61D9370", VA = "0x1861DA570", Slot = "20")]
	public void IJJLIEINFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x61CB680", Offset = "0x61CA480", VA = "0x1861CB680")]
	public void HCDDFHFLMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x61DA3F0", Offset = "0x61D91F0", VA = "0x1861DA3F0")]
	private void IAELNJKECHF(Vector3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x61D9FB0", Offset = "0x61D8DB0", VA = "0x1861D9FB0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 HDBMGGKOBAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x61D7E70", Offset = "0x61D6C70", VA = "0x1861D7E70")]
	private void BEIIHKJAGPJ(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x61DA190", Offset = "0x61D8F90", VA = "0x1861DA190")]
	private Vector3 HPNPJNHPHHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x61D9230", Offset = "0x61D8030", VA = "0x1861D9230")]
	private Quaternion CNGIKLPDILG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x61D7FD0", Offset = "0x61D6DD0", VA = "0x1861D7FD0")]
	internal (float, Vector3) CCFHKDJKOEN(Rigidbody OHKHGCEKJBJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KHAIJFCPHHM
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x61DE180", Offset = "0x61DCF80", VA = "0x1861DE180")]
	public static HHOMDDKLJAM BDMEFLCHJBK(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CCDBIEPENJJ : ALCNMNBHEIP, ACBNPECKOAN
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool OMDMDIGFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x61C91B0", Offset = "0x61C7FB0", VA = "0x1861C91B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public KLJHGLPFOPI NBPHMHIHAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x61C8D50", Offset = "0x61C7B50", VA = "0x1861C8D50", Slot = "11")]
		get
		{
			return default(KLJHGLPFOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private KLJHGLPFOPI LFPKECOCIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x61C8D50", Offset = "0x61C7B50", VA = "0x1861C8D50")]
		get
		{
			return default(KLJHGLPFOPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x61C8900", Offset = "0x61C7700", VA = "0x1861C8900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x61C9210", Offset = "0x61C8010", VA = "0x1861C9210")]
	public CCDBIEPENJJ(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x61C8C50", Offset = "0x61C7A50", VA = "0x1861C8C50", Slot = "4")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x61C8970", Offset = "0x61C7770", VA = "0x1861C8970")]
	private bool CLLPKANIGLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x61C8B50", Offset = "0x61C7950", VA = "0x1861C8B50", Slot = "5")]
	public void DFBNOFDAPGG(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x61C8BD0", Offset = "0x61C79D0", VA = "0x1861C8BD0", Slot = "6")]
	public void FGBFHLHBONF(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x61C8EB0", Offset = "0x61C7CB0", VA = "0x1861C8EB0", Slot = "9")]
	public void LEOOKHEPDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x61C8A50", Offset = "0x61C7850", VA = "0x1861C8A50")]
	private void COFHJNGNEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x61C9010", Offset = "0x61C7E10", VA = "0x1861C9010")]
	private void LPMJJOLNGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x61C8DB0", Offset = "0x61C7BB0", VA = "0x1861C8DB0", Slot = "8")]
	public void JHLNCEAFEDH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x61C8E30", Offset = "0x61C7C30", VA = "0x1861C8E30", Slot = "7")]
	public void JMGIAAHKJIC(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DFGIMPBOJAH : ALCNMNBHEIP, GCLEAEBJEJA
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x61CB450", Offset = "0x61CA250", VA = "0x1861CB450", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool OMIFHCLAEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x61CB3E0", Offset = "0x61CA1E0", VA = "0x1861CB3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event OPLLFGEIFBA EKGBOJKJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x61CB340", Offset = "0x61CA140", VA = "0x1861CB340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x61CB7C0", Offset = "0x61CA5C0", VA = "0x1861CB7C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public DFGIMPBOJAH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x61CB2D0", Offset = "0x61CA0D0", VA = "0x1861CB2D0", Slot = "11")]
	public IDisposable CJDNPCMAGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x61CB440", Offset = "0x61CA240", VA = "0x1861CB440", Slot = "8")]
	public void HEJDCJEGLEE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x61CB590", Offset = "0x61CA390", VA = "0x1861CB590", Slot = "9")]
	public void JHGHHIKNMIH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x61CB6C0", Offset = "0x61CA4C0", VA = "0x1861CB6C0", Slot = "10")]
	public void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x61CB5A0", Offset = "0x61CA3A0", VA = "0x1861CB5A0", Slot = "12")]
	public void KHMAEOCCFDI(Rigidbody ANDHNALLMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x61CB4B0", Offset = "0x61CA2B0", VA = "0x1861CB4B0", Slot = "13")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x61CB680", Offset = "0x61CA480", VA = "0x1861CB680", Slot = "6")]
	public void LJDDCAMEMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BMKKMEFACOI : ALCNMNBHEIP, FNJBMNDKPLN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView HIFKLECGFMI;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x61C8430", Offset = "0x61C7230", VA = "0x1861C8430", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x61C8070", Offset = "0x61C6E70", VA = "0x1861C8070", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OPLLFGEIFBA FPOFAHOLBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x61C8450", Offset = "0x61C7250", VA = "0x1861C8450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x61C7E10", Offset = "0x61C6C10", VA = "0x1861C7E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x61C8840", Offset = "0x61C7640", VA = "0x1861C8840")]
	public BMKKMEFACOI(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x61C8100", Offset = "0x61C6F00", VA = "0x1861C8100", Slot = "8")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x61C7CB0", Offset = "0x61C6AB0", VA = "0x1861C7CB0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x61C8640", Offset = "0x61C7440", VA = "0x1861C8640", Slot = "9")]
	public void OMFHFOICOHL(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x61C8230", Offset = "0x61C7030", VA = "0x1861C8230", Slot = "10")]
	public void IOGDNBGBPBH(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x61C7AD0", Offset = "0x61C68D0", VA = "0x1861C7AD0")]
	private void AMDOPIEODMK(PhotonView LDLNIDMAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x61C84F0", Offset = "0x61C72F0", VA = "0x1861C84F0")]
	private void JOHGNLALIAB(RigidbodyEx ECIIPDBEOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x61C7EB0", Offset = "0x61C6CB0", VA = "0x1861C7EB0")]
	private void EMMEJBAGPEN(PhotonView NJNICFHBOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class IOPEEPFMPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x61DC180", Offset = "0x61DAF80", VA = "0x1861DC180")]
	public static BMKKMEFACOI JGPGKIAMDMM(this EHIGKANDEAP IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PIBHGCNBKMG : ALCNMNBHEIP, FOCHNEJJMDO
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x61E4560", Offset = "0x61E3360", VA = "0x1861E4560", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x61E4680", Offset = "0x61E3480", VA = "0x1861E4680", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool EJFLOBHJLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x61E45C0", Offset = "0x61E33C0", VA = "0x1861E45C0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x61E4260", Offset = "0x61E3060", VA = "0x1861E4260")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x61E4620", Offset = "0x61E3420", VA = "0x1861E4620", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x61E43E0", Offset = "0x61E31E0", VA = "0x1861E43E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x61E46F0", Offset = "0x61E34F0", VA = "0x1861E46F0")]
	public PIBHGCNBKMG(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x61E4350", Offset = "0x61E3150", VA = "0x1861E4350", Slot = "9")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x61E42D0", Offset = "0x61E30D0", VA = "0x1861E42D0", Slot = "10")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HAMEKLMLGPD : ALCNMNBHEIP, KCMJCMMJLOM
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x61D7BF0", Offset = "0x61D69F0", VA = "0x1861D7BF0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x61D78F0", Offset = "0x61D66F0", VA = "0x1861D78F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x61D7A40", Offset = "0x61D6840", VA = "0x1861D7A40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x61D7AA0", Offset = "0x61D68A0", VA = "0x1861D7AA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public HAMEKLMLGPD(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x61D7D20", Offset = "0x61D6B20", VA = "0x1861D7D20", Slot = "8")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x61D7C50", Offset = "0x61D6A50", VA = "0x1861D7C50", Slot = "9")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PMDCDBMECJP(typeof(NEGNBENACNL), new string[] { })]
public sealed class IFEHMICAJED : ENEHADLKBBF, NEGNBENACNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[PDOCKCLGMBB]
	private HCCIMPJEHHN EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC20", Offset = "0x61DAA20", VA = "0x1861DBC20", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x61DBBF0", Offset = "0x61DA9F0", VA = "0x1861DBBF0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x61DB8A0", Offset = "0x61DA6A0", VA = "0x1861DB8A0", Slot = "6")]
	public void CCFHKDJKOEN(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC70", Offset = "0x61DAA70", VA = "0x1861DBC70", Slot = "7")]
	public void JFKNDDFIKNJ(EPCANLGBBON GOOJPBOEHHC, bool DMNBAGAHDKF, bool FANKCIEBGIH, bool LACFBHJLLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x61DBE90", Offset = "0x61DAC90", VA = "0x1861DBE90", Slot = "8")]
	public void JNPOMPPCHDC(EPCANLGBBON GOOJPBOEHHC, float3 PFHKDIPHHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x61DB9C0", Offset = "0x61DA7C0", VA = "0x1861DB9C0", Slot = "9")]
	public void CLOMMGEKCFA(EPCANLGBBON GOOJPBOEHHC, float3 PHGPAJDKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x61DBFD0", Offset = "0x61DADD0", VA = "0x1861DBFD0")]
	private bool LPJDDEMJFAK(EPCANLGBBON GOOJPBOEHHC, [Out] DGIEOHABIDE IIJDENGNPJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x61DC090", Offset = "0x61DAE90", VA = "0x1861DC090")]
	private bool MNBEOMCEBNM(EPCANLGBBON GOOJPBOEHHC, [Out] HHOMDDKLJAM CAKIFCEENIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x61DBB00", Offset = "0x61DA900", VA = "0x1861DBB00")]
	private bool DKEDLHJKAGM(EPCANLGBBON GOOJPBOEHHC, [Out] AKAGBMHIJNC GIEEANPPDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IFEHMICAJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class OFBGAOFADLH : ALCNMNBHEIP, PCBDEJNLIBE
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool HGHFLMAHMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x61C4540", Offset = "0x61C3340", VA = "0x1861C4540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x61E3B00", Offset = "0x61E2900", VA = "0x1861E3B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x61E40D0", Offset = "0x61E2ED0", VA = "0x1861E40D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool IOJAOAGKCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x61E37C0", Offset = "0x61E25C0", VA = "0x1861E37C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x61E3CF0", Offset = "0x61E2AF0", VA = "0x1861E3CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool GCLGPDNHGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x61E3900", Offset = "0x61E2700", VA = "0x1861E3900")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x61E3B60", Offset = "0x61E2960", VA = "0x1861E3B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int AGAPDFNEKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x61E3750", Offset = "0x61E2550", VA = "0x1861E3750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event OPLLFGEIFBA IPEEDOMDGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x61E3E00", Offset = "0x61E2C00", VA = "0x1861E3E00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x61E3D60", Offset = "0x61E2B60", VA = "0x1861E3D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x61E4130", Offset = "0x61E2F30", VA = "0x1861E4130")]
	public OFBGAOFADLH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x61E3C40", Offset = "0x61E2A40", VA = "0x1861E3C40", Slot = "6")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x61E3BD0", Offset = "0x61E29D0", VA = "0x1861E3BD0", Slot = "8")]
	public void EAGDCCCGKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x61E3960", Offset = "0x61E2760", VA = "0x1861E3960", Slot = "7")]
	public bool CHDICAKHBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x61E3EA0", Offset = "0x61E2CA0", VA = "0x1861E3EA0", Slot = "9")]
	public void LEFEOLICJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x61CB680", Offset = "0x61CA480", VA = "0x1861CB680", Slot = "12")]
	public void JCOAOEOCLOG(bool GEFNNEJLOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x61E3F90", Offset = "0x61E2D90", VA = "0x1861E3F90", Slot = "11")]
	public void LKLMCLDBKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "10")]
	public void AIFDDHHFGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x61E3820", Offset = "0x61E2620", VA = "0x1861E3820")]
	private void BHKEBALKJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class ACOCOBFJIBN : ALCNMNBHEIP, NMIMBODNLJI
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x61C1550", Offset = "0x61C0350", VA = "0x1861C1550", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x61C1190", Offset = "0x61BFF90", VA = "0x1861C1190")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x61C1850", Offset = "0x61C0650", VA = "0x1861C1850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool CLMAJLBDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x61C1080", Offset = "0x61BFE80", VA = "0x1861C1080", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x61C18B0", Offset = "0x61C06B0", VA = "0x1861C18B0")]
	public ACOCOBFJIBN(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x61C10E0", Offset = "0x61BFEE0", VA = "0x1861C10E0", Slot = "5")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x61C14D0", Offset = "0x61C02D0", VA = "0x1861C14D0", Slot = "7")]
	public void MPBJBLDHMLC(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x61C1450", Offset = "0x61C0250", VA = "0x1861C1450", Slot = "8")]
	public void JOMCGDIDDGE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x61C1630", Offset = "0x61C0430", VA = "0x1861C1630", Slot = "9")]
	public void PFFOHPOCDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x61C0E20", Offset = "0x61BFC20", VA = "0x1861C0E20", Slot = "11")]
	public void CAKEMGLLFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x61C1280", Offset = "0x61C0080", VA = "0x1861C1280", Slot = "12")]
	public void GLKPCHEPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "10")]
	public void CHPIHHCBCFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AKAGBMHIJNC : ALCNMNBHEIP, KJCBHAEKLLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x61C3FC0", Offset = "0x61C2DC0", VA = "0x1861C3FC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x61C3640", Offset = "0x61C2440", VA = "0x1861C3640", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x61C1B80", Offset = "0x61C0980", VA = "0x1861C1B80", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x61C4BD0", Offset = "0x61C39D0", VA = "0x1861C4BD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x61C1C30", Offset = "0x61C0A30", VA = "0x1861C1C30", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x61C4E10", Offset = "0x61C3C10", VA = "0x1861C4E10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x61C3C90", Offset = "0x61C2A90", VA = "0x1861C3C90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x61C2FA0", Offset = "0x61C1DA0", VA = "0x1861C2FA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x61C4680", Offset = "0x61C3480", VA = "0x1861C4680", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x61C4560", Offset = "0x61C3360", VA = "0x1861C4560", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x61C1CF0", Offset = "0x61C0AF0", VA = "0x1861C1CF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x61C1B50", Offset = "0x61C0950", VA = "0x1861C1B50", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x61C4620", Offset = "0x61C3420", VA = "0x1861C4620", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x61C2360", Offset = "0x61C1160", VA = "0x1861C2360", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x61C3030", Offset = "0x61C1E30", VA = "0x1861C3030", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private CLIDKDJAIPG KKLDNFFPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1C51B30", Offset = "0x1C50930", VA = "0x181C51B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool HGHFLMAHMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x61C4540", Offset = "0x61C3340", VA = "0x1861C4540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public AKAGBMHIJNC(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x61C46E0", Offset = "0x61C34E0", VA = "0x1861C46E0", Slot = "20")]
	public void MNGJMFIPKKA(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x61C1D20", Offset = "0x61C0B20", VA = "0x1861C1D20", Slot = "30")]
	public void DGMECMMNNNM(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x61C2570", Offset = "0x61C1370", VA = "0x1861C2570", Slot = "19")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x61C24B0", Offset = "0x61C12B0", VA = "0x1861C24B0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x61C3E50", Offset = "0x61C2C50", VA = "0x1861C3E50", Slot = "28")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x61C1970", Offset = "0x61C0770", VA = "0x1861C1970", Slot = "35")]
	public Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x61C4ED0", Offset = "0x61C3CD0", VA = "0x1861C4ED0", Slot = "34")]
	public Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x61C2570", Offset = "0x61C1370", VA = "0x1861C2570", Slot = "27")]
	public void EIKGJPKGMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x61C5310", Offset = "0x61C4110", VA = "0x1861C5310", Slot = "25")]
	public void PBLACPABIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x61C36B0", Offset = "0x61C24B0", VA = "0x1861C36B0", Slot = "24")]
	public void IKKFNLBJCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x61C4300", Offset = "0x61C3100", VA = "0x1861C4300", Slot = "33")]
	public void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x61C1C90", Offset = "0x61C0A90", VA = "0x1861C1C90", Slot = "32")]
	public void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x61C4750", Offset = "0x61C3550", VA = "0x1861C4750", Slot = "31")]
	public void NANGECNGOHL(Vector3 EHHHOADEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x61C1D90", Offset = "0x61C0B90", VA = "0x1861C1D90", Slot = "22")]
	public void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x61C4920", Offset = "0x61C3720", VA = "0x1861C4920", Slot = "21")]
	public void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x61C2620", Offset = "0x61C1420", VA = "0x1861C2620", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x61C3CC0", Offset = "0x61C2AC0", VA = "0x1861C3CC0", Slot = "29")]
	public Vector3 KBMECCIPCJF(Vector3 JIJAOBLIPMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x61C5370", Offset = "0x61C4170", VA = "0x1861C5370", Slot = "26")]
	public void PCPELMIIDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x61C2360", Offset = "0x61C1160", VA = "0x1861C2360")]
	private void KJANEGBMKKK(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x61C4C40", Offset = "0x61C3A40", VA = "0x1861C4C40")]
	private void OEEJMNFNHLK(Vector3 APBMLIKHBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x61C5090", Offset = "0x61C3E90", VA = "0x1861C5090")]
	private Vector3 OLKOIDFMNDN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x61C3710", Offset = "0x61C2510", VA = "0x1861C3710")]
	private void JLBGIAILOIF(Vector3 PFHKDIPHHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x61C4070", Offset = "0x61C2E70", VA = "0x1861C4070")]
	private Vector3 KJBHKLGJEKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x61C2A30", Offset = "0x61C1830", VA = "0x1861C2A30")]
	private void GFPGHDMLPDF(Vector3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x61C2FD0", Offset = "0x61C1DD0", VA = "0x1861C2FD0")]
	private void HIJFAPGFMFA(Vector3 JIJAOBLIPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x61C2300", Offset = "0x61C1100", VA = "0x1861C2300")]
	private void DJJMEIMNENN(Vector3 PCFFHDKFCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x61C3090", Offset = "0x61C1E90", VA = "0x1861C3090")]
	private void ICIDNNDNAJN(string PFGBGEIKPOE, Vector3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x61C3DA0", Offset = "0x61C2BA0", VA = "0x1861C3DA0")]
	private void KBPLJOHOPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class ALCNMNBHEIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly DGIEOHABIDE EBCLIMEMCGJ;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected HCCIMPJEHHN DDIGFEAEKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5394CC0", Offset = "0x5393AC0", VA = "0x185394CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected EPCANLGBBON IMNDOBAMGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5394D00", Offset = "0x5393B00", VA = "0x185394D00")]
		get
		{
			return default(EPCANLGBBON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C4300", VA = "0x1861C5500")]
	public ALCNMNBHEIP(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x61C5D20", Offset = "0x61C4B20", VA = "0x1861C5D20")]
	protected AFHMHCLBGPL LLBNKDCPIOA(EPCANLGBBON ALPEICGOMCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DJIKDCCJHHE : DNCFLFJNBGK
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x61CCB90", Offset = "0x61CB990", VA = "0x1861CCB90", Slot = "4")]
	public ACKPPMBHNPB FLHJOIDNMBF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x61CD040", Offset = "0x61CBE40", VA = "0x1861CD040", Slot = "5")]
	public KJCBHAEKLLK JOMLJJNHEFD(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x61CD510", Offset = "0x61CC310", VA = "0x1861CD510", Slot = "6")]
	public IGPMOHBFCIK PMCNMDAMJPA(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x61CC9B0", Offset = "0x61CB7B0", VA = "0x1861CC9B0", Slot = "7")]
	public KCMJCMMJLOM DDECDGMLLLN(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x61CCBF0", Offset = "0x61CB9F0", VA = "0x1861CCBF0", Slot = "8")]
	public PCBDEJNLIBE HBHHEHGGIBP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x61CD350", Offset = "0x61CC150", VA = "0x1861CD350", Slot = "9")]
	public AJDCFLFHENI MBFCIJLEHOM(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x61CD120", Offset = "0x61CBF20", VA = "0x1861CD120", Slot = "10")]
	public GCLEAEBJEJA KDFDKAKHHPL(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x61CD270", Offset = "0x61CC070", VA = "0x1861CD270", Slot = "11")]
	public CLIDKDJAIPG MABLEBGNIEP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x61CC690", Offset = "0x61CB490", VA = "0x1861CC690", Slot = "12")]
	public CDAIFLEPMCD AFNAGMMCLBG(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x61CD430", Offset = "0x61CC230", VA = "0x1861CD430", Slot = "13")]
	public DKIHIGMFBHJ MPJCIOHIADF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x61CCA90", Offset = "0x61CB890", VA = "0x1861CCA90")]
	public NMIMBODNLJI FFLIPKGEEDG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x61CC780", Offset = "0x61CB580", VA = "0x1861CC780")]
	public FNJBMNDKPLN HOAMBNLCLLB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD60", Offset = "0x61CBB60", VA = "0x1861CCD60")]
	public ACBNPECKOAN IENBAJNMOIH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x61CD200", Offset = "0x61CC000", VA = "0x1861CD200")]
	public GDFECGMIEMM KHJMLFGPIAP(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEA0", Offset = "0x61CBCA0", VA = "0x1861CCEA0")]
	public FOCHNEJJMDO JLHGMBPIGAB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x61CC880", Offset = "0x61CB680", VA = "0x1861CC880", Slot = "19")]
	public AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP, OBIMNGPJPFI AMCDJKCDDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DJIKDCCJHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x61CCA90", Offset = "0x61CB890", VA = "0x1861CCA90", Slot = "14")]
	private NMIMBODNLJI FIIMDGALDGD(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x61CC780", Offset = "0x61CB580", VA = "0x1861CC780", Slot = "15")]
	private FNJBMNDKPLN CBOFKDEHGFG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD60", Offset = "0x61CBB60", VA = "0x1861CCD60", Slot = "16")]
	private ACBNPECKOAN PDMOEMKDOEF(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x61CD200", Offset = "0x61CC000", VA = "0x1861CD200", Slot = "17")]
	private GDFECGMIEMM OOBNBBJPNJE(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x61CC770", Offset = "0x61CB570", VA = "0x1861CC770", Slot = "18")]
	private FOCHNEJJMDO AGJMADGGLFH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class JFDIMPAOFEM : IReadOnlyList<AFHMHCLBGPL>, IEnumerable<AFHMHCLBGPL>, IEnumerable, IReadOnlyCollection<AFHMHCLBGPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly EPCANLGBBON ALPEICGOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly HCCIMPJEHHN PLJNIEKIKFG;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x61DCFD0", Offset = "0x61DBDD0", VA = "0x1861DCFD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public AFHMHCLBGPL CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x61DCE80", Offset = "0x61DBC80", VA = "0x1861DCE80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x353AC30", Offset = "0x3539A30", VA = "0x18353AC30")]
	public JFDIMPAOFEM(EPCANLGBBON ALPEICGOMCK, HCCIMPJEHHN PLJNIEKIKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x61DCD70", Offset = "0x61DBB70", VA = "0x1861DCD70", Slot = "6")]
	public IEnumerator<AFHMHCLBGPL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x61DCD70", Offset = "0x61DBB70", VA = "0x1861DCD70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x61DCE80", Offset = "0x61DBC80", VA = "0x1861DCE80")]
	[CompilerGenerated]
	private AFHMHCLBGPL HFHBDLIMIMB(int NAKKFLBPDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PMDCDBMECJP(typeof(DNCFLFJNBGK), new string[] { })]
public class ALKMJOHCDNL : DNCFLFJNBGK, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DNCFLFJNBGK HDHMCEEPNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly DNCFLFJNBGK EDBIBDGOGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private LLDCKPPKNLB BMJPGJOIFBH;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private DNCFLFJNBGK LPKEFNMBODP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x61C6810", Offset = "0x61C5610", VA = "0x1861C6810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x61C63F0", Offset = "0x61C51F0", VA = "0x1861C63F0", Slot = "20")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x61C6200", Offset = "0x61C5000", VA = "0x1861C6200", Slot = "4")]
	public ACKPPMBHNPB FLHJOIDNMBF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x61C6440", Offset = "0x61C5240", VA = "0x1861C6440", Slot = "5")]
	public KJCBHAEKLLK JOMLJJNHEFD(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x61C6870", Offset = "0x61C5670", VA = "0x1861C6870", Slot = "6")]
	public IGPMOHBFCIK PMCNMDAMJPA(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x61C60B0", Offset = "0x61C4EB0", VA = "0x1861C60B0", Slot = "7")]
	public KCMJCMMJLOM DDECDGMLLLN(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x61C62A0", Offset = "0x61C50A0", VA = "0x1861C62A0", Slot = "8")]
	public PCBDEJNLIBE HBHHEHGGIBP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x61C66D0", Offset = "0x61C54D0", VA = "0x1861C66D0", Slot = "9")]
	public AJDCFLFHENI MBFCIJLEHOM(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x61C64E0", Offset = "0x61C52E0", VA = "0x1861C64E0", Slot = "10")]
	public GCLEAEBJEJA KDFDKAKHHPL(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x61C6630", Offset = "0x61C5430", VA = "0x1861C6630", Slot = "11")]
	public CLIDKDJAIPG MABLEBGNIEP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x61C5DC0", Offset = "0x61C4BC0", VA = "0x1861C5DC0", Slot = "12")]
	public CDAIFLEPMCD AFNAGMMCLBG(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x61C6770", Offset = "0x61C5570", VA = "0x1861C6770", Slot = "13")]
	public DKIHIGMFBHJ MPJCIOHIADF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x61C6150", Offset = "0x61C4F50", VA = "0x1861C6150")]
	public NMIMBODNLJI FFLIPKGEEDG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x61C5F10", Offset = "0x61C4D10", VA = "0x1861C5F10")]
	public FNJBMNDKPLN HOAMBNLCLLB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x61C6340", Offset = "0x61C5140", VA = "0x1861C6340")]
	public ACBNPECKOAN IENBAJNMOIH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x61C6580", Offset = "0x61C5380", VA = "0x1861C6580")]
	public GDFECGMIEMM KHJMLFGPIAP(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x61C5E60", Offset = "0x61C4C60", VA = "0x1861C5E60")]
	public FOCHNEJJMDO JLHGMBPIGAB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x61C5FC0", Offset = "0x61C4DC0", VA = "0x1861C5FC0", Slot = "19")]
	public AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP, OBIMNGPJPFI AMCDJKCDDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x61C6910", Offset = "0x61C5710", VA = "0x1861C6910")]
	public ALKMJOHCDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x61C6150", Offset = "0x61C4F50", VA = "0x1861C6150", Slot = "14")]
	private NMIMBODNLJI FIIMDGALDGD(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x61C5F10", Offset = "0x61C4D10", VA = "0x1861C5F10", Slot = "15")]
	private FNJBMNDKPLN CBOFKDEHGFG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x61C6340", Offset = "0x61C5140", VA = "0x1861C6340", Slot = "16")]
	private ACBNPECKOAN PDMOEMKDOEF(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x61C6580", Offset = "0x61C5380", VA = "0x1861C6580", Slot = "17")]
	private GDFECGMIEMM OOBNBBJPNJE(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x61C5E60", Offset = "0x61C4C60", VA = "0x1861C5E60", Slot = "18")]
	private FOCHNEJJMDO AGJMADGGLFH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class LIBMNODJEGC : AFHMHCLBGPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly LIBMNODJEGC IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx PIEGHOBIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject NOMLNDHBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x857F80", Offset = "0x856D80", VA = "0x180857F80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xCAA3F0", Offset = "0xCA91F0", VA = "0x180CAA3F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x760F10", Offset = "0x75FD10", VA = "0x180760F10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x760F50", Offset = "0x75FD50", VA = "0x180760F50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x760EF0", Offset = "0x75FCF0", VA = "0x180760EF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x760F00", Offset = "0x75FD00", VA = "0x180760F00", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x92E5C0", Offset = "0x92D3C0", VA = "0x18092E5C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E9CE0", Offset = "0x7E8AE0", VA = "0x1807E9CE0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A01020", Offset = "0x19FFE20", VA = "0x181A01020", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x4A3CAA0", Offset = "0x4A3B8A0", VA = "0x184A3CAA0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x61DF280", Offset = "0x61DE080", VA = "0x1861DF280", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x61DF250", Offset = "0x61DE050", VA = "0x1861DF250", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E02840", Offset = "0x3E01640", VA = "0x183E02840", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1930AC0", Offset = "0x192F8C0", VA = "0x181930AC0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CMJDNEDLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x86B3C0", Offset = "0x86A1C0", VA = "0x18086B3C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool BDPGIFJOMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x164DA40", Offset = "0x164C840", VA = "0x18164DA40", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1890", Offset = "0x5AF0690", VA = "0x185AF1890", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3E04390", Offset = "0x3E03190", VA = "0x183E04390", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8F7620", Offset = "0x8F6420", VA = "0x1808F7620", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x61DF2A0", Offset = "0x61DE0A0", VA = "0x1861DF2A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x52B2E60", Offset = "0x52B1C60", VA = "0x1852B2E60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0310", Offset = "0x7AF110", VA = "0x1807B0310", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "48")]
		get
		{
			return default(NJDNLEIDKBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10E0F30", Offset = "0x10DFD30", VA = "0x1810E0F30", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform PNPLLHEAAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x83B840", Offset = "0x83A640", VA = "0x18083B840", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 FJLCOOOFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float MECGPNGIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float CFPAPCLNAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion GPHPDBHPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D00", Offset = "0x8A0B00", VA = "0x1808A1D00", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 LCPDOLOFPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion AEJINJPKNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D00", Offset = "0x8A0B00", VA = "0x1808A1D00", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool CLDEONKBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A890", Offset = "0xA89690", VA = "0x180A8A890", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event OPLLFGEIFBA NHEANGMCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event OPLLFGEIFBA OKHMBPMOOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event MBKKMCCOIPG GLBJKAKEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event OPLLFGEIFBA FPOFAHOLBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event OPLLFGEIFBA CFHBGAIBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event OPLLFGEIFBA IPEEDOMDGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event OPLLFGEIFBA EKGBOJKJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event OPLLFGEIFBA EHEJIDGBADF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "41")]
	public void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "71")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "72")]
	public void DLBGPCKLDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "73")]
	public void AJFAFEMLEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "74")]
	public void LEFEOLICJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "81")]
	public void AIEIBGACDCB(AFHMHCLBGPL POACLGOFKAJ, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "84")]
	public void BLOEJDKJNDB(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "85")]
	public void PHDEHILJHEH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "86")]
	public Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "87")]
	public Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "88")]
	public void EIKGJPKGMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "89")]
	public void PBLACPABIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "90")]
	public void IKKFNLBJCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "91")]
	public void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "92")]
	public void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "93")]
	public void NANGECNGOHL(Vector3 EHHHOADEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "94")]
	public void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "95")]
	public void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "96")]
	public void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "97")]
	public Vector3 KBMECCIPCJF(Vector3 POACLGOFKAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xA40AD0", Offset = "0xA3F8D0", VA = "0x180A40AD0", Slot = "98")]
	public Vector3 JEHIJLJANBD(Vector3 POACLGOFKAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "99")]
	public void PCPELMIIDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "100")]
	public void MMJPJMKAPFF(AFHMHCLBGPL EKKBLJBHBHE, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "101")]
	public void CIBBIFNDEKN(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "104")]
	public void FICIDNHDLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "105")]
	public void DOHEBIHADFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "106")]
	public void GFEBEDIHENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "109")]
	public bool CHDICAKHBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "110")]
	public void LKLMCLDBKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "115")]
	public IDisposable CJDNPCMAGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "116")]
	public void HEJDCJEGLEE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "117")]
	public void JHGHHIKNMIH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "118")]
	public void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "121")]
	public void EFNDFHFPFMG(Vector3 AJMCFPCIEEJ, Quaternion FLNKDKBDHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "122")]
	public void KCBCOHDEPPK(Vector3 PPDEPMDHBIE, Quaternion AGPEIIIHNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "123")]
	public bool LHFIODPLHAN(float DGEJJEICPCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "124")]
	public void PBHJHBLHANJ(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "125")]
	public void MOLNEBLHJPG(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "126")]
	public void MPBJBLDHMLC(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "127")]
	public void JOMCGDIDDGE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "128")]
	public void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "129")]
	public void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "130")]
	public void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "131")]
	public void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x61DF260", Offset = "0x61DE060", VA = "0x1861DF260", Slot = "132")]
	public bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "133")]
	public void IJJLIEINFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LIBMNODJEGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class DGIEOHABIDE : EHIGKANDEAP, IBIAPBPMOCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal EPCANLGBBON ALPEICGOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal HCCIMPJEHHN PNCLKHJICEL;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x61CC310", Offset = "0x61CB110", VA = "0x1861CC310")]
	public DGIEOHABIDE(GameObject LEMKPNELLPI, RigidbodyEx IILFEDCNOPF, OBIMNGPJPFI AMCDJKCDDEF, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x61CB860", Offset = "0x61CA660", VA = "0x1861CB860", Slot = "135")]
	protected override void CHAFGEIHJHP(OBIMNGPJPFI AMCDJKCDDEF, GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "141")]
	protected override IDisposable CODFCGJGKKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x61CBAD0", Offset = "0x61CA8D0", VA = "0x1861CBAD0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x61CC240", Offset = "0x61CB040", VA = "0x1861CC240", Slot = "142")]
	public void ONMEFHAPCJC(ECMHEOBCCNJ ICMOHCKEJOO, ECMHEOBCCNJ LMBCAMGCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x61CBE90", Offset = "0x61CAC90", VA = "0x1861CBE90", Slot = "143")]
	public void JOGDLKEAHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x61CC180", Offset = "0x61CAF80", VA = "0x1861CC180", Slot = "144")]
	public void MGBPKCHKANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x61CBE30", Offset = "0x61CAC30", VA = "0x1861CBE30", Slot = "145")]
	public void JCOAOEOCLOG(bool GEFNNEJLOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x61CBC40", Offset = "0x61CAA40", VA = "0x1861CBC40", Slot = "146")]
	public bool FCCAOLELCBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x61CBDD0", Offset = "0x61CABD0", VA = "0x1861CBDD0", Slot = "147")]
	public void GMGACKJAGEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "140")]
	protected override void OAOLAJCMMLM(RigidbodyEx KNIBDNLMNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF50", Offset = "0x61CAD50", VA = "0x1861CBF50")]
	private void LHBCDAKNOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class HJJJCHECFNH
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x61DB790", Offset = "0x61DA590", VA = "0x1861DB790")]
	public static EHIGKANDEAP EDPDEJGNLAB(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OKPCCAOLCMM : ACKPPMBHNPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLPCBEDDCDJ(AFHMHCLBGPL EBCLIMEMCGJ);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAGKNOIOPHJ(AFHMHCLBGPL EBCLIMEMCGJ);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEDFLOLKLOA(AFHMHCLBGPL JMEBKHCDIFK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEMLNCIGAOK(AFHMHCLBGPL JMEBKHCDIFK);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KIIOKNIAEIC : IGPMOHBFCIK
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	PNOGIDMGPHE<AFHMHCLBGPL> DJLHEPLKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	AFHMHCLBGPL BINELINNCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MBOHOEKDOPF : GDFECGMIEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) CCFHKDJKOEN(Rigidbody OHKHGCEKJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BLJOKBJGEJP : FNJBMNDKPLN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView PIKHGMOMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class KFHGBGBFHKL : CDAIFLEPMCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode IDOBDFAEGHD;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode KMHNNBPAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x61DDDB0", Offset = "0x61DCBB0", VA = "0x1861DDDB0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x61DD910", Offset = "0x61DC710", VA = "0x1861DD910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x61D1110", Offset = "0x61CFF10", VA = "0x1861D1110")]
	public KFHGBGBFHKL(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x61DDC00", Offset = "0x61DCA00", VA = "0x1861DDC00", Slot = "6")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD30", Offset = "0x61DCB30", VA = "0x1861DDD30", Slot = "9")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD10", Offset = "0x61DCB10", VA = "0x1861DDD10", Slot = "7")]
	public void HGLFDNPNEOI(bool MOJBMAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD20", Offset = "0x61DCB20", VA = "0x1861DDD20", Slot = "8")]
	public void IHMDIAEIIED(bool MOJBMAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x61DDAA0", Offset = "0x61DC8A0", VA = "0x1861DDAA0", Slot = "10")]
	public bool DBGBHLICAOP(Vector3 EFMDODKKOAD, [Out] RaycastHit JNGEOKOGLNH, float HGECKMNELOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x61DD980", Offset = "0x61DC780", VA = "0x1861DD980")]
	private void CNGNHCPHDGC(bool MOJBMAEBGOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class AKGHLKNANJO : AJDCFLFHENI, IDisposable, FHMMDJEGHBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NJDNLEIDKBA FELFJIHCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private HNBDLINLDMG KJLBCIPKKKA;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public NJDNLEIDKBA HJMACGLHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x61C55A0", Offset = "0x61C43A0", VA = "0x1861C55A0", Slot = "6")]
		get
		{
			return default(NJDNLEIDKBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x61C5AF0", Offset = "0x61C48F0", VA = "0x1861C5AF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform PPHPAGGBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x61C5C70", Offset = "0x61C4A70", VA = "0x1861C5C70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CMHABJECOFN, CMHABJECOFN> HIINAOPCHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x61C5BC0", Offset = "0x61C49C0", VA = "0x1861C5BC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x61C5A40", Offset = "0x61C4840", VA = "0x1861C5A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x61C5C90", Offset = "0x61C4A90", VA = "0x1861C5C90")]
	public AKGHLKNANJO(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x61C5740", Offset = "0x61C4540", VA = "0x1861C5740", Slot = "8")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x61C56F0", Offset = "0x61C44F0", VA = "0x1861C56F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1A70950", Offset = "0x1A6F750", VA = "0x181A70950", Slot = "11")]
	private void GAKEFAMFAGH(CMHABJECOFN FAGNKKLHAKO, CMHABJECOFN MKIGNGOBIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "12")]
	private void GFCPEFAJECH(bool KMOAILLCHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class EGNFILPBPLN : CLIDKDJAIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x61D0AA0", Offset = "0x61CF8A0", VA = "0x1861D0AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x61D07F0", Offset = "0x61CF5F0", VA = "0x1861D07F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x61C1850", Offset = "0x61C0650", VA = "0x1861C1850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x61D03B0", Offset = "0x61CF1B0", VA = "0x1861D03B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x61D1110", Offset = "0x61CFF10", VA = "0x1861D1110")]
	public EGNFILPBPLN(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x61D0410", Offset = "0x61CF210", VA = "0x1861D0410", Slot = "4")]
	public void EHCJPFDJDEA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x61D0EB0", Offset = "0x61CFCB0", VA = "0x1861D0EB0")]
	private void OPFBHIANODA(Vector3 PIOPLCOODHB, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x61D0570", Offset = "0x61CF370", VA = "0x1861D0570", Slot = "5")]
	public void GAHOHEOBGOG(Vector3 PIOPLCOODHB, Vector3 CMKBDFOJBFE, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x61D0AF0", Offset = "0x61CF8F0", VA = "0x1861D0AF0", Slot = "6")]
	public void OBLMNDNFBJN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x61D0840", Offset = "0x61CF640", VA = "0x1861D0840")]
	private void MDPJFPPKMFN(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x61D0C50", Offset = "0x61CFA50", VA = "0x1861D0C50", Slot = "7")]
	public void OEHAMMAKOGE(Vector3 BHLCCAKELIC, ForceMode BDCJIMILLMG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LAEAOBHPKKD : DKIHIGMFBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool NFDCFICNIAO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool BDBMPIKLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x61DF110", Offset = "0x61DDF10", VA = "0x1861DF110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x61D1110", Offset = "0x61CFF10", VA = "0x1861D1110")]
	public LAEAOBHPKKD(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x61DF220", Offset = "0x61DE020", VA = "0x1861DF220", Slot = "6")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x61D7760", Offset = "0x61D6560", VA = "0x1861D7760", Slot = "7")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class CIJFMJEABOD : OKPCCAOLCMM, ACKPPMBHNPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly AFHMHCLBGPL EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<AFHMHCLBGPL> JNHIBBPLDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private AFHMHCLBGPL PHNFANHCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AFHMHCLBGPL LPDGANJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform NDAHBOPJPMO;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x61C9FB0", Offset = "0x61C8DB0", VA = "0x1861C9FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x61CA470", Offset = "0x61C9270", VA = "0x1861CA470", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public AFHMHCLBGPL CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<AFHMHCLBGPL> PNHMGGDACKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event OPLLFGEIFBA NHEANGMCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x61CA6A0", Offset = "0x61C94A0", VA = "0x1861CA6A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x61CAEF0", Offset = "0x61C9CF0", VA = "0x1861CAEF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event OPLLFGEIFBA OKHMBPMOOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x61CAE50", Offset = "0x61C9C50", VA = "0x1861CAE50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x61CAA70", Offset = "0x61C9870", VA = "0x1861CAA70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MBKKMCCOIPG GLBJKAKEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x61CA600", Offset = "0x61C9400", VA = "0x1861CA600", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x61C9520", Offset = "0x61C8320", VA = "0x1861C9520", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action CLOLLEOLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x61CA520", Offset = "0x61C9320", VA = "0x1861CA520", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x61C9CE0", Offset = "0x61C8AE0", VA = "0x1861C9CE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action MPKDJHNAIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x61CADB0", Offset = "0x61C9BB0", VA = "0x1861CADB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x61CA920", Offset = "0x61C9720", VA = "0x1861CA920", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<AFHMHCLBGPL> BOBLLFGOFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x61CAD00", Offset = "0x61C9B00", VA = "0x1861CAD00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x61CA9C0", Offset = "0x61C97C0", VA = "0x1861CA9C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<AFHMHCLBGPL> MKFMCBJCGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x61CAC50", Offset = "0x61C9A50", VA = "0x1861CAC50", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x61CA010", Offset = "0x61C8E10", VA = "0x1861CA010", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action CEKGJANOJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x61CA0C0", Offset = "0x61C8EC0", VA = "0x1861CA0C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x61CABB0", Offset = "0x61C99B0", VA = "0x1861CABB0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<AFHMHCLBGPL> JILPDOBNMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x61C9C30", Offset = "0x61C8A30", VA = "0x1861C9C30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x61CA870", Offset = "0x61C9670", VA = "0x1861CA870", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x61CB210", Offset = "0x61CA010", VA = "0x1861CB210")]
	public CIJFMJEABOD(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x61CA160", Offset = "0x61C8F60", VA = "0x1861CA160", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x61C96B0", Offset = "0x61C84B0", VA = "0x1861C96B0", Slot = "30")]
	public void AIEIBGACDCB(AFHMHCLBGPL CEBKCILOOLP, bool MCPGFMFBGOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x61CA200", Offset = "0x61C9000", VA = "0x1861CA200", Slot = "6")]
	public void EEDFLOLKLOA(AFHMHCLBGPL JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x61CAF90", Offset = "0x61C9D90", VA = "0x1861CAF90", Slot = "7")]
	public void PEMLNCIGAOK(AFHMHCLBGPL JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x61C9D80", Offset = "0x61C8B80", VA = "0x1861C9D80", Slot = "4")]
	public void CLPCBEDDCDJ(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x61CA480", Offset = "0x61C9280", VA = "0x1861CA480", Slot = "5")]
	public void FAGKNOIOPHJ(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x61CAB10", Offset = "0x61C9910", VA = "0x1861CAB10")]
	private void LPNKHEODFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x61CA5C0", Offset = "0x61C93C0", VA = "0x1861CA5C0")]
	private void FOEMEFHAPHB(AFHMHCLBGPL JMEBKHCDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x61C9E70", Offset = "0x61C8C70", VA = "0x1861C9E70")]
	private void CNHICEBFJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x61CA740", Offset = "0x61C9540", VA = "0x1861CA740")]
	private void HCKLGHIPGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x61C93F0", Offset = "0x61C81F0", VA = "0x1861C93F0")]
	private void AEBDJAOPFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x61C95C0", Offset = "0x61C83C0", VA = "0x1861C95C0")]
	[CompilerGenerated]
	private object AGOGPNCIIHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class DMCKACEJBEK
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x61CF6B0", Offset = "0x61CE4B0", VA = "0x1861CF6B0")]
	public static OKPCCAOLCMM FNJKBCLLLBP(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class KLHHFHOMKFI : KIIOKNIAEIC, IGPMOHBFCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PNOGIDMGPHE<AFHMHCLBGPL> HONNJKGEMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool DGMEOEAHADF;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public PNOGIDMGPHE<AFHMHCLBGPL> DJLHEPLKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 EGKKNMHFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x61DEB80", Offset = "0x61DD980", VA = "0x1861DEB80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 KDKNEAIEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x61DE9C0", Offset = "0x61DD7C0", VA = "0x1861DE9C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x61DE490", Offset = "0x61DD290", VA = "0x1861DE490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public AFHMHCLBGPL BINELINNCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x61DE910", Offset = "0x61DD710", VA = "0x1861DE910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x61DF010", Offset = "0x61DDE10", VA = "0x1861DF010")]
	public KLHHFHOMKFI(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x61DEFA0", Offset = "0x61DDDA0", VA = "0x1861DEFA0", Slot = "8")]
	public void PGEKNDEFMEI(AFHMHCLBGPL LPDGANJNOMK, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x61DEBB0", Offset = "0x61DD9B0", VA = "0x1861DEBB0", Slot = "9")]
	public void KEINGDGJHID(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x61DE580", Offset = "0x61DD380", VA = "0x1861DE580")]
	private Vector3 DHACMAMEFFN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x61DEC10", Offset = "0x61DDA10", VA = "0x1861DEC10")]
	private void LFNIBBBILKA(AFHMHCLBGPL CCCCAIEEKAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class HKBKNNKFNDP
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x61DB7E0", Offset = "0x61DA5E0", VA = "0x1861DB7E0")]
	public static KIIOKNIAEIC IJMFICNKAOE(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class NOECAGDIECH : MBOHOEKDOPF, GDFECGMIEMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 BGABOHGMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 NEIHEGNBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float DKINIKOLCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float PBAFEEAKDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 EILEFJOFIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? FLGPPHOOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? JALLMMLFEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool IFAALPJAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool HFGGICMHODP;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 MIFDMJANJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xF8D620", Offset = "0xF8C420", VA = "0x180F8D620", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x61E23A0", Offset = "0x61E11A0", VA = "0x1861E23A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 FOMGGENGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x61E3340", Offset = "0x61E2140", VA = "0x1861E3340", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float FJMNGCPILMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038F80", VA = "0x18103A180", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x61E0BA0", Offset = "0x61DF9A0", VA = "0x1861E0BA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float FDDHKABKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xAEA490", Offset = "0xAE9290", VA = "0x180AEA490", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x61E0CB0", Offset = "0x61DFAB0", VA = "0x1861E0CB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 MMDPJCEINLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x61E3440", Offset = "0x61E2240", VA = "0x1861E3440", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion NPFINFCDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x61E2680", Offset = "0x61E1480", VA = "0x1861E2680", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x61C77B0", Offset = "0x61C65B0", VA = "0x1861C77B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event OPLLFGEIFBA LNECMPPGONO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x61E0D60", Offset = "0x61DFB60", VA = "0x1861E0D60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x61E32A0", Offset = "0x61E20A0", VA = "0x1861E32A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x61E35D0", Offset = "0x61E23D0", VA = "0x1861E35D0")]
	public NOECAGDIECH(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x61E2080", Offset = "0x61E0E80", VA = "0x1861E2080", Slot = "17")]
	public void FICIDNHDLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x61E1FA0", Offset = "0x61E0DA0", VA = "0x1861E1FA0", Slot = "16")]
	public void DOHEBIHADFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x61E31C0", Offset = "0x61E1FC0", VA = "0x1861E31C0", Slot = "19")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x61E2F30", Offset = "0x61E1D30", VA = "0x1861E2F30", Slot = "20")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x61E2230", Offset = "0x61E1030", VA = "0x1861E2230", Slot = "18")]
	public void GFEBEDIHENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x61E2A90", Offset = "0x61E1890", VA = "0x1861E2A90", Slot = "21")]
	public void IJJLIEINFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x61E23A0", Offset = "0x61E11A0", VA = "0x1861E23A0")]
	private void GFHEJGPIDGG(Vector3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x61E2800", Offset = "0x61E1600", VA = "0x1861E2800")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 HDBMGGKOBAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x61E0BA0", Offset = "0x61DF9A0", VA = "0x1861E0BA0")]
	private void BJKKHPMKDAO(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x61E0CB0", Offset = "0x61DFAB0", VA = "0x1861E0CB0")]
	private void BEIIHKJAGPJ(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x61E28F0", Offset = "0x61E16F0", VA = "0x1861E28F0")]
	private Vector3 HPNPJNHPHHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x61E2450", Offset = "0x61E1250", VA = "0x1861E2450", Slot = "15")]
	public void GGMDNNMLIJH((Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x61E1E20", Offset = "0x61E0C20", VA = "0x1861E1E20")]
	private Quaternion CNGIKLPDILG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x61E0E00", Offset = "0x61DFC00", VA = "0x1861E0E00")]
	public void CCFHKDJKOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x61E0ED0", Offset = "0x61DFCD0", VA = "0x1861E0ED0", Slot = "4")]
	public (float, Vector3) CCFHKDJKOEN(Rigidbody OHKHGCEKJBJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class NAHNGPLFIJN
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x61DF500", Offset = "0x61DE300", VA = "0x1861DF500")]
	public static MBOHOEKDOPF BDMEFLCHJBK(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class PPNLFBJFIKG : ACBNPECKOAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LNJAJLDNNOD BIAGBJJBOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly KLJHGLPFOPI EPFHBFGFNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool OMDMDIGFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xC34DA0", Offset = "0xC33BA0", VA = "0x180C34DA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public KLJHGLPFOPI NBPHMHIHAME
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "11")]
		get
		{
			return default(KLJHGLPFOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x61E5F20", Offset = "0x61E4D20", VA = "0x1861E5F20")]
	public PPNLFBJFIKG(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x61E5B20", Offset = "0x61E4920", VA = "0x1861E5B20", Slot = "4")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x61E5900", Offset = "0x61E4700", VA = "0x1861E5900")]
	private bool CLLPKANIGLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x61E5AC0", Offset = "0x61E48C0", VA = "0x1861E5AC0", Slot = "5")]
	public void DFBNOFDAPGG(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x61E5AF0", Offset = "0x61E48F0", VA = "0x1861E5AF0", Slot = "6")]
	public void FGBFHLHBONF(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x61E5C70", Offset = "0x61E4A70", VA = "0x1861E5C70", Slot = "9")]
	public void LEOOKHEPDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x61E59A0", Offset = "0x61E47A0", VA = "0x1861E59A0")]
	private void COFHJNGNEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x61E5DB0", Offset = "0x61E4BB0", VA = "0x1861E5DB0")]
	private void LPMJJOLNGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x61E5BF0", Offset = "0x61E49F0", VA = "0x1861E5BF0", Slot = "8")]
	public void JHLNCEAFEDH(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x61E5C30", Offset = "0x61E4A30", VA = "0x1861E5C30", Slot = "7")]
	public void JMGIAAHKJIC(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class APJAFPHEIEB : GCLEAEBJEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LNJAJLDNNOD EOLMCNPIAAB;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool ICLHEFBBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x61C6AE0", Offset = "0x61C58E0", VA = "0x1861C6AE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event OPLLFGEIFBA EKGBOJKJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x61C6A30", Offset = "0x61C5830", VA = "0x1861C6A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x61C6DA0", Offset = "0x61C5BA0", VA = "0x1861C6DA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x61C6E40", Offset = "0x61C5C40", VA = "0x1861C6E40")]
	public APJAFPHEIEB(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x61C69C0", Offset = "0x61C57C0", VA = "0x1861C69C0", Slot = "11")]
	public IDisposable CJDNPCMAGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x61C6AD0", Offset = "0x61C58D0", VA = "0x1861C6AD0", Slot = "8")]
	public void HEJDCJEGLEE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x61C6BC0", Offset = "0x61C59C0", VA = "0x1861C6BC0", Slot = "9")]
	public void JHGHHIKNMIH(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x61C6C90", Offset = "0x61C5A90", VA = "0x1861C6C90", Slot = "10")]
	public void MGOFIBJJOCC(object EKDHBKMFLGI, bool PACNNAFJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x61C6C50", Offset = "0x61C5A50", VA = "0x1861C6C50", Slot = "6")]
	public void LJDDCAMEMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x61C6BD0", Offset = "0x61C59D0", VA = "0x1861C6BD0", Slot = "12")]
	public void KHMAEOCCFDI(Rigidbody ANDHNALLMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x61C6B90", Offset = "0x61C5990", VA = "0x1861C6B90", Slot = "13")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class DOOCEGPLJDD : BLJOKBJGEJP, FNJBMNDKPLN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView HIFKLECGFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool GDHPAHDNMAK;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView PIKHGMOMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool PMOILNEKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x61C8430", Offset = "0x61C7230", VA = "0x1861C8430", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FKOLKBFFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event OPLLFGEIFBA FPOFAHOLBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x61CFF90", Offset = "0x61CED90", VA = "0x1861CFF90", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x61CF9E0", Offset = "0x61CE7E0", VA = "0x1861CF9E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D0300", Offset = "0x61CF100", VA = "0x1861D0300")]
	public DOOCEGPLJDD(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x61CFCF0", Offset = "0x61CEAF0", VA = "0x1861CFCF0", Slot = "9")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x61CF8E0", Offset = "0x61CE6E0", VA = "0x1861CF8E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x61D0190", Offset = "0x61CEF90", VA = "0x1861D0190", Slot = "10")]
	public void OMFHFOICOHL(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x61CFE20", Offset = "0x61CEC20", VA = "0x1861CFE20", Slot = "11")]
	public void IOGDNBGBPBH(AFHMHCLBGPL LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x61CF770", Offset = "0x61CE570", VA = "0x1861CF770")]
	private void AMDOPIEODMK(PhotonView LDLNIDMAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x61D0030", Offset = "0x61CEE30", VA = "0x1861D0030")]
	private void JOHGNLALIAB(RigidbodyEx ECIIPDBEOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x61CFA80", Offset = "0x61CE880", VA = "0x1861CFA80")]
	private void EMMEJBAGPEN(PhotonView NJNICFHBOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class MEOJLDDLBJK
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x61DF440", Offset = "0x61DE240", VA = "0x1861DF440")]
	public static BLJOKBJGEJP JGPGKIAMDMM(this AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class DHPHHHKEDPE : FOCHNEJJMDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints AKPIKNNEDOD;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool NOHCGIHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA18A80", Offset = "0xA17880", VA = "0x180A18A80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8380", Offset = "0x3BC7180", VA = "0x183BC8380", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool EJFLOBHJLJD
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x19D1650", Offset = "0x19D0450", VA = "0x1819D1650", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8370", Offset = "0x3BC7170", VA = "0x183BC8370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints IDKCGIGCFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x61CC4B0", Offset = "0x61CB2B0", VA = "0x1861CC4B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x61CC5E0", Offset = "0x61CB3E0", VA = "0x1861CC5E0")]
	public DHPHHHKEDPE(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x61CC480", Offset = "0x61CB280", VA = "0x1861CC480", Slot = "9")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x61CC450", Offset = "0x61CB250", VA = "0x1861CC450", Slot = "10")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class JFMJDGBLKFK : KCMJCMMJLOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly AFHMHCLBGPL EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float JHJLCBLFJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float JNJCPCMFNDI;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float AJIGLEDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2A0", Offset = "0x7E90A0", VA = "0x1807EA2A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x61DD020", Offset = "0x61DBE20", VA = "0x1861DD020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float DDDCHMEPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x88CF80", Offset = "0x88BD80", VA = "0x18088CF80", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x61DD0F0", Offset = "0x61DBEF0", VA = "0x1861DD0F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x61DD2B0", Offset = "0x61DC0B0", VA = "0x1861DD2B0")]
	public JFMJDGBLKFK(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x61DD260", Offset = "0x61DC060", VA = "0x1861DD260", Slot = "8")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x61DD1C0", Offset = "0x61DBFC0", VA = "0x1861DD1C0", Slot = "9")]
	public void JGCEJKBBHIC(Rigidbody IMDIIOPGPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class BMCOHEGJMAF : PCBDEJNLIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OLMLMAOHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool AMLMOCNBJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int NFCEKIKIBGC;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x61C77B0", Offset = "0x61C65B0", VA = "0x1861C77B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool HGHFLMAHMON
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x61C7650", Offset = "0x61C6450", VA = "0x1861C7650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private AFHMHCLBGPL KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x61C73C0", Offset = "0x61C61C0", VA = "0x1861C73C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x61C79E0", Offset = "0x61C67E0", VA = "0x1861C79E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event OPLLFGEIFBA IPEEDOMDGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x61C75B0", Offset = "0x61C63B0", VA = "0x1861C75B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x61C7510", Offset = "0x61C6310", VA = "0x1861C7510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x61C7A40", Offset = "0x61C6840", VA = "0x1861C7A40")]
	public BMCOHEGJMAF(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x61C7430", Offset = "0x61C6230", VA = "0x1861C7430", Slot = "6")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x61C7420", Offset = "0x61C6220", VA = "0x1861C7420", Slot = "8")]
	public void EAGDCCCGKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x61C7270", Offset = "0x61C6070", VA = "0x1861C7270", Slot = "7")]
	public bool CHDICAKHBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x61C7670", Offset = "0x61C6470", VA = "0x1861C7670", Slot = "9")]
	public void LEFEOLICJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x61C7710", Offset = "0x61C6510", VA = "0x1861C7710", Slot = "11")]
	public void LKLMCLDBKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x61C74C0", Offset = "0x61C62C0", VA = "0x1861C74C0", Slot = "12")]
	public void JCOAOEOCLOG(bool GEFNNEJLOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x61C6F30", Offset = "0x61C5D30", VA = "0x1861C6F30", Slot = "10")]
	public void AIFDDHHFGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x61C7800", Offset = "0x61C6600", VA = "0x1861C7800")]
	private bool PLIPPFEOIEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x61C70E0", Offset = "0x61C5EE0", VA = "0x1861C70E0")]
	private void BHKEBALKJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class PMOMKNIHCBM : NMIMBODNLJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly LNJAJLDNNOD BECMBBAGJCD;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody DGCCHJJPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool GAKPKOHHDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x61C1850", Offset = "0x61C0650", VA = "0x1861C1850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool CLMAJLBDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xC34DA0", Offset = "0xC33BA0", VA = "0x180C34DA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x61E57F0", Offset = "0x61E45F0", VA = "0x1861E57F0")]
	public PMOMKNIHCBM(AFHMHCLBGPL EBCLIMEMCGJ, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x61E5090", Offset = "0x61E3E90", VA = "0x1861E5090", Slot = "5")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x61E5490", Offset = "0x61E4290", VA = "0x1861E5490", Slot = "7")]
	public void MPBJBLDHMLC(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x61E5460", Offset = "0x61E4260", VA = "0x1861E5460", Slot = "8")]
	public void JOMCGDIDDGE(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x61E54C0", Offset = "0x61E42C0", VA = "0x1861E54C0", Slot = "9")]
	public void PFFOHPOCDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x61E4A10", Offset = "0x61E3810", VA = "0x1861E4A10", Slot = "11")]
	public void CAKEMGLLFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x61E5130", Offset = "0x61E3F30", VA = "0x1861E5130", Slot = "12")]
	public void GLKPCHEPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x61E4C00", Offset = "0x61E3A00", VA = "0x1861E4C00", Slot = "10")]
	public void CHPIHHCBCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x61E52B0", Offset = "0x61E40B0", VA = "0x1861E52B0")]
	private void JGCBGKABMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x61E4860", Offset = "0x61E3660", VA = "0x1861E4860")]
	private void BGEGIDGMLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JOAHPJNEION : KJCBHAEKLLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly EHIGKANDEAP EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly LNJAJLDNNOD DIMIJPALEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float CJCGOBADDML;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public EAICDDBCGGM GMAIBPBMGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public MDFNBBCABMJ AODOJPBNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 OLNFDFKLHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x61EBFF0", Offset = "0x61EADF0", VA = "0x1861EBFF0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x61EE9C0", Offset = "0x61ED7C0", VA = "0x1861EE9C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 OKKIKHDGGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x61EDC20", Offset = "0x61ECA20", VA = "0x1861EDC20", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x61ED2A0", Offset = "0x61EC0A0", VA = "0x1861ED2A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 EOODCLIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x61EE330", Offset = "0x61ED130", VA = "0x1861EE330", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x61EE270", Offset = "0x61ED070", VA = "0x1861EE270", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 NENDCLIOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x61EC170", Offset = "0x61EAF70", VA = "0x1861EC170", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x61EBFC0", Offset = "0x61EADC0", VA = "0x1861EBFC0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float HNJDPJEIILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1B70", VA = "0x1807B2D70", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x61EC890", Offset = "0x61EB690", VA = "0x1861EC890", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool CJDFJPEDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x15BA4A0", Offset = "0x15B92A0", VA = "0x1815BA4A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private CLIDKDJAIPG KKLDNFFPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1C51B30", Offset = "0x1C50930", VA = "0x181C51B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool HGHFLMAHMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x61C4540", Offset = "0x61C3340", VA = "0x1861C4540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x61EEE40", Offset = "0x61EDC40", VA = "0x1861EEE40")]
	public JOAHPJNEION(AFHMHCLBGPL EBCLIMEMCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA10", Offset = "0x61EB810", VA = "0x1861ECA10", Slot = "19")]
	public void GBKJIACAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x61EC940", Offset = "0x61EB740", VA = "0x1861EC940", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x61EDF20", Offset = "0x61ECD20", VA = "0x1861EDF20", Slot = "28")]
	public void KHMAEOCCFDI(Rigidbody IMDIIOPGPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xA4B090", Offset = "0xA49E90", VA = "0x180A4B090", Slot = "20")]
	public void MNGJMFIPKKA(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xA4C3B0", Offset = "0xA4B1B0", VA = "0x180A4C3B0", Slot = "30")]
	public void DGMECMMNNNM(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x61EBE50", Offset = "0x61EAC50", VA = "0x1861EBE50", Slot = "35")]
	public Vector3 AGCKEKLOJIH(Vector3 FGPAGLKAPID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x61EEA80", Offset = "0x61ED880", VA = "0x1861EEA80", Slot = "34")]
	public Vector3 OKJLFDLHBKG(Vector3 PFHKDIPHHDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA10", Offset = "0x61EB810", VA = "0x1861ECA10", Slot = "27")]
	public void EIKGJPKGMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x61EECB0", Offset = "0x61EDAB0", VA = "0x1861EECB0", Slot = "25")]
	public void PBLACPABIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x61ED760", Offset = "0x61EC560", VA = "0x1861ED760", Slot = "24")]
	public void IKKFNLBJCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x61EE0D0", Offset = "0x61ECED0", VA = "0x1861EE0D0", Slot = "33")]
	public void KNDHFOGLLLC(Vector3 JMDPABCLOMI, Vector3 DGINOCOHLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x61EC110", Offset = "0x61EAF10", VA = "0x1861EC110", Slot = "32")]
	public void BGNLIABGNOA(Vector3 MFOHPHLHCMH, Vector3 PHGPAJDKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x61EE450", Offset = "0x61ED250", VA = "0x1861EE450", Slot = "31")]
	public void NANGECNGOHL(Vector3 EHHHOADEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x61EC260", Offset = "0x61EB060", VA = "0x1861EC260", Slot = "22")]
	public void DIBELGFIMNN(FAMJEMLEDEM HBGEPJELKLP, Vector3 CENOKKHAFFL, float LCIJPCKEHPE, float PLBKOIGLFDB = 8f, float NGFPCBAKBPB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x61EE5C0", Offset = "0x61ED3C0", VA = "0x1861EE5C0", Slot = "21")]
	public void NEIDOBDKEKM(LFHDNPMOEKP MHOBOIPJLKL, Vector3 APBMLIKHBHE, float KKNIMCMDKOC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x61ECAC0", Offset = "0x61EB8C0", VA = "0x1861ECAC0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GBKHBEPJDFG(LFHDNPMOEKP MHOBOIPJLKL, Vector3 ALADLBOMNEP, float MOGLJNNCEHD = 7f, float MDBDEKBOBPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x61EDD10", Offset = "0x61ECB10", VA = "0x1861EDD10", Slot = "29")]
	public Vector3 KBMECCIPCJF(Vector3 JIJAOBLIPMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x61EED10", Offset = "0x61EDB10", VA = "0x1861EED10", Slot = "26")]
	public void PCPELMIIDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x61EC890", Offset = "0x61EB690", VA = "0x1861EC890")]
	private void KJANEGBMKKK(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x61EE850", Offset = "0x61ED650", VA = "0x1861EE850")]
	private void OEEJMNFNHLK(Vector3 APBMLIKHBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x61EEBD0", Offset = "0x61ED9D0", VA = "0x1861EEBD0")]
	private Vector3 OLKOIDFMNDN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x61ED7C0", Offset = "0x61EC5C0", VA = "0x1861ED7C0")]
	private void JLBGIAILOIF(Vector3 PFHKDIPHHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x61EDFF0", Offset = "0x61ECDF0", VA = "0x1861EDFF0")]
	private Vector3 KJBHKLGJEKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE60", Offset = "0x61EBC60", VA = "0x1861ECE60")]
	private void GFPGHDMLPDF(Vector3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x61ED2D0", Offset = "0x61EC0D0", VA = "0x1861ED2D0")]
	private void HIJFAPGFMFA(Vector3 PFHKDIPHHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x61EDE70", Offset = "0x61ECC70", VA = "0x1861EDE70")]
	private void KBPLJOHOPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JLOKPCJEBDD : DNCFLFJNBGK
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x61EB9F0", Offset = "0x61EA7F0", VA = "0x1861EB9F0", Slot = "4")]
	public ACKPPMBHNPB FLHJOIDNMBF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x61EBB20", Offset = "0x61EA920", VA = "0x1861EBB20", Slot = "5")]
	public KJCBHAEKLLK JOMLJJNHEFD(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x61EBDF0", Offset = "0x61EABF0", VA = "0x1861EBDF0", Slot = "6")]
	public IGPMOHBFCIK PMCNMDAMJPA(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x61EB920", Offset = "0x61EA720", VA = "0x1861EB920", Slot = "7")]
	public KCMJCMMJLOM DDECDGMLLLN(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA50", Offset = "0x61EA850", VA = "0x1861EBA50", Slot = "8")]
	public PCBDEJNLIBE HBHHEHGGIBP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x61EBD30", Offset = "0x61EAB30", VA = "0x1861EBD30", Slot = "9")]
	public AJDCFLFHENI MBFCIJLEHOM(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC00", Offset = "0x61EAA00", VA = "0x1861EBC00", Slot = "10")]
	public GCLEAEBJEJA KDFDKAKHHPL(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x61EBCD0", Offset = "0x61EAAD0", VA = "0x1861EBCD0", Slot = "11")]
	public CLIDKDJAIPG MABLEBGNIEP(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x61EB730", Offset = "0x61EA530", VA = "0x1861EB730", Slot = "12")]
	public CDAIFLEPMCD AFNAGMMCLBG(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x61EBD90", Offset = "0x61EAB90", VA = "0x1861EBD90", Slot = "13")]
	public DKIHIGMFBHJ MPJCIOHIADF(AFHMHCLBGPL IIJDENGNPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x61EB980", Offset = "0x61EA780", VA = "0x1861EB980")]
	public NMIMBODNLJI FFLIPKGEEDG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x61EB800", Offset = "0x61EA600", VA = "0x1861EB800")]
	public FNJBMNDKPLN HOAMBNLCLLB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x61EBAB0", Offset = "0x61EA8B0", VA = "0x1861EBAB0")]
	public ACBNPECKOAN IENBAJNMOIH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC60", Offset = "0x61EAA60", VA = "0x1861EBC60")]
	public GDFECGMIEMM KHJMLFGPIAP(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x61EB790", Offset = "0x61EA590", VA = "0x1861EB790")]
	public FOCHNEJJMDO JLHGMBPIGAB(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x61EB870", Offset = "0x61EA670", VA = "0x1861EB870", Slot = "19")]
	public AFHMHCLBGPL CPODLJKEDGB(RigidbodyEx EBCLIMEMCGJ, GJIHNGPJMHA LMCJHCIOIIP, OBIMNGPJPFI AMCDJKCDDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JLOKPCJEBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x61EB980", Offset = "0x61EA780", VA = "0x1861EB980", Slot = "14")]
	private NMIMBODNLJI FIIMDGALDGD(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x61EB800", Offset = "0x61EA600", VA = "0x1861EB800", Slot = "15")]
	private FNJBMNDKPLN CBOFKDEHGFG(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x61EBAB0", Offset = "0x61EA8B0", VA = "0x1861EBAB0", Slot = "16")]
	private ACBNPECKOAN PDMOEMKDOEF(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC60", Offset = "0x61EAA60", VA = "0x1861EBC60", Slot = "17")]
	private GDFECGMIEMM OOBNBBJPNJE(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x61EB790", Offset = "0x61EA590", VA = "0x1861EB790", Slot = "18")]
	private FOCHNEJJMDO AGJMADGGLFH(AFHMHCLBGPL IIJDENGNPJH, [In] GJIHNGPJMHA LMCJHCIOIIP)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MCMFKIKAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x61EEEE0", Offset = "0x61EDCE0", VA = "0x1861EEEE0", Slot = "6")]
		public sealed override void DEIBGDDLADL(MMLHPMLOJHM PMOMGAGBHKB)
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
