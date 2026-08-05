using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ImposterPreviewCustomFraming : MonoBehaviour, MGAAOCJJEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float PFAEGEIHDJB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27DE460", Offset = "0x27DD660", VA = "0x1827DE460")]
	public void SetReferencePoint(Vector3 EMHBBLDAMOB, Quaternion BNPOLGHMEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27DE1C0", Offset = "0x27DD3C0", VA = "0x1827DE1C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27DE3F0", Offset = "0x27DD5F0", VA = "0x1827DE3F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16239F0", Offset = "0x1622BF0", VA = "0x1816239F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct POAMDOLBDAB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static POAMDOLBDAB AFEPOGEFOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float CBDNBILDKDM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x730D50", Offset = "0x72FF50", VA = "0x180730D50")]
	public POAMDOLBDAB(float DLBAALCJHDN)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[NODNICKNPLO(NOMJLFGGPAB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int OKPEHIADEAE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int JKOFBFABNGN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> ECOAFJIAEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool LGHOFGFGJBK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27DE620", Offset = "0x27DD820", VA = "0x1827DE620")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27DE520", Offset = "0x27DD720", VA = "0x1827DE520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27DE800", Offset = "0x27DDA00", VA = "0x1827DE800")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, MGAAOCJJEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x27DC330", Offset = "0x27DB530", VA = "0x1827DC330", Slot = "4")]
		public void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGAAOCJJEEL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LCCKNMBGBFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> ONOLPILHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> KGFPECBMPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JDHNHDAMLJN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLPMBEOKLL(params Type[] DGBCFCPCHGO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHNDBPBOLKA(params Type[] DGBCFCPCHGO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject BCMAPNBIHMA(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T BCMAPNBIHMA<T>(T DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T BCMAPNBIHMA<T>(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BCMAPNBIHMA(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T BCMAPNBIHMA<T>(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T BCMAPNBIHMA<T>(T DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DBMDMHMMAFB : IDisposable, JDHNHDAMLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> IBLGDLAKCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> DPPAMMIKOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform NJGLDIFIAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> ENHKEJLMCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PJPHCBHFADK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27DC860", Offset = "0x27DBA60", VA = "0x1827DC860")]
	[EEPNDFMGFKJ(CPDKPFACMJL.None)]
	public static void HDEJLANFJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27DCF30", Offset = "0x27DC130", VA = "0x1827DCF30")]
	[Preserve]
	public DBMDMHMMAFB([AHKDIAMPNOO(null)] LCCKNMBGBFC NAIMGCBKOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27DC620", Offset = "0x27DB820", VA = "0x1827DC620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27DC5D0", Offset = "0x27DB7D0", VA = "0x1827DC5D0", Slot = "5")]
	public void BGLPMBEOKLL(params Type[] DGBCFCPCHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27DCEE0", Offset = "0x27DC0E0", VA = "0x1827DCEE0", Slot = "6")]
	public void PHNDBPBOLKA(params Type[] DGBCFCPCHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27DC4B0", Offset = "0x27DB6B0", VA = "0x1827DC4B0", Slot = "7")]
	public GameObject BCMAPNBIHMA(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3847F50", Offset = "0x3847150", VA = "0x183847F50", Slot = "8")]
	public T BCMAPNBIHMA<T>(T DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3848620", Offset = "0x3847820", VA = "0x183848620", Slot = "9")]
	public T BCMAPNBIHMA<T>(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, bool PECCLOJEBON = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27DC540", Offset = "0x27DB740", VA = "0x1827DC540", Slot = "10")]
	public GameObject BCMAPNBIHMA(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38485D0", Offset = "0x38477D0", VA = "0x1838485D0", Slot = "11")]
	public T BCMAPNBIHMA<T>(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3847FC0", Offset = "0x38471C0", VA = "0x183847FC0", Slot = "12")]
	public T BCMAPNBIHMA<T>(T DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3848050", Offset = "0x3847250", VA = "0x183848050")]
	private T BCMAPNBIHMA<T>(GameObject DBHBBNPKELE, Transform ENAGHEEPLJN, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON, out GameObject EADMLICGDJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3847AD0", Offset = "0x3846CD0", VA = "0x183847AD0")]
	private T APLIBCKEIFG<T>(GameObject NEFMINHNLIG, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27DCDC0", Offset = "0x27DBFC0", VA = "0x1827DCDC0")]
	private void NKINPEPILKN(Component OFADDADJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27DC950", Offset = "0x27DBB50", VA = "0x1827DC950")]
	private void KDMFJPLDGBG(Component OFADDADJKKI, NGGBPNJPEGF JBADGMEDNJF, bool PECCLOJEBON, [Optional] Type HFEMBCAENDH, [Optional] Type JHHDFLBIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27DC720", Offset = "0x27DB920", VA = "0x1827DC720")]
	private void EDPNJGADDON(GameObject NEFMINHNLIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NGGBPNJPEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> JDLHOFIFALP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x428D020", Offset = "0x428C220", VA = "0x18428D020")]
	public NGGBPNJPEGF CEAJIHNFBDD<T>(T DPMFCNNBNAK)
	{
		return default(NGGBPNJPEGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3883680", Offset = "0x3882880", VA = "0x183883680")]
	public T FCLOOBPJBAH<T>(T LJCMBCOMOJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFF10", Offset = "0x3ADF110", VA = "0x183ADFF10")]
	public bool GJMMOBCKDJC<T>(out T DPMFCNNBNAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PBGGHJELPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool PLJPBPFNOIK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76BEA0", Offset = "0x76B0A0", VA = "0x18076BEA0")]
	public PBGGHJELPML(bool HMEKNEECIMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CGELHGPLMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool KHNJKENENDK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27DC320", Offset = "0x27DB520", VA = "0x1827DC320")]
	public CGELHGPLMFN(bool JMBFLEACKPC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, MGAAOCJJEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27E0940", Offset = "0x27DFB40", VA = "0x1827E0940", Slot = "4")]
		public void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x27DE880", Offset = "0x27DDA80", VA = "0x1827DE880")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x27DE870", Offset = "0x27DDA70", VA = "0x1827DE870")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x27DE4A0", Offset = "0x27DD6A0", VA = "0x1827DE4A0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MOFJMFPIGMG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> PNGBPCLEPNM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 GICFPIBIOGI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 BIGCIIKMLHE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera NFCMPKOCFIA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string COIKHJIKBHD = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const DPJHCONILKF NADOJDBAJCE = DPJHCONILKF.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> OJEOPBLPOBG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode NMKPPNKLJGL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color FICFJKENKMI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color AHFPHABHOIO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color JDPPDLBDGJF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap HIELIHLIGOO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool AHKCCPOMOLB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera EPDANCKKCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x27DF970", Offset = "0x27DEB70", VA = "0x1827DF970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27DEA20", Offset = "0x27DDC20", VA = "0x1827DEA20")]
	public static void CLDLBKJABGO(Vector3 JGMHPGIFGEF, Quaternion LJBEHAGOMGH, ImposterRenderConfig KMCEOCLBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x27DF630", Offset = "0x27DE830", VA = "0x1827DF630")]
	private static void EHBDOOFINED(Vector3 JGMHPGIFGEF, Quaternion LJBEHAGOMGH, URPLight LOBPDAJJIFO, ImposterRenderConfig.LightConfig EGMGFDMMMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x27DEDA0", Offset = "0x27DDFA0", VA = "0x1827DEDA0")]
	public static void ECPMNKCGMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27DFB70", Offset = "0x27DED70", VA = "0x1827DFB70")]
	private static void GHMEHPMBHGL(int EKFLANOJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27DE8A0", Offset = "0x27DDAA0", VA = "0x1827DE8A0")]
	public static void BMGGEDBEBPJ(ImposterRenderConfig KMCEOCLBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27DECA0", Offset = "0x27DDEA0", VA = "0x1827DECA0")]
	public static void DPGAHJLJGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27E0560", Offset = "0x27DF760", VA = "0x1827E0560")]
	public static void OLJNBAALHAJ(GameObject EIHFABKHILN, RenderTexture MLHNOPCEHHD, ImposterRenderConfig KMCEOCLBMOE, POAMDOLBDAB NFEIGHNDOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27DEE80", Offset = "0x27DE080", VA = "0x1827DEE80")]
	private static void EFONIEDMDHJ(GameObject EIHFABKHILN, RenderTexture MLHNOPCEHHD, ImposterRenderConfig KMCEOCLBMOE, POAMDOLBDAB NFEIGHNDOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27DF3A0", Offset = "0x27DE5A0", VA = "0x1827DF3A0")]
	private static void EGHOJPMBAPI(GameObject EIHFABKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27DFE70", Offset = "0x27DF070", VA = "0x1827DFE70")]
	public static void HNCKLKCNFJJ(List<Renderer> PHJNBJJINGN, List<Material> OGOECNHEIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27E0000", Offset = "0x27DF200", VA = "0x1827E0000")]
	public static void JFHNLFABBNJ(GameObject DBHBBNPKELE, Vector3 LJIOMNMAJJG, Vector3 LPPEBMHABAN, float IFIOOHIPJPE, POAMDOLBDAB NFEIGHNDOGO, out Vector3 FAGMLPJHGIO, out Quaternion LNAOCLNJIHL, out float BEIKJNDBBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27E0710", Offset = "0x27DF910", VA = "0x1827E0710")]
	public static RenderTexture PLDJONDELFJ(int FNNLNDILPIG, int AKPHHICECEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27E0320", Offset = "0x27DF520", VA = "0x1827E0320")]
	public static void LDHEICFFMHA()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct AJPNPFIMMKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public GGMBIJOCENK HHHDEAAGGGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject KJMMLKABFGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture HDCIGKLMHNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig PJMFPCBCBFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public POAMDOLBDAB POAMDOLBDAB;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x27DC2B0", Offset = "0x27DB4B0", VA = "0x1827DC2B0")]
			public AJPNPFIMMKO(GGMBIJOCENK JFKKPGJCCBD, GameObject IJIADPABHHE, RenderTexture MLHNOPCEHHD, ImposterRenderConfig PLEKCLPJCNP, POAMDOLBDAB NFEIGHNDOGO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OAMEPDNEKHF = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int FHEPNOIMHCI = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::MCDMHMIKFDJ<AJPNPFIMMKO, RenderTexture> NFAKANLJDOK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<AJPNPFIMMKO> AGPBBBHNPHN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GMHAPELGHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xC4FD50", Offset = "0xC4EF50", VA = "0x180C4FD50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x27DD760", Offset = "0x27DC960", VA = "0x1827DD760")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject EIHFABKHILN, RenderTexture MLHNOPCEHHD, ImposterRenderConfig KMCEOCLBMOE, POAMDOLBDAB NFEIGHNDOGO, CancellationToken GENHLOEKMNL, bool CKKBFILNOCJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x27DD260", Offset = "0x27DC460", VA = "0x1827DD260", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x27DD6D0", Offset = "0x27DC8D0", VA = "0x1827DD6D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x27DD380", Offset = "0x27DC580", VA = "0x1827DD380")]
		private static Task<RenderTexture> KIBLECONNKG(AJPNPFIMMKO NPDINJLPKDF, CancellationToken GENHLOEKMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x27DDB70", Offset = "0x27DCD70", VA = "0x1827DDB70")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x27DDF00", Offset = "0x27DD100", VA = "0x1827DDF00")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27DDBD0", Offset = "0x27DCDD0", VA = "0x1827DDBD0")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
