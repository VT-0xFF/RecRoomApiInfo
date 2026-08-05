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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static KBJOPGEOOCH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int KNABIKABPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int AFLIABLDNNC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F607F0", Offset = "0x6F5EFF0", VA = "0x186F607F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F60830", Offset = "0x6F5F030", VA = "0x186F60830")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F60810", Offset = "0x6F5F010", VA = "0x186F60810")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DKIECHCHJFL, [Optional] UnityEngine.Object JFDMKPDIBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DKIECHCHJFL, [Optional] UnityEngine.Object JFDMKPDIBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F60920", Offset = "0x6F5F120", VA = "0x186F60920")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KEDGBGINDFP
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LNPEDHIJIMK : MLAAMHAMNCK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1599D60", Offset = "0x1598560", VA = "0x181599D60", Slot = "4")]
		public Vector3 OHEPKJEBFID()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1599D60", Offset = "0x1598560", VA = "0x181599D60", Slot = "5")]
		public Vector3 BFPGMPGOAEH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LNPEDHIJIMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MLAAMHAMNCK PCMJAGFIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BC90", Offset = "0x5F4A490", VA = "0x185F4BC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly MFFHLJHLBIG HMBFEDIJKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool NHOHANJCEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FAFKHKPFEKI HGFMEPEKMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private BFCLHOINCJP physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal FAFKHKPFEKI AOOPEEENLEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F61350", Offset = "0x6F5FB50", VA = "0x186F61350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9130B0", Offset = "0x9118B0", VA = "0x1809130B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LEIIEFIHIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F63580", Offset = "0x6F61D80", VA = "0x186F63580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ODFEIMILGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F63520", Offset = "0x6F61D20", VA = "0x186F63520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ONIJEEBBCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F64140", Offset = "0x6F62940", VA = "0x186F64140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F656D0", Offset = "0x6F63ED0", VA = "0x186F656D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform EMNGBEEEHMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD8BB50", Offset = "0xD8A350", VA = "0x180D8BB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BJCECNAIBIG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD8BB50", Offset = "0xD8A350", VA = "0x180D8BB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FFFAJCBJCHK EFPMFLGMIAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F63270", Offset = "0x6F61A70", VA = "0x186F63270")]
			get
			{
				return default(FFFAJCBJCHK);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F64E30", Offset = "0x6F63630", VA = "0x186F64E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PJBJHNNIMMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F637F0", Offset = "0x6F61FF0", VA = "0x186F637F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EMKHKPNFBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F63400", Offset = "0x6F61C00", VA = "0x186F63400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MLAAMHAMNCK KNKDIKABJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F63730", Offset = "0x6F61F30", VA = "0x186F63730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F65040", Offset = "0x6F63840", VA = "0x186F65040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JHEBHKGMPAF CPNBMHEFJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F636D0", Offset = "0x6F61ED0", VA = "0x186F636D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F64FD0", Offset = "0x6F637D0", VA = "0x186F64FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MFEJBDEHODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F635B0", Offset = "0x6F61DB0", VA = "0x186F635B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody CGNLPAOPEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F63610", Offset = "0x6F61E10", VA = "0x186F63610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LGMFNHPALFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F63460", Offset = "0x6F61C60", VA = "0x186F63460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F64EF0", Offset = "0x6F636F0", VA = "0x186F64EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JIKLDANODOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x218D4A0", Offset = "0x218BCA0", VA = "0x18218D4A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4060B20", Offset = "0x405F320", VA = "0x184060B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float CHODJKFAPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F640E0", Offset = "0x6F628E0", VA = "0x186F640E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LMACMILFAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F64080", Offset = "0x6F62880", VA = "0x186F64080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F65660", Offset = "0x6F63E60", VA = "0x186F65660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OIOOEPMJBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F63A50", Offset = "0x6F62250", VA = "0x186F63A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F652E0", Offset = "0x6F63AE0", VA = "0x186F652E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GIFDAOBHDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F63850", Offset = "0x6F62050", VA = "0x186F63850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F650B0", Offset = "0x6F638B0", VA = "0x186F650B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HCMLLAEMOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F64660", Offset = "0x6F62E60", VA = "0x186F64660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F65C10", Offset = "0x6F64410", VA = "0x186F65C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 ADFEMPOHHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F63E60", Offset = "0x6F62660", VA = "0x186F63E60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F65430", Offset = "0x6F63C30", VA = "0x186F65430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 HKENGGJIGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F647A0", Offset = "0x6F62FA0", VA = "0x186F647A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode POOCPGIKOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F63990", Offset = "0x6F62190", VA = "0x186F63990")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F65200", Offset = "0x6F63A00", VA = "0x186F65200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float FNKBHNMOBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F634C0", Offset = "0x6F61CC0", VA = "0x186F634C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F64F60", Offset = "0x6F63760", VA = "0x186F64F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IJJBJLEMONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F639F0", Offset = "0x6F621F0", VA = "0x186F639F0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F65270", Offset = "0x6F63A70", VA = "0x186F65270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 HEEADIMOMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F641A0", Offset = "0x6F629A0", VA = "0x186F641A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MCJHNLHNHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F641A0", Offset = "0x6F629A0", VA = "0x186F641A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F659E0", Offset = "0x6F641E0", VA = "0x186F659E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EGHKKPPIJGN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F63F40", Offset = "0x6F62740", VA = "0x186F63F40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F65510", Offset = "0x6F63D10", VA = "0x186F65510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IMPMMLNMDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F64600", Offset = "0x6F62E00", VA = "0x186F64600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F65BA0", Offset = "0x6F643A0", VA = "0x186F65BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion JJPINILMJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F64280", Offset = "0x6F62A80", VA = "0x186F64280")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F65740", Offset = "0x6F63F40", VA = "0x186F65740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion DIEMMNDNHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F64520", Offset = "0x6F62D20", VA = "0x186F64520")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F65AC0", Offset = "0x6F642C0", VA = "0x186F65AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 GMLKEOIBEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F64360", Offset = "0x6F62B60", VA = "0x186F64360")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F65820", Offset = "0x6F64020", VA = "0x186F65820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LKMBGCCKLPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F64440", Offset = "0x6F62C40", VA = "0x186F64440")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F65900", Offset = "0x6F64100", VA = "0x186F65900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 PPJHGOCBPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F646C0", Offset = "0x6F62EC0", VA = "0x186F646C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F65C80", Offset = "0x6F64480", VA = "0x186F65C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 LLBIDODECBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F63FA0", Offset = "0x6F627A0", VA = "0x186F63FA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F65580", Offset = "0x6F63D80", VA = "0x186F65580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JDNINLGNNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F638B0", Offset = "0x6F620B0", VA = "0x186F638B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F65120", Offset = "0x6F63920", VA = "0x186F65120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AFFJGLIILJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F63D80", Offset = "0x6F62580", VA = "0x186F63D80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F65350", Offset = "0x6F63B50", VA = "0x186F65350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 INPCFJLMNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F63C40", Offset = "0x6F62440", VA = "0x186F63C40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion MIIDBCDLHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F63B60", Offset = "0x6F62360", VA = "0x186F63B60")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NIJGKMFFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F64960", Offset = "0x6F63160", VA = "0x186F64960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DGBHAPEEKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F64880", Offset = "0x6F63080", VA = "0x186F64880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ICBDCKBKPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6F63D20", Offset = "0x6F62520", VA = "0x186F63D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HPAPGLPAOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6F63790", Offset = "0x6F61F90", VA = "0x186F63790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JKOBEIFFLAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F633A0", Offset = "0x6F61BA0", VA = "0x186F633A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DGHDMLPPOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6F63340", Offset = "0x6F61B40", VA = "0x186F63340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FFNCCFIMIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6F63210", Offset = "0x6F61A10", VA = "0x186F63210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GKGFHIFHOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F63AB0", Offset = "0x6F622B0", VA = "0x186F63AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GLGGKOPKDGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x975CB0", Offset = "0x9744B0", VA = "0x180975CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PENLMJLNPDM HACHEKBJCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F63130", Offset = "0x6F61930", VA = "0x186F63130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F64D50", Offset = "0x6F63550", VA = "0x186F64D50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IJIIOKHNDCH HBKOCCDFBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F630C0", Offset = "0x6F618C0", VA = "0x186F630C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F64CE0", Offset = "0x6F634E0", VA = "0x186F64CE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PENLMJLNPDM ABGONPKEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F62E20", Offset = "0x6F61620", VA = "0x186F62E20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F64A40", Offset = "0x6F63240", VA = "0x186F64A40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PENLMJLNPDM PCAPCNOAOJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F62E90", Offset = "0x6F61690", VA = "0x186F62E90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F64AB0", Offset = "0x6F632B0", VA = "0x186F64AB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event PENLMJLNPDM DDALOGBJKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F62FE0", Offset = "0x6F617E0", VA = "0x186F62FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F64C00", Offset = "0x6F63400", VA = "0x186F64C00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F62F70", Offset = "0x6F61770", VA = "0x186F62F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F64B90", Offset = "0x6F63390", VA = "0x186F64B90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PENLMJLNPDM PLJODFLBJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F63050", Offset = "0x6F61850", VA = "0x186F63050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F64C70", Offset = "0x6F63470", VA = "0x186F64C70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PENLMJLNPDM INMKKNIENIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F631A0", Offset = "0x6F619A0", VA = "0x186F631A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F64DC0", Offset = "0x6F635C0", VA = "0x186F64DC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PENLMJLNPDM MOMDHFIOGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F62F00", Offset = "0x6F61700", VA = "0x186F62F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F64B20", Offset = "0x6F63320", VA = "0x186F64B20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10")]
		internal void EFGHEMDKEOG(FAFKHKPFEKI NHIFGJKHMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E10", Offset = "0x6F60610", VA = "0x186F61E10")]
		internal void MGFPIONOJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F62B10", Offset = "0x6F61310", VA = "0x186F62B10")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LPGBCHBJCAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F627A0", Offset = "0x6F60FA0", VA = "0x186F627A0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F612E0", Offset = "0x6F5FAE0", VA = "0x186F612E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F61350", Offset = "0x6F5FB50", VA = "0x186F61350")]
		private FAFKHKPFEKI HNGOLBJLLAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F61980", Offset = "0x6F60180", VA = "0x186F61980")]
		private void LEAMKENGDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F61F60", Offset = "0x6F60760", VA = "0x186F61F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E10", Offset = "0x6F60610", VA = "0x186F61E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F61640", Offset = "0x6F5FE40", VA = "0x186F61640")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F61F00", Offset = "0x6F60700", VA = "0x186F61F00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F61FC0", Offset = "0x6F607C0", VA = "0x186F61FC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F60970", Offset = "0x6F5F170", VA = "0x186F60970")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F62030", Offset = "0x6F60830", VA = "0x186F62030")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F615E0", Offset = "0x6F5FDE0", VA = "0x186F615E0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F61EA0", Offset = "0x6F606A0", VA = "0x186F61EA0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F62910", Offset = "0x6F61110", VA = "0x186F62910")]
		public void SetParent(RigidbodyEx ECNGHFJBIJL, bool NGKEIPOGCJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F62340", Offset = "0x6F60B40", VA = "0x186F62340")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F618A0", Offset = "0x6F600A0", VA = "0x186F618A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx LDCOLCDIOIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F618E0", Offset = "0x6F600E0", VA = "0x186F618E0")]
		public bool IsRigidbodyDescendant(RigidbodyEx DHHBLOHICNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F60B90", Offset = "0x6F5F390", VA = "0x186F60B90")]
		public void AddInterpolationRestriction(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F620A0", Offset = "0x6F608A0", VA = "0x186F620A0")]
		public void RemoveInterpolationRestriction(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F61400", Offset = "0x6F5FC00", VA = "0x186F61400")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F60C00", Offset = "0x6F5F400", VA = "0x186F60C00")]
		public void AddKinematic(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F62110", Offset = "0x6F60910", VA = "0x186F62110")]
		public void RemoveKinematic(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F62890", Offset = "0x6F61090", VA = "0x186F62890")]
		public void SetKinematic(object FLDJLPKNKKO, bool GCGPLALBKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F626A0", Offset = "0x6F60EA0", VA = "0x186F626A0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F625A0", Offset = "0x6F60DA0", VA = "0x186F625A0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F617A0", Offset = "0x6F5FFA0", VA = "0x186F617A0")]
		public Vector3 GetConstrainedVelocity(Vector3 PPJHGOCBPCK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F616A0", Offset = "0x6F5FEA0", VA = "0x186F616A0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JDNINLGNNJF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F60B00", Offset = "0x6F5F300", VA = "0x186F60B00")]
		public void AddForce(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F609E0", Offset = "0x6F5F1E0", VA = "0x186F609E0")]
		public void AddForceAtPosition(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F60D70", Offset = "0x6F5F570", VA = "0x186F60D70")]
		public void AddTorque(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F60C70", Offset = "0x6F5F470", VA = "0x186F60C70")]
		public void AddRelativeTorque(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62BF0", Offset = "0x6F613F0", VA = "0x186F62BF0")]
		public Vector3 WorldToLocalVelocity(Vector3 PLGCJGPJLOA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F61D10", Offset = "0x6F60510", VA = "0x186F61D10")]
		public Vector3 LocalToWorldVelocity(Vector3 LLBIDODECBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F61580", Offset = "0x6F5FD80", VA = "0x186F61580")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F61520", Offset = "0x6F5FD20", VA = "0x186F61520")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F614C0", Offset = "0x6F5FCC0", VA = "0x186F614C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F61460", Offset = "0x6F5FC60", VA = "0x186F61460")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F624A0", Offset = "0x6F60CA0", VA = "0x186F624A0")]
		public void ResetVelocityWorldSpace(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F623A0", Offset = "0x6F60BA0", VA = "0x186F623A0")]
		public void ResetVelocityLocalSpace(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F62260", Offset = "0x6F60A60", VA = "0x186F62260")]
		public void ResetLinearVelocityLocalSpace(Vector3 NNFLIAGNPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F62A00", Offset = "0x6F61200", VA = "0x186F62A00")]
		public bool SweepTest(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F61920", Offset = "0x6F60120", VA = "0x186F61920")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F629A0", Offset = "0x6F611A0", VA = "0x186F629A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F62B90", Offset = "0x6F61390", VA = "0x186F62B90")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F60D00", Offset = "0x6F5F500", VA = "0x186F60D00")]
		public void AddShouldHaveUnityRigidbodyToken(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F62180", Offset = "0x6F60980", VA = "0x186F62180")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F610B0", Offset = "0x6F5F8B0", VA = "0x186F610B0")]
		public void ApplyForceVelocityChange(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F60FB0", Offset = "0x6F5F7B0", VA = "0x186F60FB0")]
		public void ApplyAngularVelocityChange(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F611D0", Offset = "0x6F5F9D0", VA = "0x186F611D0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F60EF0", Offset = "0x6F5F6F0", VA = "0x186F60EF0")]
		public bool AllowedScaleChange(float OMOAPNBJLBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F60E00", Offset = "0x6F5F600", VA = "0x186F60E00")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OFKMLDLKKGB, object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F621F0", Offset = "0x6F609F0", VA = "0x186F621F0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F62D80", Offset = "0x6F61580", VA = "0x186F62D80")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FDFOGIEFJDN
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5F376C0", Offset = "0x5F35EC0", VA = "0x185F376C0")]
	public static FAFKHKPFEKI AOOPEEENLEL(this RigidbodyEx LPIBPEGGEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PENLMJLNPDM(RigidbodyEx KNNKNILIDJH);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AHFEBFDJGCO : FDLOOMEBFFN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JJNJBIEPOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int HCHMCBDKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "6")]
	public GBAHALBBEFO MGLHCGNDNOG(float CIKEFFDMPDJ)
	{
		return default(GBAHALBBEFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
	public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "9")]
	public void JJOACBAGNIC(ADEMDHOELEN HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "10")]
	public void CPPHPNNFPKL(ADEMDHOELEN CIHBNKECJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "11")]
	public GBAHALBBEFO NBABKLLOPPO(ADEMDHOELEN HHNPCHNMLMA)
	{
		return default(GBAHALBBEFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "12")]
	public bool DAOMDHGCLOP(ADEMDHOELEN HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "13")]
	public void FBMNDAIKFCN(ADEMDHOELEN HHNPCHNMLMA, FFFAJCBJCHK CCLDMBAFDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public AHFEBFDJGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BFCLHOINCJP
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GJCDONMOIJG
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CJKCMEGMCAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody CNBDNPIBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 MGLJKNHHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 NOIKJKFLDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BFCLHOINCJP LMIIBOOAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GDHFCFBAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NADEAEAJGDH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void IJIIOKHNDCH(RigidbodyEx KNNKNILIDJH, bool NGKEIPOGCJF = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KKBPAALNMJN(typeof(OFKKOHAHMCI), new string[] { "Ignore", "Mock" })]
public class PDDLMIGPOJP : OFKKOHAHMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LLJBHMHACBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8116F0", Offset = "0x80FEF0", VA = "0x1808116F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
	public void GAHLMBDGPDK(string FKPBDLDGFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "6")]
	public void PHPCFJAKJCC(RigidbodyEx LPIBPEGGEEE, Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83C8F0", Offset = "0x83B0F0", VA = "0x18083C8F0", Slot = "7")]
	public FDLOOMEBFFN KKBIDAPGBJC(int MCJMDOGPMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void DGMOCEENFAD(Vector3 HKENGGJIGFE, float OAOMDGGCPHF, Color OPOEPBAFNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PDDLMIGPOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KKBPAALNMJN(typeof(MCALNKPINNM), new string[] { })]
public class HJPPKKOGDJH : MCALNKPINNM, BOGFHHLHMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EDINIDCGNHI CONCNLCHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OFKKOHAHMCI FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BAEMKDJGAPE OHDNLJNCDAB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool AAABFJFMEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F3F050", Offset = "0x5F3D850", VA = "0x185F3F050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public OFKKOHAHMCI GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EB20", Offset = "0x5F3D320", VA = "0x185F3EB20", Slot = "12")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F3ED50", Offset = "0x5F3D550", VA = "0x185F3ED50", Slot = "7")]
	public ICDDKLLCIME NKNFIMKMBOH(RigidbodyEx LPIBPEGGEEE)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EBB0", Offset = "0x5F3D3B0", VA = "0x185F3EBB0")]
	private static ICDDKLLCIME MJGIENFHPGB(RigidbodyEx LPIBPEGGEEE)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5F3ECB0", Offset = "0x5F3D4B0", VA = "0x185F3ECB0", Slot = "8")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EA50", Offset = "0x5F3D250", VA = "0x185F3EA50", Slot = "11")]
	private RigidbodyEx FOGFADFKIHD(GameObject NBIMDBPEIEO, CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E960", Offset = "0x5F3D160", VA = "0x185F3E960", Slot = "9")]
	public void EHFPLOBAFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E810", Offset = "0x5F3D010", VA = "0x185F3E810", Slot = "10")]
	public void APKFOCFKDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public HJPPKKOGDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BFCJBHENOAM
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float OHMPLFMOANO = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float DLFFGENFFFO = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float JAHDEJPDGLK = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public BFCJBHENOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NLHCAGAFFDA
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C8F0", Offset = "0x6F5B0F0", VA = "0x186F5C8F0")]
	public static void MIKBJGKOOGI(this Rigidbody LPGBCHBJCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C7E0", Offset = "0x6F5AFE0", VA = "0x186F5C7E0")]
	public static void MIKBJGKOOGI(this Rigidbody LPGBCHBJCAK, Vector3 LIMDIMJFPNB, Quaternion MIIDBCDLHGC, Vector3 JGECPMODFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CA40", Offset = "0x6F5B240", VA = "0x186F5CA40")]
	public static void NFHMGNOLEMG(Vector3 PPJHGOCBPCK, Vector3 PKBDFEAADGM, out Vector3 HDCAFGJOKJM, out Vector3 GDPFKIBHMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FPHOFMJLENJ
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ECIMMNKGOEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PENLMJLNPDM OCCHAGGOINB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NLOPKOPLBOH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface OFKKOHAHMCI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool LLJBHMHACBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAHLMBDGPDK(string FKPBDLDGFCC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHPCFJAKJCC(RigidbodyEx LPIBPEGGEEE, Action FOGMDOMFJBB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDLOOMEBFFN KKBIDAPGBJC(int MCJMDOGPMFA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGMOCEENFAD(Vector3 HKENGGJIGFE, float OAOMDGGCPHF, Color OPOEPBAFNOG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface MCALNKPINNM
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OFKKOHAHMCI GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool AAABFJFMEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ICDDKLLCIME NKNFIMKMBOH(RigidbodyEx LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHFPLOBAFBB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APKFOCFKDHF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx MINFOIAPHNJ(GameObject NBIMDBPEIEO, [Optional] CJKCMEGMCAM PHBHEFAPHDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JOKBCEDMKLI
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx CGLLJFNDJEC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKLLDNMELNG(object FLDJLPKNKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class IICGPMHJLKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F44DD0", Offset = "0x5F435D0", VA = "0x185F44DD0")]
	public IICGPMHJLKE(KLJOINJFJMA EFBLLBPFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F44D70", Offset = "0x5F43570", VA = "0x185F44D70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KLJOINJFJMA : FAFKHKPFEKI, IDisposable, AFHDOJMAAGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string HGPLFKFIDEE = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly MCALNKPINNM GAICNONPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal CMANNCNAEEB PABIOJINDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PPMGPBJOPHG LIOEFMLCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal ECIMMNKGOEA HFMKNNGIALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PMKPCPNEKNE PPJHGOCBPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NABDDFAEAAL ALIKELHIDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal IPMJOKMPDFD EDJNKFIBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal NLOPKOPLBOH MMPBNEKGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DPIKHFGILLN HDFNJCCOBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal LDMPFENPFIH BDJDLEHEGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HMNJOAIBFBB CBFFLIGMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JAFLIGJBBGN PLECFEFOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal NAAOIBJHADK HCKNDFMIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JEDJEILBNNF EICBDICCCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal BEOHALDGFAH CNBDNPIBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GADMMIHBFNL OLPKFIHFFGD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B41E0", Offset = "0x8B29E0", VA = "0x1808B41E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAB3C10", Offset = "0xAB2410", VA = "0x180AB3C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E9210", Offset = "0x8E7A10", VA = "0x1808E9210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB02EA0", Offset = "0xB016A0", VA = "0x180B02EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C330", Offset = "0x5F4AB30", VA = "0x185F4C330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ED90", Offset = "0x5F4D590", VA = "0x185F4ED90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5F51270", Offset = "0x5F4FA70", VA = "0x185F51270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5F50FC0", Offset = "0x5F4F7C0", VA = "0x185F50FC0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5F51310", Offset = "0x5F4FB10", VA = "0x185F51310", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FCE0", Offset = "0x5F4E4E0", VA = "0x185F4FCE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5F51610", Offset = "0x5F4FE10", VA = "0x185F51610", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5F51660", Offset = "0x5F4FE60", VA = "0x185F51660", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E870", Offset = "0x5F4D070", VA = "0x185F4E870", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5F516C0", Offset = "0x5F4FEC0", VA = "0x185F516C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C590", Offset = "0x5F4AD90", VA = "0x185F4C590", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F650", Offset = "0x5F4DE50", VA = "0x185F4F650", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E480", Offset = "0x5F4CC80", VA = "0x185F4E480", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5F51950", Offset = "0x5F50150", VA = "0x185F51950", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C640", Offset = "0x5F4AE40", VA = "0x185F4C640", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F760", Offset = "0x5F4DF60", VA = "0x185F4F760", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E4D0", Offset = "0x5F4CCD0", VA = "0x185F4E4D0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E5F0", Offset = "0x5F4CDF0", VA = "0x185F4E5F0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5F51BF0", Offset = "0x5F503F0", VA = "0x185F51BF0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BF60", Offset = "0x5F4A760", VA = "0x185F4BF60", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C0D0", Offset = "0x5F4A8D0", VA = "0x185F4C0D0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CF30", Offset = "0x5F4B730", VA = "0x185F4CF30", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5F51AC0", Offset = "0x5F502C0", VA = "0x185F51AC0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F51D80", Offset = "0x5F50580", VA = "0x185F51D80", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BEC0", Offset = "0x5F4A6C0", VA = "0x185F4BEC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C490", Offset = "0x5F4AC90", VA = "0x185F4C490", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5F50230", Offset = "0x5F4EA30", VA = "0x185F50230", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DC80", Offset = "0x5F4C480", VA = "0x185F4DC80", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F7C0", Offset = "0x5F4DFC0", VA = "0x185F4F7C0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E970", Offset = "0x5F4D170", VA = "0x185F4E970", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5F51480", Offset = "0x5F4FC80", VA = "0x185F51480", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DA30", Offset = "0x5F4C230", VA = "0x185F4DA30", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5F50C30", Offset = "0x5F4F430", VA = "0x185F50C30", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5F512C0", Offset = "0x5F4FAC0", VA = "0x185F512C0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E1C0", Offset = "0x5F4C9C0", VA = "0x185F4E1C0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5F50320", Offset = "0x5F4EB20", VA = "0x185F50320", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5F51370", Offset = "0x5F4FB70", VA = "0x185F51370", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F370", Offset = "0x5F4DB70", VA = "0x185F4F370", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DBE0", Offset = "0x5F4C3E0", VA = "0x185F4DBE0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C850", Offset = "0x5F4B050", VA = "0x185F4C850", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EFF0", Offset = "0x5F4D7F0", VA = "0x185F4EFF0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EF00", Offset = "0x5F4D700", VA = "0x185F4EF00", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5F50890", Offset = "0x5F4F090", VA = "0x185F50890", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5F50D00", Offset = "0x5F4F500", VA = "0x185F50D00", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5F511C0", Offset = "0x5F4F9C0", VA = "0x185F511C0", Slot = "51")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DCD0", Offset = "0x5F4C4D0", VA = "0x185F4DCD0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BF10", Offset = "0x5F4A710", VA = "0x185F4BF10", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CDA0", Offset = "0x5F4B5A0", VA = "0x185F4CDA0", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CDA0", Offset = "0x5F4B5A0", VA = "0x185F4CDA0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F890", Offset = "0x5F4E090", VA = "0x185F4F890", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EC20", Offset = "0x5F4D420", VA = "0x185F4EC20", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EF60", Offset = "0x5F4D760", VA = "0x185F4EF60", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EF80", Offset = "0x5F4D780", VA = "0x185F4EF80", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EEE0", Offset = "0x5F4D6E0", VA = "0x185F4EEE0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5F519B0", Offset = "0x5F501B0", VA = "0x185F519B0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5F509E0", Offset = "0x5F4F1E0", VA = "0x185F509E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DB50", Offset = "0x5F4C350", VA = "0x185F4DB50", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F950", Offset = "0x5F4E150", VA = "0x185F4F950", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C4F0", Offset = "0x5F4ACF0", VA = "0x185F4C4F0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5F50BF0", Offset = "0x5F4F3F0", VA = "0x185F50BF0", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CDB0", Offset = "0x5F4B5B0", VA = "0x185F4CDB0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FAC0", Offset = "0x5F4E2C0", VA = "0x185F4FAC0", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C5E0", Offset = "0x5F4ADE0", VA = "0x185F4C5E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FB10", Offset = "0x5F4E310", VA = "0x185F4FB10", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F9A0", Offset = "0x5F4E1A0", VA = "0x185F4F9A0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F210", Offset = "0x5F4DA10", VA = "0x185F4F210", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C540", Offset = "0x5F4AD40", VA = "0x185F4C540", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5F51160", Offset = "0x5F4F960", VA = "0x185F51160", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5F500E0", Offset = "0x5F4E8E0", VA = "0x185F500E0", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FD30", Offset = "0x5F4E530", VA = "0x185F4FD30", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool DOAGCOOFKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F260", Offset = "0x5F4DA60", VA = "0x185F4F260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool CGMDMAJLBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5F51440", Offset = "0x5F4FC40", VA = "0x185F51440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F51100", Offset = "0x5F4F900", VA = "0x185F51100", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F50380", Offset = "0x5F4EB80", VA = "0x185F50380", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F51D20", Offset = "0x5F50520", VA = "0x185F51D20", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CAA0", Offset = "0x5F4B2A0", VA = "0x185F4CAA0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C2D0", Offset = "0x5F4AAD0", VA = "0x185F4C2D0", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DE10", Offset = "0x5F4C610", VA = "0x185F4DE10", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D000", Offset = "0x5F4B800", VA = "0x185F4D000", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CC60", Offset = "0x5F4B460", VA = "0x185F4CC60", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PENLMJLNPDM DDALOGBJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5F515B0", Offset = "0x5F4FDB0", VA = "0x185F515B0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5F51B90", Offset = "0x5F50390", VA = "0x185F51B90", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FA60", Offset = "0x5F4E260", VA = "0x185F4FA60", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5F51210", Offset = "0x5F4FA10", VA = "0x185F51210", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5F51710", Offset = "0x5F4FF10", VA = "0x185F51710", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5F51CC0", Offset = "0x5F504C0", VA = "0x185F51CC0", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C270", Offset = "0x5F4AA70", VA = "0x185F4C270", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FA00", Offset = "0x5F4E200", VA = "0x185F4FA00", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event PENLMJLNPDM MOMDHFIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C030", Offset = "0x5F4A830", VA = "0x185F4C030", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E390", Offset = "0x5F4CB90", VA = "0x185F4E390", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F51E90", Offset = "0x5F50690", VA = "0x185F51E90")]
	public KLJOINJFJMA(GameObject ALBKEDBKENG, RigidbodyEx GNMMOMPJING, MCALNKPINNM GAICNONPFPG, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D1D0", Offset = "0x5F4B9D0", VA = "0x185F4D1D0", Slot = "143")]
	protected virtual void DIGCCAPCOMD(MCALNKPINNM GAICNONPFPG, CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D960", Offset = "0x5F4C160", VA = "0x185F4D960", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CDF0", Offset = "0x5F4B5F0", VA = "0x185F4CDF0", Slot = "75")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E5A0", Offset = "0x5F4CDA0", VA = "0x185F4E5A0", Slot = "76")]
	public void MBMKEKPNCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DDF0", Offset = "0x5F4C5F0", VA = "0x185F4DDF0", Slot = "77")]
	public void FABPKIFEFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5F4BDB0", Offset = "0x5F4A5B0", VA = "0x185F4BDB0", Slot = "145")]
	public virtual void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FEC0", Offset = "0x5F4E6C0", VA = "0x185F4FEC0", Slot = "86")]
	public void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ED30", Offset = "0x5F4D530", VA = "0x185F4ED30", Slot = "89")]
	public void GFCCENMEHND(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ECD0", Offset = "0x5F4D4D0", VA = "0x185F4ECD0", Slot = "90")]
	public void GEOOCCNGKCP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D870", Offset = "0x5F4C070", VA = "0x185F4D870", Slot = "91")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C9B0", Offset = "0x5F4B1B0", VA = "0x185F4C9B0", Slot = "92")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E5A0", Offset = "0x5F4CDA0", VA = "0x185F4E5A0", Slot = "93")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EE90", Offset = "0x5F4D690", VA = "0x185F4EE90", Slot = "94")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F0C0", Offset = "0x5F4D8C0", VA = "0x185F4F0C0", Slot = "95")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C760", Offset = "0x5F4AF60", VA = "0x185F4C760", Slot = "96")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5F51770", Offset = "0x5F4FF70", VA = "0x185F51770", Slot = "97")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E210", Offset = "0x5F4CA10", VA = "0x185F4E210", Slot = "98")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FB60", Offset = "0x5F4E360", VA = "0x185F4FB60", Slot = "99")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F508E0", Offset = "0x5F4F0E0", VA = "0x185F508E0", Slot = "100")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5F50D60", Offset = "0x5F4F560", VA = "0x185F50D60", Slot = "101")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F51860", Offset = "0x5F50060", VA = "0x185F51860", Slot = "102")]
	public Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F50A90", Offset = "0x5F4F290", VA = "0x185F50A90", Slot = "103")]
	public Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DC30", Offset = "0x5F4C430", VA = "0x185F4DC30", Slot = "104")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C1A0", Offset = "0x5F4A9A0", VA = "0x185F4C1A0", Slot = "105")]
	public void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5F4BE60", Offset = "0x5F4A660", VA = "0x185F4BE60", Slot = "106")]
	public void AKFOKBBCEAC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CCC0", Offset = "0x5F4B4C0", VA = "0x185F4CCC0", Slot = "44")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E430", Offset = "0x5F4CC30", VA = "0x185F4E430", Slot = "109")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CC10", Offset = "0x5F4B410", VA = "0x185F4CC10", Slot = "110")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5F510B0", Offset = "0x5F4F8B0", VA = "0x185F510B0", Slot = "111")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4BD60", Offset = "0x5F4A560", VA = "0x185F4BD60", Slot = "114")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DB00", Offset = "0x5F4C300", VA = "0x185F4DB00", Slot = "78")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F710", Offset = "0x5F4DF10", VA = "0x185F4F710", Slot = "115")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E2E0", Offset = "0x5F4CAE0", VA = "0x185F4E2E0", Slot = "120")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FC80", Offset = "0x5F4E480", VA = "0x185F4FC80", Slot = "121")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5F51550", Offset = "0x5F4FD50", VA = "0x185F51550", Slot = "122")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F50B80", Offset = "0x5F4F380", VA = "0x185F50B80", Slot = "123")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F440", Offset = "0x5F4DC40", VA = "0x185F4F440", Slot = "126")]
	public void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E6C0", Offset = "0x5F4CEC0", VA = "0x185F4E6C0", Slot = "127")]
	public void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F6B0", Offset = "0x5F4DEB0", VA = "0x185F4F6B0", Slot = "128")]
	public bool IOBHGAHMENP(float OMOAPNBJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DD90", Offset = "0x5F4C590", VA = "0x185F4DD90", Slot = "129")]
	public void ENPJOCBLDHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E330", Offset = "0x5F4CB30", VA = "0x185F4E330", Slot = "130")]
	public void FFBLKOEHHKE(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EDE0", Offset = "0x5F4D5E0", VA = "0x185F4EDE0", Slot = "131")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F310", Offset = "0x5F4DB10", VA = "0x185F4F310", Slot = "132")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5F51010", Offset = "0x5F4F810", VA = "0x185F51010")]
	public void MNKABIJBAEL(object FLDJLPKNKKO, bool AFPDPADDMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DE70", Offset = "0x5F4C670", VA = "0x185F4DE70", Slot = "134")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CB00", Offset = "0x5F4B300", VA = "0x185F4CB00", Slot = "135")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F040", Offset = "0x5F4D840", VA = "0x185F4F040", Slot = "136")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5F50E70", Offset = "0x5F4F670", VA = "0x185F50E70", Slot = "137")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F110", Offset = "0x5F4D910", VA = "0x185F4F110", Slot = "138")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EE40", Offset = "0x5F4D640", VA = "0x185F4EE40", Slot = "139")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5F51E50", Offset = "0x5F50650", VA = "0x185F51E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C3C0", Offset = "0x5F4ABC0", VA = "0x185F4C3C0")]
	private void BHJDGJHMJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FF30", Offset = "0x5F4E730", VA = "0x185F4FF30")]
	private void KBAIPCPMFOL(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EA40", Offset = "0x5F4D240", VA = "0x185F4EA40")]
	private void GDBIDIMIOEI(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E8C0", Offset = "0x5F4D0C0", VA = "0x185F4E8C0")]
	private void GBEOLMMODIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C8B0", Offset = "0x5F4B0B0", VA = "0x185F4C8B0")]
	private void CCGACNHJLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5F50780", Offset = "0x5F4EF80", VA = "0x185F50780")]
	private void KJEHAIENAKE(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5F50EF0", Offset = "0x5F4F6F0", VA = "0x185F50EF0")]
	private void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C690", Offset = "0x5F4AE90", VA = "0x185F4C690")]
	private void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D060", Offset = "0x5F4B860", VA = "0x185F4D060")]
	private void DHLLADGECJC(RigidbodyEx ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5F503E0", Offset = "0x5F4EBE0", VA = "0x185F503E0", Slot = "146")]
	protected virtual void KIDECLKFDOJ(RigidbodyEx LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5F50650", Offset = "0x5F4EE50", VA = "0x185F50650")]
	[Conditional("UNITY_EDITOR")]
	private void KIDJBHHOICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DEF0", Offset = "0x5F4C6F0", VA = "0x185F4DEF0")]
	protected void FCIIPIKELJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D4B0", Offset = "0x5F4BCB0", VA = "0x185F4D4B0")]
	protected void DMFCEPEBHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class EGNJBEJBNIH
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5F331D0", Offset = "0x5F319D0", VA = "0x185F331D0")]
	public static FAFKHKPFEKI EDMEKBKHLAN(this FAFKHKPFEKI LPIBPEGGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5F33150", Offset = "0x5F31950", VA = "0x185F33150")]
	public static bool CEFJFNELIIP(this FAFKHKPFEKI LPIBPEGGEEE, FAFKHKPFEKI LDCOLCDIOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5F33300", Offset = "0x5F31B00", VA = "0x185F33300")]
	public static bool MAIDKEOPNBC(this FAFKHKPFEKI LPIBPEGGEEE, FAFKHKPFEKI DHHBLOHICNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5F33100", Offset = "0x5F31900", VA = "0x185F33100")]
	public static RigidbodyEx AHAAINDKLOK(this FAFKHKPFEKI AOOPEEENLEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5F33290", Offset = "0x5F31A90", VA = "0x185F33290")]
	public static KLJOINJFJMA IIJFNGJDPAG(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PENLMJLNPDM NGIDLMLHHJM;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CFOFFHECGMA();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGMANKLHEDO();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MOGOAIJKGFM();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GKCLCHKBIHO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface AFHDOJMAAGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FAFKHKPFEKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PENLMJLNPDM ABGONPKEDMI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PENLMJLNPDM PCAPCNOAOJG;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event IJIIOKHNDCH IAIGIJMEMKI;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event PENLMJLNPDM OCCHAGGOINB;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event PENLMJLNPDM DDALOGBJKIJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event PENLMJLNPDM OKAHFOGBNGD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event PENLMJLNPDM IBIEOIEHHMK;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event PENLMJLNPDM MOMDHFIOGGG;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void MBMKEKPNCDC();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FABPKIFEFOL();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EFAMGCMKBGN();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void AHMPHJEIING();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void GFCCENMEHND(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void GEOOCCNGKCP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FMGKABPAPIP();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void GOPHGLEKHBH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HNPHPPHGNGH();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void FEMBKDIAAAP(Vector3 KDJKJGOIBLL);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void ELHHONDCCEA();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void AKFOKBBCEAC(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FGMANKLHEDO();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CFOFFHECGMA();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void MOGOAIJKGFM();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool AHEGLGAEPAK();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void JDFOHMHOLKJ();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable FFBAOBHCCAJ();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JMLHFLEGLGJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OEHMBAJJPJP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool IOBHGAHMENP(float OMOAPNBJLBI);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void ENPJOCBLDHN(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FFBLKOEHHKE(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GHIPEPNLOHM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void IFJCMMGNPMM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void GKCLCHKBIHO();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NAAOIBJHADK
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MLAAMHAMNCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OHEPKJEBFID();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BFPGMPGOAEH();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFGGHBKIECF(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPELJIHJKHN(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODHNAICIIGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HMNJOAIBFBB : IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDAMFPNNPPI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CMANNCNAEEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event PENLMJLNPDM ABGONPKEDMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event PENLMJLNPDM PCAPCNOAOJG;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event IJIIOKHNDCH IAIGIJMEMKI;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action ILMHHPLDHOO;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action LKKCMMNHMJL;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<FAFKHKPFEKI> HMDKKBAFIJC;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<FAFKHKPFEKI> IDGBMMFDPEK;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action MBIPKGCCLDK;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<FAFKHKPFEKI> ICECBJMMMCO;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JEDJEILBNNF
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JHEBHKGMPAF
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPPEKBPHOAI(Vector3 DACMIONAPNF);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFGBDHECLAN(Vector3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OONNGPOACNE(Vector3 DACMIONAPNF);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COEOOJPLLEB(Vector3 JDNINLGNNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event PENLMJLNPDM IBIEOIEHHMK;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAHNFOENCGE();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMLHFLEGLGJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEHMBAJJPJP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable FFBAOBHCCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBEBFFILMKK(Rigidbody GGGGHNNPHJC);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GADMMIHBFNL
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEHHJKMGHLL(bool ICBDCKBKPKF);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJEBGEAKFJB(bool ICBDCKBKPKF);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PMKPCPNEKNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDHOAFOCKIJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HNPHPPHGNGH();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GOPHGLEKHBH();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ELHHONDCCEA();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FMGKABPAPIP();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void COEBAFIHDGK(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FEMBKDIAAAP(Vector3 KDJKJGOIBLL);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHIPEPNLOHM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFJCMMGNPMM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKBFBEIOBJL();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBPBPENLGPL();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGMALIJEELK();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGEMPCCFGGD();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DPIKHFGILLN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event PENLMJLNPDM OKAHFOGBNGD;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHEGLGAEPAK();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPMMBIEPONO();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFAMGCMKBGN();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CDIMIBACCOA();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDFOHMHOLKJ();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBMPOHOFPGJ(bool AOHFCNFADMO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KKBPAALNMJN(typeof(OCPDIKODPNM), new string[] { })]
public sealed class FAFIBKLLHHG : BOGFHHLHMCB, OCPDIKODPNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[BDIAFGIKHDL]
	private BCOGGGBMMOK LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C7730", Offset = "0x8C5F30", VA = "0x1808C7730", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F37240", Offset = "0x5F35A40", VA = "0x185F37240", Slot = "4")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F36E50", Offset = "0x5F35650", VA = "0x185F36E50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F37290", Offset = "0x5F35A90", VA = "0x185F37290", Slot = "6")]
	public void JCGOMGHJDJL(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F36FC0", Offset = "0x5F357C0", VA = "0x185F36FC0", Slot = "7")]
	public void HKHBOINIIGG(ICDDKLLCIME EEOIFMPKINO, bool OFPIHBKDDCH, bool PFMKDPAMNII, bool BIHGJFFAABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F36E80", Offset = "0x5F35680", VA = "0x185F36E80")]
	private bool EDBFICJLCJJ(ICDDKLLCIME EEOIFMPKINO, out KDCPJKLPAPB NHIFGJKHMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F37570", Offset = "0x5F35D70", VA = "0x185F37570")]
	private bool MNKOBJCFGKK(ICDDKLLCIME EEOIFMPKINO, out JDLMFJEEHBM KEIIDHHNOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F37420", Offset = "0x5F35C20", VA = "0x185F37420")]
	private bool JJGMIKNDDBI(ICDDKLLCIME EEOIFMPKINO, out HKFPBDAEJKC JOCBENOCNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public FAFIBKLLHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HKFPBDAEJKC : KOJGKBEMDEB, IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F42630", Offset = "0x5F40E30", VA = "0x185F42630", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F3FB50", Offset = "0x5F3E350", VA = "0x185F3FB50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 ELBOLAAKPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F40B30", Offset = "0x5F3F330", VA = "0x185F40B30")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F3FB50", Offset = "0x5F3E350", VA = "0x185F3FB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 HCGFPCGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F3FB80", Offset = "0x5F3E380", VA = "0x185F3FB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F42140", Offset = "0x5F40940", VA = "0x185F42140", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F42520", Offset = "0x5F40D20", VA = "0x185F42520", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float LBKNHHCNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F42760", Offset = "0x5F40F60", VA = "0x185F42760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F3FCB0", Offset = "0x5F3E4B0", VA = "0x185F3FCB0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F3FA50", Offset = "0x5F3E250", VA = "0x185F3FA50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F42600", Offset = "0x5F40E00", VA = "0x185F42600", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F40980", Offset = "0x5F3F180", VA = "0x185F40980", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F32EF0", Offset = "0x5F316F0", VA = "0x185F32EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PENLMJLNPDM NGIDLMLHHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F422C0", Offset = "0x5F40AC0", VA = "0x185F422C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F40010", Offset = "0x5F3E810", VA = "0x185F40010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F42A50", Offset = "0x5F41250", VA = "0x185F42A50")]
	public HKFPBDAEJKC(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5F42990", Offset = "0x5F41190", VA = "0x185F42990")]
	public float3 PKIIOCFAKHH()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F130", Offset = "0x5F3D930", VA = "0x185F3F130")]
	public bool ADDPKNIPLIB(out float3 HKENGGJIGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F42440", Offset = "0x5F40C40", VA = "0x185F42440")]
	public void NHOLJPJKDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F40890", Offset = "0x5F3F090", VA = "0x185F40890")]
	public bool IBJDHIFLJOO(out float CHODJKFAPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F7D0", Offset = "0x5F3DFD0", VA = "0x185F3F7D0", Slot = "14")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FD90", Offset = "0x5F3E590", VA = "0x185F3FD90", Slot = "16")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F450", Offset = "0x5F3DC50", VA = "0x185F3F450", Slot = "15")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F41FF0", Offset = "0x5F407F0", VA = "0x185F41FF0", Slot = "18")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5F405C0", Offset = "0x5F3EDC0", VA = "0x185F405C0", Slot = "19")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F42360", Offset = "0x5F40B60", VA = "0x185F42360", Slot = "17")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5F400B0", Offset = "0x5F3E8B0", VA = "0x185F400B0", Slot = "20")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5F36330", Offset = "0x5F34B30", VA = "0x185F36330")]
	public void GBBGDIJCNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F42850", Offset = "0x5F41050", VA = "0x185F42850")]
	private void PCAAMBKMJPP(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5F409B0", Offset = "0x5F3F1B0", VA = "0x185F409B0")]
	[Obsolete]
	private Vector3 IOGOIOLPNLB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FA50", Offset = "0x5F3E250", VA = "0x185F3FA50")]
	private void DLCJAMEDIPF(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F41DB0", Offset = "0x5F405B0", VA = "0x185F41DB0")]
	private Vector3 KMFOEIELKBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F220", Offset = "0x5F3DA20", VA = "0x185F3F220")]
	private Quaternion APGNIGHBLCM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F40C60", Offset = "0x5F3F460", VA = "0x185F40C60")]
	internal (float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class LCLBAJICBKO
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B650", Offset = "0x6F59E50", VA = "0x186F5B650")]
	public static HKFPBDAEJKC FNDOCLELGBE(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class POKNHPFLFJJ : KOJGKBEMDEB, PMKPCPNEKNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D560", Offset = "0x6F5BD60", VA = "0x186F5D560", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F510", Offset = "0x6F5DD10", VA = "0x186F5F510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EB60", Offset = "0x6F5D360", VA = "0x186F5EB60", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F605A0", Offset = "0x6F5EDA0", VA = "0x186F605A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D1E0", Offset = "0x6F5B9E0", VA = "0x186F5D1E0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DFE0", Offset = "0x6F5C7E0", VA = "0x186F5DFE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F0A0", Offset = "0x6F5D8A0", VA = "0x186F5F0A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F0D0", Offset = "0x6F5D8D0", VA = "0x186F5F0D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F606A0", Offset = "0x6F5EEA0", VA = "0x186F606A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F60730", Offset = "0x6F5EF30", VA = "0x186F60730", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F60700", Offset = "0x6F5EF00", VA = "0x186F60700", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D1B0", Offset = "0x6F5B9B0", VA = "0x186F5D1B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D690", Offset = "0x6F5BE90", VA = "0x186F5D690", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F100", Offset = "0x6F5D900", VA = "0x186F5F100", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E950", Offset = "0x6F5D150", VA = "0x186F5E950", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private NAAOIBJHADK KAAEMNKNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2616D20", Offset = "0x2615520", VA = "0x182616D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5F36660", Offset = "0x5F34E60", VA = "0x185F36660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C6D0", Offset = "0x6F5AED0", VA = "0x186F5C6D0")]
	public POKNHPFLFJJ(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F410", Offset = "0x6F5DC10", VA = "0x186F5F410", Slot = "20")]
	public void IDHOAFOCKIJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DE70", Offset = "0x6F5C670", VA = "0x186F5DE70", Slot = "31")]
	public void COEBAFIHDGK(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DF70", Offset = "0x6F5C770", VA = "0x186F5DF70", Slot = "19")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E720", Offset = "0x6F5CF20", VA = "0x186F5E720", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FCF0", Offset = "0x6F5E4F0", VA = "0x186F5FCF0", Slot = "28")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E5B0", Offset = "0x6F5CDB0", VA = "0x186F5E5B0", Slot = "36")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D920", Offset = "0x6F5C120", VA = "0x186F5D920", Slot = "35")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DF70", Offset = "0x6F5C770", VA = "0x186F5DF70", Slot = "27")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F270", Offset = "0x6F5DA70", VA = "0x186F5F270", Slot = "25")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F2B0", Offset = "0x6F5DAB0", VA = "0x186F5F2B0", Slot = "24")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D780", Offset = "0x6F5BF80", VA = "0x186F5D780", Slot = "34")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F60480", Offset = "0x6F5EC80", VA = "0x186F60480", Slot = "33")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EA40", Offset = "0x6F5D240", VA = "0x186F5EA40", Slot = "32")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F610", Offset = "0x6F5DE10", VA = "0x186F5F610", Slot = "22")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F9A0", Offset = "0x6F5E1A0", VA = "0x186F5F9A0", Slot = "21")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FED0", Offset = "0x6F5E6D0", VA = "0x186F5FED0", Slot = "23")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6F604E0", Offset = "0x6F5ECE0", VA = "0x186F604E0", Slot = "30")]
	public Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FBF0", Offset = "0x6F5E3F0", VA = "0x186F5FBF0", Slot = "29")]
	public Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E860", Offset = "0x6F5D060", VA = "0x186F5E860", Slot = "26")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F100", Offset = "0x6F5D900", VA = "0x186F5F100")]
	private void GNAGAOKDICE(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F2F0", Offset = "0x6F5DAF0", VA = "0x186F5F2F0")]
	private void IAKIEGDKDAI(Vector3 ODOOOABGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F60220", Offset = "0x6F5EA20", VA = "0x186F60220")]
	private Vector3 OPBFFCOBIJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EC90", Offset = "0x6F5D490", VA = "0x186F5EC90")]
	private void FIALGKEPIBL(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D240", Offset = "0x6F5BA40", VA = "0x186F5D240")]
	private Vector3 BFPGMPGOAEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DA70", Offset = "0x6F5C270", VA = "0x186F5DA70")]
	private void CFGBDHECLAN(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6F601C0", Offset = "0x6F5E9C0", VA = "0x186F601C0")]
	private void NIMJBANPDME(Vector3 PPJHGOCBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FE70", Offset = "0x6F5E670", VA = "0x186F5FE70")]
	private void LILMCAPDKLP(Vector3 JDNINLGNNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E0A0", Offset = "0x6F5C8A0", VA = "0x186F5E0A0")]
	private void DENHFDHOOKI(string ADDFCMAPIBH, Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D4A0", Offset = "0x6F5BCA0", VA = "0x186F5D4A0")]
	private void BMJDIGOKBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class KNDDJMAMFNE : KOJGKBEMDEB, NLOPKOPLBOH
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5F52130", Offset = "0x5F50930", VA = "0x185F52130", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5F51F60", Offset = "0x5F50760", VA = "0x185F51F60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5F524B0", Offset = "0x5F50CB0", VA = "0x185F524B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5F522E0", Offset = "0x5F50AE0", VA = "0x185F522E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public KNDDJMAMFNE(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5F52590", Offset = "0x5F50D90", VA = "0x185F52590", Slot = "8")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5F52210", Offset = "0x5F50A10", VA = "0x185F52210", Slot = "9")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class NBEFNPDKNIA : FAFKHKPFEKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NBEFNPDKNIA EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3120", VA = "0x1808B4920", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x12770B0", Offset = "0x12758B0", VA = "0x1812770B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1871C80", Offset = "0x1870480", VA = "0x181871C80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xFC8AD0", Offset = "0xFC72D0", VA = "0x180FC8AD0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8ABED0", Offset = "0x8AA6D0", VA = "0x1808ABED0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x9118A0", VA = "0x1809130A0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9130B0", Offset = "0x9118B0", VA = "0x1809130B0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3630", Offset = "0x1AC1E30", VA = "0x181AC3630", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1256890", Offset = "0x1255090", VA = "0x181256890", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x492B760", Offset = "0x4929F60", VA = "0x18492B760", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x492CD30", Offset = "0x492B530", VA = "0x18492CD30", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x29F4570", Offset = "0x29F2D70", VA = "0x1829F4570", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x29F2A30", Offset = "0x29F1230", VA = "0x1829F2A30", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x29F4590", Offset = "0x29F2D90", VA = "0x1829F4590", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x29F08C0", Offset = "0x29EF0C0", VA = "0x1829F08C0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xFFEE50", Offset = "0xFFD650", VA = "0x180FFEE50", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1072F20", Offset = "0x1071720", VA = "0x181072F20", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1072F10", Offset = "0x1071710", VA = "0x181072F10", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xDE2310", Offset = "0xDE0B10", VA = "0x180DE2310", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x208B0B0", Offset = "0x20898B0", VA = "0x18208B0B0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x21F1620", Offset = "0x21EFE20", VA = "0x1821F1620", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2057810", Offset = "0x2056010", VA = "0x182057810", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xC73360", Offset = "0xC71B60", VA = "0x180C73360", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x18FE7A0", Offset = "0x18FCFA0", VA = "0x1818FE7A0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7F62C0", Offset = "0x7F4AC0", VA = "0x1807F62C0", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x18FE7A0", Offset = "0x18FCFA0", VA = "0x1818FE7A0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x18FE7A0", Offset = "0x18FCFA0", VA = "0x1818FE7A0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool OJHHJBOIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "51")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3529D00", Offset = "0x3528500", VA = "0x183529D00", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA64F10", Offset = "0xA63710", VA = "0x180A64F10", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9E90F0", Offset = "0x9E78F0", VA = "0x1809E90F0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x18FE7A0", Offset = "0x18FCFA0", VA = "0x1818FE7A0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x18FE7A0", Offset = "0x18FCFA0", VA = "0x1818FE7A0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1E14C40", Offset = "0x1E13440", VA = "0x181E14C40", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1E14C40", Offset = "0x1E13440", VA = "0x181E14C40", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB7810", Offset = "0x1BB6010", VA = "0x181BB7810", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event PENLMJLNPDM DDALOGBJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event PENLMJLNPDM MOMDHFIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "44")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "75")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "76")]
	public void MBMKEKPNCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "77")]
	public void FABPKIFEFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "78")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "79")]
	public void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "86")]
	public void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "89")]
	public void GFCCENMEHND(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "90")]
	public void GEOOCCNGKCP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "91")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "92")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "93")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "94")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "95")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "96")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "97")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "98")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "99")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "100")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "101")]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "102")]
	public Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7F3470", Offset = "0x7F1C70", VA = "0x1807F3470", Slot = "103")]
	public Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "104")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "105")]
	public void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "106")]
	public void AKFOKBBCEAC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "109")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "110")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "111")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "114")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "115")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "120")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "121")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "122")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "123")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "126")]
	public void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "127")]
	public void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "128")]
	public bool IOBHGAHMENP(float OMOAPNBJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "129")]
	public void ENPJOCBLDHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "130")]
	public void FFBLKOEHHKE(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "131")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "132")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "134")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "135")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "136")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "137")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C760", Offset = "0x6F5AF60", VA = "0x186F5C760", Slot = "138")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "139")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public NBEFNPDKNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class CJNJPFNNDIB : KOJGKBEMDEB, NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F31670", Offset = "0x5F2FE70", VA = "0x185F31670", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F31460", Offset = "0x5F2FC60", VA = "0x185F31460", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F30D60", Offset = "0x5F2F560", VA = "0x185F30D60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5F30E40", Offset = "0x5F2F640", VA = "0x185F30E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public CJNJPFNNDIB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5F316A0", Offset = "0x5F2FEA0", VA = "0x185F316A0", Slot = "6")]
	public void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F31830", Offset = "0x5F30030", VA = "0x185F31830")]
	private void MEILECPHJFN(KDCPJKLPAPB ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F30FA0", Offset = "0x5F2F7A0", VA = "0x185F30FA0", Slot = "7")]
	public void FKLLDNMELNG(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F31090", Offset = "0x5F2F890", VA = "0x185F31090")]
	private Vector3 GAHKIOJBOFK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class ACDBDOKBINI
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D600", Offset = "0x5F2BE00", VA = "0x185F2D600")]
	public static CJNJPFNNDIB KNOKCGBBPPB(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BLKBJADJNCL : KOJGKBEMDEB, CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly MFFHLJHLBIG KKGGJGMLOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIIGAJMMHGL JNGPCOLGDDJ;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D960", Offset = "0x5F2C160", VA = "0x185F2D960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public ICDDKLLCIME BKGMLNFKFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F2FA60", Offset = "0x5F2E260", VA = "0x185F2FA60")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F2EE30", Offset = "0x5F2D630", VA = "0x185F2EE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F2EDF0", Offset = "0x5F2D5F0", VA = "0x185F2EDF0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F770", Offset = "0x5F2DF70", VA = "0x185F2F770", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public ICDDKLLCIME BNEFPIEPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D990", Offset = "0x5F2C190", VA = "0x185F2D990")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F8C0", Offset = "0x5F2E0C0", VA = "0x185F2F8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F880", Offset = "0x5F2E080", VA = "0x185F2F880", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5F2EF30", Offset = "0x5F2D730", VA = "0x185F2EF30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5F2EB80", Offset = "0x5F2D380", VA = "0x185F2EB80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F9C0", Offset = "0x5F2E1C0", VA = "0x185F2F9C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DA90", Offset = "0x5F2C290", VA = "0x185F2DA90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D8C0", Offset = "0x5F2C0C0", VA = "0x185F2D8C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E300", Offset = "0x5F2CB00", VA = "0x185F2E300", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action ILMHHPLDHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DD90", Offset = "0x5F2C590", VA = "0x185F2DD90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E9F0", Offset = "0x5F2D1F0", VA = "0x185F2E9F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action LKKCMMNHMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E1C0", Offset = "0x5F2C9C0", VA = "0x185F2E1C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5F2EC20", Offset = "0x5F2D420", VA = "0x185F2EC20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<FAFKHKPFEKI> HMDKKBAFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E3A0", Offset = "0x5F2CBA0", VA = "0x185F2E3A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E950", Offset = "0x5F2D150", VA = "0x185F2E950", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<FAFKHKPFEKI> IDGBMMFDPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F7E0", Offset = "0x5F2DFE0", VA = "0x185F2F7E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E810", Offset = "0x5F2D010", VA = "0x185F2E810", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action MBIPKGCCLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DB30", Offset = "0x5F2C330", VA = "0x185F2DB30", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E8B0", Offset = "0x5F2D0B0", VA = "0x185F2E8B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<FAFKHKPFEKI> ICECBJMMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E440", Offset = "0x5F2CC40", VA = "0x185F2E440", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E260", Offset = "0x5F2CA60", VA = "0x185F2E260", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FBF0", Offset = "0x5F2E3F0", VA = "0x185F2FBF0")]
	public BLKBJADJNCL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DFF0", Offset = "0x5F2C7F0", VA = "0x185F2DFF0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EA90", Offset = "0x5F2D290", VA = "0x185F2EA90", Slot = "26")]
	public void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EB10", Offset = "0x5F2D310", VA = "0x185F2EB10")]
	private void JPDJPFJGJJB(KDCPJKLPAPB PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EFD0", Offset = "0x5F2D7D0", VA = "0x185F2EFD0")]
	private void NEFIMCAACMN(KDCPJKLPAPB PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DBD0", Offset = "0x5F2C3D0", VA = "0x185F2DBD0")]
	private void DCAAKEBPGMM(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DE30", Offset = "0x5F2C630", VA = "0x185F2DE30")]
	private void DIAJFCLGHNB(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E660", Offset = "0x5F2CE60", VA = "0x185F2E660")]
	private void HCHGKENDMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E590", Offset = "0x5F2CD90", VA = "0x185F2E590")]
	private void GOLOLHKODGD(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E4E0", Offset = "0x5F2CCE0", VA = "0x185F2E4E0")]
	private void GLBGGDLJEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D790", Offset = "0x5F2BF90", VA = "0x185F2D790")]
	private void ANNGLPCKBKA(KDCPJKLPAPB LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F2ECC0", Offset = "0x5F2D4C0", VA = "0x185F2ECC0")]
	private void MEAEKDMOCMC(KDCPJKLPAPB LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class DLFACDICEOB
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F329D0", Offset = "0x5F311D0", VA = "0x185F329D0")]
	public static BLKBJADJNCL AEAGMJDNIIJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class KDCPJKLPAPB : KLJOINJFJMA, MKCCBALLBBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal BCOGGGBMMOK MMMOAIMMECP;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5F4BC80", Offset = "0x5F4A480", VA = "0x185F4BC80")]
	public KDCPJKLPAPB(GameObject ALBKEDBKENG, RigidbodyEx GNMMOMPJING, MCALNKPINNM GAICNONPFPG, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B1C0", Offset = "0x5F499C0", VA = "0x185F4B1C0", Slot = "143")]
	protected override void DIGCCAPCOMD(MCALNKPINNM GAICNONPFPG, CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B5D0", Offset = "0x5F49DD0", VA = "0x185F4B5D0", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B440", Offset = "0x5F49C40", VA = "0x185F4B440", Slot = "147")]
	public void DLNOJJNGPDA(BLMHMCOGNAC OFDNJFOOJOA, BLMHMCOGNAC MEKEHDPAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B510", Offset = "0x5F49D10", VA = "0x185F4B510", Slot = "148")]
	public void DOHGMJJCAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B820", Offset = "0x5F4A020", VA = "0x185F4B820", Slot = "149")]
	public void KEFOHPEBEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B760", Offset = "0x5F49F60", VA = "0x185F4B760", Slot = "150")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B8E0", Offset = "0x5F4A0E0", VA = "0x185F4B8E0", Slot = "151")]
	public bool KNJFBMCNMDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F4B7C0", Offset = "0x5F49FC0", VA = "0x185F4B7C0", Slot = "152")]
	public void HBKADGJMAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "146")]
	protected override void KIDECLKFDOJ(RigidbodyEx HDCPFIKNJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4BA40", Offset = "0x5F4A240", VA = "0x185F4BA40")]
	private void PIEJLKKGEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "145")]
	public override void AHMPHJEIING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class OKLLDFPMLJO
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D160", Offset = "0x6F5B960", VA = "0x186F5D160")]
	public static KLJOINJFJMA KLOGBFNGGAN(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class IOIEEDEPIEL : KOJGKBEMDEB, PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string IHEGBFLFHMK = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F45860", Offset = "0x5F44060", VA = "0x185F45860", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F45850", Offset = "0x5F44050", VA = "0x185F45850", Slot = "5")]
		get
		{
			return default(LHPAGGDFKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private LHPAGGDFKDF JCMMMGIPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F45E20", Offset = "0x5F44620", VA = "0x185F45E20")]
		get
		{
			return default(LHPAGGDFKDF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F45F80", Offset = "0x5F44780", VA = "0x185F45F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F46180", Offset = "0x5F44980", VA = "0x185F46180")]
	public IOIEEDEPIEL(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F45A40", Offset = "0x5F44240", VA = "0x185F45A40", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F45D80", Offset = "0x5F44580", VA = "0x185F45D80")]
	private bool IFMJEIBBLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F45750", Offset = "0x5F43F50", VA = "0x185F45750", Slot = "7")]
	public void AFGGHBKIECF(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F45940", Offset = "0x5F44140", VA = "0x185F45940", Slot = "8")]
	public void CPELJIHJKHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F46070", Offset = "0x5F44870", VA = "0x185F46070", Slot = "11")]
	public void ODHNAICIIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F45C90", Offset = "0x5F44490", VA = "0x185F45C90")]
	private void FAEHMCHMGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F45B00", Offset = "0x5F44300", VA = "0x185F45B00")]
	private void EAFCDCFDCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F45F40", Offset = "0x5F44740", VA = "0x185F45F40", Slot = "10")]
	public void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F45F00", Offset = "0x5F44700", VA = "0x185F45F00", Slot = "9")]
	public void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HMBOBLBMEHN : KOJGKBEMDEB, NAAOIBJHADK
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F32EF0", Offset = "0x5F316F0", VA = "0x185F32EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5F3D7B0", Offset = "0x5F3BFB0", VA = "0x185F3D7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5F387F0", Offset = "0x5F36FF0", VA = "0x185F387F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5F43B80", Offset = "0x5F42380", VA = "0x185F43B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public HMBOBLBMEHN(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5F43260", Offset = "0x5F41A60", VA = "0x185F43260", Slot = "4")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5F43610", Offset = "0x5F41E10", VA = "0x185F43610")]
	private void KEJNLHKMPMG(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5F42D40", Offset = "0x5F41540", VA = "0x185F42D40", Slot = "5")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5F433C0", Offset = "0x5F41BC0", VA = "0x185F433C0", Slot = "6")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F42FE0", Offset = "0x5F417E0", VA = "0x185F42FE0")]
	private void DPDFEMBNECH(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5F43900", Offset = "0x5F42100", VA = "0x185F43900", Slot = "7")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5F43520", Offset = "0x5F41D20", VA = "0x185F43520")]
	private void JGIMFEIAGIB(string DKIECHCHJFL, UnityEngine.Object JFDMKPDIBDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IPNDMHNEJCC : KOJGKBEMDEB, BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string AGPJDLGHNPA = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5F471D0", Offset = "0x5F459D0", VA = "0x185F471D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5F46A70", Offset = "0x5F45270", VA = "0x185F46A70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5F387F0", Offset = "0x5F36FF0", VA = "0x185F387F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5F46E20", Offset = "0x5F45620", VA = "0x185F46E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5F472B0", Offset = "0x5F45AB0", VA = "0x185F472B0")]
	public IPNDMHNEJCC(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5F469C0", Offset = "0x5F451C0", VA = "0x185F469C0", Slot = "5")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5F46B60", Offset = "0x5F45360", VA = "0x185F46B60", Slot = "7")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5F46F00", Offset = "0x5F45700", VA = "0x185F46F00", Slot = "8")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5F464B0", Offset = "0x5F44CB0", VA = "0x185F464B0", Slot = "9")]
	public void AKBFBEIOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5F46760", Offset = "0x5F44F60", VA = "0x185F46760", Slot = "10")]
	public void DBPBPENLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5F47000", Offset = "0x5F45800", VA = "0x185F47000", Slot = "11")]
	public void IGMALIJEELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "12")]
	public void NGEMPCCFGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5F46C60", Offset = "0x5F45460", VA = "0x185F46C60")]
	private void HMNJIJBDGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5F462F0", Offset = "0x5F44AF0", VA = "0x185F462F0")]
	private void AGKDIBAHEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class JDLMFJEEHBM : KOJGKBEMDEB, JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5F49130", Offset = "0x5F47930", VA = "0x185F49130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5F49950", Offset = "0x5F48150", VA = "0x185F49950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool MEGCMGIMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5F492B0", Offset = "0x5F47AB0", VA = "0x185F492B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5F49210", Offset = "0x5F47A10", VA = "0x185F49210", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5F49630", Offset = "0x5F47E30", VA = "0x185F49630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public JDLMFJEEHBM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5F49390", Offset = "0x5F47B90", VA = "0x185F49390", Slot = "12")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5F496D0", Offset = "0x5F47ED0", VA = "0x185F496D0", Slot = "9")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5F49A30", Offset = "0x5F48230", VA = "0x185F49A30", Slot = "10")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5F496E0", Offset = "0x5F47EE0", VA = "0x185F496E0", Slot = "11")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5F497E0", Offset = "0x5F47FE0", VA = "0x185F497E0", Slot = "13")]
	public void LBEBFFILMKK(Rigidbody GGGGHNNPHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5F49450", Offset = "0x5F47C50", VA = "0x185F49450", Slot = "14")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5F36330", Offset = "0x5F34B30", VA = "0x185F36330", Slot = "6")]
	public void BAHNFOENCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MIIAKIBJCOD : KOJGKBEMDEB, GADMMIHBFNL
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode CDFCPOFNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C260", Offset = "0x6F5AA60", VA = "0x186F5C260")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C5D0", Offset = "0x6F5ADD0", VA = "0x186F5C5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C410", Offset = "0x6F5AC10", VA = "0x186F5C410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BFF0", Offset = "0x6F5A7F0", VA = "0x186F5BFF0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C3D0", Offset = "0x6F5ABD0", VA = "0x186F5C3D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C6D0", Offset = "0x6F5AED0", VA = "0x186F5C6D0")]
	public MIIAKIBJCOD(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C0A0", Offset = "0x6F5A8A0", VA = "0x186F5C0A0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C360", Offset = "0x6F5AB60", VA = "0x186F5C360", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C3C0", Offset = "0x6F5ABC0", VA = "0x186F5C3C0", Slot = "7")]
	public void MEHHJKMGHLL(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C350", Offset = "0x6F5AB50", VA = "0x186F5C350", Slot = "8")]
	public void KJEBGEAKFJB(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C160", Offset = "0x6F5A960", VA = "0x186F5C160", Slot = "10")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C430", Offset = "0x6F5AC30", VA = "0x186F5C430")]
	private void OIKJOBJMGEJ(bool ICBDCKBKPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class CIIGAJMMHGL : IReadOnlyList<FAFKHKPFEKI>, IEnumerable<FAFKHKPFEKI>, IEnumerable, IReadOnlyCollection<FAFKHKPFEKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly BCOGGGBMMOK LOJMOJPJAMH;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5F30AE0", Offset = "0x5F2F2E0", VA = "0x185F30AE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public FAFKHKPFEKI OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x5F30BB0", Offset = "0x5F2F3B0", VA = "0x185F30BB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5F30A90", Offset = "0x5F2F290", VA = "0x185F30A90")]
	public CIIGAJMMHGL(ICDDKLLCIME CMPMKFMJCNO, BCOGGGBMMOK LOJMOJPJAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5F30900", Offset = "0x5F2F100", VA = "0x185F30900", Slot = "6")]
	public IEnumerator<FAFKHKPFEKI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5F30900", Offset = "0x5F2F100", VA = "0x185F30900", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5F308F0", Offset = "0x5F2F0F0", VA = "0x185F308F0")]
	[CompilerGenerated]
	private FAFKHKPFEKI DLENALJEHIK(int OCIFJAIBHIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BPFBGMILMIM : BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5F30720", Offset = "0x5F2EF20", VA = "0x185F30720", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5F300D0", Offset = "0x5F2E8D0", VA = "0x185F300D0", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5F30620", Offset = "0x5F2EE20", VA = "0x185F30620", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5F30230", Offset = "0x5F2EA30", VA = "0x185F30230", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5F306C0", Offset = "0x5F2EEC0", VA = "0x185F306C0", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5F304D0", Offset = "0x5F2ECD0", VA = "0x185F304D0", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5F30430", Offset = "0x5F2EC30", VA = "0x185F30430", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5F30390", Offset = "0x5F2EB90", VA = "0x185F30390", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5F301D0", Offset = "0x5F2E9D0", VA = "0x185F301D0", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5F30130", Offset = "0x5F2E930", VA = "0x185F30130", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FFA0", Offset = "0x5F2E7A0", VA = "0x185F2FFA0")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5F302D0", Offset = "0x5F2EAD0", VA = "0x185F302D0")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE10", Offset = "0x5F2E610", VA = "0x185F2FE10")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5F30060", Offset = "0x5F2E860", VA = "0x185F30060")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FDA0", Offset = "0x5F2E5A0", VA = "0x185F2FDA0")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5F30570", Offset = "0x5F2ED70", VA = "0x185F30570", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public BPFBGMILMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FFA0", Offset = "0x5F2E7A0", VA = "0x185F2FFA0", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5F302D0", Offset = "0x5F2EAD0", VA = "0x185F302D0", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE10", Offset = "0x5F2E610", VA = "0x185F2FE10", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5F30060", Offset = "0x5F2E860", VA = "0x185F30060", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FDA0", Offset = "0x5F2E5A0", VA = "0x185F2FDA0", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class EPEIMKKLODK : KOJGKBEMDEB, LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int GCEPGFMHOEN = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float EKMOPOCMBDC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float OJFALJCIKDC = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float GPDIGMFENGK = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5F32EF0", Offset = "0x5F316F0", VA = "0x185F32EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool KNEIAPCMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5F36520", Offset = "0x5F34D20", VA = "0x185F36520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5F36660", Offset = "0x5F34E60", VA = "0x185F36660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5F36A10", Offset = "0x5F35210", VA = "0x185F36A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5F36BF0", Offset = "0x5F353F0", VA = "0x185F36BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool OMKKLIAJFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5F36100", Offset = "0x5F34900", VA = "0x185F36100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5F36380", Offset = "0x5F34B80", VA = "0x185F36380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool EHJADDANEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5F35EC0", Offset = "0x5F346C0", VA = "0x185F35EC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5F36680", Offset = "0x5F34E80", VA = "0x185F36680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int PDBNGLJAJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5F36A70", Offset = "0x5F35270", VA = "0x185F36A70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5F36770", Offset = "0x5F34F70", VA = "0x185F36770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5F365C0", Offset = "0x5F34DC0", VA = "0x185F365C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5F36B50", Offset = "0x5F35350", VA = "0x185F36B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5F36C50", Offset = "0x5F35450", VA = "0x185F36C50")]
	public EPEIMKKLODK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5F35FA0", Offset = "0x5F347A0", VA = "0x185F35FA0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5F36370", Offset = "0x5F34B70", VA = "0x185F36370", Slot = "8")]
	public void FPMMBIEPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5F35CA0", Offset = "0x5F344A0", VA = "0x185F35CA0", Slot = "7")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5F36050", Offset = "0x5F34850", VA = "0x185F36050", Slot = "9")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5F36330", Offset = "0x5F34B30", VA = "0x185F36330", Slot = "12")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5F36470", Offset = "0x5F34C70", VA = "0x185F36470", Slot = "11")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "10")]
	public void CDIMIBACCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5F36860", Offset = "0x5F35060", VA = "0x185F36860")]
	private bool MLLBIMFCMED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5F361E0", Offset = "0x5F349E0", VA = "0x185F361E0")]
	private void ENCDJLHHGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KKBPAALNMJN(typeof(BAEMKDJGAPE), new string[] { })]
