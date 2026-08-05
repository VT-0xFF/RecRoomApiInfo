using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NKGFMLGBJOM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x793900", Offset = "0x792900", VA = "0x180793900")]
	public NKGFMLGBJOM()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[AJECOHLOKKH]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[AJECOHLOKKH]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x49858D0", Offset = "0x49848D0", VA = "0x1849858D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4985890", Offset = "0x4984890", VA = "0x184985890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4985910", Offset = "0x4984910", VA = "0x184985910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4985B20", Offset = "0x4984B20", VA = "0x184985B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4985A90", Offset = "0x4984A90", VA = "0x184985A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8400E0", Offset = "0x83F0E0", VA = "0x1808400E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E10", Offset = "0x7B1E10", VA = "0x1807B2E10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4985850", Offset = "0x4984850", VA = "0x184985850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4985A00", Offset = "0x4984A00", VA = "0x184985A00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4985280", Offset = "0x4984280", VA = "0x184985280")]
	public void CopyBounds(SavedExtents AGELLNNPMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49857C0", Offset = "0x49847C0", VA = "0x1849857C0")]
	public void SetLocalSpaceBounds(Bounds ELBFMOCBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA17790", Offset = "0xA16790", VA = "0x180A17790")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49856F0", Offset = "0x49846F0", VA = "0x1849856F0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49852B0", Offset = "0x49842B0", VA = "0x1849852B0")]
	private void GMPBGBOBDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x49854C0", Offset = "0x49844C0", VA = "0x1849854C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4984CC0", Offset = "0x4983CC0", VA = "0x184984CC0")]
	public static void CalculateLocalBoundsFor(GameObject MNCBMNIPDNH, out Bounds ELBFMOCBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4985700", Offset = "0x4984700", VA = "0x184985700")]
	private static void PLAFBBDHDNO(Bounds FFKAJGPOGIJ, Color LEBLBLLCPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x49857E0", Offset = "0x49847E0", VA = "0x1849857E0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5358B0", Offset = "0x5348B0", VA = "0x1805358B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "4")]
	public virtual void OECDBMKJGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[NKGFMLGBJOM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C51560", Offset = "0x3C50560", VA = "0x183C51560", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C510A0", Offset = "0x3C500A0", VA = "0x183C510A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C51B60", Offset = "0x3C50B60", VA = "0x183C51B60")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AFOJPBGEDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public AFOJPBGEDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x25A2E30", Offset = "0x25A1E30", VA = "0x1825A2E30")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[NKGFMLGBJOM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x25ADDE0", Offset = "0x25ACDE0", VA = "0x1825ADDE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x25ADE10", Offset = "0x25ACE10", VA = "0x1825ADE10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x25ADD30", Offset = "0x25ACD30", VA = "0x1825ADD30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey MNGGKJHHPNI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x25ADD60", Offset = "0x25ACD60", VA = "0x1825ADD60", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x25ADC30", Offset = "0x25ACC30", VA = "0x1825ADC30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25AD490", Offset = "0x25AC490", VA = "0x1825AD490", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25ACE00", Offset = "0x25ABE00", VA = "0x1825ACE00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25ACA60", Offset = "0x25ABA60", VA = "0x1825ACA60", Slot = "14")]
	protected virtual string KMJFEGNHCOJ(TKeyVal PBEECLKLGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25AC940", Offset = "0x25AB940", VA = "0x1825AC940", Slot = "4")]
	public bool ContainsKey(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25ADB20", Offset = "0x25ACB20", VA = "0x1825ADB20", Slot = "5")]
	public bool TryGetValue(TKey MNGGKJHHPNI, out TVal DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25AC970", Offset = "0x25AB970", VA = "0x1825AC970", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25AC970", Offset = "0x25AB970", VA = "0x1825AC970", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25ADB50", Offset = "0x25ACB50", VA = "0x1825ADB50")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MEGGGOEKELK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OCANNAEJGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public OCANNAEJGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2454C70", Offset = "0x2453C70", VA = "0x182454C70")]
		internal bool <GetSamples>b__0(global::JOGNBEOKOPD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float PINBHCDDIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float DIAFAHKOKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::JOGNBEOKOPD<float, T>> BBKLJMLHAIP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OELDOAAJHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2440910", Offset = "0x243F910", VA = "0x182440910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2441420", Offset = "0x2440420", VA = "0x182441420")]
	public MEGGGOEKELK(float BGAPJAGOBNI, float IOHHAEGINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2440BE0", Offset = "0x243FBE0", VA = "0x182440BE0")]
	public bool HMBPMOBDNDN(float DFKHDCLBACA, T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24413C0", Offset = "0x24403C0", VA = "0x1824413C0")]
	public int NLGPNFLDKNB(float DFKHDCLBACA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2440D40", Offset = "0x243FD40", VA = "0x182440D40")]
	public IEnumerable<T> IPNBILJOPGP(float DFKHDCLBACA, [Optional] float? FPJHDKGDLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2440990", Offset = "0x243F990", VA = "0x182440990")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x24409C0", Offset = "0x243F9C0", VA = "0x1824409C0")]
	private void HEDOAKCIDEJ(float DFKHDCLBACA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class MABCANGEALG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct IDHMICICAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T DPFBMCEIHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float CJKEMOPKGGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float FKFOPBNPIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> EMGCCOEKAAN;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int MPDBKPEFPNH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDHMICICAEG[] ABDMDAMADHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int CGHDNLNDOCN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LOIDCDIGPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0070", Offset = "0x69F070", VA = "0x1806A0070")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69F140", VA = "0x1806A0140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x243FB20", Offset = "0x243EB20", VA = "0x18243FB20")]
	public MABCANGEALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x243FB50", Offset = "0x243EB50", VA = "0x18243FB50")]
	public MABCANGEALG(int ACFAACNMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x243F520", Offset = "0x243E520", VA = "0x18243F520")]
	public void ONGBLFOLDCH(float DFKHDCLBACA, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x243E740", Offset = "0x243D740", VA = "0x18243E740")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x243EED0", Offset = "0x243DED0", VA = "0x18243EED0")]
	public bool NKKJIGCNOPD(float BFBDDONNAMI, float MFOMPCHJCIB, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x243EBB0", Offset = "0x243DBB0", VA = "0x18243EBB0")]
	public bool NKGHMPOPIMB(float BFBDDONNAMI, float MFOMPCHJCIB, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x243F6E0", Offset = "0x243E6E0", VA = "0x18243F6E0")]
	public void PMGDDHPOPHF(float BFBDDONNAMI, float MFOMPCHJCIB, List<T> CGBPEHFCGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x243E9E0", Offset = "0x243D9E0", VA = "0x18243E9E0")]
	private int HDGPNKDAMMN(int BOGILONLLLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x243EA10", Offset = "0x243DA10", VA = "0x18243EA10")]
	private void ICNDEKMBAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKBJDGIEOBI();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FLHJGNDCAIG(T PAGIOBKBEJN, T CNMNKJHPLKO, float ALPPOEENOGM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GCAGGJIFFJM(T DDDOLDGEMNC, float ALPPOEENOGM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DPNDCMCJOLD(T PAGIOBKBEJN, T CNMNKJHPLKO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JELFDDMHCDF(T PAGIOBKBEJN, T CNMNKJHPLKO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JCDACPLANJN : global::MABCANGEALG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4982D50", Offset = "0x4981D50", VA = "0x184982D50", Slot = "4")]
	protected override Vector3 BKBJDGIEOBI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4982E70", Offset = "0x4981E70", VA = "0x184982E70", Slot = "5")]
	protected override Vector3 FLHJGNDCAIG(Vector3 PAGIOBKBEJN, Vector3 CNMNKJHPLKO, float ALPPOEENOGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4982F30", Offset = "0x4981F30", VA = "0x184982F30", Slot = "6")]
	protected override Vector3 GCAGGJIFFJM(Vector3 DDDOLDGEMNC, float ALPPOEENOGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4982DC0", Offset = "0x4981DC0", VA = "0x184982DC0", Slot = "7")]
	protected override Vector3 DPNDCMCJOLD(Vector3 PAGIOBKBEJN, Vector3 CNMNKJHPLKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4982FD0", Offset = "0x4981FD0", VA = "0x184982FD0", Slot = "8")]
	protected override Vector3 JELFDDMHCDF(Vector3 PAGIOBKBEJN, Vector3 CNMNKJHPLKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4983040", Offset = "0x4982040", VA = "0x184983040")]
	public JCDACPLANJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBOOFPDHKEK : global::MABCANGEALG<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4984310", Offset = "0x4983310", VA = "0x184984310")]
	public OBOOFPDHKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4984370", Offset = "0x4983370", VA = "0x184984370")]
	public OBOOFPDHKEK(int ACFAACNMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x695B80", Offset = "0x694B80", VA = "0x180695B80", Slot = "4")]
	protected override float BKBJDGIEOBI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4984280", Offset = "0x4983280", VA = "0x184984280", Slot = "5")]
	protected override float FLHJGNDCAIG(float PAGIOBKBEJN, float CNMNKJHPLKO, float ALPPOEENOGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B0C0", Offset = "0x3E9A0C0", VA = "0x183E9B0C0", Slot = "6")]
	protected override float GCAGGJIFFJM(float DDDOLDGEMNC, float ALPPOEENOGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27FA3E0", Offset = "0x27F93E0", VA = "0x1827FA3E0", Slot = "7")]
	protected override float DPNDCMCJOLD(float PAGIOBKBEJN, float CNMNKJHPLKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4984300", Offset = "0x4983300", VA = "0x184984300", Slot = "8")]
	protected override float JELFDDMHCDF(float PAGIOBKBEJN, float CNMNKJHPLKO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AFJLKBIDGPN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x247A900", Offset = "0x2479900", VA = "0x18247A900")]
	public static global::AHEOMOMICHL<T1> DMLCAMHGJAD<T1>(T1 HNMBIILEELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23D2B30", Offset = "0x23D1B30", VA = "0x1823D2B30")]
	public static global::JOGNBEOKOPD<T1, T2> DMLCAMHGJAD<T1, T2>(T1 HNMBIILEELA, T2 FBBBGDBAICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x294C150", Offset = "0x294B150", VA = "0x18294C150")]
	public static global::CEJCCAGLDMF<T1, T2, T3> DMLCAMHGJAD<T1, T2, T3>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23D2DB0", Offset = "0x23D1DB0", VA = "0x1823D2DB0")]
	public static global::LJAPIDCOKHN<T1, T2, T3, T4> DMLCAMHGJAD<T1, T2, T3, T4>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23D2D10", Offset = "0x23D1D10", VA = "0x1823D2D10")]
	public static global::PLOLLPEJDOM<T1, T2, T3, T4, T5> DMLCAMHGJAD<T1, T2, T3, T4, T5>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x23D2C60", Offset = "0x23D1C60", VA = "0x1823D2C60")]
	public static global::PKPNBMAEJFG<T1, T2, T3, T4, T5, T6> DMLCAMHGJAD<T1, T2, T3, T4, T5, T6>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BA0", Offset = "0x23D1BA0", VA = "0x1823D2BA0")]
	public static global::LJBADCKICMI<T1, T2, T3, T4, T5, T6, T7> DMLCAMHGJAD<T1, T2, T3, T4, T5, T6, T7>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF, T7 DIAOGELKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2259270", Offset = "0x2258270", VA = "0x182259270")]
	public static global::GJAPLBKGFFE<T1, T2, T3, T4, T5, T6, T7, T8> DMLCAMHGJAD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF, T7 DIAOGELKECB, T8 JKFPLOLGHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3030", Offset = "0x1DF2030", VA = "0x181DF3030")]
	[IteratorStateMachine(typeof(JLOAGAJBJFI))]
	public static IEnumerable<global::JOGNBEOKOPD<T1, T2>> AKMLGMNCNAK<T1, T2>(IEnumerable<T1> MGMKOCNNKKD, IEnumerable<T2> FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x209AFB0", Offset = "0x2099FB0", VA = "0x18209AFB0")]
	[IteratorStateMachine(typeof(IIFEKCPNEEN))]
	public static IEnumerable<global::CEJCCAGLDMF<T1, T2, T3>> AKMLGMNCNAK<T1, T2, T3>(IEnumerable<T1> MGMKOCNNKKD, IEnumerable<T2> FFKAJGPOGIJ, IEnumerable<T3> LEBLBLLCPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2843750", Offset = "0x2842750", VA = "0x182843750")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4268EE0", Offset = "0x4267EE0", VA = "0x184268EE0")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4268EF0", Offset = "0x4267EF0", VA = "0x184268EF0")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ, int GAKBDOCFCKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49804E0", Offset = "0x497F4E0", VA = "0x1849804E0")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ, int GAKBDOCFCKG, int KCLPAFNHJON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4980490", Offset = "0x497F490", VA = "0x184980490")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ, int GAKBDOCFCKG, int KCLPAFNHJON, int PGFCCDOFBAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x49804B0", Offset = "0x497F4B0", VA = "0x1849804B0")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ, int GAKBDOCFCKG, int KCLPAFNHJON, int PGFCCDOFBAD, int CAOKLBMIFJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4980500", Offset = "0x497F500", VA = "0x184980500")]
	internal static int IHECHPKNDIC(int MBAIOBEKMFA, int MBGJBDOPMMK, int DMEDCLKINHJ, int GAKBDOCFCKG, int KCLPAFNHJON, int PGFCCDOFBAD, int CAOKLBMIFJD, int ANFIIBFHGHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AHEOMOMICHL<T1> : IComparable<global::AHEOMOMICHL<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x234AEB0", Offset = "0x2349EB0", VA = "0x18234AEB0")]
	public AHEOMOMICHL(T1 HNMBIILEELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x234AD00", Offset = "0x2349D00", VA = "0x18234AD00", Slot = "4")]
	public int CompareTo(global::AHEOMOMICHL<T1> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x234AD70", Offset = "0x2349D70", VA = "0x18234AD70", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA0A2D0", Offset = "0xA092D0", VA = "0x180A0A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x234AE10", Offset = "0x2349E10", VA = "0x18234AE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JOGNBEOKOPD<T1, T2> : IComparable<global::JOGNBEOKOPD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x250C5F0", Offset = "0x250B5F0", VA = "0x18250C5F0")]
	public JOGNBEOKOPD(T1 HNMBIILEELA, T2 FBBBGDBAICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x2509C70", VA = "0x18250AC70", Slot = "4")]
	public int CompareTo(global::JOGNBEOKOPD<T1, T2> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x250AD90", Offset = "0x2509D90", VA = "0x18250AD90", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x250BA10", Offset = "0x250AA10", VA = "0x18250BA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x250BEA0", Offset = "0x250AEA0", VA = "0x18250BEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CEJCCAGLDMF<T1, T2, T3> : IComparable<global::CEJCCAGLDMF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3594110", Offset = "0x3593110", VA = "0x183594110")]
	public CEJCCAGLDMF(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3593930", Offset = "0x3592930", VA = "0x183593930", Slot = "4")]
	public int CompareTo(global::CEJCCAGLDMF<T1, T2, T3> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3593B30", Offset = "0x3592B30", VA = "0x183593B30", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3593E20", Offset = "0x3592E20", VA = "0x183593E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3593E90", Offset = "0x3592E90", VA = "0x183593E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LJAPIDCOKHN<T1, T2, T3, T4> : IComparable<global::LJAPIDCOKHN<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 HHPMLIALMFH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D79BF0", Offset = "0x3D78BF0", VA = "0x183D79BF0")]
	public LJAPIDCOKHN(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3D797C0", Offset = "0x3D787C0", VA = "0x183D797C0", Slot = "4")]
	public int CompareTo(global::LJAPIDCOKHN<T1, T2, T3, T4> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3D79900", Offset = "0x3D78900", VA = "0x183D79900", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3D79A20", Offset = "0x3D78A20", VA = "0x183D79A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3D79AE0", Offset = "0x3D78AE0", VA = "0x183D79AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PLOLLPEJDOM<T1, T2, T3, T4, T5> : IComparable<global::PLOLLPEJDOM<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 HHPMLIALMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 ELCMMKLJOPO;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B4A0", Offset = "0x2E4A4A0", VA = "0x182E4B4A0")]
	public PLOLLPEJDOM(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C91420", Offset = "0x3C90420", VA = "0x183C91420", Slot = "4")]
	public int CompareTo(global::PLOLLPEJDOM<T1, T2, T3, T4, T5> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C915A0", Offset = "0x3C905A0", VA = "0x183C915A0", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C916E0", Offset = "0x3C906E0", VA = "0x183C916E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C917E0", Offset = "0x3C907E0", VA = "0x183C917E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PKPNBMAEJFG<T1, T2, T3, T4, T5, T6> : IComparable<global::PKPNBMAEJFG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 HHPMLIALMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 ELCMMKLJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 HEAGKFHNJCI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E4ADF0", Offset = "0x2E49DF0", VA = "0x182E4ADF0")]
	public PKPNBMAEJFG(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DC90", Offset = "0x3C8CC90", VA = "0x183C8DC90", Slot = "4")]
	public int CompareTo(global::PKPNBMAEJFG<T1, T2, T3, T4, T5, T6> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DE50", Offset = "0x3C8CE50", VA = "0x183C8DE50", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DFC0", Offset = "0x3C8CFC0", VA = "0x183C8DFC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E0E0", Offset = "0x3C8D0E0", VA = "0x183C8E0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LJBADCKICMI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::LJBADCKICMI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 HHPMLIALMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 ELCMMKLJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 HEAGKFHNJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 NLJFBMDAOLK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A2E0", Offset = "0x3D792E0", VA = "0x183D7A2E0")]
	public LJBADCKICMI(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF, T7 DIAOGELKECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D79C80", Offset = "0x3D78C80", VA = "0x183D79C80", Slot = "4")]
	public int CompareTo(global::LJBADCKICMI<T1, T2, T3, T4, T5, T6, T7> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D79E80", Offset = "0x3D78E80", VA = "0x183D79E80", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A020", Offset = "0x3D79020", VA = "0x183D7A020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A170", Offset = "0x3D79170", VA = "0x183D7A170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GJAPLBKGFFE<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::GJAPLBKGFFE<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 OLEDNKLBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 IEODLLCMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 HPDDOMEEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 HHPMLIALMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 ELCMMKLJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 HEAGKFHNJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 NLJFBMDAOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 FPKICEKOHLP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CEA0", Offset = "0x3C2BEA0", VA = "0x183C2CEA0")]
	public GJAPLBKGFFE(T1 HNMBIILEELA, T2 FBBBGDBAICG, T3 KDKGJFFIGAF, T4 DALBDOKOKLD, T5 IFJLDKELPOG, T6 IHINIINFBBF, T7 DIAOGELKECB, T8 JKFPLOLGHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C790", Offset = "0x3C2B790", VA = "0x183C2C790", Slot = "4")]
	public int CompareTo(global::GJAPLBKGFFE<T1, T2, T3, T4, T5, T6, T7, T8> AGELLNNPMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C9E0", Offset = "0x3C2B9E0", VA = "0x183C2C9E0", Slot = "0")]
	public override bool Equals(object AGELLNNPMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CBA0", Offset = "0x3C2BBA0", VA = "0x183C2CBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CD10", Offset = "0x3C2BD10", VA = "0x183C2CD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float OELFCDNJIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x631680", Offset = "0x630680", VA = "0x180631680")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x48E4220", Offset = "0x48E3220", VA = "0x1848E4220")]
	public T BDKJPPBHHBH(float ALPPOEENOGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x48E3E70", Offset = "0x48E2E70", VA = "0x1848E3E70")]
	public T APALBIJLCEE(float ALPPOEENOGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FLHJGNDCAIG(T PAGIOBKBEJN, T CNMNKJHPLKO, float ALPPOEENOGM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x49827E0", Offset = "0x49817E0", VA = "0x1849827E0", Slot = "4")]
	protected override float FLHJGNDCAIG(float PAGIOBKBEJN, float CNMNKJHPLKO, float ALPPOEENOGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4982860", Offset = "0x4981860", VA = "0x184982860")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4986A80", Offset = "0x4985A80", VA = "0x184986A80", Slot = "4")]
	protected override Vector3 FLHJGNDCAIG(Vector3 PAGIOBKBEJN, Vector3 CNMNKJHPLKO, float ALPPOEENOGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4986B40", Offset = "0x4985B40", VA = "0x184986B40")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4981ED0", Offset = "0x4980ED0", VA = "0x184981ED0", Slot = "4")]
	protected override Color FLHJGNDCAIG(Color PAGIOBKBEJN, Color CNMNKJHPLKO, float ALPPOEENOGM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4981F20", Offset = "0x4980F20", VA = "0x184981F20")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class BECNFIFLLOE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] POBLMFANHDG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x511440", Offset = "0x510440", VA = "0x180511440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1A0", Offset = "0x5CC1A0", VA = "0x1805CD1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x33E5280", Offset = "0x33E4280", VA = "0x1833E5280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x33E5150", Offset = "0x33E4150", VA = "0x1833E5150")]
	public static global::BECNFIFLLOE<T> ALNLLKAEKMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x33E5340", Offset = "0x33E4340", VA = "0x1833E5340")]
	public static global::BECNFIFLLOE<T> DCCICELBMBM(int NBDFKNGGAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x33E5BD0", Offset = "0x33E4BD0", VA = "0x1833E5BD0")]
	private BECNFIFLLOE(T[] IJFDHAMIKGN, int NBDFKNGGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x33E5480", Offset = "0x33E4480", VA = "0x1833E5480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x33E59D0", Offset = "0x33E49D0", VA = "0x1833E59D0")]
	public void ONGBLFOLDCH(in T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33E5630", Offset = "0x33E4630", VA = "0x1833E5630")]
	public void JMLFPIGMKAM(int ACFAACNMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33E4FD0", Offset = "0x33E3FD0", VA = "0x1833E4FD0")]
	private void AECNNDDCJKK(int NBDFKNGGAPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class EPJMFHNKBMG
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x247D990", Offset = "0x247C990", VA = "0x18247D990")]
	public static global::BECNFIFLLOE<T> ALNLLKAEKMD<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8230", Offset = "0x1CE7230", VA = "0x181CE8230")]
	public static global::BECNFIFLLOE<T> DCCICELBMBM<T>(int NBDFKNGGAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class KFLNNLALCAH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> GDLIMOCAAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> NHCHCGBEPHB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2248810", Offset = "0x2247810", VA = "0x182248810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HBLMAKKNPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5358A0", Offset = "0x5348A0", VA = "0x1805358A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> PFKPHBMLJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2509090", Offset = "0x2508090", VA = "0x182509090", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> LMFFKJDICMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x27D4B20", Offset = "0x27D3B20", VA = "0x1827D4B20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x27D4AF0", Offset = "0x27D3AF0", VA = "0x1827D4AF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x27D4B50", Offset = "0x27D3B50", VA = "0x1827D4B50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x27D3DD0", Offset = "0x27D2DD0", VA = "0x1827D3DD0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x27D4750", Offset = "0x27D3750", VA = "0x1827D4750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E00", Offset = "0x27D2E00", VA = "0x1827D3E00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27D4970", Offset = "0x27D3970", VA = "0x1827D4970", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27D3DA0", Offset = "0x27D2DA0", VA = "0x1827D3DA0", Slot = "9")]
	public void Add(TKey MNGGKJHHPNI, TVal DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27D3D40", Offset = "0x27D2D40", VA = "0x1827D3D40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KNAIIFKDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E60", Offset = "0x27D2E60", VA = "0x1827D3E60", Slot = "8")]
	public bool ContainsKey(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E90", Offset = "0x27D2E90", VA = "0x1827D3E90", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27D4910", Offset = "0x27D3910", VA = "0x1827D4910", Slot = "10")]
	public bool Remove(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27D4910", Offset = "0x27D3910", VA = "0x1827D4910", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24405C0", Offset = "0x243F5C0", VA = "0x1824405C0", Slot = "11")]
	public bool TryGetValue(TKey MNGGKJHHPNI, out TVal DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27D4360", Offset = "0x27D3360", VA = "0x1827D4360", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27D3EF0", Offset = "0x27D2EF0", VA = "0x1827D3EF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ABDMDAMADHK, int NEMDNDOFKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27D4860", Offset = "0x27D3860", VA = "0x1827D4860")]
	public void ONGBLFOLDCH(TVal IKMEOANGHEH, TKey MNGGKJHHPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27D4820", Offset = "0x27D3820", VA = "0x1827D4820")]
	public void ONGBLFOLDCH(KeyValuePair<TVal, TKey> KNAIIFKDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27D42B0", Offset = "0x27D32B0", VA = "0x1827D42B0")]
	public bool EPINABJBNBK(TVal MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27D3F50", Offset = "0x27D2F50", VA = "0x1827D3F50")]
	public bool DHMIPJBINIK(KeyValuePair<TVal, TKey> KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27D4790", Offset = "0x27D3790", VA = "0x1827D4790")]
	public bool KOAAEEDJIKB(TVal MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27D4790", Offset = "0x27D3790", VA = "0x1827D4790")]
	public bool KOAAEEDJIKB(KeyValuePair<TVal, TKey> KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27D47F0", Offset = "0x27D37F0", VA = "0x1827D47F0")]
	public bool MMEDHLOPCHO(TVal MNGGKJHHPNI, out TKey DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27D4470", Offset = "0x27D3470", VA = "0x1827D4470")]
	public IEnumerator<KeyValuePair<TVal, TKey>> HIEMJBNNLOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27D44F0", Offset = "0x27D34F0", VA = "0x1827D44F0")]
	private void IACFJIPBBOB(TKey MNGGKJHHPNI, TVal IKMEOANGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27D4600", Offset = "0x27D3600", VA = "0x1827D4600")]
	private void JFNKFPPDBHI(TKey MNGGKJHHPNI, TVal IKMEOANGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27D41F0", Offset = "0x27D31F0", VA = "0x1827D41F0")]
	private bool EKHMDMBGKCO(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27D3FB0", Offset = "0x27D2FB0", VA = "0x1827D3FB0")]
	private bool EKHMDMBGKCO(TVal IKMEOANGHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27D4A10", Offset = "0x27D3A10", VA = "0x1827D4A10")]
	public KFLNNLALCAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class GJKDAKCDBMB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::GJKDAKCDBMB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6A0070", Offset = "0x69F070", VA = "0x1806A0070", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3C29A10", Offset = "0x3C28A10", VA = "0x183C29A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C29BB0", Offset = "0x3C28BB0", VA = "0x183C29BB0")]
		public Enumerator(global::GJKDAKCDBMB<T> CGBPEHFCGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C29130", Offset = "0x3C28130", VA = "0x183C29130", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C29570", Offset = "0x3C28570", VA = "0x183C29570", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C28DF0", Offset = "0x3C27DF0", VA = "0x183C28DF0")]
		private void FKPBFMEBCEL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] JIOHNEPGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int JGPOOACBJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int PNHCANBEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BEANBJEKGAH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D2B0", Offset = "0x3C2C2B0", VA = "0x183C2D2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D2F0", Offset = "0x3C2C2F0", VA = "0x183C2D2F0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C2ECD0", Offset = "0x3C2DCD0", VA = "0x183C2ECD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C2F330", Offset = "0x3C2E330", VA = "0x183C2F330")]
	public GJKDAKCDBMB(int NBDFKNGGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C2F080", Offset = "0x3C2E080", VA = "0x183C2F080")]
	public void ONGBLFOLDCH(T ALPPOEENOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DEF0", Offset = "0x3C2CEF0", VA = "0x183C2DEF0")]
	public void KGCNJLLBGAH(IEnumerable<T> JOBMGHOJBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DB40", Offset = "0x3C2CB40", VA = "0x183C2DB40")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DB60", Offset = "0x3C2CB60", VA = "0x183C2DB60")]
	public void HIADANBBODM(int MODLAKNNNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C2EDC0", Offset = "0x3C2DDC0", VA = "0x183C2EDC0")]
	public void OKIDEMHPFCC(int MODLAKNNNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D600", Offset = "0x3C2C600", VA = "0x183C2D600")]
	public void EPIEJAMEOIP(T[] ABDMDAMADHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D590", Offset = "0x3C2C590", VA = "0x183C2D590")]
	public Enumerator EMLPMGDEOEM()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3C2F140", Offset = "0x3C2E140", VA = "0x183C2F140", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3C2F140", Offset = "0x3C2E140", VA = "0x183C2F140", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E9F0", Offset = "0x3C2D9F0", VA = "0x183C2E9F0")]
	private int KJKOCGOKDIN(int IDCLMAKCIEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D470", Offset = "0x3C2C470", VA = "0x183C2D470")]
	private int CJIIPACCIEH(int IDCLMAKCIEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class DAELMKEBOHH
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IOJGIHONONE(object[] KLKLKJLJMDI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected DAELMKEBOHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DCNBFHEFMBO<T> : DAELMKEBOHH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	protected struct FFMHBOIFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum HPAFHHMDBBN
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HPAFHHMDBBN CIMKNKPILIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T EDHAOFHJENI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int KJAPGDLPFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool FHKKONOKIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool HNBJDHMNILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> PCIDEACPJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<FFMHBOIFMPN> GDIBCGDHGHB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool EIOOKIOFDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x38BEDB0", Offset = "0x38BDDB0", VA = "0x1838BEDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x38BF250", Offset = "0x38BE250", VA = "0x1838BF250")]
	protected DCNBFHEFMBO(bool HNBJDHMNILG, bool FHKKONOKIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x38BF030", Offset = "0x38BE030", VA = "0x1838BF030")]
	protected bool LAIFAMFBOMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38BEDF0", Offset = "0x38BDDF0", VA = "0x1838BEDF0")]
	protected void JFNJGLEDFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x38BEAD0", Offset = "0x38BDAD0", VA = "0x1838BEAD0")]
	protected void FIBCIEGKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2782350", Offset = "0x2781350", VA = "0x182782350")]
	private static void DANLNDCCGBB<U>(ref List<U> KALOMCOIBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x38BF0D0", Offset = "0x38BE0D0", VA = "0x1838BF0D0", Slot = "5")]
	public void ONGBLFOLDCH(T EDHAOFHJENI, bool PEACNHLENIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x38BEED0", Offset = "0x38BDED0", VA = "0x1838BEED0", Slot = "6")]
	public void KOAAEEDJIKB(T EDHAOFHJENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x38BEC80", Offset = "0x38BDC80", VA = "0x1838BEC80")]
	public void FLOPBJIDDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CIKKKEHKDPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CNEELAKGHKO : global::DCNBFHEFMBO<Action>, CIKKKEHKDPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4981D50", Offset = "0x4980D50", VA = "0x184981D50")]
	public CNEELAKGHKO(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4981A50", Offset = "0x4980A50", VA = "0x184981A50")]
	public void EBCKFPBDBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4981C70", Offset = "0x4980C70", VA = "0x184981C70", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4981CF0", Offset = "0x4980CF0", VA = "0x184981CF0")]
	public static CNEELAKGHKO PIFOIFMPBGG(CNEELAKGHKO OAIGFHGMDJH, Action EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4981C10", Offset = "0x4980C10", VA = "0x184981C10")]
	public static CNEELAKGHKO GAPFHKLBLBE(CNEELAKGHKO OAIGFHGMDJH, Action EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HHKBEFOFFPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class ILGGPDMEKNN<T> : global::DCNBFHEFMBO<Action<T>>, global::HHKBEFOFFPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public ILGGPDMEKNN(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6680", Offset = "0x3CD5680", VA = "0x183CD6680")]
	public void EBCKFPBDBMA(T ALPPOEENOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3CDAE90", Offset = "0x3CD9E90", VA = "0x183CDAE90", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB530", Offset = "0x3CDA530", VA = "0x183CDB530")]
	public static global::ILGGPDMEKNN<T> PIFOIFMPBGG(global::ILGGPDMEKNN<T> OAIGFHGMDJH, Action<T> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9780", Offset = "0x3CD8780", VA = "0x183CD9780")]
	public static global::ILGGPDMEKNN<T> GAPFHKLBLBE(global::ILGGPDMEKNN<T> OAIGFHGMDJH, Action<T> EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNFOGPFKNBH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T, U> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T, U> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ELGGIAFFIHI<T, U> : global::DCNBFHEFMBO<Action<T, U>>, global::FNFOGPFKNBH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public ELGGIAFFIHI(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x25A5480", Offset = "0x25A4480", VA = "0x1825A5480")]
	public void EBCKFPBDBMA(T ALPPOEENOGM, U FAKJLOFLJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x25AA4A0", Offset = "0x25A94A0", VA = "0x1825AA4A0", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x25AB370", Offset = "0x25AA370", VA = "0x1825AB370")]
	public static global::ELGGIAFFIHI<T, U> PIFOIFMPBGG(global::ELGGIAFFIHI<T, U> OAIGFHGMDJH, Action<T, U> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25A8B70", Offset = "0x25A7B70", VA = "0x1825A8B70")]
	public static global::ELGGIAFFIHI<T, U> GAPFHKLBLBE(global::ELGGIAFFIHI<T, U> OAIGFHGMDJH, Action<T, U> EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AHADLFCDJHD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T, U, V> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T, U, V> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class CGNMFPMANKO<T, U, V> : global::DCNBFHEFMBO<Action<T, U, V>>, global::AHADLFCDJHD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public CGNMFPMANKO(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3594F10", Offset = "0x3593F10", VA = "0x183594F10")]
	public void EBCKFPBDBMA(T ALPPOEENOGM, U FAKJLOFLJDH, V DPPCIFMDPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3597C30", Offset = "0x3596C30", VA = "0x183597C30", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3598090", Offset = "0x3597090", VA = "0x183598090")]
	public static global::CGNMFPMANKO<T, U, V> PIFOIFMPBGG(global::CGNMFPMANKO<T, U, V> OAIGFHGMDJH, Action<T, U, V> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3596950", Offset = "0x3595950", VA = "0x183596950")]
	public static global::CGNMFPMANKO<T, U, V> GAPFHKLBLBE(global::CGNMFPMANKO<T, U, V> OAIGFHGMDJH, Action<T, U, V> EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LOEHPEJDIDI<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T, U, V, W> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T, U, V, W> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NLPCKCEGBBM<T, U, V, W> : global::DCNBFHEFMBO<Action<T, U, V, W>>, global::LOEHPEJDIDI<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public NLPCKCEGBBM(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x32D0C90", Offset = "0x32CFC90", VA = "0x1832D0C90")]
	public void EBCKFPBDBMA(T ALPPOEENOGM, U FAKJLOFLJDH, V DPPCIFMDPOI, W IBKHPENJJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x32D19C0", Offset = "0x32D09C0", VA = "0x1832D19C0", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x32D2B30", Offset = "0x32D1B30", VA = "0x1832D2B30")]
	public static global::NLPCKCEGBBM<T, U, V, W> PIFOIFMPBGG(global::NLPCKCEGBBM<T, U, V, W> OAIGFHGMDJH, Action<T, U, V, W> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x32D11C0", Offset = "0x32D01C0", VA = "0x1832D11C0")]
	public static global::NLPCKCEGBBM<T, U, V, W> GAPFHKLBLBE(global::NLPCKCEGBBM<T, U, V, W> OAIGFHGMDJH, Action<T, U, V, W> EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OKLHHDEMOFP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T, U, V, W, X> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T, U, V, W, X> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DGANGBIHKJD<T, U, V, W, X> : global::DCNBFHEFMBO<Action<T, U, V, W, X>>, global::OKLHHDEMOFP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public DGANGBIHKJD(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x38C0CD0", Offset = "0x38BFCD0", VA = "0x1838C0CD0")]
	public void EBCKFPBDBMA(T ALPPOEENOGM, U FAKJLOFLJDH, V DPPCIFMDPOI, W IBKHPENJJPF, X LLFMGCPPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x38C1010", Offset = "0x38C0010", VA = "0x1838C1010", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x38C1620", Offset = "0x38C0620", VA = "0x1838C1620")]
	public static global::DGANGBIHKJD<T, U, V, W, X> PIFOIFMPBGG(global::DGANGBIHKJD<T, U, V, W, X> OAIGFHGMDJH, Action<T, U, V, W, X> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x38C0F70", Offset = "0x38BFF70", VA = "0x1838C0F70")]
	public static global::DGANGBIHKJD<T, U, V, W, X> GAPFHKLBLBE(global::DGANGBIHKJD<T, U, V, W, X> OAIGFHGMDJH, Action<T, U, V, W, X> EDHAOFHJENI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NILGHPIHJGK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGBLFOLDCH(Action<T, U, V, W, X, Y> EDHAOFHJENI, bool PEACNHLENIB = false);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOAAEEDJIKB(Action<T, U, V, W, X, Y> EDHAOFHJENI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PKJGNFDELDE<T, U, V, W, X, Y> : global::DCNBFHEFMBO<Action<T, U, V, W, X, Y>>, global::NILGHPIHJGK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x25AB410", Offset = "0x25AA410", VA = "0x1825AB410")]
	public PKJGNFDELDE(bool HNBJDHMNILG = false, bool FHKKONOKIFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C8CEC0", Offset = "0x3C8BEC0", VA = "0x183C8CEC0")]
	public void EBCKFPBDBMA(T ALPPOEENOGM, U FAKJLOFLJDH, V DPPCIFMDPOI, W IBKHPENJJPF, X LLFMGCPPNJC, Y JPNAADDLLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D880", Offset = "0x3C8C880", VA = "0x183C8D880", Slot = "4")]
	public override void IOJGIHONONE(object[] KLKLKJLJMDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DBF0", Offset = "0x3C8CBF0", VA = "0x183C8DBF0")]
	public static global::PKJGNFDELDE<T, U, V, W, X, Y> PIFOIFMPBGG(global::PKJGNFDELDE<T, U, V, W, X, Y> OAIGFHGMDJH, Action<T, U, V, W, X, Y> EDHAOFHJENI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D490", Offset = "0x3C8C490", VA = "0x183C8D490")]
	public static global::PKJGNFDELDE<T, U, V, W, X, Y> GAPFHKLBLBE(global::PKJGNFDELDE<T, U, V, W, X, Y> OAIGFHGMDJH, Action<T, U, V, W, X, Y> EDHAOFHJENI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct OJPCBCHMAJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BCDBKDCAIGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct MPHOEJNJBHL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::BCDBKDCAIGH<T> GFOJMFAOGDI;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T DPFBMCEIHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x33F7350", Offset = "0x33F6350", VA = "0x1833F7350")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x33F7320", Offset = "0x33F6320", VA = "0x1833F7320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AC0", Offset = "0x6F5AC0", VA = "0x1806F6AC0")]
		public MPHOEJNJBHL(global::BCDBKDCAIGH<T> GFOJMFAOGDI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct AHFDMBLACEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<MPHOEJNJBHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::BCDBKDCAIGH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x33E0ED0", Offset = "0x33DFED0", VA = "0x1833E0ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2610720", Offset = "0x260F720", VA = "0x182610720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JGMEGPDLNKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<MPHOEJNJBHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::BCDBKDCAIGH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x33F6830", Offset = "0x33F5830", VA = "0x1833F6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2610720", Offset = "0x260F720", VA = "0x182610720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim LJOLECMHEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T JLLFFGGFBGE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int PCLLALFKNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x33E13A0", Offset = "0x33E03A0", VA = "0x1833E13A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x33E1A50", Offset = "0x33E0A50", VA = "0x1833E1A50")]
	public BCDBKDCAIGH(in T JLLFFGGFBGE, int JFBJJBMIADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x33E1980", Offset = "0x33E0980", VA = "0x1833E1980")]
	public BCDBKDCAIGH(in T JLLFFGGFBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x33E1360", Offset = "0x33E0360", VA = "0x1833E1360")]
	public MPHOEJNJBHL BOOENCBOFOF()
	{
		return default(MPHOEJNJBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x33E1320", Offset = "0x33E0320", VA = "0x1833E1320")]
	public MPHOEJNJBHL BOOENCBOFOF(CancellationToken LDBMCJENAKJ)
	{
		return default(MPHOEJNJBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x33E16A0", Offset = "0x33E06A0", VA = "0x1833E16A0")]
	[AsyncStateMachine(typeof(global::BCDBKDCAIGH<>.AHFDMBLACEI))]
	public Task<MPHOEJNJBHL> LKHNFGNGAEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x33E13C0", Offset = "0x33E03C0", VA = "0x1833E13C0")]
	[AsyncStateMachine(typeof(global::BCDBKDCAIGH<>.JGMEGPDLNKB))]
	public Task<MPHOEJNJBHL> LKHNFGNGAEM(CancellationToken LDBMCJENAKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class COAPLBFJJGN
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4981DB0", Offset = "0x4980DB0", VA = "0x184981DB0")]
	public static global::BCDBKDCAIGH<OJPCBCHMAJP> ALNLLKAEKMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4981E10", Offset = "0x4980E10", VA = "0x184981E10")]
	public static global::BCDBKDCAIGH<OJPCBCHMAJP> ALNLLKAEKMD(int JFBJJBMIADJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x247A900", Offset = "0x2479900", VA = "0x18247A900")]
	public static global::BCDBKDCAIGH<T> ALNLLKAEKMD<T>(in T JLLFFGGFBGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x23E3050", Offset = "0x23E2050", VA = "0x1823E3050")]
	public static global::BCDBKDCAIGH<T> ALNLLKAEKMD<T>(in T JLLFFGGFBGE, int JFBJJBMIADJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FIHEJJJKBLL<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate bool AEHDGPNNFDN(global::FIHEJJJKBLL<T> EBOMLHHEIIO);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BAFIKALAOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::FIHEJJJKBLL<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public BAFIKALAOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3BF17E0", Offset = "0x3BF07E0", VA = "0x183BF17E0")]
		internal bool <FindNode>b__0(global::FIHEJJJKBLL<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T OLJIAJIIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::FIHEJJJKBLL<T>> NDKMFIMONJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::FIHEJJJKBLL<T> BMGLDJNPNLG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::FIHEJJJKBLL<T> ALEKIJIAINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5AF900", Offset = "0x5AE900", VA = "0x1805AF900")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA830", Offset = "0x3BF9830", VA = "0x183BFA830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NGENJNFLPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8D40", Offset = "0x3BF7D40", VA = "0x183BF8D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NLLIAJNELEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA7B0", Offset = "0x3BF97B0", VA = "0x183BFA7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::FIHEJJJKBLL<T> AALDJPJFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3BF97E0", Offset = "0x3BF87E0", VA = "0x183BF97E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB2F0", Offset = "0x3BFA2F0", VA = "0x183BFB2F0")]
	public FIHEJJJKBLL(T BBLCALGMNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3BF93F0", Offset = "0x3BF83F0", VA = "0x183BF93F0")]
	public global::FIHEJJJKBLL<T> BHACCJIAAGO(T MMLDEJLEJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3BFABB0", Offset = "0x3BF9BB0", VA = "0x183BFABB0")]
	public global::FIHEJJJKBLL<T> IMIGGCPIGHM(T PFALCFELBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAE10", Offset = "0x3BF9E10", VA = "0x183BFAE10")]
	public global::FIHEJJJKBLL<T> KOAAEEDJIKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9AC0", Offset = "0x3BF8AC0", VA = "0x183BF9AC0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9600", Offset = "0x3BF8600", VA = "0x183BF9600")]
	public global::FIHEJJJKBLL<T> DLEJDANJMEH(T JKGHBLOILEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF90B0", Offset = "0x3BF80B0", VA = "0x183BF90B0")]
	public static void ANPKFHIJEDN(global::FIHEJJJKBLL<T> DDAGEOGPLIN, AEHDGPNNFDN JAJHFLPIFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2788370", Offset = "0x2787370", VA = "0x182788370")]
	public static void ANPKFHIJEDN<A>(global::FIHEJJJKBLL<T> DDAGEOGPLIN, Func<global::FIHEJJJKBLL<T>, A, bool> JAJHFLPIFLP, A GIOKEMJBFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA270", Offset = "0x3BF9270", VA = "0x183BFA270")]
	public static string GCONPNENCGH(global::FIHEJJJKBLL<T> DDAGEOGPLIN, int EIIGHGIDAOK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAEC0", Offset = "0x3BF9EC0", VA = "0x183BFAEC0")]
	public static global::FIHEJJJKBLL<T> LGBLACEEJCP(global::FIHEJJJKBLL<T> DDAGEOGPLIN, T KGDIDBJEPHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NPPBDKHLLFI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate Task<TResult> CPNKGOBPDDK(TRequest MOLEAEHPOIL, CancellationToken LDBMCJENAKJ);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum ENKLDPJIDND
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class EJIMEEMHONA
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float LIPFMBOLBFE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan JNDALFLPMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int LAAINPLNEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ENKLDPJIDND HBPDBIILJJI;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly EJIMEEMHONA CJPEENBFOMB;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float KGCNIEJFNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x32C7F50", Offset = "0x32C6F50", VA = "0x1832C7F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan IMEMDJLDJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x32C7FC0", Offset = "0x32C6FC0", VA = "0x1832C7FC0")]
		public EJIMEEMHONA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private readonly struct PNADCNFMNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest MOLEAEHPOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken LDBMCJENAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> MFDAPHBCIGF;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x32D9780", Offset = "0x32D8780", VA = "0x1832D9780")]
		public PNADCNFMNAH(TRequest MOLEAEHPOIL, TaskCompletionSource<TResult> MFDAPHBCIGF, CancellationToken LDBMCJENAKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ODLALGBMNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public ODLALGBMNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2248810", Offset = "0x2247810", VA = "0x182248810")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PHFOHLGECMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::NPPBDKHLLFI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x32D8F40", Offset = "0x32D7F40", VA = "0x1832D8F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DE880", VA = "0x1807DF880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OFMOPDIAABB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public PNADCNFMNAH req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::NPPBDKHLLFI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public OFMOPDIAABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x32D8A30", Offset = "0x32D7A30", VA = "0x1832D8A30")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource HCJMLMHAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<PNADCNFMNAH> EJPIGNHCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly EJIMEEMHONA GDLPEMICMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly CPNKGOBPDDK GPDJHJPBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task AJIBENMPCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int KNJNDODMOEL;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x32D8270", Offset = "0x32D7270", VA = "0x1832D8270")]
	public NPPBDKHLLFI(CPNKGOBPDDK GPDJHJPBGLA, [Optional] EJIMEEMHONA GDLPEMICMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x32D74B0", Offset = "0x32D64B0", VA = "0x1832D74B0")]
	public Task<TResult> MIFOMHMOHHE(TRequest MOLEAEHPOIL, CancellationToken LDBMCJENAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x32D7FA0", Offset = "0x32D6FA0", VA = "0x1832D7FA0")]
	private void OPCFDHNEDOA(PNADCNFMNAH CLEJKBBJHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x32D7BD0", Offset = "0x32D6BD0", VA = "0x1832D7BD0")]
	[AsyncStateMachine(typeof(global::NPPBDKHLLFI<, >.PHFOHLGECMA))]
	private Task OJAJKNDFJNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x32D67A0", Offset = "0x32D57A0", VA = "0x1832D67A0")]
	private PNADCNFMNAH INEFJCNHCFH()
	{
		return default(PNADCNFMNAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x32D6EE0", Offset = "0x32D5EE0", VA = "0x1832D6EE0")]
	private void LIJGLOMPGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x32D6760", Offset = "0x32D5760", VA = "0x1832D6760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
public class BHOABEOGBKG<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate int FJNEKBEMDCA(TKey MNGGKJHHPNI, TVal DDDOLDGEMNC);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class DOFOBFHBIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey ABFANLOKOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal DPFBMCEIHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7466B0", Offset = "0x7456B0", VA = "0x1807466B0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x7A9010", Offset = "0x7A8010", VA = "0x1807A9010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int LABKDOAMNAE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5CCC50", Offset = "0x5CBC50", VA = "0x1805CCC50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x59CE50", Offset = "0x59BE50", VA = "0x18059CE50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime DDDBGMKCJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x76D6F0", Offset = "0x76C6F0", VA = "0x18076D6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x33F41F0", Offset = "0x33F31F0", VA = "0x1833F41F0")]
		public DOFOBFHBIAJ(TKey MNGGKJHHPNI, TVal IKMEOANGHEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int LIBMJAKNELN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<DOFOBFHBIAJ>> PMCPCLMDNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<DOFOBFHBIAJ> KDIFAJPGIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly FJNEKBEMDCA KNNILPKNGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan NLMOGFDOPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DBGLEIENLGM NLBCKBGHOCM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CJAONJFIKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5109D0", Offset = "0x50F9D0", VA = "0x1805109D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool JIPIFPNCLON
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x33F2F40", Offset = "0x33F1F40", VA = "0x1833F2F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int BPMFINPLMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x78AF30", Offset = "0x789F30", VA = "0x18078AF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x768120", Offset = "0x767120", VA = "0x180768120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2333B30", Offset = "0x2332B30", VA = "0x182333B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> PFKPHBMLJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x33F22C0", Offset = "0x33F12C0", VA = "0x1833F22C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x27D4790", Offset = "0x27D3790", VA = "0x1827D4790")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x33F2FD0", Offset = "0x33F1FD0", VA = "0x1833F2FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x33F39D0", Offset = "0x33F29D0", VA = "0x1833F39D0")]
	public BHOABEOGBKG(int NBDFKNGGAPC, [Optional] FJNEKBEMDCA KNNILPKNGLN, [Optional] IEqualityComparer<TKey> AGLOMLJFLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x33F3CF0", Offset = "0x33F2CF0", VA = "0x1833F3CF0")]
	public BHOABEOGBKG(TimeSpan NLMOGFDOPHN, [Optional] IEqualityComparer<TKey> AGLOMLJFLLJ, [Optional] DBGLEIENLGM NLBCKBGHOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x33F3E10", Offset = "0x33F2E10", VA = "0x1833F3E10")]
	public BHOABEOGBKG(int NBDFKNGGAPC, TimeSpan NLMOGFDOPHN, [Optional] IEqualityComparer<TKey> AGLOMLJFLLJ, [Optional] DBGLEIENLGM NLBCKBGHOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x33F3AA0", Offset = "0x33F2AA0", VA = "0x1833F3AA0")]
	public BHOABEOGBKG(int NBDFKNGGAPC, FJNEKBEMDCA KNNILPKNGLN, TimeSpan NLMOGFDOPHN, [Optional] IEqualityComparer<TKey> AGLOMLJFLLJ, [Optional] DBGLEIENLGM NLBCKBGHOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x33F2150", Offset = "0x33F1150", VA = "0x1833F2150")]
	public void CJOBEOHEECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x33F3850", Offset = "0x33F2850", VA = "0x1833F3850")]
	public void NOIJBADHPIF(TKey MNGGKJHHPNI, TVal DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x33F3000", Offset = "0x33F2000", VA = "0x1833F3000")]
	public bool KOAAEEDJIKB(TKey MNGGKJHHPNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x33F2090", Offset = "0x33F1090", VA = "0x1833F2090")]
	private TVal AKCFEJPPDDL(TKey LEFPHHIFKFD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x33F32E0", Offset = "0x33F22E0", VA = "0x1833F32E0")]
	public bool MMEDHLOPCHO(TKey LEFPHHIFKFD, out TVal DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x33F2D40", Offset = "0x33F1D40", VA = "0x1833F2D40")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x33F2DC0", Offset = "0x33F1DC0", VA = "0x1833F2DC0")]
	private bool HBMFJFBKHCG(DOFOBFHBIAJ NFHEHHDPCJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x33F2820", Offset = "0x33F1820", VA = "0x1833F2820")]
	private void FAJPNMBLJMJ(LinkedListNode<DOFOBFHBIAJ> ODPCPAMPODH, TVal FOMAGDONKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x33F3640", Offset = "0x33F2640", VA = "0x1833F3640")]
	private void NGMGLNDNHJK(TKey MNGGKJHHPNI, TVal DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x33F2680", Offset = "0x33F1680", VA = "0x1833F2680")]
	private void DFBHFFPIHHD(DOFOBFHBIAJ NFHEHHDPCJI, TVal FOMAGDONKAD, int EMBLGPGFDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class KJNPDLAMFGH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> KALOMCOIBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> FJBJBFBLBLL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2248810", Offset = "0x2247810", VA = "0x182248810", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HBLMAKKNPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5358A0", Offset = "0x5348A0", VA = "0x1805358A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x27DC100", Offset = "0x27DB100", VA = "0x1827DC100", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x27DC1F0", Offset = "0x27DB1F0", VA = "0x1827DC1F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x27DB800", Offset = "0x27DA800", VA = "0x1827DB800", Slot = "11")]
	public void Add(T KNAIIFKDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x27DBCA0", Offset = "0x27DACA0", VA = "0x1827DBCA0")]
	public bool NGHONFINKGC(T KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x27DBF10", Offset = "0x27DAF10", VA = "0x1827DBF10", Slot = "15")]
	public bool Remove(T KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x24404D0", Offset = "0x243F4D0", VA = "0x1824404D0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x23CB190", Offset = "0x23CA190", VA = "0x1823CB190", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x27DB830", Offset = "0x27DA830", VA = "0x1827DB830", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x243C9D0", Offset = "0x243B9D0", VA = "0x18243C9D0", Slot = "13")]
	public bool Contains(T KNAIIFKDFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x27DB890", Offset = "0x27DA890", VA = "0x1827DB890", Slot = "14")]
	public void CopyTo(T[] ABDMDAMADHK, int NEMDNDOFKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x27D4AF0", Offset = "0x27D3AF0", VA = "0x1827D4AF0", Slot = "6")]
	public int IndexOf(T KNAIIFKDFLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x27DBA60", Offset = "0x27DAA60", VA = "0x1827DBA60", Slot = "7")]
	public void Insert(int IDCLMAKCIEP, T KNAIIFKDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x27DBD70", Offset = "0x27DAD70", VA = "0x1827DBD70", Slot = "8")]
	public void RemoveAt(int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x27DB8C0", Offset = "0x27DA8C0", VA = "0x1827DB8C0")]
	public void EALIBFGFMBO(Predicate<T> DHNKJAFMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x27DBD40", Offset = "0x27DAD40", VA = "0x1827DBD40")]
	public void OCHPPJBOLCF(Comparison<T> EIINELGIMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x27DC020", Offset = "0x27DB020", VA = "0x1827DC020")]
	public KJNPDLAMFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MKPIAMIHKEM
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4983EF0", Offset = "0x4982EF0", VA = "0x184983EF0")]
	public static Vector3 OKALBFLEEHO(this GameObject MNCBMNIPDNH, float PNGLIJPCCEE)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D5CE0", Offset = "0x5D4CE0", VA = "0x1805D5CE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4986060", Offset = "0x4985060", VA = "0x184986060")]
		public SerializedGuid(in Guid CJGGLKPKMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4985C40", Offset = "0x4984C40", VA = "0x184985C40")]
		public static SerializedGuid CCAJCCNJPLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4985CF0", Offset = "0x4984CF0", VA = "0x184985CF0")]
		public static SerializedGuid DPJCBEIOOKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4985BB0", Offset = "0x4984BB0", VA = "0x184985BB0")]
		public bool BIHNCPFNCND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4986030", Offset = "0x4985030", VA = "0x184986030", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4985F90", Offset = "0x4984F90", VA = "0x184985F90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4985EF0", Offset = "0x4984EF0", VA = "0x184985EF0")]
		public bool GOHNAOFJIKF(in Guid CJGGLKPKMIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4985D70", Offset = "0x4984D70", VA = "0x184985D70", Slot = "7")]
		public bool Equals(SerializedGuid AGELLNNPMJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4985E10", Offset = "0x4984E10", VA = "0x184985E10", Slot = "0")]
		public override bool Equals(object CKMKLMKNMPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4985F80", Offset = "0x4984F80", VA = "0x184985F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4985CC0", Offset = "0x4984CC0", VA = "0x184985CC0", Slot = "6")]
		public int CompareTo(SerializedGuid AGELLNNPMJB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DGNNCPNFDLA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type JLIECAMBHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string CPMGNOFHBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool MGLEBOIMIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool CMPHNHLKCPF;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x49820E0", Offset = "0x49810E0", VA = "0x1849820E0")]
	public DGNNCPNFDLA(Type NPAOCMCIOOK, string JLDEEABAHKB, bool GGFACPIPEFE = false, bool AGAHLKNFKMC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface EDNOOGGECGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IIEPHOLNPDJ<T> : EDNOOGGECGB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool PJECEEMMOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string EDNJJAKPFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::IIEPHOLNPDJ<T> BPNICLOPDDL(Action<T> LBGDHBAMLDH);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::IIEPHOLNPDJ<T> PFNMMGDCHEC(Action<T> LBGDHBAMLDH);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::IIEPHOLNPDJ<T> DFBEOJJNFKK(Action<T, T> GGIFDILLEIP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::IIEPHOLNPDJ<T> PEAMOMPEKJA(Action<T, T> GGIFDILLEIP);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::IIEPHOLNPDJ<T> LHMLEPICACG(Action<string> NLGPBDHBMGO);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::IIEPHOLNPDJ<T> EDMLKABAJOP(Action<string> NLGPBDHBMGO);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LPOAGENPNOL<T> : global::IIEPHOLNPDJ<T>, EDNOOGGECGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::ELGGIAFFIHI<T, T> LAPFDBFGJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::ILGGPDMEKNN<T> JGGNHCNODKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::ILGGPDMEKNN<string> CKDDPHCLJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string ILMCLHHHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T EJBMJHIBKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool FBJEKEDKLPP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x27CF290", Offset = "0x27CE290", VA = "0x1827CF290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PJECEEMMOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x607D60", Offset = "0x606D60", VA = "0x180607D60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string EDNJJAKPFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x511460", Offset = "0x510460", VA = "0x180511460", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3047BC0", Offset = "0x3046BC0", VA = "0x183047BC0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D86360", Offset = "0x3D85360", VA = "0x183D86360")]
	private void JOBKHMBJALH(T PHBBFAJNGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D86490", Offset = "0x3D85490", VA = "0x183D86490")]
	private void NIODCAALFDN(string HBPJACFNCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D862B0", Offset = "0x3D852B0", VA = "0x183D862B0")]
	public void ILOGKMIJNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3D861F0", Offset = "0x3D851F0", VA = "0x183D861F0", Slot = "6")]
	public global::IIEPHOLNPDJ<T> DFBEOJJNFKK(Action<T, T> GGIFDILLEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3D86530", Offset = "0x3D85530", VA = "0x183D86530", Slot = "7")]
	public global::IIEPHOLNPDJ<T> PEAMOMPEKJA(Action<T, T> GGIFDILLEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3D86160", Offset = "0x3D85160", VA = "0x183D86160", Slot = "4")]
	public global::IIEPHOLNPDJ<T> BPNICLOPDDL(Action<T> GGIFDILLEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D86580", Offset = "0x3D85580", VA = "0x183D86580", Slot = "5")]
	public global::IIEPHOLNPDJ<T> PFNMMGDCHEC(Action<T> LBGDHBAMLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D86400", Offset = "0x3D85400", VA = "0x183D86400", Slot = "8")]
	public global::IIEPHOLNPDJ<T> LHMLEPICACG(Action<string> NLGPBDHBMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D86240", Offset = "0x3D85240", VA = "0x183D86240", Slot = "9")]
	public global::IIEPHOLNPDJ<T> EDMLKABAJOP(Action<string> NLGPBDHBMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D865D0", Offset = "0x3D855D0", VA = "0x183D865D0")]
	public LPOAGENPNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FOFLGKKMOPI
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FLEGHHCDHPE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::IIEPHOLNPDJ<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::IMHPNJHAAJB<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public FLEGHHCDHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C29C00", Offset = "0x3C28C00", VA = "0x183C29C00")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x225CC40", Offset = "0x225BC40", VA = "0x18225CC40")]
	public static global::HMPJDJAALAE<T> EIIBODMFAOH<T>(this global::IIEPHOLNPDJ<T> IEDMGLHHDHF, Action<T> FNJEPDKDNHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class DBGLEIENLGM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CLODILKMKEA : DBGLEIENLGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static DBGLEIENLGM BBILGMKNANF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x49818A0", Offset = "0x49808A0", VA = "0x1849818A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime HGMJHFHKBKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4981900", Offset = "0x4980900", VA = "0x184981900", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float HBLIIPOMEHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4980300", Offset = "0x497F300", VA = "0x184980300", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x49819F0", Offset = "0x49809F0", VA = "0x1849819F0")]
		public CLODILKMKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static DBGLEIENLGM GLAPFIOILII;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static DBGLEIENLGM CJPEENBFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4981F60", Offset = "0x4980F60", VA = "0x184981F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime HGMJHFHKBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float HBLIIPOMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected DBGLEIENLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LPNIEEAHPHB : global::OMCFNNKCFBF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4983EB0", Offset = "0x4982EB0", VA = "0x184983EB0")]
	public LPNIEEAHPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class OMCFNNKCFBF<T> : global::JBOMGFGLCBF<T>, KJBFLHGEELG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> HGLBEJIOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task KMMABOEAIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2244BF0", Offset = "0x2243BF0", VA = "0x182244BF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::HMPJDJAALAE<T> HEOIKHIEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private EJLKCPFELBD OGDCEDNAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x22469D0", Offset = "0x22459D0", VA = "0x1822469D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x366EEA0", Offset = "0x366DEA0", VA = "0x18366EEA0")]
	public OMCFNNKCFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NJOEOPLHHLL : global::JKBOHPFFMNA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4984230", Offset = "0x4983230", VA = "0x184984230")]
	public NJOEOPLHHLL(Exception KFHJIBPHHGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JKBOHPFFMNA<T> : global::JBOMGFGLCBF<T>, KJBFLHGEELG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> HGLBEJIOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task KMMABOEAIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2244BF0", Offset = "0x2243BF0", VA = "0x182244BF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::HMPJDJAALAE<T> HEOIKHIEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private EJLKCPFELBD OGDCEDNAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x22469D0", Offset = "0x22459D0", VA = "0x1822469D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x25089F0", Offset = "0x25079F0", VA = "0x1825089F0")]
	public JKBOHPFFMNA(Exception KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KJBFLHGEELG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task HGLBEJIOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	EJLKCPFELBD HEOIKHIEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface JBOMGFGLCBF<T> : KJBFLHGEELG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> HGLBEJIOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::HMPJDJAALAE<T> HEOIKHIEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class BKKLGJLCBOF<TTask, T> : global::JBOMGFGLCBF<T>, KJBFLHGEELG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HDGBLOMDNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::BKKLGJLCBOF<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public HDGBLOMDNCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool FMJFPHLBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> LBOLAOAOLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource LAGABIEPICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool CGMMHFJBPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext BOBNMLCGNEB;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> HGLBEJIOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task KMMABOEAIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::HMPJDJAALAE<T> HEOIKHIEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private EJLKCPFELBD OGDCEDNAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x23CA990", Offset = "0x23C9990", VA = "0x1823CA990", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool KPNGFEOILIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x606E40", Offset = "0x605E40", VA = "0x180606E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x25F6A00", Offset = "0x25F5A00", VA = "0x1825F6A00")]
	static BKKLGJLCBOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x25F6D20", Offset = "0x25F5D20", VA = "0x1825F6D20")]
	protected BKKLGJLCBOF(TTask LBOLAOAOLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x25F6700", Offset = "0x25F5700", VA = "0x1825F6700", Slot = "1")]
	~BKKLGJLCBOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x25F63F0", Offset = "0x25F53F0", VA = "0x1825F63F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x25F6590", Offset = "0x25F5590", VA = "0x1825F6590")]
	private void ELGBEGHMCDN(bool EPBGLEPGAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T EEKENLAECIA(TTask JIMAJGNFPIN);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JOLFJHHJBLB();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x25F6840", Offset = "0x25F5840", VA = "0x1825F6840")]
	[CompilerGenerated]
	private void MJGKOHDAING(object FAFNNELAHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GPGHFEENJOB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type JLIECAMBHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string CPMGNOFHBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool MGLEBOIMIJM;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x49828A0", Offset = "0x49818A0", VA = "0x1849828A0")]
	public GPGHFEENJOB(Type NPAOCMCIOOK, string JLDEEABAHKB, bool GGFACPIPEFE = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x50D010", Offset = "0x50C010", VA = "0x18050D010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x559080", Offset = "0x558080", VA = "0x180559080")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int JBBLPPAEOAH, int HBDJNODOPPF]
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2245180", Offset = "0x2244180", VA = "0x182245180")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2245220", Offset = "0x2244220", VA = "0x182245220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x22450F0", Offset = "0x22440F0", VA = "0x1822450F0")]
		public Array2D(uint AGCGFKAOCBO, uint DGPMNFKJNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2245070", Offset = "0x2244070", VA = "0x182245070")]
		public void FLOPBJIDDIH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x49808E0", Offset = "0x497F8E0", VA = "0x1849808E0")]
		public Array2DVector3(uint AGCGFKAOCBO, uint DGPMNFKJNDI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KIPNNGHJCML
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private enum GNMLDMJFDKG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int HEPEMBAMNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool EICICNCHAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private GNMLDMJFDKG JCCPBFJMFHH;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool KNCANGKPIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x4983150", Offset = "0x4982150", VA = "0x184983150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DLPNCKDPJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x49832D0", Offset = "0x49822D0", VA = "0x1849832D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4983E80", Offset = "0x4982E80", VA = "0x184983E80")]
	public KIPNNGHJCML(bool EICICNCHAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x49838B0", Offset = "0x49828B0", VA = "0x1849838B0")]
	public void MMNKFKPJJIB(object CKMKLMKNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x49830A0", Offset = "0x49820A0", VA = "0x1849830A0")]
	public void BDACFCPLECG(int DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4983870", Offset = "0x4982870", VA = "0x184983870")]
	public void FGOHFKJJCFN(uint KNHKNKGNHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4983890", Offset = "0x4982890", VA = "0x184983890")]
	public void LGELCHKNDAA(bool PBDEPPLMJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4983DD0", Offset = "0x4982DD0", VA = "0x184983DD0")]
	public void NKLHCPMEHHC(long DJJNCHOCFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4983830", Offset = "0x4982830", VA = "0x184983830")]
	public void FFHACHPPICJ(ulong GKBMJJOOCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4983260", Offset = "0x4982260", VA = "0x184983260")]
	public void DAEMAEJLMKK(string GKPLHBJICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x49831D0", Offset = "0x49821D0", VA = "0x1849831D0")]
	public void COFNJGOMMDJ(Enum KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4983710", Offset = "0x4982710", VA = "0x184983710")]
	public void FDLMBLACDMB(IList KALOMCOIBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x31C2FC0", Offset = "0x31C1FC0", VA = "0x1831C2FC0")]
	public void FKDLHKDKHMM<T, U>(Dictionary<T, U> LHJKLEHEOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4983350", Offset = "0x4982350", VA = "0x184983350")]
	private void EFEBGNELLLK(IDictionary LHJKLEHEOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4983160", Offset = "0x4982160", VA = "0x184983160")]
	public int CEPMILFMFIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x49832E0", Offset = "0x49822E0", VA = "0x1849832E0")]
	public short EFBKMBIAEPM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4983880", Offset = "0x4982880", VA = "0x184983880")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4983E10", Offset = "0x4982E10", VA = "0x184983E10")]
	private void OOCCABFKOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class AJPAJILHMJB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal class BGAAGDEANKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public TNode ANALFBKHBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TNode OACJHOOKBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public EELEKMNOADE FFILKFELCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<EELEKMNOADE> NDOBLLBDMPM;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public BGAAGDEANKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal struct EELEKMNOADE : IComparable<EELEKMNOADE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int CLDONMOJFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public TClaimant DKDEEODNCBO;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x53D690", Offset = "0x53C690", VA = "0x18053D690")]
		public EELEKMNOADE(int CLDONMOJFNE, TClaimant DKDEEODNCBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3B74FD0", Offset = "0x3B73FD0", VA = "0x183B74FD0")]
		public bool CAFCOEPOJJK(in EELEKMNOADE AGELLNNPMJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3B75040", Offset = "0x3B74040", VA = "0x183B75040")]
		public bool POAPAJKIMCM(in EELEKMNOADE AGELLNNPMJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3B75030", Offset = "0x3B74030", VA = "0x183B75030", Slot = "4")]
		public int CompareTo(EELEKMNOADE AGELLNNPMJB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3B75050", Offset = "0x3B74050", VA = "0x183B75050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum EEGPEAPJDOG
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MPAAALAPHHN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public global::AJPAJILHMJB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3860", Offset = "0x2BB2860", VA = "0x182BB3860")]
		[DebuggerHidden]
		public MPAAALAPHHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3B81420", Offset = "0x3B80420", VA = "0x183B81420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3B815E0", Offset = "0x3B805E0", VA = "0x183B815E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3B81500", Offset = "0x3B80500", VA = "0x183B81500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2255DA0", Offset = "0x2254DA0", VA = "0x182255DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly global::DOMLPKKGMON<BGAAGDEANKH> BACHGBNGMCN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly global::DOMLPKKGMON<List<EELEKMNOADE>> AFPPHMLOJLE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static int FEDIEILPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	internal readonly Dictionary<TClaimant, TNode> DBBAOMMHFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	internal readonly Dictionary<TNode, BGAAGDEANKH> DGMDIODFGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EEGPEAPJDOG MKIOPHCNOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool AHAOHHHDIIJ;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FEJGHAKOGBJ(TNode EBOMLHHEIIO);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EAAONLDPIMM(TNode EBOMLHHEIIO, TClaimant BCOKMLLKKNC, TClaimant IICHJOJKCLP);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3B70150", Offset = "0x3B6F150", VA = "0x183B70150")]
	public AJPAJILHMJB(EEGPEAPJDOG MKIOPHCNOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EB60", Offset = "0x3B6DB60", VA = "0x183B6EB60")]
	public void CCNKDOMMOJB(TNode EBOMLHHEIIO, TNode JKGHBLOILEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FA20", Offset = "0x3B6EA20", VA = "0x183B6FA20")]
	public void LOEMNANJNOB(TClaimant DKDEEODNCBO, TNode KELOBEPBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EC80", Offset = "0x3B6DC80", VA = "0x183B6EC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EBE0", Offset = "0x3B6DBE0", VA = "0x183B6EBE0")]
	private void DAKEEEJPGEM(TClaimant DKDEEODNCBO, TNode HLGGOBGODAE, TNode KELOBEPBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EEE0", Offset = "0x3B6DEE0", VA = "0x183B6EEE0")]
	private int EHICMEKPKMH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F630", Offset = "0x3B6E630", VA = "0x183B6F630")]
	private void JDEGAEDPGGG(TClaimant DKDEEODNCBO, TNode POPDOBDOAKB, TNode NNGAIPFOCLA, int MKGLHDGHBBL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FB20", Offset = "0x3B6EB20", VA = "0x183B6FB20")]
	private void MBAAGJMCEKB(EELEKMNOADE FGLNGMIDPNF, BGAAGDEANKH PBJKKJLPLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E8F0", Offset = "0x3B6D8F0", VA = "0x183B6E8F0")]
	private void BHALPFFFPEE(TClaimant DKDEEODNCBO, TNode POPDOBDOAKB, TNode NNGAIPFOCLA, int MKGLHDGHBBL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F530", Offset = "0x3B6E530", VA = "0x183B6F530")]
	private void IIOCACNDBIG(EELEKMNOADE FGLNGMIDPNF, TNode EBOMLHHEIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3B6EF50", Offset = "0x3B6DF50", VA = "0x183B6EF50")]
	private void FCLGBIAHAIM(EELEKMNOADE FGLNGMIDPNF, BGAAGDEANKH PBJKKJLPLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F8E0", Offset = "0x3B6E8E0", VA = "0x183B6F8E0")]
	private void JJALCGALDPD(BGAAGDEANKH PBJKKJLPLJE, bool KNOHEIIFECN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FBB0", Offset = "0x3B6EBB0", VA = "0x183B6FBB0")]
	private void OFDJDKAHOHL(BGAAGDEANKH PBJKKJLPLJE, TNode JKGHBLOILEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F050", Offset = "0x3B6E050", VA = "0x183B6F050")]
	[IteratorStateMachine(typeof(global::AJPAJILHMJB<, >.MPAAALAPHHN))]
	private IEnumerable<TNode> FHKFAADGAON(TNode POPDOBDOAKB, TNode NNGAIPFOCLA, bool MJBJNEDCPCH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F470", Offset = "0x3B6E470", VA = "0x183B6F470")]
	private BGAAGDEANKH HLHDEMDBJDN(TNode EBOMLHHEIIO, TNode OACJHOOKBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F2E0", Offset = "0x3B6E2E0", VA = "0x183B6F2E0")]
	private BGAAGDEANKH HAOPOALOBIJ(TNode EBOMLHHEIIO, TNode OACJHOOKBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6F120", Offset = "0x3B6E120", VA = "0x183B6F120")]
	private void FIANLKNKOOJ(BGAAGDEANKH PBJKKJLPLJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EHDFCJCEGGB<T> : IEnumerable<global::EHDFCJCEGGB<T>.NFCLDJHHLJC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct NFCLDJHHLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public T DDDOLDGEMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int IDCLMAKCIEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class AJGDIOHPPJK : IEnumerator<NFCLDJHHLJC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private global::EHDFCJCEGGB<T> FENCLDBGIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int IDCLMAKCIEP;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x29B97E0", Offset = "0x29B87E0", VA = "0x1829B97E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public NFCLDJHHLJC KDFGEPIKDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x37DEE60", Offset = "0x37DDE60", VA = "0x1837DEE60", Slot = "4")]
			get
			{
				return default(NFCLDJHHLJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D970", Offset = "0xA5C970", VA = "0x180A5D970")]
		public AJGDIOHPPJK(global::EHDFCJCEGGB<T> FENCLDBGIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x37DEDD0", Offset = "0x37DDDD0", VA = "0x1837DEDD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x804900", Offset = "0x803900", VA = "0x180804900", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9A77D0", Offset = "0x9A67D0", VA = "0x1809A77D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private struct FMFDJILLAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool CIDPDMMNIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public T DDDOLDGEMNC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private const int BPDHGJDNIND = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Dictionary<T, int> DKJEKJLHCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private FMFDJILLAML[] KJHGGKFIMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int MFLIPKGBNPK;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2509090", Offset = "0x2508090", VA = "0x182509090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x37E7D80", Offset = "0x37E6D80", VA = "0x1837E7D80")]
	public static global::EHDFCJCEGGB<T> EFNMLJAHHOF(NFCLDJHHLJC[] CKLBMPMIGKJ, bool CADCDGECHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x37E8720", Offset = "0x37E7720", VA = "0x1837E8720")]
	public EHDFCJCEGGB(int NBDFKNGGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2440470", Offset = "0x243F470", VA = "0x182440470")]
	public bool KKJFKKBAPGN(T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x37E8350", Offset = "0x37E7350", VA = "0x1837E8350")]
	public bool LCGOHCEICFB(int IDCLMAKCIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x37E7CD0", Offset = "0x37E6CD0", VA = "0x1837E7CD0")]
	public bool DHMIPJBINIK(Func<T, bool> DALENJJNDIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x37E7B10", Offset = "0x37E6B10", VA = "0x1837E7B10")]
	public int ANILCOJHJGJ(T DDDOLDGEMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x37E8160", Offset = "0x37E7160", VA = "0x1837E8160")]
	public T EIIBODMFAOH(int IDCLMAKCIEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x37E8280", Offset = "0x37E7280", VA = "0x1837E8280")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x37E83B0", Offset = "0x37E73B0", VA = "0x1837E83B0")]
	public bool NGHONFINKGC(T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x37E83D0", Offset = "0x37E73D0", VA = "0x1837E83D0")]
	public bool NGHONFINKGC(T DDDOLDGEMNC, int IDCLMAKCIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x37E82D0", Offset = "0x37E72D0", VA = "0x1837E82D0")]
	public bool KOAAEEDJIKB(T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x37E8600", Offset = "0x37E7600", VA = "0x1837E8600")]
	public bool PGLBIPMLLHA(int IDCLMAKCIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x37E81D0", Offset = "0x37E71D0", VA = "0x1837E81D0")]
	private void EKHMDMBGKCO(int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x37E7B60", Offset = "0x37E6B60", VA = "0x1837E7B60")]
	public NFCLDJHHLJC[] BKKHKMDGMEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x37E8650", Offset = "0x37E7650", VA = "0x1837E8650")]
	private int PJCKPFICFPO(int JGPOOACBJKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x37E86A0", Offset = "0x37E76A0", VA = "0x1837E86A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x37E86A0", Offset = "0x37E76A0", VA = "0x1837E86A0", Slot = "4")]
	private IEnumerator<NFCLDJHHLJC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DOMLPKKGMON<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Stack<T> LHABLJIEIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly List<T> GDOJNEMLBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly int BBMICAFIFKB;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int GKDLBGNFGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x22448C0", Offset = "0x22438C0", VA = "0x1822448C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int PJMDNIPFIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x22471E0", Offset = "0x22461E0", VA = "0x1822471E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x37E0F70", Offset = "0x37DFF70", VA = "0x1837E0F70")]
	public static global::DOMLPKKGMON<T> EFCKGAFFAPJ(int NBDFKNGGAPC = 0, int BBMICAFIFKB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x37E0D90", Offset = "0x37DFD90", VA = "0x1837E0D90")]
	public static global::DOMLPKKGMON<T> CFEOGAPADPM(int NBDFKNGGAPC = 0, int BBMICAFIFKB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x37E16F0", Offset = "0x37E06F0", VA = "0x1837E16F0")]
	public DOMLPKKGMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x37E1560", Offset = "0x37E0560", VA = "0x1837E1560")]
	public DOMLPKKGMON(int NBDFKNGGAPC, int BBMICAFIFKB = int.MaxValue, bool PLJDMOPCIMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x37E10E0", Offset = "0x37E00E0", VA = "0x1837E10E0")]
	public T HGJCDOELOPB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x37E13F0", Offset = "0x37E03F0", VA = "0x1837E13F0")]
	public void LPEONJHPIFD(T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x37E0CD0", Offset = "0x37DFCD0", VA = "0x1837E0CD0")]
	private void AIPBENINOBE(T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x37E1210", Offset = "0x37E0210", VA = "0x1837E1210")]
	private void HPCOHPKNPDG(T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x37E1040", Offset = "0x37E0040", VA = "0x1837E1040")]
	[Conditional("DEBUG_BUILD")]
	private void ELMLLDKGAGD(T KEHOHFADGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x37E14B0", Offset = "0x37E04B0", VA = "0x1837E14B0")]
	[Conditional("DEBUG_BUILD")]
	private void OHLHMLBEMLD(T KEHOHFADGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x37E0E60", Offset = "0x37DFE60", VA = "0x1837E0E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x37E1230", Offset = "0x37E0230", VA = "0x1837E1230")]
	private void LEHCNFKCEJJ(IEnumerable<T> LOAJEDAGJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DMIKABFMLDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private Dictionary<int, T> KNFENIPMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private T PIAAPNKLHCK;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T NADFMKDCABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool BCJDKGDMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x37E0140", Offset = "0x37DF140", VA = "0x1837E0140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x37E03B0", Offset = "0x37DF3B0", VA = "0x1837E03B0")]
	public bool NGMGLNDNHJK(T DDDOLDGEMNC, int CLDONMOJFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x37E0320", Offset = "0x37DF320", VA = "0x1837E0320")]
	public bool KJDHIIBCHOE(int CLDONMOJFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x37DFE80", Offset = "0x37DEE80", VA = "0x1837DFE80")]
	public T BIAMEJHGJEA(int PMOGMKCHBJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x37E00E0", Offset = "0x37DF0E0", VA = "0x1837E00E0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x37E0180", Offset = "0x37DF180", VA = "0x1837E0180")]
	private bool JDPGBNBNHCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x37E0380", Offset = "0x37DF380", VA = "0x1837E0380")]
	public bool MMEDHLOPCHO(int CLDONMOJFNE, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x32CF4C0", Offset = "0x32CE4C0", VA = "0x1832CF4C0")]
	public DMIKABFMLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CBPPPMKMNFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	protected struct DPINFHCMHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public T DPFBMCEIHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int CPHMKPBKNEH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	protected readonly List<DPINFHCMHHL> JIOHNEPGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private T PGAJHIKBLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2248810", Offset = "0x2247810", VA = "0x182248810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x364F050", Offset = "0x364E050", VA = "0x18364F050")]
	public bool DHMIPJBINIK(T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x364F730", Offset = "0x364E730", VA = "0x18364F730")]
	public void ONGBLFOLDCH(T DDDOLDGEMNC, int CLDONMOJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x364F580", Offset = "0x364E580", VA = "0x18364F580")]
	public bool KOAAEEDJIKB(T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x364F4B0", Offset = "0x364E4B0", VA = "0x18364F4B0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x364F6A0", Offset = "0x364E6A0", VA = "0x18364F6A0")]
	public T OHLEJJJAKJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x364F510", Offset = "0x364E510", VA = "0x18364F510")]
	public T INEFJCNHCFH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x364F2A0", Offset = "0x364E2A0", VA = "0x18364F2A0")]
	private void FHAKGIDOCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x364F7D0", Offset = "0x364E7D0", VA = "0x18364F7D0")]
	public CBPPPMKMNFD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		[KOMIOHHCHBI(EOFKBLFJCEN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x49845C0", Offset = "0x49835C0", VA = "0x1849845C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x4984A90", Offset = "0x4983A90", VA = "0x184984A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x49848B0", Offset = "0x49838B0", VA = "0x1849848B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x4984C30", Offset = "0x4983C30", VA = "0x184984C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x4984480", Offset = "0x4983480", VA = "0x184984480")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x4984950", Offset = "0x4983950", VA = "0x184984950")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x4984770", Offset = "0x4983770", VA = "0x184984770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x49843E0", Offset = "0x49833E0", VA = "0x1849843E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface JKIPJLPLPBH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> : JKIPJLPLPBH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2258D80", Offset = "0x2257D80", VA = "0x182258D80", Slot = "4")]
		public virtual T AODDNKBDOGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CAPPKHPJAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<byte, HJPHGCCBGPG> BKFIHBMEAGL;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HJPHGCCBGPG EDIJFMFGFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 GPJAJOBPMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xBEFB80", Offset = "0xBEEB80", VA = "0x180BEFB80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x32C9860", Offset = "0x32C8860", VA = "0x1832C9860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 FHEDMKGONNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xABF020", Offset = "0xABE020", VA = "0x180ABF020")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xABF040", Offset = "0xABE040", VA = "0x180ABF040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 GMBJJGHMFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE9D4C0", Offset = "0xE9C4C0", VA = "0x180E9D4C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE9D4E0", Offset = "0xE9C4E0", VA = "0x180E9D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int JDPHKBLBMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x560120", Offset = "0x55F120", VA = "0x180560120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x586290", Offset = "0x585290", VA = "0x180586290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x4981380", Offset = "0x4980380", VA = "0x184981380")]
	public CAPPKHPJAJC(Bounds MFPOPOPPFHI, Vector2[] ELEIGDKFLCL, int IPMIEPDJFMJ, byte JGPOOACBJKE, float JMBGMADIJKH = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4980D10", Offset = "0x497FD10", VA = "0x184980D10")]
	public HJPHGCCBGPG HFFLLEEDFOK(byte IDCLMAKCIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4980D70", Offset = "0x497FD70", VA = "0x184980D70")]
	public void JDFGDANPCFI(Vector3 BENEFKIJBMF, float KEGAIKHOJPD, float NOKHFDCBAME, ref List<byte> NEBKKCEAEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4980BC0", Offset = "0x497FBC0", VA = "0x184980BC0")]
	public void EBOCHMCPDJN(HJPHGCCBGPG.ABCHAELKBAK NAIOCEPLBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x4980BE0", Offset = "0x497FBE0", VA = "0x184980BE0")]
	private HJPHGCCBGPG GBPMOCFJCNH(byte IDCLMAKCIEP, HJPHGCCBGPG.DBJJLABMOHI FIHNPFINAAD, HJPHGCCBGPG OACJHOOKBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4980E60", Offset = "0x497FE60", VA = "0x184980E60")]
	private void NBGMDKKHNHA(HJPHGCCBGPG OACJHOOKBCN, Vector2[] ELEIGDKFLCL, int FCCNBDKNHPF, int CALJFABBJDP, int INILDPNLGLM, int OBKKCFKBMPD, float JMBGMADIJKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HJPHGCCBGPG
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum DBJJLABMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum ABCHAELKBAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public byte JAMKKLOGDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 OCLAOCMLHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3 LABKDOAMNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3 DKNLDPPFILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public Vector3 AIFHCDJDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public DBJJLABMOHI KIFMMBKNOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public HJPHGCCBGPG ALEKIJIAINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public List<HJPHGCCBGPG> AJKGEGKPPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool EAAECOKPNLF;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4982D30", Offset = "0x4981D30", VA = "0x184982D30")]
	public HJPHGCCBGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4982CD0", Offset = "0x4981CD0", VA = "0x184982CD0")]
	public HJPHGCCBGPG(byte HJPPHGKEPAC, DBJJLABMOHI FIHNPFINAAD, HJPHGCCBGPG OACJHOOKBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4982900", Offset = "0x4981900", VA = "0x184982900")]
	public void BHACCJIAAGO(HJPHGCCBGPG MKIDMLPDLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30")]
	public void EBOCHMCPDJN(int MNGHKNAEEDL, ABCHAELKBAK NAIOCEPLBOK, int HGMMHCPJKKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4982A40", Offset = "0x4981A40", VA = "0x184982A40")]
	public void JDFGDANPCFI(List<byte> NEBKKCEAEJM, Vector3 BENEFKIJBMF, float KEGAIKHOJPD, float NOKHFDCBAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x49829A0", Offset = "0x49819A0", VA = "0x1849829A0")]
	public bool DNICFIEPGJN(Vector3 AFJNCPHDIHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4982A00", Offset = "0x4981A00", VA = "0x184982A00")]
	public bool FLIJCEKJLNP(Vector3 AFJNCPHDIHA, float NKMCJLLKKAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CBLDKJEANCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<T, object> CHHOFNJOBDF;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2454DE0", Offset = "0x2453DE0", VA = "0x182454DE0")]
	public bool BCJNHNBPFGH(T NPAEOAOPCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x364EDB0", Offset = "0x364DDB0", VA = "0x18364EDB0")]
	public bool BCJNHNBPFGH(T NPAEOAOPCBL, object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x364ED50", Offset = "0x364DD50", VA = "0x18364ED50")]
	public bool BCJNHNBPFGH(T NPAEOAOPCBL, object NCEHCDHJMLE, out object ECBKCEBADNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x364EE60", Offset = "0x364DE60", VA = "0x18364EE60")]
	public bool LMBBFAMFNFM(T NPAEOAOPCBL, object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x364EDF0", Offset = "0x364DDF0", VA = "0x18364EDF0")]
	public bool EIJDHLAHNIA(T NPAEOAOPCBL, object NCEHCDHJMLE, out object ECBKCEBADNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x364EEA0", Offset = "0x364DEA0", VA = "0x18364EEA0")]
	public bool LMBBFAMFNFM(T NPAEOAOPCBL, object NCEHCDHJMLE, out object ECBKCEBADNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x364EE30", Offset = "0x364DE30", VA = "0x18364EE30")]
	public void FJFOLBIMOMB(T NPAEOAOPCBL, object NCEHCDHJMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x364EF30", Offset = "0x364DF30", VA = "0x18364EF30")]
	public void OCDFFBPBBHI(T NPAEOAOPCBL, object NCEHCDHJMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x364EFD0", Offset = "0x364DFD0", VA = "0x18364EFD0")]
	public CBLDKJEANCJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct ACAOAJIABOH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private readonly List<Component> KALOMCOIBIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private readonly bool PKBOGHHAOBG;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8E7710", Offset = "0x8E6710", VA = "0x1808E7710")]
			public ACAOAJIABOH(List<Component> KALOMCOIBIJ, bool PKBOGHHAOBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2244770", Offset = "0x2243770", VA = "0x182244770")]
			public OAKEGLHHBDF<T> EMLPMGDEOEM()
			{
				return default(OAKEGLHHBDF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x22447E0", Offset = "0x22437E0", VA = "0x1822447E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x22447E0", Offset = "0x22437E0", VA = "0x1822447E0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct OAKEGLHHBDF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private readonly List<Component> KALOMCOIBIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private readonly bool PKBOGHHAOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int IDCLMAKCIEP;

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public T KDFGEPIKDBB
			{
				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x22550D0", Offset = "0x22540D0", VA = "0x1822550D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2255060", Offset = "0x2254060", VA = "0x182255060", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x22550A0", Offset = "0x22540A0", VA = "0x1822550A0")]
			public OAKEGLHHBDF(List<Component> KALOMCOIBIJ, bool PKBOGHHAOBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2254F90", Offset = "0x2253F90", VA = "0x182254F90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2254FA0", Offset = "0x2253FA0", VA = "0x182254FA0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2255050", Offset = "0x2254050", VA = "0x182255050", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x49868F0", Offset = "0x49858F0", VA = "0x1849868F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x49868B0", Offset = "0x49858B0", VA = "0x1849868B0")]
		public ToolHierarchyCache(GameObject COBDKPMOMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4986110", Offset = "0x4985110", VA = "0x184986110")]
		private void FHOGAAHHIBC(GameObject COBDKPMOMNJ, bool KCLNEKGCOGO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4986230", Offset = "0x4985230", VA = "0x184986230")]
		public static void FHOGAAHHIBC(GameObject COBDKPMOMNJ, ref ToolHierarchyCache PNNPHNHGHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4986780", Offset = "0x4985780", VA = "0x184986780")]
		public void OILNPCPIBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4986730", Offset = "0x4985730", VA = "0x184986730")]
		public void NCCCIPABNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2097240", Offset = "0x2096240", VA = "0x182097240")]
		public void FJADIMFFHHA<T>(Action<T> EDHAOFHJENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4986670", Offset = "0x4985670", VA = "0x184986670")]
		public Component MPEKNKJADIO(Type CIMKNKPILIM, bool PKBOGHHAOBG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2287AE0", Offset = "0x2286AE0", VA = "0x182287AE0")]
		public T MPEKNKJADIO<T>(bool PKBOGHHAOBG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x49865E0", Offset = "0x49855E0", VA = "0x1849865E0")]
		public ACAOAJIABOH<Component> MDADAKOFFCB(Type CIMKNKPILIM, bool PKBOGHHAOBG = false)
		{
			return default(ACAOAJIABOH<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x23EBBB0", Offset = "0x23EABB0", VA = "0x1823EBBB0")]
		public ACAOAJIABOH<T> MDADAKOFFCB<T>(bool PKBOGHHAOBG = false) where T : class
		{
			return default(ACAOAJIABOH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4986330", Offset = "0x4985330", VA = "0x184986330")]
		public List<Component> MAJCFPPCHLA(Type CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4986090", Offset = "0x4985090", VA = "0x184986090", Slot = "4")]
		public bool Equals(ToolHierarchyCache LLFMGCPPNJC, ToolHierarchyCache JPNAADDLLDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x49862C0", Offset = "0x49852C0", VA = "0x1849862C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CKMKLMKNMPC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CLENOHHKNMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private int NBDFKNGGAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private int JELCPAMKKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private List<T> HHCJEIKGCEK;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x22448C0", Offset = "0x22438C0", VA = "0x1822448C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T GDGIBHOEICN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x359D6F0", Offset = "0x359C6F0", VA = "0x18359D6F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public T FKPNKEOLBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x359D4C0", Offset = "0x359C4C0", VA = "0x18359D4C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public T DDFKEJFJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x359D570", Offset = "0x359C570", VA = "0x18359D570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x359D9F0", Offset = "0x359C9F0", VA = "0x18359D9F0")]
	public CLENOHHKNMH(int NBDFKNGGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x359D770", Offset = "0x359C770", VA = "0x18359D770")]
	public void ONGBLFOLDCH(T LEGKAPNNDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x359D5C0", Offset = "0x359C5C0", VA = "0x18359D5C0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x359D600", Offset = "0x359C600", VA = "0x18359D600")]
	public void HEAJGIHCNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x359D440", Offset = "0x359C440", VA = "0x18359D440")]
	public void CECBNBLLGLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class EHJDEGMJJHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool LIHCGFPAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Action EDHAOFHJENI;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public static EHJDEGMJJHJ NBOGPFMHJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x4982760", Offset = "0x4981760", VA = "0x184982760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool IJMNMBHIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5600F0", Offset = "0x55F0F0", VA = "0x1805600F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A27E0", Offset = "0x6A17E0", VA = "0x1806A27E0")]
	public EHJDEGMJJHJ(Action EDHAOFHJENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4982740", Offset = "0x4981740", VA = "0x184982740")]
	public void FAMKCJJIIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4982740", Offset = "0x4981740", VA = "0x184982740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class AGDOLJLBMHN
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30")]
	public static void PEFIANGAHGM(AMJHMPCPMEB PENHHPCICPN, string FGILMGMMKEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class NLKFMBDEMBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private struct KIIIPGNMNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int CPHMKPBKNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public T DPFBMCEIHFE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Dictionary<object, KIIIPGNMNAH> KNFENIPMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private T PIAAPNKLHCK;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public virtual T NADFMKDCABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xBEFB80", Offset = "0xBEEB80", VA = "0x180BEFB80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x32C9860", Offset = "0x32C8860", VA = "0x1832C9860", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool BCJDKGDMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x32C98E0", Offset = "0x32C88E0", VA = "0x1832C98E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public object JCAJMGJMGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x32CF1B0", Offset = "0x32CE1B0", VA = "0x1832CF1B0")]
	public bool NGMGLNDNHJK(T DDDOLDGEMNC, object NCEHCDHJMLE, int CLDONMOJFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x32CE5A0", Offset = "0x32CD5A0", VA = "0x1832CE5A0")]
	public bool KJDHIIBCHOE(object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x32CEB20", Offset = "0x32CDB20", VA = "0x1832CEB20")]
	public bool MMEDHLOPCHO(object NCEHCDHJMLE, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x32C97E0", Offset = "0x32C87E0", VA = "0x1832C97E0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x32CD140", Offset = "0x32CC140", VA = "0x1832CD140")]
	private bool JDPGBNBNHCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x32CF4C0", Offset = "0x32CE4C0", VA = "0x1832CF4C0")]
	public NLKFMBDEMBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class BBLELIBJCNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<object, float> KNFENIPMMMM;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float LHOHMKIFGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8400E0", Offset = "0x83F0E0", VA = "0x1808400E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x840100", Offset = "0x83F100", VA = "0x180840100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4980AD0", Offset = "0x497FAD0", VA = "0x184980AD0")]
	public void NGMGLNDNHJK(float DDDOLDGEMNC, object NCEHCDHJMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4980940", Offset = "0x497F940", VA = "0x184980940")]
	public void KJDHIIBCHOE(object NCEHCDHJMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x49809B0", Offset = "0x497F9B0", VA = "0x1849809B0")]
	private void MGCIEGGFDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4980B40", Offset = "0x497FB40", VA = "0x184980B40")]
	public BBLELIBJCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public sealed class AMJHMPCPMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class COPNOPENHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly string MNEFKCLLNDA;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private COPNOPENHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A2810", Offset = "0x6A1810", VA = "0x1806A2810")]
		public COPNOPENHJE(string MNEFKCLLNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x4981E80", Offset = "0x4980E80", VA = "0x184981E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NINJMCFLFAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public NINJMCFLFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x4984180", Offset = "0x4983180", VA = "0x184984180")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly HashSet<object> FFKEAOBGMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int KBDDGOIIEDF;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool HHDJPELGENM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x49805F0", Offset = "0x497F5F0", VA = "0x1849805F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x511440", Offset = "0x510440", VA = "0x180511440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4980680", Offset = "0x497F680", VA = "0x184980680")]
	public bool ONGBLFOLDCH(object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4980600", Offset = "0x497F600", VA = "0x184980600")]
	public bool KOAAEEDJIKB(object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4980530", Offset = "0x497F530", VA = "0x184980530")]
	public bool DHMIPJBINIK(object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4980590", Offset = "0x497F590", VA = "0x184980590")]
	public void EDGCNBBELGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4980700", Offset = "0x497F700", VA = "0x184980700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4980870", Offset = "0x497F870", VA = "0x184980870")]
	public AMJHMPCPMEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IPIPHMDJKIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct ECICIJKOHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float CJKEMOPKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public T DPFBMCEIHFE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Dictionary<object, ECICIJKOHCB> KNFENIPMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private T ODHGALMNBIO;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public virtual T DGMKENGEHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x14CD640", Offset = "0x14CC640", VA = "0x1814CD640", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x32C98B0", Offset = "0x32C88B0", VA = "0x1832C98B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public object BICOMALLBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool BCJDKGDMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3377C00", Offset = "0x3376C00", VA = "0x183377C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x337A140", Offset = "0x3379140", VA = "0x18337A140")]
	public bool NGMGLNDNHJK(T DDDOLDGEMNC, object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x33798F0", Offset = "0x33788F0", VA = "0x1833798F0")]
	public bool KJDHIIBCHOE(object NCEHCDHJMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x32C97E0", Offset = "0x32C87E0", VA = "0x1832C97E0")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3379AD0", Offset = "0x3378AD0", VA = "0x183379AD0")]
	public bool MMEDHLOPCHO(object NCEHCDHJMLE, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3379130", Offset = "0x3378130", VA = "0x183379130")]
	private bool JDPGBNBNHCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x337A3F0", Offset = "0x33793F0", VA = "0x18337A3F0")]
	public IPIPHMDJKIF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4982480", Offset = "0x4981480", VA = "0x184982480")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4982150", Offset = "0x4981150", VA = "0x184982150")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
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