public class GGNKIBJJDJM : BAEMKDJGAPE, BOGFHHLHMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BAEMKDJGAPE DLGEBMNAJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BAEMKDJGAPE MOELMKDPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EDINIDCGNHI CONCNLCHMHI;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5F3A350", Offset = "0x5F38B50", VA = "0x185F3A350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A300", Offset = "0x5F38B00", VA = "0x185F3A300", Slot = "20")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A7C0", Offset = "0x5F38FC0", VA = "0x185F3A7C0", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5F39FD0", Offset = "0x5F387D0", VA = "0x185F39FD0", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A680", Offset = "0x5F38E80", VA = "0x185F3A680", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A1B0", Offset = "0x5F389B0", VA = "0x185F3A1B0", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A720", Offset = "0x5F38F20", VA = "0x185F3A720", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A4F0", Offset = "0x5F38CF0", VA = "0x185F3A4F0", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A450", Offset = "0x5F38C50", VA = "0x185F3A450", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A3B0", Offset = "0x5F38BB0", VA = "0x185F3A3B0", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A110", Offset = "0x5F38910", VA = "0x185F3A110", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A070", Offset = "0x5F38870", VA = "0x185F3A070", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5F39E70", Offset = "0x5F38670", VA = "0x185F39E70")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A250", Offset = "0x5F38A50", VA = "0x185F3A250")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5F39DC0", Offset = "0x5F385C0", VA = "0x185F39DC0")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5F39F20", Offset = "0x5F38720", VA = "0x185F39F20")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5F39D10", Offset = "0x5F38510", VA = "0x185F39D10")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A590", Offset = "0x5F38D90", VA = "0x185F3A590", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A860", Offset = "0x5F39060", VA = "0x185F3A860")]
	public GGNKIBJJDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5F39E70", Offset = "0x5F38670", VA = "0x185F39E70", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A250", Offset = "0x5F38A50", VA = "0x185F3A250", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5F39DC0", Offset = "0x5F385C0", VA = "0x185F39DC0", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5F39F20", Offset = "0x5F38720", VA = "0x185F39F20", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5F39D10", Offset = "0x5F38510", VA = "0x185F39D10", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class IOHMOCIBMMC : KOJGKBEMDEB, DPIKHFGILLN
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5F45390", Offset = "0x5F43B90", VA = "0x185F45390", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5F45570", Offset = "0x5F43D70", VA = "0x185F45570", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public IOHMOCIBMMC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5F45470", Offset = "0x5F43C70", VA = "0x185F45470", Slot = "6")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5F45320", Offset = "0x5F43B20", VA = "0x185F45320", Slot = "7")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class KOJGKBEMDEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly KDCPJKLPAPB LPIBPEGGEEE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected BCOGGGBMMOK HHCOKBJGCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xFFB210", Offset = "0xFF9A10", VA = "0x180FFB210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5F52760", Offset = "0x5F50F60", VA = "0x185F52760")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public KOJGKBEMDEB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5F52790", Offset = "0x5F50F90", VA = "0x185F52790")]
	protected FAFKHKPFEKI LLOHDMJCGLC(ICDDKLLCIME CMPMKFMJCNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DFLPABEEADD : KOJGKBEMDEB, ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5F321F0", Offset = "0x5F309F0", VA = "0x185F321F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5F32820", Offset = "0x5F31020", VA = "0x185F32820", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x5F31F60", Offset = "0x5F30760", VA = "0x185F31F60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5F31D70", Offset = "0x5F30570", VA = "0x185F31D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5F32940", Offset = "0x5F31140", VA = "0x185F32940")]
	public DFLPABEEADD(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5F31E10", Offset = "0x5F30610", VA = "0x185F31E10", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5F32000", Offset = "0x5F30800", VA = "0x185F32000", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5F32210", Offset = "0x5F30A10", VA = "0x185F32210", Slot = "9")]
	public void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5F319E0", Offset = "0x5F301E0", VA = "0x185F319E0", Slot = "10")]
	public void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5F325F0", Offset = "0x5F30DF0", VA = "0x185F325F0")]
	private void OCNBLLJGDPJ(PhotonView LPJELBBDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5F31BE0", Offset = "0x5F303E0", VA = "0x185F31BE0")]
	private void CGHHCENOAHG(RigidbodyEx OABGENDIMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5F32410", Offset = "0x5F30C10", VA = "0x185F32410")]
	private void NOEJOIHHMCI(PhotonView OFCHPIIFGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class ACDPBABDOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D670", Offset = "0x5F2BE70", VA = "0x185F2D670")]
	public static DFLPABEEADD GIGLDHHKGEJ(this KLJOINJFJMA NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class KAOMNGDOMJI : KOJGKBEMDEB, JEDJEILBNNF
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ACC0", Offset = "0x5F494C0", VA = "0x185F4ACC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5F4AAF0", Offset = "0x5F492F0", VA = "0x185F4AAF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5F4AEA0", Offset = "0x5F496A0", VA = "0x185F4AEA0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A900", Offset = "0x5F49100", VA = "0x185F4A900")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ABE0", Offset = "0x5F493E0", VA = "0x185F4ABE0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A700", Offset = "0x5F48F00", VA = "0x185F4A700", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5F4AF80", Offset = "0x5F49780", VA = "0x185F4AF80")]
	public KAOMNGDOMJI(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ADA0", Offset = "0x5F495A0", VA = "0x185F4ADA0", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A9F0", Offset = "0x5F491F0", VA = "0x185F4A9F0", Slot = "10")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class IHNLBNPODAC : KOJGKBEMDEB, HMNJOAIBFBB, IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public GALCBGLBFAD BLDMCPBPHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5F448D0", Offset = "0x5F430D0", VA = "0x185F448D0")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5F447E0", Offset = "0x5F42FE0", VA = "0x185F447E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5F449B0", Offset = "0x5F431B0", VA = "0x185F449B0", Slot = "6")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F447E0", Offset = "0x5F42FE0", VA = "0x185F447E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform NPPOFEKCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5F44BD0", Offset = "0x5F433D0", VA = "0x185F44BD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5F44CD0", Offset = "0x5F434D0", VA = "0x185F44CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5F31960", Offset = "0x5F30160", VA = "0x185F31960")]
	public IHNLBNPODAC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F44C70", Offset = "0x5F43470", VA = "0x185F44C70", Slot = "11")]
	public void OnChangedDistanceBand(GBAHALBBEFO OFDNJFOOJOA, GBAHALBBEFO MEKEHDPAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "12")]
	public void OnChangedVisibility(bool HGLINGKMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class FNHMKJDAMJI : HMNJOAIBFBB, IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int NJDDKOGBCIF = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private GALCBGLBFAD IECEOEJJEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private FDLOOMEBFFN IBJOKKJDEIN;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F38DC0", Offset = "0x5F375C0", VA = "0x185F38DC0", Slot = "6")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F38C90", Offset = "0x5F37490", VA = "0x185F38C90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform NPPOFEKCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F38C20", Offset = "0x5F37420", VA = "0x185F38C20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F38F00", Offset = "0x5F37700", VA = "0x185F38F00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F38FA0", Offset = "0x5F377A0", VA = "0x185F38FA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F39040", Offset = "0x5F37840", VA = "0x185F39040")]
	public FNHMKJDAMJI(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F38940", Offset = "0x5F37140", VA = "0x185F38940", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5F38C40", Offset = "0x5F37440", VA = "0x185F38C40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F38D60", Offset = "0x5F37560", VA = "0x185F38D60", Slot = "11")]
	private void NBIJGNJENHD(GBAHALBBEFO FIIFHFDPPBC, GBAHALBBEFO DPHBMFBPJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "12")]
	private void MOOHKHCCGPF(bool HGLINGKMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class JMKOACEABDB : KPHACHCIEDK, ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool OCPCNLKJKBI;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView PKJBIFAFLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5F321F0", Offset = "0x5F309F0", VA = "0x185F321F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F49F20", Offset = "0x5F48720", VA = "0x185F49F20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F49D30", Offset = "0x5F48530", VA = "0x185F49D30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A660", Offset = "0x5F48E60", VA = "0x185F4A660")]
	public JMKOACEABDB(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F49DD0", Offset = "0x5F485D0", VA = "0x185F49DD0", Slot = "9")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F49FC0", Offset = "0x5F487C0", VA = "0x185F49FC0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A0D0", Offset = "0x5F488D0", VA = "0x185F4A0D0", Slot = "10")]
	public void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F49A40", Offset = "0x5F48240", VA = "0x185F49A40", Slot = "11")]
	public void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A4E0", Offset = "0x5F48CE0", VA = "0x185F4A4E0")]
	private void OCNBLLJGDPJ(PhotonView LPJELBBDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F49BC0", Offset = "0x5F483C0", VA = "0x185F49BC0")]
	private void CGHHCENOAHG(RigidbodyEx OABGENDIMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A250", Offset = "0x5F48A50", VA = "0x185F4A250")]
	private void NOEJOIHHMCI(PhotonView OFCHPIIFGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class NBDOLCFHAOA
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C6E0", Offset = "0x6F5AEE0", VA = "0x186F5C6E0")]
	public static KPHACHCIEDK GIGLDHHKGEJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FMNGCPCGIIG : BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string AGPJDLGHNPA = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FMDOKKBAPOM PGIBOCIPOPP;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F387F0", Offset = "0x5F36FF0", VA = "0x185F387F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE530", Offset = "0x1AFCD30", VA = "0x181AFE530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F38850", Offset = "0x5F37050", VA = "0x185F38850")]
	public FMNGCPCGIIG(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F37F10", Offset = "0x5F36710", VA = "0x185F37F10", Slot = "5")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F37FC0", Offset = "0x5F367C0", VA = "0x185F37FC0", Slot = "7")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F381A0", Offset = "0x5F369A0", VA = "0x185F381A0", Slot = "8")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F379B0", Offset = "0x5F361B0", VA = "0x185F379B0", Slot = "9")]
	public void AKBFBEIOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F37D10", Offset = "0x5F36510", VA = "0x185F37D10", Slot = "10")]
	public void DBPBPENLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5F381D0", Offset = "0x5F369D0", VA = "0x185F381D0", Slot = "11")]
	public void IGMALIJEELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F38350", Offset = "0x5F36B50", VA = "0x185F38350", Slot = "12")]
	public void NGEMPCCFGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F37FF0", Offset = "0x5F367F0", VA = "0x185F37FF0")]
	private void HMNJIJBDGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F37800", Offset = "0x5F36000", VA = "0x185F37800")]
	private void AGKDIBAHEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MBFLNFMHMGO : JEDJEILBNNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints IJJBJLEMONJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x91F290", Offset = "0x91DA90", VA = "0x18091F290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x91F2A0", Offset = "0x91DAA0", VA = "0x18091F2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10BBF90", Offset = "0x10BA790", VA = "0x1810BBF90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x10BB540", Offset = "0x10B9D40", VA = "0x1810BB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BE50", Offset = "0x6F5A650", VA = "0x186F5BE50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BF90", Offset = "0x6F5A790", VA = "0x186F5BF90")]
	public MBFLNFMHMGO(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BF60", Offset = "0x6F5A760", VA = "0x186F5BF60", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BF30", Offset = "0x6F5A730", VA = "0x186F5BF30", Slot = "10")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GPKCGBKLHHG : NAAOIBJHADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F32EF0", Offset = "0x5F316F0", VA = "0x185F32EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F3D7B0", Offset = "0x5F3BFB0", VA = "0x185F3D7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F387F0", Offset = "0x5F36FF0", VA = "0x185F387F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F3E4E0", Offset = "0x5F3CCE0", VA = "0x185F3E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F33070", Offset = "0x5F31870", VA = "0x185F33070")]
	public GPKCGBKLHHG(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DD20", Offset = "0x5F3C520", VA = "0x185F3DD20", Slot = "4")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DFE0", Offset = "0x5F3C7E0", VA = "0x185F3DFE0")]
	private void KEJNLHKMPMG(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D800", Offset = "0x5F3C000", VA = "0x185F3D800", Slot = "5")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DE80", Offset = "0x5F3C680", VA = "0x185F3DE80", Slot = "6")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DAA0", Offset = "0x5F3C2A0", VA = "0x185F3DAA0")]
	private void DPDFEMBNECH(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E260", Offset = "0x5F3CA60", VA = "0x185F3E260", Slot = "7")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class GAEJIJLABLF : JKKHCKIOLME, NABDDFAEAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly global::LBECJFLPAEM<FAFKHKPFEKI> LEGMNJLANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool JBMILOFAAHA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public global::LBECJFLPAEM<FAFKHKPFEKI> GDKFBFNMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F39B80", Offset = "0x5F38380", VA = "0x185F39B80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F39610", Offset = "0x5F37E10", VA = "0x185F39610", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F390D0", Offset = "0x5F378D0", VA = "0x185F390D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x5F391B0", Offset = "0x5F379B0", VA = "0x185F391B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5F39C20", Offset = "0x5F38420", VA = "0x185F39C20")]
	public GAEJIJLABLF(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5F39BB0", Offset = "0x5F383B0", VA = "0x185F39BB0", Slot = "8")]
	public void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F39260", Offset = "0x5F37A60", VA = "0x185F39260", Slot = "9")]
	public void FKLLDNMELNG(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F392C0", Offset = "0x5F37AC0", VA = "0x185F392C0")]
	private Vector3 GAHKIOJBOFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F397E0", Offset = "0x5F37FE0", VA = "0x185F397E0")]
	private void GFONNFMBNPE(FAFKHKPFEKI FDEMMCBDHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class FIODCALIDME
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F37740", Offset = "0x5F35F40", VA = "0x185F37740")]
	public static JKKHCKIOLME KNOKCGBBPPB(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class EKNABMFIJOH : BEMPIPEGMEK, IPMJOKMPDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 MGLJKNHHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 NOIKJKFLDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float LMACMILFAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float CHODJKFAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 ADFEMPOHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? INPCFJLMNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? MIIDBCDLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool DDNEEDHAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool NFGHJPEOKIC;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4BD0210", Offset = "0x4BCEA10", VA = "0x184BD0210", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F33A20", Offset = "0x5F32220", VA = "0x185F33A20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F35720", Offset = "0x5F33F20", VA = "0x185F35720", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xB091F0", Offset = "0xB079F0", VA = "0x180B091F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F334F0", Offset = "0x5F31CF0", VA = "0x185F334F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1938620", Offset = "0x1936E20", VA = "0x181938620", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F33970", Offset = "0x5F32170", VA = "0x185F33970", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5F35A30", Offset = "0x5F34230", VA = "0x185F35A30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5F343F0", Offset = "0x5F32BF0", VA = "0x185F343F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D4A0", Offset = "0x5F2BCA0", VA = "0x185F2D4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event PENLMJLNPDM NGIDLMLHHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F35820", Offset = "0x5F34020", VA = "0x185F35820", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F33C90", Offset = "0x5F32490", VA = "0x185F33C90", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F35BA0", Offset = "0x5F343A0", VA = "0x185F35BA0")]
	public EKNABMFIJOH(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F33AD0", Offset = "0x5F322D0", VA = "0x185F33AD0", Slot = "17")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F33610", Offset = "0x5F31E10", VA = "0x185F33610", Slot = "16")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F35640", Offset = "0x5F33E40", VA = "0x185F35640", Slot = "19")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F341F0", Offset = "0x5F329F0", VA = "0x185F341F0", Slot = "20")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F358C0", Offset = "0x5F340C0", VA = "0x185F358C0", Slot = "18")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F33D30", Offset = "0x5F32530", VA = "0x185F33D30", Slot = "21")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F33A20", Offset = "0x5F32220", VA = "0x185F33A20")]
	private void NEADJADLFKA(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F34560", Offset = "0x5F32D60", VA = "0x185F34560")]
	[Obsolete]
	private Vector3 IOGOIOLPNLB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5F334F0", Offset = "0x5F31CF0", VA = "0x185F334F0")]
	private void NLAGPGMNKKK(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5F33970", Offset = "0x5F32170", VA = "0x185F33970")]
	private void DLCJAMEDIPF(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5F354D0", Offset = "0x5F33CD0", VA = "0x185F354D0")]
	private Vector3 KMFOEIELKBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5F33730", Offset = "0x5F31F30", VA = "0x185F33730", Slot = "15")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5F33380", Offset = "0x5F31B80", VA = "0x185F33380")]
	private Quaternion APGNIGHBLCM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5F353F0", Offset = "0x5F33BF0", VA = "0x185F353F0")]
	public void JCGOMGHJDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5F34660", Offset = "0x5F32E60", VA = "0x185F34660", Slot = "4")]
	public (float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class OFJMDLAOMKF
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CB10", Offset = "0x6F5B310", VA = "0x186F5CB10")]
	public static BEMPIPEGMEK FNDOCLELGBE(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JKKHCKIOLME : NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	global::LBECJFLPAEM<FAFKHKPFEKI> GDKFBFNMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GONPMOGJPOK : PMKPCPNEKNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FMDOKKBAPOM CEMMLJNHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float FMKENJDMKIE;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x80EE60", Offset = "0x80D660", VA = "0x18080EE60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5F3A930", Offset = "0x5F39130", VA = "0x185F3A930", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B3B0", Offset = "0x5F39BB0", VA = "0x185F3B3B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x5F3BC70", Offset = "0x5F3A470", VA = "0x185F3BC70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x5F3BD60", Offset = "0x5F3A560", VA = "0x185F3BD60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5F3D3F0", Offset = "0x5F3BBF0", VA = "0x185F3D3F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x5F3D610", Offset = "0x5F3BE10", VA = "0x185F3D610", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5F3D520", Offset = "0x5F3BD20", VA = "0x185F3D520", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5F3A900", Offset = "0x5F39100", VA = "0x185F3A900", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xBBDD90", Offset = "0xBBC590", VA = "0x180BBDD90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5F3BD90", Offset = "0x5F3A590", VA = "0x185F3BD90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x17D86C0", Offset = "0x17D6EC0", VA = "0x1817D86C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private NAAOIBJHADK KAAEMNKNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2616D20", Offset = "0x2615520", VA = "0x182616D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5F36660", Offset = "0x5F34E60", VA = "0x185F36660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D6D0", Offset = "0x5F3BED0", VA = "0x185F3D6D0")]
	public GONPMOGJPOK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B340", Offset = "0x5F39B40", VA = "0x185F3B340", Slot = "19")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B650", Offset = "0x5F39E50", VA = "0x185F3B650", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C7F0", Offset = "0x5F3AFF0", VA = "0x185F3C7F0", Slot = "28")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x17D7D10", Offset = "0x17D6510", VA = "0x1817D7D10", Slot = "20")]
	public void IDHOAFOCKIJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x17D7CF0", Offset = "0x17D64F0", VA = "0x1817D7CF0", Slot = "31")]
	public void COEBAFIHDGK(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B470", Offset = "0x5F39C70", VA = "0x185F3B470", Slot = "36")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AE50", Offset = "0x5F39650", VA = "0x185F3AE50", Slot = "35")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B340", Offset = "0x5F39B40", VA = "0x185F3B340", Slot = "27")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5F3BEB0", Offset = "0x5F3A6B0", VA = "0x185F3BEB0", Slot = "25")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5F3BEF0", Offset = "0x5F3A6F0", VA = "0x185F3BEF0", Slot = "24")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AC10", Offset = "0x5F39410", VA = "0x185F3AC10", Slot = "34")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D2D0", Offset = "0x5F3BAD0", VA = "0x185F3D2D0", Slot = "33")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B810", Offset = "0x5F3A010", VA = "0x185F3B810", Slot = "32")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C070", Offset = "0x5F3A870", VA = "0x185F3C070", Slot = "22")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C4C0", Offset = "0x5F3ACC0", VA = "0x185F3C4C0", Slot = "21")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C920", Offset = "0x5F3B120", VA = "0x185F3C920", Slot = "23")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D330", Offset = "0x5F3BB30", VA = "0x185F3D330", Slot = "30")]
	public Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C6F0", Offset = "0x5F3AEF0", VA = "0x185F3C6F0", Slot = "29")]
	public Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B6B0", Offset = "0x5F39EB0", VA = "0x185F3B6B0", Slot = "26")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5F3BD90", Offset = "0x5F3A590", VA = "0x185F3BD90")]
	private void GNAGAOKDICE(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5F3BF30", Offset = "0x5F3A730", VA = "0x185F3BF30")]
	private void IAKIEGDKDAI(Vector3 ODOOOABGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D1E0", Offset = "0x5F3B9E0", VA = "0x185F3D1E0")]
	private Vector3 OPBFFCOBIJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B950", Offset = "0x5F3A150", VA = "0x185F3B950")]
	private void FIALGKEPIBL(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AA50", Offset = "0x5F39250", VA = "0x185F3AA50")]
	private Vector3 BFPGMPGOAEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B010", Offset = "0x5F39810", VA = "0x185F3B010")]
	private void CFGBDHECLAN(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5F3CBE0", Offset = "0x5F3B3E0", VA = "0x185F3CBE0")]
	private void NIMJBANPDME(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AB50", Offset = "0x5F39350", VA = "0x185F3AB50")]
	private void BMJDIGOKBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class OFOMKPIAOLH : JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string FBDLHJHPBGO = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly FMDOKKBAPOM IADMGPBMKLA;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CB90", Offset = "0x6F5B390", VA = "0x186F5CB90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D0A0", Offset = "0x6F5B8A0", VA = "0x186F5D0A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CC70", Offset = "0x6F5B470", VA = "0x186F5CC70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CDA0", Offset = "0x6F5B5A0", VA = "0x186F5CDA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D0D0", Offset = "0x6F5B8D0", VA = "0x186F5D0D0")]
	public OFOMKPIAOLH(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CD10", Offset = "0x6F5B510", VA = "0x186F5CD10", Slot = "12")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CE40", Offset = "0x6F5B640", VA = "0x186F5CE40", Slot = "9")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D0C0", Offset = "0x6F5B8C0", VA = "0x186F5D0C0", Slot = "10")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CF20", Offset = "0x6F5B720", VA = "0x186F5CF20", Slot = "11")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CC30", Offset = "0x6F5B430", VA = "0x186F5CC30", Slot = "6")]
	public void BAHNFOENCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D020", Offset = "0x6F5B820", VA = "0x186F5D020", Slot = "13")]
	public void LBEBFFILMKK(Rigidbody GGGGHNNPHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CD70", Offset = "0x6F5B570", VA = "0x186F5CD70", Slot = "14")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class ECMNAPBLLLL : GADMMIHBFNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode IFFHGGHFFEP;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5F32EF0", Offset = "0x5F316F0", VA = "0x185F32EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5F32A40", Offset = "0x5F31240", VA = "0x185F32A40", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5F32E80", Offset = "0x5F31680", VA = "0x185F32E80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5F33070", Offset = "0x5F31870", VA = "0x185F33070")]
	public ECMNAPBLLLL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5F32B50", Offset = "0x5F31350", VA = "0x185F32B50", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5F32DF0", Offset = "0x5F315F0", VA = "0x185F32DF0", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5F32E70", Offset = "0x5F31670", VA = "0x185F32E70", Slot = "7")]
	public void MEHHJKMGHLL(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5F32DE0", Offset = "0x5F315E0", VA = "0x185F32DE0", Slot = "8")]
	public void KJEBGEAKFJB(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5F32C70", Offset = "0x5F31470", VA = "0x185F32C70", Slot = "10")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5F32F40", Offset = "0x5F31740", VA = "0x185F32F40")]
	private void OIKJOBJMGEJ(bool ICBDCKBKPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ICBBFNNPNOB : BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5F446F0", Offset = "0x5F42EF0", VA = "0x185F446F0", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5F43F10", Offset = "0x5F42710", VA = "0x185F43F10", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5F444F0", Offset = "0x5F42CF0", VA = "0x185F444F0", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5F44130", Offset = "0x5F42930", VA = "0x185F44130", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5F44610", Offset = "0x5F42E10", VA = "0x185F44610", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5F44380", Offset = "0x5F42B80", VA = "0x185F44380", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5F44320", Offset = "0x5F42B20", VA = "0x185F44320", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5F44270", Offset = "0x5F42A70", VA = "0x185F44270", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5F44080", Offset = "0x5F42880", VA = "0x185F44080", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5F44020", Offset = "0x5F42820", VA = "0x185F44020", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5F43CC0", Offset = "0x5F424C0", VA = "0x185F43CC0")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5F441A0", Offset = "0x5F429A0", VA = "0x185F441A0")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5F43C50", Offset = "0x5F42450", VA = "0x185F43C50")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5F43DE0", Offset = "0x5F425E0", VA = "0x185F43DE0")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5F43BE0", Offset = "0x5F423E0", VA = "0x185F43BE0")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5F44440", Offset = "0x5F42C40", VA = "0x185F44440", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public ICBBFNNPNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5F43CC0", Offset = "0x5F424C0", VA = "0x185F43CC0", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5F441A0", Offset = "0x5F429A0", VA = "0x185F441A0", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5F43C50", Offset = "0x5F42450", VA = "0x185F43C50", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5F43DE0", Offset = "0x5F425E0", VA = "0x185F43DE0", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5F43BE0", Offset = "0x5F423E0", VA = "0x185F43BE0", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JDLLBKNLAFL : BFCDMDFHJNM, CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly FAFKHKPFEKI LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<FAFKHKPFEKI> KKIGAGCNEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private FAFKHKPFEKI PMBNHDHBMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private FAFKHKPFEKI ONIJEEBBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform KLNKNPJHMEE;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5F47480", Offset = "0x5F45C80", VA = "0x185F47480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8C3580", Offset = "0x8C1D80", VA = "0x1808C3580", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5F48F20", Offset = "0x5F47720", VA = "0x185F48F20", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3600", Offset = "0x8C1E00", VA = "0x1808C3600", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5F48E80", Offset = "0x5F47680", VA = "0x185F48E80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5F48CA0", Offset = "0x5F474A0", VA = "0x185F48CA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5F48FD0", Offset = "0x5F477D0", VA = "0x185F48FD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5F474E0", Offset = "0x5F45CE0", VA = "0x185F474E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5F473E0", Offset = "0x5F45BE0", VA = "0x185F473E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5F47E60", Offset = "0x5F46660", VA = "0x185F47E60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action ILMHHPLDHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5F47870", Offset = "0x5F46070", VA = "0x185F47870", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5F48660", Offset = "0x5F46E60", VA = "0x185F48660", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action LKKCMMNHMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5F47BF0", Offset = "0x5F463F0", VA = "0x185F47BF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5F48D40", Offset = "0x5F47540", VA = "0x185F48D40", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FAFKHKPFEKI> HMDKKBAFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5F47F00", Offset = "0x5F46700", VA = "0x185F47F00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5F48470", Offset = "0x5F46C70", VA = "0x185F48470", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<FAFKHKPFEKI> IDGBMMFDPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5F48F30", Offset = "0x5F47730", VA = "0x185F48F30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5F48240", Offset = "0x5F46A40", VA = "0x185F48240", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action MBIPKGCCLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5F47580", Offset = "0x5F45D80", VA = "0x185F47580", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5F482E0", Offset = "0x5F46AE0", VA = "0x185F482E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<FAFKHKPFEKI> ICECBJMMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5F47FA0", Offset = "0x5F467A0", VA = "0x185F47FA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5F47DC0", Offset = "0x5F465C0", VA = "0x185F47DC0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5F49070", Offset = "0x5F47870", VA = "0x185F49070")]
	public JDLLBKNLAFL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5F47B70", Offset = "0x5F46370", VA = "0x185F47B70", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5F48700", Offset = "0x5F46F00", VA = "0x185F48700", Slot = "30")]
	public void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5F47620", Offset = "0x5F45E20", VA = "0x185F47620", Slot = "6")]
	public void DCAAKEBPGMM(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5F47910", Offset = "0x5F46110", VA = "0x185F47910", Slot = "7")]
	public void DIAJFCLGHNB(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5F47340", Offset = "0x5F45B40", VA = "0x185F47340", Slot = "4")]
	public void ANNGLPCKBKA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5F48DE0", Offset = "0x5F475E0", VA = "0x185F48DE0", Slot = "5")]
	public void MEAEKDMOCMC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5F481B0", Offset = "0x5F469B0", VA = "0x185F481B0")]
	private void HCHGKENDMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5F48170", Offset = "0x5F46970", VA = "0x185F48170")]
	private void GOLOLHKODGD(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5F48510", Offset = "0x5F46D10", VA = "0x185F48510")]
	private void JGDDCMMNPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5F48040", Offset = "0x5F46840", VA = "0x185F48040")]
	private void GLBGGDLJEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5F47C90", Offset = "0x5F46490", VA = "0x185F47C90")]
	private void EHLKHCACNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5F48380", Offset = "0x5F46B80", VA = "0x185F48380")]
	[CompilerGenerated]
	private object INHLJOFAOEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class BGHNPIHEKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D6D0", Offset = "0x5F2BED0", VA = "0x185F2D6D0")]
	public static BFCDMDFHJNM AEAGMJDNIIJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class MADOJLIAMLE : PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string IHEGBFLFHMK = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly FMDOKKBAPOM PPNOPPNGLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly LHPAGGDFKDF LMIIBOOAPKI;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE530", Offset = "0x1AFCD30", VA = "0x181AFE530", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x80ECA0", Offset = "0x80D4A0", VA = "0x18080ECA0", Slot = "5")]
		get
		{
			return default(LHPAGGDFKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BDB0", Offset = "0x6F5A5B0", VA = "0x186F5BDB0")]
	public MADOJLIAMLE(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B8A0", Offset = "0x6F5A0A0", VA = "0x186F5B8A0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BB60", Offset = "0x6F5A360", VA = "0x186F5BB60")]
	private bool IFMJEIBBLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B840", Offset = "0x6F5A040", VA = "0x186F5B840", Slot = "7")]
	public void AFGGHBKIECF(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B870", Offset = "0x6F5A070", VA = "0x186F5B870", Slot = "8")]
	public void CPELJIHJKHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BC80", Offset = "0x6F5A480", VA = "0x186F5BC80", Slot = "11")]
	public void ODHNAICIIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BA50", Offset = "0x6F5A250", VA = "0x186F5BA50")]
	private void FAEHMCHMGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B970", Offset = "0x6F5A170", VA = "0x186F5B970")]
	private void EAFCDCFDCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BC40", Offset = "0x6F5A440", VA = "0x186F5BC40", Slot = "10")]
	public void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BC00", Offset = "0x6F5A400", VA = "0x186F5BC00", Slot = "9")]
	public void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BEMPIPEGMEK : IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BFCDMDFHJNM : CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANNGLPCKBKA(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEAEKDMOCMC(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCAAKEBPGMM(FAFKHKPFEKI DBHJCCLCMCD);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIAJFCLGHNB(FAFKHKPFEKI DBHJCCLCMCD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class LPEBPKEGIHE : DPIKHFGILLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool HCMLLAEMOKI;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7730", Offset = "0x8C5F30", VA = "0x1808C7730", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B750", Offset = "0x6F59F50", VA = "0x186F5B750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B800", Offset = "0x6F5A000", VA = "0x186F5B800")]
	public LPEBPKEGIHE(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B720", Offset = "0x6F59F20", VA = "0x186F5B720", Slot = "6")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B6E0", Offset = "0x6F59EE0", VA = "0x186F5B6E0", Slot = "7")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ABOJLNCAGIK : LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int GCEPGFMHOEN = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float EKMOPOCMBDC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float OJFALJCIKDC = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float GPDIGMFENGK = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool LJFIFCNDLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool AIBBEMJFIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int KIOKOHMNEOH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D4A0", Offset = "0x5F2BCA0", VA = "0x185F2D4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool KNEIAPCMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D090", Offset = "0x5F2B890", VA = "0x185F2D090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D1D0", Offset = "0x5F2B9D0", VA = "0x185F2D1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D3A0", Offset = "0x5F2BBA0", VA = "0x185F2D3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D4F0", Offset = "0x5F2BCF0", VA = "0x185F2D4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D130", Offset = "0x5F2B930", VA = "0x185F2D130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D400", Offset = "0x5F2BC00", VA = "0x185F2D400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D550", Offset = "0x5F2BD50", VA = "0x185F2D550")]
	public ABOJLNCAGIK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CCE0", Offset = "0x5F2B4E0", VA = "0x185F2CCE0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CFE0", Offset = "0x5F2B7E0", VA = "0x185F2CFE0", Slot = "8")]
	public void FPMMBIEPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x5F2C9D0", Offset = "0x5F2B1D0", VA = "0x185F2C9D0", Slot = "7")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CD70", Offset = "0x5F2B570", VA = "0x185F2CD70", Slot = "9")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CFF0", Offset = "0x5F2B7F0", VA = "0x185F2CFF0", Slot = "11")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CFA0", Offset = "0x5F2B7A0", VA = "0x185F2CFA0", Slot = "12")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CB30", Offset = "0x5F2B330", VA = "0x185F2CB30", Slot = "10")]
	public void CDIMIBACCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D1F0", Offset = "0x5F2B9F0", VA = "0x185F2D1F0")]
	private bool MLLBIMFCMED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F2CE10", Offset = "0x5F2B610", VA = "0x185F2CE10")]
	private void ENCDJLHHGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class GPMEJGGBFFB : NLOPKOPLBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly FAFKHKPFEKI LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float OIOOEPMJBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float GIFDAOBHDEB;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD80", Offset = "0xBBA580", VA = "0x180BBBD80", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F3E540", Offset = "0x5F3CD40", VA = "0x185F3E540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD90", Offset = "0xBBA590", VA = "0x180BBBD90", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5F3E6B0", Offset = "0x5F3CEB0", VA = "0x185F3E6B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E7D0", Offset = "0x5F3CFD0", VA = "0x185F3E7D0")]
	public GPMEJGGBFFB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E780", Offset = "0x5F3CF80", VA = "0x185F3E780", Slot = "8")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E610", Offset = "0x5F3CE10", VA = "0x185F3E610", Slot = "9")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface KPHACHCIEDK : ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView PKJBIFAFLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : HPBGIGMFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F65E80", Offset = "0x6F64680", VA = "0x186F65E80", Slot = "6")]
		public sealed override void MIJPKAHHAOP(FFIAJAAMFMA IACLOIAOHJF)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
	{
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
