using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AJMMOKABBAD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D57B0", Offset = "0x5D49B0", VA = "0x1805D57B0")]
	public AJMMOKABBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC610", Offset = "0x4EFB810", VA = "0x184EFC610")]
	public byte[] BOHGHJPEDAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void GOGCEMELHOG(IncrementalHash GCMEFCLKGHN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86B6D0", Offset = "0x86A8D0", VA = "0x18086B6D0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
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
	[HFMMIMOILHL]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[HFMMIMOILHL]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4F01550", Offset = "0x4F00750", VA = "0x184F01550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F01510", Offset = "0x4F00710", VA = "0x184F01510")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F01590", Offset = "0x4F00790", VA = "0x184F01590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4F017A0", Offset = "0x4F009A0", VA = "0x184F017A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4F01710", Offset = "0x4F00910", VA = "0x184F01710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0710", VA = "0x1809F1510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBC1720", Offset = "0xBC0920", VA = "0x180BC1720")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4F014D0", Offset = "0x4F006D0", VA = "0x184F014D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4F01680", Offset = "0x4F00880", VA = "0x184F01680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4F00F00", Offset = "0x4F00100", VA = "0x184F00F00")]
	public void CopyBounds(SavedExtents EBJKBJMLDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4F01440", Offset = "0x4F00640", VA = "0x184F01440")]
	public void SetLocalSpaceBounds(Bounds CHNBBABKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64B480", Offset = "0x64A680", VA = "0x18064B480")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4F01430", Offset = "0x4F00630", VA = "0x184F01430")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4F00F30", Offset = "0x4F00130", VA = "0x184F00F30")]
	private void GLGLGIHFADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4F01200", Offset = "0x4F00400", VA = "0x184F01200")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F00940", Offset = "0x4EFFB40", VA = "0x184F00940")]
	public static void CalculateLocalBoundsFor(GameObject JMCMCLEMHIC, out Bounds CHNBBABKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F01140", Offset = "0x4F00340", VA = "0x184F01140")]
	private static void KJOLJMIJEFN(Bounds CJCOEBBKILK, Color MGJAENEOBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F01460", Offset = "0x4F00660", VA = "0x184F01460")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62BF10", Offset = "0x62B110", VA = "0x18062BF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "4")]
	public virtual void HAMNJPAHIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[AJMMOKABBAD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2670710", Offset = "0x266F910", VA = "0x182670710", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2670250", Offset = "0x266F450", VA = "0x182670250", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2670D10", Offset = "0x266FF10", VA = "0x182670D10")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IPDGKEBKDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public IPDGKEBKDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2605960", Offset = "0x2604B60", VA = "0x182605960")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[AJMMOKABBAD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2603180", Offset = "0x2602380", VA = "0x182603180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x26031B0", Offset = "0x26023B0", VA = "0x1826031B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x26030D0", Offset = "0x26022D0", VA = "0x1826030D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey DHDAEDILENC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2603100", Offset = "0x2602300", VA = "0x182603100", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2602FD0", Offset = "0x26021D0", VA = "0x182602FD0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2602830", Offset = "0x2601A30", VA = "0x182602830", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26021A0", Offset = "0x26013A0", VA = "0x1826021A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2601D70", Offset = "0x2600F70", VA = "0x182601D70", Slot = "14")]
	protected virtual string EFAJJCLHIAD(TKeyVal EKNCOOMMIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2601CE0", Offset = "0x2600EE0", VA = "0x182601CE0", Slot = "4")]
	public bool ContainsKey(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2602EC0", Offset = "0x26020C0", VA = "0x182602EC0", Slot = "5")]
	public bool TryGetValue(TKey DHDAEDILENC, out TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2601DA0", Offset = "0x2600FA0", VA = "0x182601DA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2601DA0", Offset = "0x2600FA0", VA = "0x182601DA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2602EF0", Offset = "0x26020F0", VA = "0x182602EF0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ALKBHCBCLGJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MPOIHEALIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public MPOIHEALIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2ED8840", Offset = "0x2ED7A40", VA = "0x182ED8840")]
		internal bool <GetSamples>b__0(global::LGPMOEDIABC<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float AEOJENCIEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float FPCIGHEDLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::LGPMOEDIABC<float, T>> APPGFBADLLO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int POOPDADDAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8930", Offset = "0x2EC7B30", VA = "0x182EC8930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9410", Offset = "0x2EC8610", VA = "0x182EC9410")]
	public ALKBHCBCLGJ(float OJLIBCNOFDE, float FJGBNFMEGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EC92B0", Offset = "0x2EC84B0", VA = "0x182EC92B0")]
	public bool OHJHJJHBODO(float ELGHJPPACJL, T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9030", Offset = "0x2EC8230", VA = "0x182EC9030")]
	public int IJJKDGPINPM(float ELGHJPPACJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EC89B0", Offset = "0x2EC7BB0", VA = "0x182EC89B0")]
	public IEnumerable<T> GGBGECNLMEH(float ELGHJPPACJL, [Optional] float? KNAMHKJMIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8880", Offset = "0x2EC7A80", VA = "0x182EC8880")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9090", Offset = "0x2EC8290", VA = "0x182EC9090")]
	private void KPLFBLKDCHL(float ELGHJPPACJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MDHHICBEAKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AJKCFECAJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T AMCKDLHOFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float JCODDMCJPJF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float HGOPEFIAOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> OGIDJINJCAE;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int IJELPFIHKCH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private AJKCFECAJIB[] IBNOFMOJNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int OOJHFGFFEBC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DANAMACIICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x942900", Offset = "0x941B00", VA = "0x180942900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x942990", Offset = "0x941B90", VA = "0x180942990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3020500", Offset = "0x301F700", VA = "0x183020500")]
	public MDHHICBEAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3020530", Offset = "0x301F730", VA = "0x183020530")]
	public MDHHICBEAKA(int GKFHLIDAILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30200A0", Offset = "0x301F2A0", VA = "0x1830200A0")]
	public void INLOBDHPAIC(float ELGHJPPACJL, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x301FF20", Offset = "0x301F120", VA = "0x18301FF20")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x30202F0", Offset = "0x301F4F0", VA = "0x1830202F0")]
	public bool LDMPHIMCDAE(float CHEHOELGGPO, float MIDFLJMIBAK, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3020180", Offset = "0x301F380", VA = "0x183020180")]
	public bool INNFGFJMKOF(float CHEHOELGGPO, float MIDFLJMIBAK, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x301FD90", Offset = "0x301EF90", VA = "0x18301FD90")]
	public void BDENLAEEOND(float CHEHOELGGPO, float MIDFLJMIBAK, List<T> AJBILMJPKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3020070", Offset = "0x301F270", VA = "0x183020070")]
	private int IMPEIIEPPAO(int JLPNMKCHHPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x301FEE0", Offset = "0x301F0E0", VA = "0x18301FEE0")]
	private void CHMFLLGAFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HGIFNDJAACP();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LKJAFGCJGOG(T EKPKCLNNFCJ, T NJJGMIMHBHM, float ELLGECINNIM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LMLLNBFLLIH(T PNLMJAPAHBD, float ELLGECINNIM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JAPPOMGBPML(T EKPKCLNNFCJ, T NJJGMIMHBHM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MEFAANDJMNK(T EKPKCLNNFCJ, T NJJGMIMHBHM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HAACAHEBIOD : global::MDHHICBEAKA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC2C0", Offset = "0x4EFB4C0", VA = "0x184EFC2C0", Slot = "4")]
	protected override Vector3 HGIFNDJAACP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC3E0", Offset = "0x4EFB5E0", VA = "0x184EFC3E0", Slot = "5")]
	protected override Vector3 LKJAFGCJGOG(Vector3 EKPKCLNNFCJ, Vector3 NJJGMIMHBHM, float ELLGECINNIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC4A0", Offset = "0x4EFB6A0", VA = "0x184EFC4A0", Slot = "6")]
	protected override Vector3 LMLLNBFLLIH(Vector3 PNLMJAPAHBD, float ELLGECINNIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC330", Offset = "0x4EFB530", VA = "0x184EFC330", Slot = "7")]
	protected override Vector3 JAPPOMGBPML(Vector3 EKPKCLNNFCJ, Vector3 NJJGMIMHBHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC540", Offset = "0x4EFB740", VA = "0x184EFC540", Slot = "8")]
	protected override Vector3 MEFAANDJMNK(Vector3 EKPKCLNNFCJ, Vector3 NJJGMIMHBHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC5B0", Offset = "0x4EFB7B0", VA = "0x184EFC5B0")]
	public HAACAHEBIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JFAMCLMLKDC : global::MDHHICBEAKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCA90", Offset = "0x4EFBC90", VA = "0x184EFCA90")]
	public JFAMCLMLKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCA20", Offset = "0x4EFBC20", VA = "0x184EFCA20")]
	public JFAMCLMLKDC(int GKFHLIDAILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8C7210", Offset = "0x8C6410", VA = "0x1808C7210", Slot = "4")]
	protected override float HGIFNDJAACP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC990", Offset = "0x4EFBB90", VA = "0x184EFC990", Slot = "5")]
	protected override float LKJAFGCJGOG(float EKPKCLNNFCJ, float NJJGMIMHBHM, float ELLGECINNIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB96F0", Offset = "0x3EB88F0", VA = "0x183EB96F0", Slot = "6")]
	protected override float LMLLNBFLLIH(float PNLMJAPAHBD, float ELLGECINNIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F70520", Offset = "0x1F6F720", VA = "0x181F70520", Slot = "7")]
	protected override float JAPPOMGBPML(float EKPKCLNNFCJ, float NJJGMIMHBHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCA10", Offset = "0x4EFBC10", VA = "0x184EFCA10", Slot = "8")]
	protected override float MEFAANDJMNK(float EKPKCLNNFCJ, float NJJGMIMHBHM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MAOELNOPFHJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x18EF9C0", Offset = "0x18EEBC0", VA = "0x1818EF9C0")]
	public static global::JHODMDMNLAB<T1> EJKEJHFJNHJ<T1>(T1 KLBMFPONDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x192A6F0", Offset = "0x19298F0", VA = "0x18192A6F0")]
	public static global::LGPMOEDIABC<T1, T2> EJKEJHFJNHJ<T1, T2>(T1 KLBMFPONDFD, T2 KGDCLKCADAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x192A760", Offset = "0x1929960", VA = "0x18192A760")]
	public static global::PCLOBAAMHGE<T1, T2, T3> EJKEJHFJNHJ<T1, T2, T3>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x19200E0", Offset = "0x191F2E0", VA = "0x1819200E0")]
	public static global::IIELCIHDEDJ<T1, T2, T3, T4> EJKEJHFJNHJ<T1, T2, T3, T4>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x21B5C40", Offset = "0x21B4E40", VA = "0x1821B5C40")]
	public static global::FDDNMGMBOAK<T1, T2, T3, T4, T5> EJKEJHFJNHJ<T1, T2, T3, T4, T5>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x21B5B90", Offset = "0x21B4D90", VA = "0x1821B5B90")]
	public static global::GFMEHAJHADJ<T1, T2, T3, T4, T5, T6> EJKEJHFJNHJ<T1, T2, T3, T4, T5, T6>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x192A8C0", Offset = "0x1929AC0", VA = "0x18192A8C0")]
	public static global::OGLMEKMKKGN<T1, T2, T3, T4, T5, T6, T7> EJKEJHFJNHJ<T1, T2, T3, T4, T5, T6, T7>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA, T7 FEAOODIBIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x192A7F0", Offset = "0x19299F0", VA = "0x18192A7F0")]
	public static global::MPFMKGDMCHG<T1, T2, T3, T4, T5, T6, T7, T8> EJKEJHFJNHJ<T1, T2, T3, T4, T5, T6, T7, T8>(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA, T7 FEAOODIBIFJ, T8 IKOPKCOHNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x13C4870", Offset = "0x13C3A70", VA = "0x1813C4870")]
	[IteratorStateMachine(typeof(ECBBFEAPEHC))]
	public static IEnumerable<global::LGPMOEDIABC<T1, T2>> GAKDGKKDBGM<T1, T2>(IEnumerable<T1> JNDOPINGBDA, IEnumerable<T2> CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x17701B0", Offset = "0x176F3B0", VA = "0x1817701B0")]
	[IteratorStateMachine(typeof(DDODFCIOGIO))]
	public static IEnumerable<global::PCLOBAAMHGE<T1, T2, T3>> GAKDGKKDBGM<T1, T2, T3>(IEnumerable<T1> JNDOPINGBDA, IEnumerable<T2> CJCOEBBKILK, IEnumerable<T3> MGJAENEOBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x212A750", Offset = "0x2129950", VA = "0x18212A750")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC420", Offset = "0x3BCB620", VA = "0x183BCC420")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC430", Offset = "0x3BCB630", VA = "0x183BCC430")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG, int JIEIJADHCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD300", Offset = "0x4EFC500", VA = "0x184EFD300")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG, int JIEIJADHCBN, int KKHFPFLENGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD350", Offset = "0x4EFC550", VA = "0x184EFD350")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG, int JIEIJADHCBN, int KKHFPFLENGJ, int ADIHBDGFFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD2D0", Offset = "0x4EFC4D0", VA = "0x184EFD2D0")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG, int JIEIJADHCBN, int KKHFPFLENGJ, int ADIHBDGFFFB, int NPOJLGLMABB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD320", Offset = "0x4EFC520", VA = "0x184EFD320")]
	internal static int BHDDGOCHHDE(int OKCFPDEGNCA, int MDOLKBKEDMC, int LHPJDCLMKPG, int JIEIJADHCBN, int KKHFPFLENGJ, int ADIHBDGFFFB, int NPOJLGLMABB, int FFPOHDGGGCE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JHODMDMNLAB<T1> : IComparable<global::JHODMDMNLAB<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
	public JHODMDMNLAB(T1 KLBMFPONDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3988690", Offset = "0x3987890", VA = "0x183988690", Slot = "4")]
	public int CompareTo(global::JHODMDMNLAB<T1> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3988700", Offset = "0x3987900", VA = "0x183988700", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63DEF0", Offset = "0x63D0F0", VA = "0x18063DEF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x39887A0", Offset = "0x39879A0", VA = "0x1839887A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LGPMOEDIABC<T1, T2> : IComparable<global::LGPMOEDIABC<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB9F0", Offset = "0x1CFABF0", VA = "0x181CFB9F0")]
	public LGPMOEDIABC(T1 KLBMFPONDFD, T2 KGDCLKCADAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9FB0", Offset = "0x1CF91B0", VA = "0x181CF9FB0", Slot = "4")]
	public int CompareTo(global::LGPMOEDIABC<T1, T2> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA2C0", Offset = "0x1CF94C0", VA = "0x181CFA2C0", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAC70", Offset = "0x1CF9E70", VA = "0x181CFAC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB610", Offset = "0x1CFA810", VA = "0x181CFB610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PCLOBAAMHGE<T1, T2, T3> : IComparable<global::PCLOBAAMHGE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3225EB0", Offset = "0x32250B0", VA = "0x183225EB0")]
	public PCLOBAAMHGE(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32257D0", Offset = "0x32249D0", VA = "0x1832257D0", Slot = "4")]
	public int CompareTo(global::PCLOBAAMHGE<T1, T2, T3> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32258D0", Offset = "0x3224AD0", VA = "0x1832258D0", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3225B30", Offset = "0x3224D30", VA = "0x183225B30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3225C30", Offset = "0x3224E30", VA = "0x183225C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IIELCIHDEDJ<T1, T2, T3, T4> : IComparable<global::IIELCIHDEDJ<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 HFMAMCIOOOE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2018730", Offset = "0x2017930", VA = "0x182018730")]
	public IIELCIHDEDJ(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3F79C40", Offset = "0x3F78E40", VA = "0x183F79C40", Slot = "4")]
	public int CompareTo(global::IIELCIHDEDJ<T1, T2, T3, T4> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3F79D80", Offset = "0x3F78F80", VA = "0x183F79D80", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F79EA0", Offset = "0x3F790A0", VA = "0x183F79EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F79F60", Offset = "0x3F79160", VA = "0x183F79F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FDDNMGMBOAK<T1, T2, T3, T4, T5> : IComparable<global::FDDNMGMBOAK<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 HFMAMCIOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 AKFIJDDDPOE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x26043D0", Offset = "0x26035D0", VA = "0x1826043D0")]
	public FDDNMGMBOAK(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2603EE0", Offset = "0x26030E0", VA = "0x182603EE0", Slot = "4")]
	public int CompareTo(global::FDDNMGMBOAK<T1, T2, T3, T4, T5> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2604060", Offset = "0x2603260", VA = "0x182604060", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26041A0", Offset = "0x26033A0", VA = "0x1826041A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26042A0", Offset = "0x26034A0", VA = "0x1826042A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GFMEHAJHADJ<T1, T2, T3, T4, T5, T6> : IComparable<global::GFMEHAJHADJ<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 HFMAMCIOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 AKFIJDDDPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 DDIGFNCDNHM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2207B80", Offset = "0x2206D80", VA = "0x182207B80")]
	public GFMEHAJHADJ(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22075E0", Offset = "0x22067E0", VA = "0x1822075E0", Slot = "4")]
	public int CompareTo(global::GFMEHAJHADJ<T1, T2, T3, T4, T5, T6> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22077A0", Offset = "0x22069A0", VA = "0x1822077A0", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2207910", Offset = "0x2206B10", VA = "0x182207910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2207A30", Offset = "0x2206C30", VA = "0x182207A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OGLMEKMKKGN<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::OGLMEKMKKGN<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 HFMAMCIOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 AKFIJDDDPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 DDIGFNCDNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 HDOJFAFCPPI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4356DC0", Offset = "0x4355FC0", VA = "0x184356DC0")]
	public OGLMEKMKKGN(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA, T7 FEAOODIBIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4356760", Offset = "0x4355960", VA = "0x184356760", Slot = "4")]
	public int CompareTo(global::OGLMEKMKKGN<T1, T2, T3, T4, T5, T6, T7> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4356960", Offset = "0x4355B60", VA = "0x184356960", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4356B00", Offset = "0x4355D00", VA = "0x184356B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4356C50", Offset = "0x4355E50", VA = "0x184356C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MPFMKGDMCHG<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::MPFMKGDMCHG<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 BNOCDGLEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 HKFGLEMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 KDFGKKCGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 HFMAMCIOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 AKFIJDDDPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 DDIGFNCDNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 HDOJFAFCPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 BHMIGOOFHFB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x24F94F0", Offset = "0x24F86F0", VA = "0x1824F94F0")]
	public MPFMKGDMCHG(T1 KLBMFPONDFD, T2 KGDCLKCADAA, T3 INGNLENDPFK, T4 DPHLOJIDKEA, T5 FABFGHBBIAI, T6 CONDCGPOKHA, T7 FEAOODIBIFJ, T8 IKOPKCOHNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24F8DE0", Offset = "0x24F7FE0", VA = "0x1824F8DE0", Slot = "4")]
	public int CompareTo(global::MPFMKGDMCHG<T1, T2, T3, T4, T5, T6, T7, T8> EBJKBJMLDOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24F9030", Offset = "0x24F8230", VA = "0x1824F9030", Slot = "0")]
	public override bool Equals(object EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24F91F0", Offset = "0x24F83F0", VA = "0x1824F91F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x24F9360", Offset = "0x24F8560", VA = "0x1824F9360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
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
	public T AMCKDLHOFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CMNPFDNADIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCCCCC0", Offset = "0xCCBEC0", VA = "0x180CCCCC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3796AB0", Offset = "0x3795CB0", VA = "0x183796AB0")]
	public T AMDOEMPJEHK(float ELLGECINNIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3796D80", Offset = "0x3795F80", VA = "0x183796D80")]
	public T CMIKMIAOAHO(float ELLGECINNIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LKJAFGCJGOG(T EKPKCLNNFCJ, T NJJGMIMHBHM, float ELLGECINNIM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC150", Offset = "0x4EFB350", VA = "0x184EFC150", Slot = "4")]
	protected override float LKJAFGCJGOG(float EKPKCLNNFCJ, float NJJGMIMHBHM, float ELLGECINNIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4EFC1D0", Offset = "0x4EFB3D0", VA = "0x184EFC1D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F02700", Offset = "0x4F01900", VA = "0x184F02700", Slot = "4")]
	protected override Vector3 LKJAFGCJGOG(Vector3 EKPKCLNNFCJ, Vector3 NJJGMIMHBHM, float ELLGECINNIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F027C0", Offset = "0x4F019C0", VA = "0x184F027C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB810", Offset = "0x4EFAA10", VA = "0x184EFB810", Slot = "4")]
	protected override Color LKJAFGCJGOG(Color EKPKCLNNFCJ, Color NJJGMIMHBHM, float ELLGECINNIM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB860", Offset = "0x4EFAA60", VA = "0x184EFB860")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AKOJMACHJCO : global::BMPLOPNDGEM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA7A0", Offset = "0x4EF99A0", VA = "0x184EFA7A0")]
	public AKOJMACHJCO(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA740", Offset = "0x4EF9940", VA = "0x184EFA740")]
	public AKOJMACHJCO(KFNEIIEKDOO[] MEIDBHHHAIB, bool BPGLNLNKHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA6D0", Offset = "0x4EF98D0", VA = "0x184EFA6D0", Slot = "6")]
	protected override uint HIPLHBNEJDF(uint GCMEFCLKGHN, string PNLMJAPAHBD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BEMMLPGJNKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BEMMLPGJNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(global::BHMHKFNBOAO<>.PCALBONMBIL))]
public sealed class BHMHKFNBOAO<T> : IDisposable, global::MNADAFBBDFO<T>, JCBFBKGPHFJ, global::CMDCLECPBAI<T, global::BHMHKFNBOAO<T>.GIIPBKHFJJF>, global::NPILBEMMHGD<T>, global::BINMMFEMAND<T, global::BHMHKFNBOAO<T>.GIIPBKHFJJF>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, global::BHMHKFNBOAO<T>.GIIPBKHFJJF>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct GIIPBKHFJJF : JCBFBKGPHFJ, global::LJACOOLNIOB<T>, global::HGGHFHCONMC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::BHMHKFNBOAO<T> LPAIMLEOKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int CICFMCDILIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int BNNMPMMNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x17BBA60", Offset = "0x17BAC60", VA = "0x1817BBA60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T FMENHIFBNEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3DF5340", Offset = "0x3DF4540", VA = "0x183DF5340", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private T KGOCMKGOJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4BC0", Offset = "0x3DF3DC0", VA = "0x183DF4BC0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4D20", Offset = "0x3DF3F20", VA = "0x183DF4D20", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4F60", Offset = "0x3DF4160", VA = "0x183DF4F60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x336BC00", Offset = "0x336AE00", VA = "0x18336BC00")]
		private GIIPBKHFJJF(global::BHMHKFNBOAO<T> EEGMPMAILGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0290", Offset = "0x1C9F490", VA = "0x181CA0290")]
		public static GIIPBKHFJJF ECPJFBMNCEK(global::BHMHKFNBOAO<T> EEGMPMAILGF)
		{
			return default(GIIPBKHFJJF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4C80", Offset = "0x3DF3E80", VA = "0x183DF4C80", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0370", Offset = "0x1C9F570", VA = "0x181CA0370", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class PCALBONMBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::BHMHKFNBOAO<T> LPAIMLEOKII;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BNNMPMMNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T[] LMFJLDMGEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB640", Offset = "0x3DFA840", VA = "0x183DFB640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool EIMHGAAHCJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB700", Offset = "0x3DFA900", VA = "0x183DFB700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
		public PCALBONMBIL(global::BHMHKFNBOAO<T> EEGMPMAILGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NCIJICCAPFA GACCEHCOAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] BDHEKKFBPCO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x600CA0", Offset = "0x5FFEA0", VA = "0x180600CA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x814C50", Offset = "0x813E50", VA = "0x180814C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> LMFJLDMGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF560", Offset = "0x3DEE760", VA = "0x183DEF560")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0570", Offset = "0x3DEF770", VA = "0x183DF0570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEF30", Offset = "0x3DEE130", VA = "0x183DEEF30")]
	public static global::BHMHKFNBOAO<T> ECPJFBMNCEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0300", Offset = "0x3DEF500", VA = "0x183DF0300")]
	public static global::BHMHKFNBOAO<T> JCKKGIICPLB(int EICHEFNLNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0B30", Offset = "0x3DEFD30", VA = "0x183DF0B30")]
	private BHMHKFNBOAO(T[] KAMBKMAJBMP, int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x220B160", Offset = "0x220A360", VA = "0x18220B160", Slot = "5")]
	public T ALANDGLNLAD(int PNNJEJIELDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEEB0", Offset = "0x3DEE0B0", VA = "0x183DEEEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFE30", Offset = "0x3DEF030", VA = "0x183DEFE30")]
	public void INLOBDHPAIC(in T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEE10", Offset = "0x3DEE010", VA = "0x183DEEE10")]
	public void CCOBAAGAIMD(int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3DEE610", Offset = "0x3DED810", VA = "0x183DEE610")]
	public void ALMJAAOOCNC(int GKFHLIDAILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3DF05F0", Offset = "0x3DEF7F0", VA = "0x183DF05F0")]
	private void NGIBFOMCMPB(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF070", Offset = "0x3DEE270", VA = "0x183DEF070", Slot = "11")]
	public GIIPBKHFJJF GetEnumerator()
	{
		return default(GIIPBKHFJJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0440", Offset = "0x3DEF640", VA = "0x183DF0440", Slot = "8")]
	private global::LJACOOLNIOB<T> PJJNNNOLIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0440", Offset = "0x3DEF640", VA = "0x183DF0440", Slot = "10")]
	private global::HGGHFHCONMC<T> MPKEPFMAOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0440", Offset = "0x3DEF640", VA = "0x183DF0440", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0440", Offset = "0x3DEF640", VA = "0x183DF0440", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DNOIHGKHLEG
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20A9000", Offset = "0x20A8200", VA = "0x1820A9000")]
	public static global::BHMHKFNBOAO<T> ECPJFBMNCEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x10F4590", Offset = "0x10F3790", VA = "0x1810F4590")]
	public static global::BHMHKFNBOAO<T> JCKKGIICPLB<T>(int EICHEFNLNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2829280", Offset = "0x2828480", VA = "0x182829280")]
	public static bool LOAICNNFOIF<T>(this global::BHMHKFNBOAO<T> EEGMPMAILGF, in T PNLMJAPAHBD) where T : global::EMMEEBOBHNE<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OPHEBAKOCJH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LJGNHOJEJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<HMPNKJEOEKH> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public LJGNHOJEJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD190", Offset = "0x4EFC390", VA = "0x184EFD190")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HMPNKJEOEKH>> GLOODOFCLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int CHGNLHPHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int HHKDFANFFCM;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x212EC20", Offset = "0x212DE20", VA = "0x18212EC20")]
	private OPHEBAKOCJH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HMPNKJEOEKH>> CKOHKGBJHHG, int CMOFFMFCHPC, int MJLAKODJCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDFD0", Offset = "0x4EFD1D0", VA = "0x184EFDFD0")]
	public static OPHEBAKOCJH ECPJFBMNCEK()
	{
		return default(OPHEBAKOCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE050", Offset = "0x4EFD250", VA = "0x184EFE050")]
	public (int, int, Task) EECPHMDICDM(int FHAPEIAFAEO, [Optional] CancellationToken MNPKHBAPNDC)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE3A0", Offset = "0x4EFD5A0", VA = "0x184EFE3A0")]
	public void NKKELFMLHPD(int FHAPEIAFAEO, int MJLAKODJCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class GKHKFDAINOK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> MJNCLJGCFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> FKEKGNEBPNF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PHAFKGDPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TKey> LBPFCCEONND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x220B3A0", Offset = "0x220A5A0", VA = "0x18220B3A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ICollection<TVal> ELIGLCKIOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A610", Offset = "0x1E39810", VA = "0x181E3A610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TVal DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x220B370", Offset = "0x220A570", VA = "0x18220B370", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1CF75C0", Offset = "0x1CF67C0", VA = "0x181CF75C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TKey DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x220B020", Offset = "0x220A220", VA = "0x18220B020")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x220ADF0", Offset = "0x2209FF0", VA = "0x18220ADF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x220AA90", Offset = "0x2209C90", VA = "0x18220AA90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x220B1C0", Offset = "0x220A3C0", VA = "0x18220B1C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x220A700", Offset = "0x2209900", VA = "0x18220A700", Slot = "9")]
	public void Add(TKey DHDAEDILENC, TVal PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x220A760", Offset = "0x2209960", VA = "0x18220A760", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x220AAF0", Offset = "0x2209CF0", VA = "0x18220AAF0", Slot = "8")]
	public bool ContainsKey(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E39A80", Offset = "0x1E38C80", VA = "0x181E39A80", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x220B160", Offset = "0x220A360", VA = "0x18220B160", Slot = "10")]
	public bool Remove(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x220B160", Offset = "0x220A360", VA = "0x18220B160", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x220B260", Offset = "0x220A460", VA = "0x18220B260", Slot = "11")]
	public bool TryGetValue(TKey DHDAEDILENC, out TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x220AD70", Offset = "0x2209F70", VA = "0x18220AD70", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x220AB50", Offset = "0x2209D50", VA = "0x18220AB50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IBNOFMOJNKD, int ODJLDMJPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x220AF40", Offset = "0x220A140", VA = "0x18220AF40")]
	public void INLOBDHPAIC(TVal OMOAPINBBMH, TKey DHDAEDILENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x220AED0", Offset = "0x220A0D0", VA = "0x18220AED0")]
	public void INLOBDHPAIC(KeyValuePair<TVal, TKey> PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x220AFC0", Offset = "0x220A1C0", VA = "0x18220AFC0")]
	public bool KKGMAEPOEJA(TVal DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x220AEA0", Offset = "0x220A0A0", VA = "0x18220AEA0")]
	public bool IBFBFEPPJPP(KeyValuePair<TVal, TKey> PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF75F0", Offset = "0x1CF67F0", VA = "0x181CF75F0")]
	public bool MNIDDOJOCKH(TVal DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF75F0", Offset = "0x1CF67F0", VA = "0x181CF75F0")]
	public bool MNIDDOJOCKH(KeyValuePair<TVal, TKey> PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x220ABB0", Offset = "0x2209DB0", VA = "0x18220ABB0")]
	public bool FIDGIGFFKFJ(TVal DHDAEDILENC, out TKey PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x220B0E0", Offset = "0x220A2E0", VA = "0x18220B0E0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> NICCGAGCCOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x220A680", Offset = "0x2209880", VA = "0x18220A680")]
	private void AGCILDABMDH(TKey DHDAEDILENC, TVal OMOAPINBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x220ABE0", Offset = "0x2209DE0", VA = "0x18220ABE0")]
	private void GCHELCFPKAI(TKey DHDAEDILENC, TVal OMOAPINBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x220A790", Offset = "0x2209990", VA = "0x18220A790")]
	private bool BNEFDCCLEPH(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x220A850", Offset = "0x2209A50", VA = "0x18220A850")]
	private bool BNEFDCCLEPH(TVal OMOAPINBBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x220B290", Offset = "0x220A490", VA = "0x18220B290")]
	public GKHKFDAINOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PGJOMAFLLKD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::PGJOMAFLLKD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x942900", Offset = "0x941B00", VA = "0x180942900", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3222CE0", Offset = "0x3221EE0", VA = "0x183222CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3223230", Offset = "0x3222430", VA = "0x183223230")]
		public Enumerator(global::PGJOMAFLLKD<T> AJBILMJPKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3222A70", Offset = "0x3221C70", VA = "0x183222A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3222BF0", Offset = "0x3221DF0", VA = "0x183222BF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3222540", Offset = "0x3221740", VA = "0x183222540")]
		private void CCMCPCPPBFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] IPLJMPLJHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int IMDJFDAAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int CCOGMBNGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int OJGBBKPGNFB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3230480", Offset = "0x322F680", VA = "0x183230480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230F80", VA = "0x183231D80")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x32306A0", Offset = "0x322F8A0", VA = "0x1832306A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3232090", Offset = "0x3231290", VA = "0x183232090")]
	public PGJOMAFLLKD(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x32308A0", Offset = "0x322FAA0", VA = "0x1832308A0")]
	public void INLOBDHPAIC(T ELLGECINNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3230BC0", Offset = "0x322FDC0", VA = "0x183230BC0")]
	public void MGJMEDCFION(IEnumerable<T> DKEPAEMMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x32300A0", Offset = "0x322F2A0", VA = "0x1832300A0")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3230810", Offset = "0x322FA10", VA = "0x183230810")]
	public void IIKMJDKMMNN(int KOAOGJIGGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3230010", Offset = "0x322F210", VA = "0x183230010")]
	public void BDLKIABPAFH(int KOAOGJIGGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3231BD0", Offset = "0x3230DD0", VA = "0x183231BD0")]
	public void MJBHLDJIBAI(T[] IBNOFMOJNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3230530", Offset = "0x322F730", VA = "0x183230530")]
	public Enumerator FGPBPKKHKMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32310A0", VA = "0x183231EA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32310A0", VA = "0x183231EA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x32302A0", Offset = "0x322F4A0", VA = "0x1832302A0")]
	private int EGEGCMCHMHK(int PPMIPKENDBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3230B90", Offset = "0x322FD90", VA = "0x183230B90")]
	private int LDFJDKPDHJG(int PPMIPKENDBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ODLAPGIFAAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] BDHEKKFBPCO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
	public ODLAPGIFAAA(params IDisposable[] KAMBKMAJBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8A7960", Offset = "0x8A6B60", VA = "0x1808A7960")]
	public static ODLAPGIFAAA ECPJFBMNCEK(params IDisposable[] KAMBKMAJBMP)
	{
		return default(ODLAPGIFAAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDDE0", Offset = "0x4EFCFE0", VA = "0x184EFDDE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HCIJKKCADKH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable HHKOADJNEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T AMCKDLHOFMB;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF1B0", Offset = "0x1CFE3B0", VA = "0x181CFF1B0")]
	public HCIJKKCADKH(IDisposable LJMJEKEAKDO, in T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1A1DA60", Offset = "0x1A1CC60", VA = "0x181A1DA60")]
	public static global::HCIJKKCADKH<U> FJAKNKAKPPE<U>(in global::HCIJKKCADKH<T> LJMJEKEAKDO, in U PNLMJAPAHBD)
	{
		return default(global::HCIJKKCADKH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x191DA70", Offset = "0x191CC70", VA = "0x18191DA70")]
	public global::HCIJKKCADKH<U> NJHHPEJANOL<U>(in U PNLMJAPAHBD)
	{
		return default(global::HCIJKKCADKH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1A1DAA0", Offset = "0x1A1CCA0", VA = "0x181A1DAA0")]
	public static global::HCIJKKCADKH<(T, U)> OLJNDKFIKFF<U>(in global::HCIJKKCADKH<T> JNDOPINGBDA, in global::HCIJKKCADKH<U> CJCOEBBKILK)
	{
		return default(global::HCIJKKCADKH<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1E37080", Offset = "0x1E36280", VA = "0x181E37080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MJJBHANFGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1A1EB90", Offset = "0x1A1DD90", VA = "0x181A1EB90")]
	public static global::HCIJKKCADKH<T> ECPJFBMNCEK<T>(IDisposable LJMJEKEAKDO, in T PNLMJAPAHBD)
	{
		return default(global::HCIJKKCADKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x191DA70", Offset = "0x191CC70", VA = "0x18191DA70")]
	public static global::HCIJKKCADKH<U> FJAKNKAKPPE<U, T>(in global::HCIJKKCADKH<T> KFIEHJGNLIM, in U PNLMJAPAHBD)
	{
		return default(global::HCIJKKCADKH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x19255D0", Offset = "0x19247D0", VA = "0x1819255D0")]
	public static global::HCIJKKCADKH<(T, U)> OLJNDKFIKFF<T, U>(in global::HCIJKKCADKH<T> JNDOPINGBDA, in global::HCIJKKCADKH<U> CJCOEBBKILK)
	{
		return default(global::HCIJKKCADKH<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NCIJICCAPFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0")]
	public static NCIJICCAPFA ACECFAPNHDG<T>([Optional] string JGFLHNBNHBC, [Optional] string COLNHIFGLLD, bool IFIJHHBMLAG = false)
	{
		return default(NCIJICCAPFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct GAPHGLGKGCI<T> : global::BINMMFEMAND<T, global::GAPHGLGKGCI<T>.EIGHIDDKBGL>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, global::GAPHGLGKGCI<T>.EIGHIDDKBGL>, IEnumerable<T>, IEnumerable, global::MNADAFBBDFO<T>, JCBFBKGPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct EIGHIDDKBGL : JCBFBKGPHFJ, global::HGGHFHCONMC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] LPAIMLEOKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int CICFMCDILIJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BNNMPMMNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1C99A50", Offset = "0x1C98C50", VA = "0x181C99A50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public T FMENHIFBNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1CA03D0", Offset = "0x1C9F5D0", VA = "0x181CA03D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0380", Offset = "0x1C9F580", VA = "0x181CA0380", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0380", Offset = "0x1C9F580", VA = "0x181CA0380", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6813C0", Offset = "0x6805C0", VA = "0x1806813C0")]
		private EIGHIDDKBGL(T[] EEGMPMAILGF, int PPMIPKENDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0290", Offset = "0x1C9F490", VA = "0x181CA0290")]
		public static EIGHIDDKBGL ECPJFBMNCEK(T[] EEGMPMAILGF)
		{
			return default(EIGHIDDKBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0340", Offset = "0x1C9F540", VA = "0x181CA0340", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0370", Offset = "0x1C9F570", VA = "0x181CA0370", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] NCMJLLKNAIG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int PIMJHDDGEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1C99A50", Offset = "0x1C98C50", VA = "0x181C99A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1C99A10", Offset = "0x1C98C10", VA = "0x181C99A10", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1C99C90", Offset = "0x1C98E90", VA = "0x181C99C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
	internal GAPHGLGKGCI(T[] IBNOFMOJNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1C999B0", Offset = "0x1C98BB0", VA = "0x181C999B0", Slot = "9")]
	public T ALANDGLNLAD(int PPMIPKENDBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2202050", Offset = "0x2201250", VA = "0x182202050", Slot = "6")]
	public EIGHIDDKBGL GetEnumerator()
	{
		return default(EIGHIDDKBGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x22020F0", Offset = "0x22012F0", VA = "0x1822020F0", Slot = "5")]
	private global::HGGHFHCONMC<T> MPKEPFMAOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x22020F0", Offset = "0x22012F0", VA = "0x1822020F0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x22020F0", Offset = "0x22012F0", VA = "0x1822020F0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OJHDOGCCPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x192AA10", Offset = "0x1929C10", VA = "0x18192AA10")]
	public static global::GAPHGLGKGCI<T> ECPJFBMNCEK<T>(T[] IBNOFMOJNKD)
	{
		return default(global::GAPHGLGKGCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x21ADF40", Offset = "0x21AD140", VA = "0x1821ADF40")]
	public static global::GAPHGLGKGCI<T> IEEHPPFPCHK<T>()
	{
		return default(global::GAPHGLGKGCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x10F4590", Offset = "0x10F3790", VA = "0x1810F4590")]
	public static global::GAPHGLGKGCI<T> PDJPNFBMJEB<T>(this T[] EEGMPMAILGF)
	{
		return default(global::GAPHGLGKGCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1925420", Offset = "0x1924620", VA = "0x181925420")]
	public static global::GAPHGLGKGCI<T>.EIGHIDDKBGL NMKIPIOJIMI<T>(this T[] EEGMPMAILGF)
	{
		return default(global::GAPHGLGKGCI<T>.EIGHIDDKBGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x10F4590", Offset = "0x10F3790", VA = "0x1810F4590")]
	public static global::GAPHGLGKGCI<T> CCANNPGBFCP<T>(this T[] EEGMPMAILGF)
	{
		return default(global::GAPHGLGKGCI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct JBKGDJLIMCJ<T, U> : global::BINMMFEMAND<T, U>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, U>, IEnumerable<T>, IEnumerable where U : global::HGGHFHCONMC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U LNKGPMGEBOM;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x247DC50", Offset = "0x247CE50", VA = "0x18247DC50")]
	internal JBKGDJLIMCJ(in U KGGENGLIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6813F0", Offset = "0x6805F0", VA = "0x1806813F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "5")]
	private global::HGGHFHCONMC<T> MPKEPFMAOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OIOGEMBMGNC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1920CA0", Offset = "0x191FEA0", VA = "0x181920CA0")]
	public static global::JBKGDJLIMCJ<T, U> ECPJFBMNCEK<U>(in U KGGENGLIPEA) where U : global::HGGHFHCONMC<T>
	{
		return default(global::JBKGDJLIMCJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KIGJJMDEDLH<TResult, TResultEnumerator> where TResultEnumerator : global::HGGHFHCONMC<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x21B5580", Offset = "0x21B4780", VA = "0x1821B5580")]
	public static global::CDBOMBMNEFL<TSourceEnumerator, TResultEnumerator, TResult> CNPINIDKOFA<TSourceEnumerator>(in TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::CDBOMBMNEFL<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CDBOMBMNEFL<TSourceEnumerator, TResultEnumerator, TResult> : global::HGGHFHCONMC<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::HGGHFHCONMC<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator LPAIMLEOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator AAKJEALHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool PGONAGBEKPG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public TResult FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x247DAC0", Offset = "0x247CCC0", VA = "0x18247DAC0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x247DA20", Offset = "0x247CC20", VA = "0x18247DA20", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x247DA20", Offset = "0x247CC20", VA = "0x18247DA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x247DA70", Offset = "0x247CC70", VA = "0x18247DA70")]
	internal CDBOMBMNEFL(in TSourceEnumerator EEGMPMAILGF, in TResultEnumerator DCHPJKHHCCK, bool EEIPKPDBOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x247D8A0", Offset = "0x247CAA0", VA = "0x18247D8A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x247D9D0", Offset = "0x247CBD0", VA = "0x18247D9D0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x247D850", Offset = "0x247CA50", VA = "0x18247D850", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KJONMEINDBI<TSourceEnumerator, TSource, TResult> : JCBFBKGPHFJ, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator LPAIMLEOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::AMMJIEBBAJN<TSource, TResult> DPHFOBAFGHF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x36CA800", Offset = "0x36C9A00", VA = "0x1836CA800", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TResult FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x36CB180", Offset = "0x36CA380", VA = "0x1836CB180", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x36CAEF0", Offset = "0x36CA0F0", VA = "0x1836CAEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x21408A0", Offset = "0x213FAA0", VA = "0x1821408A0")]
	internal KJONMEINDBI(in TSourceEnumerator EEGMPMAILGF, global::AMMJIEBBAJN<TSource, TResult> IANKDFOBGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x36CABD0", Offset = "0x36C9DD0", VA = "0x1836CABD0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36CAE00", Offset = "0x36CA000", VA = "0x1836CAE00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x36CA6C0", Offset = "0x36C98C0", VA = "0x1836CA6C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FKBLJAKODJF<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::HGGHFHCONMC<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::HGGHFHCONMC<TSource> where TResultEnumerator : global::HGGHFHCONMC<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator LPAIMLEOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator AAKJEALHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::AMMJIEBBAJN<TSource, TResultEnumerator> DPHFOBAFGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool PGONAGBEKPG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1C99940", Offset = "0x1C98B40", VA = "0x181C99940", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1C99850", Offset = "0x1C98A50", VA = "0x181C99850", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1C99850", Offset = "0x1C98A50", VA = "0x181C99850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1C998E0", Offset = "0x1C98AE0", VA = "0x181C998E0")]
	internal FKBLJAKODJF(in TSourceEnumerator EEGMPMAILGF, in TResultEnumerator DCHPJKHHCCK, global::AMMJIEBBAJN<TSource, TResultEnumerator> IANKDFOBGMJ, bool EEIPKPDBOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1C99670", Offset = "0x1C98870", VA = "0x181C99670", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1C99800", Offset = "0x1C98A00", VA = "0x181C99800", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1C99620", Offset = "0x1C98820", VA = "0x181C99620", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FPHGOIMPLNN<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : JCBFBKGPHFJ, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<TSource1> where TSource2Enumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator EDBCILEOBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator IAJHACEPDIO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C070", Offset = "0x1C9B270", VA = "0x181C9C070", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (TSource1, TSource2) FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C2D0", Offset = "0x1C9B4D0", VA = "0x181C9C2D0", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C1F0", Offset = "0x1C9B3F0", VA = "0x181C9C1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C290", Offset = "0x1C9B490", VA = "0x181C9C290")]
	internal FPHGOIMPLNN(in TSource1Enumerator DHKBLPLBDDO, in TSource2Enumerator JNOLHLJLHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C110", Offset = "0x1C9B310", VA = "0x181C9C110", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C180", Offset = "0x1C9B380", VA = "0x181C9C180", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C010", Offset = "0x1C9B210", VA = "0x181C9C010", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct OCFGPHNJMOM<T, U> : global::KONHKBBBCCL<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U LNKGPMGEBOM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4352870", Offset = "0x4351A70", VA = "0x184352870")]
	internal OCFGPHNJMOM(in U KGGENGLIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8994B0", Offset = "0x8986B0", VA = "0x1808994B0", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4352760", Offset = "0x4351960", VA = "0x184352760", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4352760", Offset = "0x4351960", VA = "0x184352760", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GPBLKFKMPNE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x19262A0", Offset = "0x19254A0", VA = "0x1819262A0")]
	public static global::OCFGPHNJMOM<T, U> ECPJFBMNCEK<U>(in U KGGENGLIPEA) where U : IEnumerator<T>
	{
		return default(global::OCFGPHNJMOM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct FEEEKAAENOC<TSourceEnumerator, TSource, TResult> : JCBFBKGPHFJ, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JCBFBKGPHFJ, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator LPAIMLEOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> DPHFOBAFGHF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x26044C0", Offset = "0x26036C0", VA = "0x1826044C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public TResult FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2604690", Offset = "0x2603890", VA = "0x182604690", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2604610", Offset = "0x2603810", VA = "0x182604610", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2604650", Offset = "0x2603850", VA = "0x182604650")]
	internal FEEEKAAENOC(in TSourceEnumerator EEGMPMAILGF, Func<TSource, TResult> IANKDFOBGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2604570", Offset = "0x2603770", VA = "0x182604570", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x26045C0", Offset = "0x26037C0", VA = "0x1826045C0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2604470", Offset = "0x2603670", VA = "0x182604470", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DPCKFPCNNPL
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2829510", Offset = "0x2828710", VA = "0x182829510")]
	public static bool NHHBDONJOEF<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator EEGMPMAILGF, in TArgs KNBHIGDFKBF, in global::EPJFHNCEFEE<TArgs, TSource, bool> NHFAHIIPLGN) where TSourceEnumerator : global::HGGHFHCONMC<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1B3DDB0", Offset = "0x1B3CFB0", VA = "0x181B3DDB0")]
	public static int GMJHOMKOGNG<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator EEGMPMAILGF, in TArgs KNBHIGDFKBF, global::EPJFHNCEFEE<TArgs, TSource, bool> NHFAHIIPLGN) where TSourceEnumerator : global::HGGHFHCONMC<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2829430", Offset = "0x2828630", VA = "0x182829430")]
	public static bool KPEDMCFIEHO<TSourceEnumerator, TSource>(this TSourceEnumerator EEGMPMAILGF, in TSource PBADFAIJJOK) where TSourceEnumerator : global::HGGHFHCONMC<TSource> where TSource : global::EMMEEBOBHNE<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1B3E0A0", Offset = "0x1B3D2A0", VA = "0x181B3E0A0")]
	public static int OBAINKCMEJL<TSourceEnumerator, TSource>(this TSourceEnumerator EEGMPMAILGF, in TSource PNLMJAPAHBD) where TSourceEnumerator : global::HGGHFHCONMC<TSource> where TSource : global::EMMEEBOBHNE<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x19207B0", Offset = "0x191F9B0", VA = "0x1819207B0")]
	public static global::KJONMEINDBI<TSourceEnumerator, TSource, TResult> PHLBNINMBAI<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator EEGMPMAILGF, global::AMMJIEBBAJN<TSource, TResult> IANKDFOBGMJ) where TSourceEnumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<TSource>
	{
		return default(global::KJONMEINDBI<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1920760", Offset = "0x191F960", VA = "0x181920760")]
	public static global::FEEEKAAENOC<TSourceEnumerator, TSource, TResult> OGOIHHNMMJO<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator EEGMPMAILGF, Func<TSource, TResult> IANKDFOBGMJ) where TSourceEnumerator : JCBFBKGPHFJ, IEnumerator<TSource>
	{
		return default(global::FEEEKAAENOC<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ADEABLJNHPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x281CC00", Offset = "0x281BE00", VA = "0x18281CC00")]
	public static bool JPOIIEGHCIL<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x276B060", Offset = "0x276A260", VA = "0x18276B060")]
	public static T MJBHHGLFAPO<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : global::HGGHFHCONMC<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x21A7180", Offset = "0x21A6380", VA = "0x1821A7180")]
	public static global::FKBLJAKODJF<TSourceEnumerator, TSource, TResultEnumerator, T> HOFMHNHELBN<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator EEGMPMAILGF, global::AMMJIEBBAJN<TSource, TResultEnumerator> IANKDFOBGMJ) where TSourceEnumerator : global::HGGHFHCONMC<TSource> where TResultEnumerator : global::HGGHFHCONMC<T>
	{
		return default(global::FKBLJAKODJF<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2294550", Offset = "0x2293750", VA = "0x182294550")]
	public static string GNNLHGMKKCN<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x35541F0", Offset = "0x35533F0", VA = "0x1835541F0")]
	public static T[] MDBHMELIKLE<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : JCBFBKGPHFJ, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x19312B0", Offset = "0x19304B0", VA = "0x1819312B0")]
	public static T LGKLELKPMBN<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x281CD30", Offset = "0x281BF30", VA = "0x18281CD30")]
	public static bool MKJMCKLFILH<TSourceEnumerator>(TSourceEnumerator EEGMPMAILGF) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CKOIKLEPMJA<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x21B27D0", Offset = "0x21B19D0", VA = "0x1821B27D0")]
	public static global::FPHGOIMPLNN<TSource1Enumerator, T, TSource2Enumerator, U> OCGEBFIJBPF<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator DHKBLPLBDDO, in TSource2Enumerator JNOLHLJLHBI) where TSource1Enumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<T> where TSource2Enumerator : JCBFBKGPHFJ, global::HGGHFHCONMC<U>
	{
		return default(global::FPHGOIMPLNN<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface APIAJBAJNGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HGGHFHCONMC<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BINMMFEMAND<T, TEnumerator> : global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::HGGHFHCONMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HGGHFHCONMC<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	T FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MNADAFBBDFO<T> : JCBFBKGPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T ALANDGLNLAD(int PNNJEJIELDM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KONHKBBBCCL<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JCBFBKGPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EMMEEBOBHNE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGBOIIKJAHG(in T EBJKBJMLDOO);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NPILBEMMHGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::LJACOOLNIOB<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CMDCLECPBAI<T, TEnumerator> : global::NPILBEMMHGD<T>, global::BINMMFEMAND<T, TEnumerator>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::LJACOOLNIOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LJACOOLNIOB<T> : global::HGGHFHCONMC<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	new T FMENHIFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void BJMEEIKAFAP<T>(in T OEDMLNBLEKI);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void FGBBMPLACGO<T1, T2>(in T1 HMAPEKLPADL, in T2 LMICDNDFHAB);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ILLFLAIPPLA
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x282EC80", Offset = "0x282DE80", VA = "0x18282EC80")]
	public static bool EAPGDONDJKN<T, U>(this T EEGMPMAILGF, in U CEEAMODAEEL) where T : global::EMMEEBOBHNE<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult AMMJIEBBAJN<T, out TResult>(in T OEDMLNBLEKI);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult EPJFHNCEFEE<T1, T2, out TResult>(in T1 HMAPEKLPADL, in T2 LMICDNDFHAB);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult OPIPAGBLBIN<T1, T2, T3, out TResult>(in T1 HMAPEKLPADL, in T2 LMICDNDFHAB, in T3 DBGFBNFJLMG);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult CAPPLAIHBEP<T, TResult>(in T OEDMLNBLEKI);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult EJNMEKNGOBB<T1, T2, TResult>(in T1 HMAPEKLPADL, in T2 LMICDNDFHAB);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult JBCPNBDMDGE<T1, T2, T3, TResult>(in T1 HMAPEKLPADL, in T2 LMICDNDFHAB, in T3 DBGFBNFJLMG);
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public struct FKHGDICFPEO<T> : global::CMDCLECPBAI<T, global::FKHGDICFPEO<T>.GHMMPJOHGNC>, global::NPILBEMMHGD<T>, global::BINMMFEMAND<T, global::FKHGDICFPEO<T>.GHMMPJOHGNC>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, global::FKHGDICFPEO<T>.GHMMPJOHGNC>, IEnumerable<T>, IEnumerable, global::MNADAFBBDFO<T>, JCBFBKGPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GHMMPJOHGNC : JCBFBKGPHFJ, global::LJACOOLNIOB<T>, global::HGGHFHCONMC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] LPAIMLEOKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int CICFMCDILIJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int BNNMPMMNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1C99A50", Offset = "0x1C98C50", VA = "0x181C99A50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public T FMENHIFBNEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1CA03D0", Offset = "0x1C9F5D0", VA = "0x181CA03D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private T KGOCMKGOJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1CA02F0", Offset = "0x1C9F4F0", VA = "0x181CA02F0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0380", Offset = "0x1C9F580", VA = "0x181CA0380", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0380", Offset = "0x1C9F580", VA = "0x181CA0380", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6813C0", Offset = "0x6805C0", VA = "0x1806813C0")]
		private GHMMPJOHGNC(T[] EEGMPMAILGF, int PPMIPKENDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0290", Offset = "0x1C9F490", VA = "0x181CA0290")]
		public static GHMMPJOHGNC ECPJFBMNCEK(T[] EEGMPMAILGF)
		{
			return default(GHMMPJOHGNC);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0340", Offset = "0x1C9F540", VA = "0x181CA0340", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0370", Offset = "0x1C9F570", VA = "0x181CA0370", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] NCMJLLKNAIG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int PIMJHDDGEME
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C99A50", Offset = "0x1C98C50", VA = "0x181C99A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C99A10", Offset = "0x1C98C10", VA = "0x181C99A10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C99C90", Offset = "0x1C98E90", VA = "0x181C99C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
	internal FKHGDICFPEO(T[] IBNOFMOJNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1C999B0", Offset = "0x1C98BB0", VA = "0x181C999B0", Slot = "11")]
	public T ALANDGLNLAD(int PPMIPKENDBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1C99A70", Offset = "0x1C98C70", VA = "0x181C99A70")]
	public global::GAPHGLGKGCI<T> GAIJDJNPDBN()
	{
		return default(global::GAPHGLGKGCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C99AF0", Offset = "0x1C98CF0", VA = "0x181C99AF0", Slot = "8")]
	public GHMMPJOHGNC GetEnumerator()
	{
		return default(GHMMPJOHGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1C99B90", Offset = "0x1C98D90", VA = "0x181C99B90", Slot = "5")]
	private global::LJACOOLNIOB<T> PJJNNNOLIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C99B90", Offset = "0x1C98D90", VA = "0x181C99B90", Slot = "7")]
	private global::HGGHFHCONMC<T> MPKEPFMAOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1C99B90", Offset = "0x1C98D90", VA = "0x181C99B90", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1C99B90", Offset = "0x1C98D90", VA = "0x181C99B90", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CCJOGKOJPIO
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x192AA10", Offset = "0x1929C10", VA = "0x18192AA10")]
	public static global::FKHGDICFPEO<T> ECPJFBMNCEK<T>(T[] IBNOFMOJNKD)
	{
		return default(global::FKHGDICFPEO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x21ADF40", Offset = "0x21AD140", VA = "0x1821ADF40")]
	public static global::FKHGDICFPEO<T> IEEHPPFPCHK<T>()
	{
		return default(global::FKHGDICFPEO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x10F4590", Offset = "0x10F3790", VA = "0x1810F4590")]
	public static global::FKHGDICFPEO<T> AELAHKFCAJD<T>(this T[] EEGMPMAILGF)
	{
		return default(global::FKHGDICFPEO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1925420", Offset = "0x1924620", VA = "0x181925420")]
	public static global::FKHGDICFPEO<T>.GHMMPJOHGNC EJJALLMOBNL<T>(this T[] EEGMPMAILGF)
	{
		return default(global::FKHGDICFPEO<T>.GHMMPJOHGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x10F4590", Offset = "0x10F3790", VA = "0x1810F4590")]
	public static global::FKHGDICFPEO<T> EMOHOGFELDG<T>(this T[] EEGMPMAILGF)
	{
		return default(global::FKHGDICFPEO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct MPCEIEIOHBN<T, U> : global::CMDCLECPBAI<T, U>, global::NPILBEMMHGD<T>, global::BINMMFEMAND<T, U>, global::APIAJBAJNGN<T>, global::KONHKBBBCCL<T, U>, IEnumerable<T>, IEnumerable where U : global::LJACOOLNIOB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U LNKGPMGEBOM;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x247DC50", Offset = "0x247CE50", VA = "0x18247DC50")]
	internal MPCEIEIOHBN(in U KGGENGLIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6813F0", Offset = "0x6805F0", VA = "0x1806813F0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "5")]
	private global::LJACOOLNIOB<T> PJJNNNOLIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "7")]
	private global::HGGHFHCONMC<T> MPKEPFMAOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x24F85F0", Offset = "0x24F77F0", VA = "0x1824F85F0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JLEIHDPNHNF<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1920CA0", Offset = "0x191FEA0", VA = "0x181920CA0")]
	public static global::MPCEIEIOHBN<T, U> ECPJFBMNCEK<U>(in U KGGENGLIPEA) where U : global::LJACOOLNIOB<T>
	{
		return default(global::MPCEIEIOHBN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
public class IGEPKNAOCCM<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> JMNBPFANHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> CBGMBPGKNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> OPPKLAEFHOK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IList<Internal> NHAFAKFKOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PHAFKGDPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6074A0", Offset = "0x6066A0", VA = "0x1806074A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6074B0", Offset = "0x6066B0", VA = "0x1806074B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public External DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F795B0", Offset = "0x3F787B0", VA = "0x183F795B0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F79650", Offset = "0x3F78850", VA = "0x183F79650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F79550", Offset = "0x3F78750", VA = "0x183F79550", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3F794C0", Offset = "0x3F786C0", VA = "0x183F794C0")]
	public IGEPKNAOCCM(Func<Internal, External> JMNBPFANHGO, Func<External, Internal> CBGMBPGKNLP, bool BCPLNLDALIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F791D0", Offset = "0x3F783D0", VA = "0x183F791D0", Slot = "6")]
	public int IndexOf(External PBADFAIJJOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F78E50", Offset = "0x3F78050", VA = "0x183F78E50", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3F78EB0", Offset = "0x3F780B0", VA = "0x183F78EB0", Slot = "13")]
	public bool Contains(External PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3F78F40", Offset = "0x3F78140", VA = "0x183F78F40", Slot = "14")]
	public void CopyTo(External[] IBNOFMOJNKD, int ODJLDMJPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3F78DC0", Offset = "0x3F77FC0", VA = "0x183F78DC0", Slot = "11")]
	public void Add(External PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3F792C0", Offset = "0x3F784C0", VA = "0x183F792C0", Slot = "7")]
	public void Insert(int PPMIPKENDBN, External PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3F79430", Offset = "0x3F78630", VA = "0x183F79430", Slot = "15")]
	public bool Remove(External PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3F79360", Offset = "0x3F78560", VA = "0x183F79360", Slot = "8")]
	public void RemoveAt(int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3F79160", Offset = "0x3F78360", VA = "0x183F79160", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1B35A70", Offset = "0x1B34C70", VA = "0x181B35A70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public class ABDIFPJCHPE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> JMNBPFANHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> OPPKLAEFHOK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<Internal> NHAFAKFKOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PHAFKGDPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x573BD0", VA = "0x1805749D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public External DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2018C40", Offset = "0x2017E40", VA = "0x182018C40", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2018BE0", Offset = "0x2017DE0", VA = "0x182018BE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
	public ABDIFPJCHPE(Func<Internal, External> JMNBPFANHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2018B90", Offset = "0x2017D90", VA = "0x182018B90")]
	public ABDIFPJCHPE(IReadOnlyList<Internal> OPPKLAEFHOK, Func<Internal, External> JMNBPFANHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2018970", Offset = "0x2017B70", VA = "0x182018970")]
	public void MJBHLDJIBAI(External[] IBNOFMOJNKD, int ODJLDMJPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2018900", Offset = "0x2017B00", VA = "0x182018900", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x17C8430", Offset = "0x17C7630", VA = "0x1817C8430", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class JDENLAAECME<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> OPPKLAEFHOK;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public IReadOnlyList<Internal> NHAFAKFKOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool PHAFKGDPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x573BD0", VA = "0x1805749D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public External DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x38BAC00", Offset = "0x38B9E00", VA = "0x1838BAC00", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x38BABA0", Offset = "0x38B9DA0", VA = "0x1838BABA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
	public JDENLAAECME(IReadOnlyList<Internal> OPPKLAEFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x38BA8D0", Offset = "0x38B9AD0", VA = "0x1838BA8D0")]
	public bool IBFBFEPPJPP(External PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x38BA970", Offset = "0x38B9B70", VA = "0x1838BA970")]
	public void MJBHLDJIBAI(External[] IBNOFMOJNKD, int ODJLDMJPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x38BA860", Offset = "0x38B9A60", VA = "0x1838BA860", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1B35A70", Offset = "0x1B34C70", VA = "0x181B35A70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class OFNGJDMHEGE
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LODKJKOEFML(object[] KNBHIGDFKBF);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	protected OFNGJDMHEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class HHNJAFFHALD<T> : OFNGJDMHEGE
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct HHFIKHHOLKC
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public enum OPNMJAINKNI
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OPNMJAINKNI DEJAEMDNDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T DINDBGHHKFD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int HLMNJPOMEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool PKIGJGOLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool MDECONADOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> NKBFMBLHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<HHFIKHHOLKC> AEFHNJIPGGF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool PECEKAHCAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E3CF20", Offset = "0x1E3C120", VA = "0x181E3CF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D2E0", Offset = "0x1E3C4E0", VA = "0x181E3D2E0")]
	protected HHNJAFFHALD(bool MDECONADOJB, bool PKIGJGOLBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D0E0", Offset = "0x1E3C2E0", VA = "0x181E3D0E0")]
	protected bool JOBJAKOIGLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CB60", Offset = "0x1E3BD60", VA = "0x181E3CB60")]
	protected void DBGNEHBLLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CC40", Offset = "0x1E3BE40", VA = "0x181E3CC40")]
	protected void DFOIIFHBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A58C80", Offset = "0x2A57E80", VA = "0x182A58C80")]
	private static void CENNNLPKJIO<U>(ref List<U> OPPKLAEFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CF60", Offset = "0x1E3C160", VA = "0x181E3CF60", Slot = "5")]
	public void INLOBDHPAIC(T DINDBGHHKFD, bool GLJGFHPFODH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D180", Offset = "0x1E3C380", VA = "0x181E3D180", Slot = "6")]
	public void MNIDDOJOCKH(T DINDBGHHKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CDF0", Offset = "0x1E3BFF0", VA = "0x181E3CDF0")]
	public void DHEPINIAIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IBPBPMBDGPJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class AIBLIBIGGML : global::HHNJAFFHALD<Action>, IBPBPMBDGPJ
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA670", Offset = "0x4EF9870", VA = "0x184EFA670")]
	public AIBLIBIGGML(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA370", Offset = "0x4EF9570", VA = "0x184EFA370")]
	public void CCNLNBIKCNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA5F0", Offset = "0x4EF97F0", VA = "0x184EFA5F0", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA530", Offset = "0x4EF9730", VA = "0x184EFA530")]
	public static AIBLIBIGGML FBGPCCMIGKB(AIBLIBIGGML MGEDBPNDFJG, Action DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA590", Offset = "0x4EF9790", VA = "0x184EFA590")]
	public static AIBLIBIGGML KMMIECOBGKO(AIBLIBIGGML MGEDBPNDFJG, Action DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface OFFBNPGCHAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class PALBEJLAEDO<T> : global::HHNJAFFHALD<Action<T>>, global::OFFBNPGCHAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public PALBEJLAEDO(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3309010", Offset = "0x3308210", VA = "0x183309010")]
	public void CCNLNBIKCNF(T ELLGECINNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x330D600", Offset = "0x330C800", VA = "0x18330D600", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x330BCB0", Offset = "0x330AEB0", VA = "0x18330BCB0")]
	public static global::PALBEJLAEDO<T> FBGPCCMIGKB(global::PALBEJLAEDO<T> MGEDBPNDFJG, Action<T> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x330BD50", Offset = "0x330AF50", VA = "0x18330BD50")]
	public static global::PALBEJLAEDO<T> KMMIECOBGKO(global::PALBEJLAEDO<T> MGEDBPNDFJG, Action<T> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NIBDJFBMCPC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T, U> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T, U> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class KDJLKKHDCLF<T, U> : global::HHNJAFFHALD<Action<T, U>>, global::NIBDJFBMCPC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public KDJLKKHDCLF(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x31A0180", Offset = "0x319F380", VA = "0x1831A0180")]
	public void CCNLNBIKCNF(T ELLGECINNIM, U HNHOGLANJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x31A58E0", Offset = "0x31A4AE0", VA = "0x1831A58E0", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x31A2EC0", Offset = "0x31A20C0", VA = "0x1831A2EC0")]
	public static global::KDJLKKHDCLF<T, U> FBGPCCMIGKB(global::KDJLKKHDCLF<T, U> MGEDBPNDFJG, Action<T, U> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x31A2F60", Offset = "0x31A2160", VA = "0x1831A2F60")]
	public static global::KDJLKKHDCLF<T, U> KMMIECOBGKO(global::KDJLKKHDCLF<T, U> MGEDBPNDFJG, Action<T, U> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface MCBBEFPCPPI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T, U, V> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T, U, V> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class PPPJAGEECFK<T, U, V> : global::HHNJAFFHALD<Action<T, U, V>>, global::MCBBEFPCPPI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public PPPJAGEECFK(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD570", Offset = "0x3BBC770", VA = "0x183BBD570")]
	public void CCNLNBIKCNF(T ELLGECINNIM, U HNHOGLANJGO, V HBLIEEAHDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF480", Offset = "0x3BBE680", VA = "0x183BBF480", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE500", Offset = "0x3BBD700", VA = "0x183BBE500")]
	public static global::PPPJAGEECFK<T, U, V> FBGPCCMIGKB(global::PPPJAGEECFK<T, U, V> MGEDBPNDFJG, Action<T, U, V> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE5A0", Offset = "0x3BBD7A0", VA = "0x183BBE5A0")]
	public static global::PPPJAGEECFK<T, U, V> KMMIECOBGKO(global::PPPJAGEECFK<T, U, V> MGEDBPNDFJG, Action<T, U, V> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface GJGNAEBIEIK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T, U, V, W> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T, U, V, W> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class HOFHOFENAKO<T, U, V, W> : global::HHNJAFFHALD<Action<T, U, V, W>>, global::GJGNAEBIEIK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public HOFHOFENAKO(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x37BBB80", Offset = "0x37BAD80", VA = "0x1837BBB80")]
	public void CCNLNBIKCNF(T ELLGECINNIM, U HNHOGLANJGO, V HBLIEEAHDEM, W BBPCEFEBLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x37BE640", Offset = "0x37BD840", VA = "0x1837BE640", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x37BD3B0", Offset = "0x37BC5B0", VA = "0x1837BD3B0")]
	public static global::HOFHOFENAKO<T, U, V, W> FBGPCCMIGKB(global::HOFHOFENAKO<T, U, V, W> MGEDBPNDFJG, Action<T, U, V, W> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x37BD450", Offset = "0x37BC650", VA = "0x1837BD450")]
	public static global::HOFHOFENAKO<T, U, V, W> KMMIECOBGKO(global::HOFHOFENAKO<T, U, V, W> MGEDBPNDFJG, Action<T, U, V, W> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface JMBLHBHIKNO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T, U, V, W, X> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T, U, V, W, X> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class OCOFMHOGNEB<T, U, V, W, X> : global::HHNJAFFHALD<Action<T, U, V, W, X>>, global::JMBLHBHIKNO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public OCOFMHOGNEB(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4352BA0", Offset = "0x4351DA0", VA = "0x184352BA0")]
	public void CCNLNBIKCNF(T ELLGECINNIM, U HNHOGLANJGO, V HBLIEEAHDEM, W BBPCEFEBLNB, X NJBKHCBPNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x43532A0", Offset = "0x43524A0", VA = "0x1843532A0", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4352E40", Offset = "0x4352040", VA = "0x184352E40")]
	public static global::OCOFMHOGNEB<T, U, V, W, X> FBGPCCMIGKB(global::OCOFMHOGNEB<T, U, V, W, X> MGEDBPNDFJG, Action<T, U, V, W, X> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4352EE0", Offset = "0x43520E0", VA = "0x184352EE0")]
	public static global::OCOFMHOGNEB<T, U, V, W, X> KMMIECOBGKO(global::OCOFMHOGNEB<T, U, V, W, X> MGEDBPNDFJG, Action<T, U, V, W, X> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KNAKICPKDMJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLOBDHPAIC(Action<T, U, V, W, X, Y> DINDBGHHKFD, bool GLJGFHPFODH = false);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNIDDOJOCKH(Action<T, U, V, W, X, Y> DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class GPOFDMMPJFD<T, U, V, W, X, Y> : global::HHNJAFFHALD<Action<T, U, V, W, X, Y>>, global::KNAKICPKDMJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x21854A0", VA = "0x1821862A0")]
	public GPOFDMMPJFD(bool MDECONADOJB = false, bool PKIGJGOLBDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x21854A0", Offset = "0x21846A0", VA = "0x1821854A0")]
	public void CCNLNBIKCNF(T ELLGECINNIM, U HNHOGLANJGO, V HBLIEEAHDEM, W BBPCEFEBLNB, X NJBKHCBPNDB, Y CBNFMHDNCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2185F60", Offset = "0x2185160", VA = "0x182185F60", Slot = "4")]
	public override void LODKJKOEFML(object[] KNBHIGDFKBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2185760", Offset = "0x2184960", VA = "0x182185760")]
	public static global::GPOFDMMPJFD<T, U, V, W, X, Y> FBGPCCMIGKB(global::GPOFDMMPJFD<T, U, V, W, X, Y> MGEDBPNDFJG, Action<T, U, V, W, X, Y> DINDBGHHKFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2185800", Offset = "0x2184A00", VA = "0x182185800")]
	public static global::GPOFDMMPJFD<T, U, V, W, X, Y> KMMIECOBGKO(global::GPOFDMMPJFD<T, U, V, W, X, Y> MGEDBPNDFJG, Action<T, U, V, W, X, Y> DINDBGHHKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public sealed class CKALCNMFFOH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct IPMJCKFDKFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::CKALCNMFFOH<T> GCGMLOEDDEJ;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public T AMCKDLHOFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x26EC5D0", Offset = "0x26EB7D0", VA = "0x1826EC5D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x26EC5A0", Offset = "0x26EB7A0", VA = "0x1826EC5A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
		public IPMJCKFDKFG(global::CKALCNMFFOH<T> GCGMLOEDDEJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct LCKJJODHGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<IPMJCKFDKFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::CKALCNMFFOH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x26EC990", Offset = "0x26EBB90", VA = "0x1826EC990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1E45F30", Offset = "0x1E45130", VA = "0x181E45F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct KPMFADEAIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<IPMJCKFDKFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::CKALCNMFFOH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x26EC7C0", Offset = "0x26EB9C0", VA = "0x1826EC7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1E45F30", Offset = "0x1E45130", VA = "0x181E45F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim LOLIBCDMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T LFDIJDKLPJK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int OEKHCFLOHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x26D7BD0", Offset = "0x26D6DD0", VA = "0x1826D7BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x26D7CA0", Offset = "0x26D6EA0", VA = "0x1826D7CA0")]
	public CKALCNMFFOH(in T LFDIJDKLPJK, int JDHPCCBOICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x26D7C70", Offset = "0x26D6E70", VA = "0x1826D7C70")]
	public CKALCNMFFOH(in T LFDIJDKLPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x26D7C30", Offset = "0x26D6E30", VA = "0x1826D7C30")]
	public IPMJCKFDKFG NPAJGFAMAON()
	{
		return default(IPMJCKFDKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x26D7BF0", Offset = "0x26D6DF0", VA = "0x1826D7BF0")]
	public IPMJCKFDKFG NPAJGFAMAON(CancellationToken MNPKHBAPNDC)
	{
		return default(IPMJCKFDKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x26D7610", Offset = "0x26D6810", VA = "0x1826D7610")]
	[AsyncStateMachine(typeof(global::CKALCNMFFOH<>.LCKJJODHGAM))]
	public Task<IPMJCKFDKFG> LNJJLLFDLBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x26D7A50", Offset = "0x26D6C50", VA = "0x1826D7A50")]
	[AsyncStateMachine(typeof(global::CKALCNMFFOH<>.KPMFADEAIJF))]
	public Task<IPMJCKFDKFG> LNJJLLFDLBF(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class OPCOPEBKLCF
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDF00", Offset = "0x4EFD100", VA = "0x184EFDF00")]
	public static global::CKALCNMFFOH<HMPNKJEOEKH> ECPJFBMNCEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDF60", Offset = "0x4EFD160", VA = "0x184EFDF60")]
	public static global::CKALCNMFFOH<HMPNKJEOEKH> ECPJFBMNCEK(int JDHPCCBOICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x18EF9C0", Offset = "0x18EEBC0", VA = "0x1818EF9C0")]
	public static global::CKALCNMFFOH<T> ECPJFBMNCEK<T>(in T LFDIJDKLPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x191FFE0", Offset = "0x191F1E0", VA = "0x18191FFE0")]
	public static global::CKALCNMFFOH<T> ECPJFBMNCEK<T>(in T LFDIJDKLPJK, int JDHPCCBOICG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JEFLDBDIHKF<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public delegate bool OLABIKJNEMO(global::JEFLDBDIHKF<T> MBNJFBIGPPP);

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class JEAIHKAJIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public global::JEFLDBDIHKF<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public JEAIHKAJIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x38BACC0", Offset = "0x38B9EC0", VA = "0x1838BACC0")]
		internal bool <FindNode>b__0(global::JEFLDBDIHKF<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public T CDCLNPGIGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LinkedList<global::JEFLDBDIHKF<T>> INLLGAJJCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public global::JEFLDBDIHKF<T> GENMKMIPEIP;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::JEFLDBDIHKF<T> JEOIJKMCIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x59F950", Offset = "0x59EB50", VA = "0x18059F950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x38BBB40", Offset = "0x38BAD40", VA = "0x1838BBB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool DGGCGHIFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x38BC510", Offset = "0x38BB710", VA = "0x1838BC510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool AFKPGHBIDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x38BD360", Offset = "0x38BC560", VA = "0x1838BD360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public global::JEFLDBDIHKF<T> GHEDAMOCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x38BDC70", Offset = "0x38BCE70", VA = "0x1838BDC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x38BE010", Offset = "0x38BD210", VA = "0x1838BE010")]
	public JEFLDBDIHKF(T AIAAIMCBOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x38BDA60", Offset = "0x38BCC60", VA = "0x1838BDA60")]
	public global::JEFLDBDIHKF<T> KBANPNFKKPL(T LIFJICDCNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x38BCFD0", Offset = "0x38BC1D0", VA = "0x1838BCFD0")]
	public global::JEFLDBDIHKF<T> FOHFKNKCNFH(T FIHKEMKJOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x38BDCF0", Offset = "0x38BCEF0", VA = "0x1838BDCF0")]
	public global::JEFLDBDIHKF<T> MNIDDOJOCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x38BC2B0", Offset = "0x38BB4B0", VA = "0x1838BC2B0")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x38BDE30", Offset = "0x38BD030", VA = "0x1838BDE30")]
	public global::JEFLDBDIHKF<T> NIEJKMJIKAJ(T JILEPKFEGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x38BD3E0", Offset = "0x38BC5E0", VA = "0x1838BD3E0")]
	public static void JJJEBPGDCJO(global::JEFLDBDIHKF<T> JBBAHCEJALG, OLABIKJNEMO BIPINHFPINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EC50", Offset = "0x2A5DE50", VA = "0x182A5EC50")]
	public static void JJJEBPGDCJO<A>(global::JEFLDBDIHKF<T> JBBAHCEJALG, Func<global::JEFLDBDIHKF<T>, A, bool> BIPINHFPINC, A OEDMLNBLEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x38BC540", Offset = "0x38BB740", VA = "0x1838BC540")]
	public static string FMBINNNJEBH(global::JEFLDBDIHKF<T> JBBAHCEJALG, int LNPLMCEIBJD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x38BBE30", Offset = "0x38BB030", VA = "0x1838BBE30")]
	public static global::JEFLDBDIHKF<T> DDLELCPEOHC(global::JEFLDBDIHKF<T> JBBAHCEJALG, T NEFKBCIOEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class ANBDCELLPFH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public delegate Task<TResult> LNIKBLMJCFF(TRequest JENMNBIOPFE, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum JGDAJJDOLLI
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HIAINIAFOHA
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private const float CNDDCGNBNKA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TimeSpan EKOMLDPDANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int NJHLFGGIOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JGDAJJDOLLI PFNMDKIPOPK;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly HIAINIAFOHA MLLBELOGAMP;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float JNPHHGKAGKD
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x3A39180", Offset = "0x3A38380", VA = "0x183A39180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public TimeSpan OCBNJDNHPLI
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3A392D0", Offset = "0x3A384D0", VA = "0x183A392D0")]
		public HIAINIAFOHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private readonly struct HKFOMGDDLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly TRequest JENMNBIOPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly CancellationToken MNPKHBAPNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TaskCompletionSource<TResult> DPOJINMJOKD;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3A393B0", Offset = "0x3A385B0", VA = "0x183A393B0")]
		public HKFOMGDDLMB(TRequest JENMNBIOPFE, TaskCompletionSource<TResult> DPOJINMJOKD, CancellationToken MNPKHBAPNDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class IPBEHMHDBNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public IPBEHMHDBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct DICGOONLHDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::ANBDCELLPFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3A389B0", Offset = "0x3A37BB0", VA = "0x183A389B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class OHGHCFKLFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HKFOMGDDLMB req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::ANBDCELLPFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public OHGHCFKLFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3A3CF10", Offset = "0x3A3C110", VA = "0x183A3CF10")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CancellationTokenSource KJBLLPFMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<HKFOMGDDLMB> EIKJLFFNGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly HIAINIAFOHA GDPIPGPMFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly LNIKBLMJCFF HLBPEMCAPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Task DOIMLNCKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int PHMKPLGAMNP;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3A302D0", Offset = "0x3A2F4D0", VA = "0x183A302D0")]
	public ANBDCELLPFH(LNIKBLMJCFF HLBPEMCAPOM, [Optional] HIAINIAFOHA GDPIPGPMFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3A2ED50", Offset = "0x3A2DF50", VA = "0x183A2ED50")]
	public Task<TResult> DODMHAGJIMG(TRequest JENMNBIOPFE, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F550", Offset = "0x3A2E750", VA = "0x183A2F550")]
	private void EJBPOLEPLPI(HKFOMGDDLMB NBBLLICANBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F780", Offset = "0x3A2E980", VA = "0x183A2F780")]
	[AsyncStateMachine(typeof(global::ANBDCELLPFH<, >.DICGOONLHDA))]
	private Task JCJIMPLOMME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E860", Offset = "0x3A2DA60", VA = "0x183A2E860")]
	private HKFOMGDDLMB AMPCLHFIEOJ()
	{
		return default(HKFOMGDDLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3A2FD80", Offset = "0x3A2EF80", VA = "0x183A2FD80")]
	private void PBCPMHEEAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F470", Offset = "0x3A2E670", VA = "0x183A2F470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class AFJEMDPBNPF<TKey, TVal> : global::BGFJGCDALJJ<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JDFGNPHALIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> NAEIPHPELBE;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	internal override int OBHNMHMJKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x201AC10", Offset = "0x2019E10", VA = "0x18201AC10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal int OCEPHOLJANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x201A890", Offset = "0x2019A90", VA = "0x18201A890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public override int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x201A6E0", Offset = "0x20198E0", VA = "0x18201A6E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x201AC40", Offset = "0x2019E40", VA = "0x18201AC40")]
	public AFJEMDPBNPF(int EICHEFNLNOA, [Optional] NADOAAENEDD BBBOCCKHPLL, [Optional] IEqualityComparer<TKey> BIGHHANHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x201A8C0", Offset = "0x2019AC0", VA = "0x18201A8C0")]
	public void JIMGLPDFCKB(TKey DHDAEDILENC, TVal PNLMJAPAHBD, bool BFJJKMFBPNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x201A960", Offset = "0x2019B60", VA = "0x18201A960")]
	public bool KEAEFAAAHDF(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x201A740", Offset = "0x2019940", VA = "0x18201A740", Slot = "6")]
	public override bool FIDGIGFFKFJ(TKey JJOFCDOLBEH, out TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x201A9E0", Offset = "0x2019BE0", VA = "0x18201A9E0")]
	public bool LKLJNALJOKD(TKey DHDAEDILENC, TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x201A560", Offset = "0x2019760", VA = "0x18201A560")]
	public bool BEHEMCCNHLH(TKey DHDAEDILENC, TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x201A670", Offset = "0x2019870", VA = "0x18201A670", Slot = "7")]
	public override void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x201A7F0", Offset = "0x20199F0", VA = "0x18201A7F0")]
	private bool FMCIKDJABMJ(TKey DHDAEDILENC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
public class BGFJGCDALJJ<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public delegate int NADOAAENEDD(TKey DHDAEDILENC, TVal PNLMJAPAHBD);

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class AGCLODNFMPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TKey PKFENIANCPD
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TVal AMCKDLHOFMB
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6070A0", Offset = "0x6062A0", VA = "0x1806070A0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x6070C0", Offset = "0x6062C0", VA = "0x1806070C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int PHMELCGNMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x64BA40", Offset = "0x64AC40", VA = "0x18064BA40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x64BA50", Offset = "0x64AC50", VA = "0x18064BA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DateTime BNDJENACJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x954A00", Offset = "0x953C00", VA = "0x180954A00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x40CD320", Offset = "0x40CC520", VA = "0x1840CD320")]
		public AGCLODNFMPK(TKey DHDAEDILENC, TVal OMOAPINBBMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int PAFEMCJGKKG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<AGCLODNFMPK>> FNNOMGKENKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<AGCLODNFMPK> FJHKJJOHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly NADOAAENEDD BBBOCCKHPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan OJPBPHKAMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly KKPDIOBBDLE OHMIOCCACPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int HPIFIHHNLKK;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int ENMCFBNCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD30", Offset = "0x5CBF30", VA = "0x1805CCD30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private bool LNALENLPMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x40D96E0", Offset = "0x40D88E0", VA = "0x1840D96E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	internal virtual int OBHNMHMJKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD40", Offset = "0x5CBF40", VA = "0x1805CCD40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private int KOAOGJIGGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1C99280", Offset = "0x1C98480", VA = "0x181C99280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public virtual int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x17C79C0", Offset = "0x17C6BC0", VA = "0x1817C79C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<TKey> LBPFCCEONND
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x40D9E70", Offset = "0x40D9070", VA = "0x1840D9E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public TVal DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3066980", Offset = "0x3065B80", VA = "0x183066980")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7400", Offset = "0x1CF6600", VA = "0x181CF7400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x40DAA80", Offset = "0x40D9C80", VA = "0x1840DAA80")]
	public BGFJGCDALJJ(int EICHEFNLNOA, [Optional] NADOAAENEDD BBBOCCKHPLL, [Optional] IEqualityComparer<TKey> BIGHHANHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x40DAB50", Offset = "0x40D9D50", VA = "0x1840DAB50")]
	public BGFJGCDALJJ(TimeSpan OJPBPHKAMNI, [Optional] IEqualityComparer<TKey> BIGHHANHAGE, [Optional] KKPDIOBBDLE OHMIOCCACPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x40DA7E0", Offset = "0x40D99E0", VA = "0x1840DA7E0")]
	public BGFJGCDALJJ(int EICHEFNLNOA, TimeSpan OJPBPHKAMNI, [Optional] IEqualityComparer<TKey> BIGHHANHAGE, [Optional] KKPDIOBBDLE OHMIOCCACPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x40DA830", Offset = "0x40D9A30", VA = "0x1840DA830")]
	public BGFJGCDALJJ(int EICHEFNLNOA, NADOAAENEDD BBBOCCKHPLL, TimeSpan OJPBPHKAMNI, [Optional] IEqualityComparer<TKey> BIGHHANHAGE, [Optional] KKPDIOBBDLE OHMIOCCACPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x40D9570", Offset = "0x40D8770", VA = "0x1840D9570")]
	public void EHEMMALJIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x40D9220", Offset = "0x40D8420", VA = "0x1840D9220")]
	public void BIGDAPHKFNM(TKey DHDAEDILENC, TVal PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x40DA090", Offset = "0x40D9290", VA = "0x1840DA090")]
	public bool MNIDDOJOCKH(TKey DHDAEDILENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x40D9450", Offset = "0x40D8650", VA = "0x1840D9450")]
	private TVal DCCAFIHBGKB(TKey JJOFCDOLBEH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x40D9770", Offset = "0x40D8970", VA = "0x1840D9770", Slot = "6")]
	public virtual bool FIDGIGFFKFJ(TKey JJOFCDOLBEH, out TVal PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x40D9500", Offset = "0x40D8700", VA = "0x1840D9500", Slot = "7")]
	public virtual void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x40DA590", Offset = "0x40D9790", VA = "0x1840DA590")]
	private bool PNGODHNJLAM(AGCLODNFMPK GOHLBANHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x40D9C40", Offset = "0x40D8E40", VA = "0x1840D9C40")]
	private void GNLBJKPMJML(LinkedListNode<AGCLODNFMPK> EBBKMHAMMKG, TVal OGKDGJDCPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x40DA3C0", Offset = "0x40D95C0", VA = "0x1840DA3C0")]
	private void NKBPPDODNBD(TKey DHDAEDILENC, TVal PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x40D9080", Offset = "0x40D8280", VA = "0x1840D9080")]
	private void BGDEHNCDHDL(AGCLODNFMPK GOHLBANHDJB, TVal OGKDGJDCPLP, int NKMKIPLDEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DefaultMember("Item")]
public class EOCNIIIEIBF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> OPPKLAEFHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> HBPNHBDIDNI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool PHAFKGDPGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x25FDF40", Offset = "0x25FD140", VA = "0x1825FDF40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AB30", Offset = "0x2C49D30", VA = "0x182C4AB30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A1B0", Offset = "0x2C493B0", VA = "0x182C4A1B0", Slot = "11")]
	public void Add(T PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A6D0", Offset = "0x2C498D0", VA = "0x182C4A6D0")]
	public bool NCLDJIPBNOB(T PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A9D0", Offset = "0x2C49BD0", VA = "0x182C4A9D0", Slot = "15")]
	public bool Remove(T PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A270", Offset = "0x2C49470", VA = "0x182C4A270", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1B2C200", Offset = "0x1B2B400", VA = "0x181B2C200", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A1E0", Offset = "0x2C493E0", VA = "0x182C4A1E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C94B30", Offset = "0x1C93D30", VA = "0x181C94B30", Slot = "13")]
	public bool Contains(T PBADFAIJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A240", Offset = "0x2C49440", VA = "0x182C4A240", Slot = "14")]
	public void CopyTo(T[] IBNOFMOJNKD, int ODJLDMJPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x220B370", Offset = "0x220A570", VA = "0x18220B370", Slot = "6")]
	public int IndexOf(T PBADFAIJJOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A3C0", Offset = "0x2C495C0", VA = "0x182C4A3C0", Slot = "7")]
	public void Insert(int PPMIPKENDBN, T PBADFAIJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A870", Offset = "0x2C49A70", VA = "0x182C4A870", Slot = "8")]
	public void RemoveAt(int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A550", Offset = "0x2C49750", VA = "0x182C4A550")]
	public void MPBDEDPNACP(Predicate<T> LHOELMCHLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A770", Offset = "0x2C49970", VA = "0x182C4A770")]
	public void PFGOCAAGCAP(Comparison<T> NHEMKCJFKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AA50", Offset = "0x2C49C50", VA = "0x182C4AA50")]
	public EOCNIIIEIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class JJKIJOCFFGH
{
	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCB40", Offset = "0x4EFBD40", VA = "0x184EFCB40")]
	public static Vector3 CIEIIFHPPCH(this GameObject JMCMCLEMHIC, float AMMEKEPABFD)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9600", Offset = "0x1CD8800", VA = "0x181CD9600")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4F01CE0", Offset = "0x4F00EE0", VA = "0x184F01CE0")]
		public SerializedGuid(in Guid BKKEEPLCOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F018C0", Offset = "0x4F00AC0", VA = "0x184F018C0")]
		public static SerializedGuid CKPKBKJPGNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F01970", Offset = "0x4F00B70", VA = "0x184F01970")]
		public static SerializedGuid EOMNEOBJIGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F01830", Offset = "0x4F00A30", VA = "0x184F01830")]
		public bool AACIJFDDOIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F01CB0", Offset = "0x4F00EB0", VA = "0x184F01CB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F01C10", Offset = "0x4F00E10", VA = "0x184F01C10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F01B80", Offset = "0x4F00D80", VA = "0x184F01B80")]
		public bool HNONPHLDFEM(in Guid BKKEEPLCOHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x4F019F0", Offset = "0x4F00BF0", VA = "0x184F019F0", Slot = "7")]
		public bool Equals(SerializedGuid EBJKBJMLDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F01A90", Offset = "0x4F00C90", VA = "0x184F01A90", Slot = "0")]
		public override bool Equals(object CEEAMODAEEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F01B70", Offset = "0x4F00D70", VA = "0x184F01B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F01940", Offset = "0x4F00B40", VA = "0x184F01940", Slot = "6")]
		public int CompareTo(SerializedGuid EBJKBJMLDOO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AAJJELMFLFP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type LIGNLPJDDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string PMBEKOGFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool FLHJJHBLJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool OIPFFKONHON;

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA300", Offset = "0x4EF9500", VA = "0x184EFA300")]
	public AAJJELMFLFP(Type EJMMIMHMKOF, string LELFMFELNMG, bool EKCANMMALGK = false, bool OFFHPICLCLP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface JPOKFNFFCPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface ICMNPLIIFEF<T> : JPOKFNFFCPG
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	T AMCKDLHOFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool BBIHACFDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string BGNNOAJOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::ICMNPLIIFEF<T> HBMKFBHLJGO(Action<T> KIFGAIPBOCF);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::ICMNPLIIFEF<T> NADDEFAINJC(Action<T> KIFGAIPBOCF);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::ICMNPLIIFEF<T> LGAFCPOAPBO(Action<T, T> ANLIFDEFHJA);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::ICMNPLIIFEF<T> MANAHMOAJOF(Action<T, T> ANLIFDEFHJA);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::ICMNPLIIFEF<T> MBDEKDLLKDH(Action<string> IGJCELEICPH);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::ICMNPLIIFEF<T> PKNODODFENI(Action<string> IGJCELEICPH);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HHMLPKKNBDJ<T> : global::ICMNPLIIFEF<T>, JPOKFNFFCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::KDJLKKHDCLF<T, T> KNMEEEFAGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::PALBEJLAEDO<T> APGPEAJJBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::PALBEJLAEDO<string> ICLKHGPOOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string GNGKCJGCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T HPCDOCAJMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool LDJFOFBHHPC;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T AMCKDLHOFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C580", Offset = "0x1E3B780", VA = "0x181E3C580", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool BBIHACFDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D7180", Offset = "0x5D6380", VA = "0x1805D7180", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string BGNNOAJOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C550", Offset = "0x1E3B750", VA = "0x181E3C550", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C640", Offset = "0x1E3B840", VA = "0x181E3C640")]
	private void HIDJLFDDMID(T IMJFNGNMFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C860", Offset = "0x1E3BA60", VA = "0x181E3C860")]
	private void NPAANEDDFLL(string MPHBMEGMJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C900", Offset = "0x1E3BB00", VA = "0x181E3C900")]
	public void PBDOEKBABBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C6E0", Offset = "0x1E3B8E0", VA = "0x181E3C6E0", Slot = "6")]
	public global::ICMNPLIIFEF<T> LGAFCPOAPBO(Action<T, T> ANLIFDEFHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C730", Offset = "0x1E3B930", VA = "0x181E3C730", Slot = "7")]
	public global::ICMNPLIIFEF<T> MANAHMOAJOF(Action<T, T> ANLIFDEFHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C5B0", Offset = "0x1E3B7B0", VA = "0x181E3C5B0", Slot = "4")]
	public global::ICMNPLIIFEF<T> HBMKFBHLJGO(Action<T> ANLIFDEFHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C810", Offset = "0x1E3BA10", VA = "0x181E3C810", Slot = "5")]
	public global::ICMNPLIIFEF<T> NADDEFAINJC(Action<T> KIFGAIPBOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C780", Offset = "0x1E3B980", VA = "0x181E3C780", Slot = "8")]
	public global::ICMNPLIIFEF<T> MBDEKDLLKDH(Action<string> IGJCELEICPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C9B0", Offset = "0x1E3BBB0", VA = "0x181E3C9B0", Slot = "9")]
	public global::ICMNPLIIFEF<T> PKNODODFENI(Action<string> IGJCELEICPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CA20", Offset = "0x1E3BC20", VA = "0x181E3CA20")]
	public HHMLPKKNBDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class JMNCGGPPOFK
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BMGDLGEEJBG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::ICMNPLIIFEF<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::CJNJOHDMLHP<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public BMGDLGEEJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3984D60", Offset = "0x3983F60", VA = "0x183984D60")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x19C2690", Offset = "0x19C1890", VA = "0x1819C2690")]
	public static global::IAGOKENNLHI<T> LDOFPKIAPPK<T>(this global::ICMNPLIIFEF<T> DFPKKJGJCHO, Action<T> KMEGFPKBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class MKPPAJLLJAE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public readonly struct JEPKFGJBKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long MHOMJNBBKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long JGMMIMAMGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int PHKLHBCGPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int LNNEEAPKGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool HIGGCDJOHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string AAIFFOFIEAG;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x24ECFA0", Offset = "0x24EC1A0", VA = "0x1824ECFA0")]
		public JEPKFGJBKOE(long MHOMJNBBKBK, int PHKLHBCGPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x24ECF70", Offset = "0x24EC170", VA = "0x1824ECF70")]
		public JEPKFGJBKOE(long MHOMJNBBKBK, long JGMMIMAMGLG, int PHKLHBCGPED, int LNNEEAPKGHO, bool HIGGCDJOHHE, string AAIFFOFIEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x24ECD60", Offset = "0x24EBF60", VA = "0x1824ECD60")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CJNKDEONNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x24ECF20", Offset = "0x24EC120", VA = "0x1824ECF20")]
		public int NPBNALFJJOA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x24ECF00", Offset = "0x24EC100", VA = "0x1824ECF00")]
		public int LFIHNIMANGF(int PAIBLMEOEBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x24ECE90", Offset = "0x24EC090", VA = "0x1824ECE90")]
		public double IACJMHCAFND()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x24ECDD0", Offset = "0x24EBFD0", VA = "0x1824ECDD0")]
		public JEPKFGJBKOE FKKANAAKKBP(long JGMMIMAMGLG, int LNNEEAPKGHO)
		{
			return default(JEPKFGJBKOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class FGDOGDEIJDO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey PKFENIANCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::MKPPAJLLJAE<TKey> IDJNPLHMMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<FGDOGDEIJDO> CBHDEKJLKGD;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string MEEGFFGIEEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x23B9620", Offset = "0x23B8820", VA = "0x1823B9620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x24E7EE0", Offset = "0x24E70E0", VA = "0x1824E7EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public IEnumerable<FGDOGDEIJDO> INLLGAJJCFE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x24E7F10", Offset = "0x24E7110", VA = "0x1824E7F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public JEPKFGJBKOE NICJHNGPKAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xB73580", Offset = "0xB72780", VA = "0x180B73580")]
			[CompilerGenerated]
			get
			{
				return default(JEPKFGJBKOE);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x24E7CF0", Offset = "0x24E6EF0", VA = "0x1824E7CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x24E8140", Offset = "0x24E7340", VA = "0x1824E8140")]
		internal FGDOGDEIJDO(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, TKey DHDAEDILENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x24E7F30", Offset = "0x24E7130", VA = "0x1824E7F30")]
		public FGDOGDEIJDO OKNABCEEMBP(TKey DHDAEDILENC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x24E8040", Offset = "0x24E7240", VA = "0x1824E8040")]
		public void PFKBOHGNMIB(TKey DHDAEDILENC, Action<FGDOGDEIJDO> DINDBGHHKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x193B540", Offset = "0x193A740", VA = "0x18193B540")]
		public T PFKBOHGNMIB<T>(TKey DHDAEDILENC, Func<FGDOGDEIJDO, T> EIKFPIHDCPF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x229ABC0", Offset = "0x2299DC0", VA = "0x18229ABC0")]
		[AsyncStateMachine(typeof(DNMADEAEKKD))]
		public Task<T> FPGODDINOIM<T>(TKey DHDAEDILENC, Func<FGDOGDEIJDO, Task<T>> EIKFPIHDCPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x24E7D20", Offset = "0x24E6F20", VA = "0x1824E7D20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GDLDMFMEDFC : IEnumerable<(TKey, List<TKey>, JEPKFGJBKOE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JEPKFGJBKOE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, JEPKFGJBKOE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::MKPPAJLLJAE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, JEPKFGJBKOE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private (TKey, List<TKey>, JEPKFGJBKOE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x24E8620", Offset = "0x24E7820", VA = "0x1824E8620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JEPKFGJBKOE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x24E86A0", Offset = "0x24E78A0", VA = "0x1824E86A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x24E87D0", Offset = "0x24E79D0", VA = "0x1824E87D0")]
		[DebuggerHidden]
		public GDLDMFMEDFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x24E8700", Offset = "0x24E7900", VA = "0x1824E8700", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x24E82F0", Offset = "0x24E74F0", VA = "0x1824E82F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x24E8780", Offset = "0x24E7980", VA = "0x1824E8780")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x24E8650", Offset = "0x24E7850", VA = "0x1824E8650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x24E8560", Offset = "0x24E7760", VA = "0x1824E8560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JEPKFGJBKOE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B3ABB0", Offset = "0x1B39DB0", VA = "0x181B3ABB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HALFOFNCHOK : IEnumerable<(TKey, List<TKey>, JEPKFGJBKOE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JEPKFGJBKOE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, JEPKFGJBKOE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private FGDOGDEIJDO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FGDOGDEIJDO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::MKPPAJLLJAE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<FGDOGDEIJDO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, JEPKFGJBKOE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private (TKey, List<TKey>, JEPKFGJBKOE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x24E8620", Offset = "0x24E7820", VA = "0x1824E8620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JEPKFGJBKOE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x24E9630", Offset = "0x24E8830", VA = "0x1824E9630", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x24E87D0", Offset = "0x24E79D0", VA = "0x1824E87D0")]
		[DebuggerHidden]
		public HALFOFNCHOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x24E9690", Offset = "0x24E8890", VA = "0x1824E9690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x24E8FA0", Offset = "0x24E81A0", VA = "0x1824E8FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x24E9760", Offset = "0x24E8960", VA = "0x1824E9760")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x24E97B0", Offset = "0x24E89B0", VA = "0x1824E97B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x24E95E0", Offset = "0x24E87E0", VA = "0x1824E95E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x24E94E0", Offset = "0x24E86E0", VA = "0x1824E94E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JEPKFGJBKOE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x24E95B0", Offset = "0x24E87B0", VA = "0x1824E95B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, JEPKFGJBKOE> JDFMEOAEKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, JEPKFGJBKOE> KNPEFHFENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::MKPPAJLLJAE<TKey>> BKLNIIBOLGA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string JEJLDHCNGHH = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly FGDOGDEIJDO IHAAPNOBDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool BJOLDLCEHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int DHNKIKJHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch CBKJLJBKGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int NEDILGBDEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string IJELAINAEAA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FGDOGDEIJDO BIAJKNOLDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	[NotNull]
	public string MEEGFFGIEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x59F950", Offset = "0x59EB50", VA = "0x18059F950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x24F2F00", Offset = "0x24F2100", VA = "0x1824F2F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long LCHAJEICBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x24F30C0", Offset = "0x24F22C0", VA = "0x1824F30C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int AMHOPKAMHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x24F2D70", Offset = "0x24F1F70", VA = "0x1824F2D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x24F30E0", Offset = "0x24F22E0", VA = "0x1824F30E0")]
	public MKPPAJLLJAE(TKey AFGLPDLJBKK, [Optional] int? PHKLHBCGPED, [Optional][CanBeNull] Stopwatch CBKJLJBKGKC, [Optional] Action<TKey, JEPKFGJBKOE> JDFMEOAEKNN, [Optional] Action<TKey, JEPKFGJBKOE> KNPEFHFENCI, [Optional] Action<global::MKPPAJLLJAE<TKey>> BKLNIIBOLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DC0", Offset = "0x24F1FC0", VA = "0x1824F2DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DA0", Offset = "0x24F1FA0", VA = "0x1824F2DA0")]
	public void CEIIELJAJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x24F2EE0", Offset = "0x24F20E0", VA = "0x1824F2EE0")]
	public void GICFPECINJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x24F3030", Offset = "0x24F2230", VA = "0x1824F3030")]
	[IteratorStateMachine(typeof(global::MKPPAJLLJAE<>.GDLDMFMEDFC))]
	public IEnumerable<(TKey, List<TKey>, JEPKFGJBKOE)> KAPPCJEONIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x24F2F60", Offset = "0x24F2160", VA = "0x1824F2F60")]
	[IteratorStateMachine(typeof(global::MKPPAJLLJAE<>.HALFOFNCHOK))]
	private IEnumerable<(TKey, List<TKey>, JEPKFGJBKOE)> KAPPCJEONIM(List<TKey> ONIMCFGGJHN, FGDOGDEIJDO JACLJOJFPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x24F2E50", Offset = "0x24F2050", VA = "0x1824F2E50")]
	private (long, int) ECKFFCIONCO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class IEHFDNKFCDE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut LBDNDBDCLHD(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected IEHFDNKFCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class LLACCAJOFHH<TKey> : global::IEHFDNKFCDE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate string BPJIOGNBPCK(TKey DHDAEDILENC);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1D01B50", Offset = "0x1D00D50", VA = "0x181D01B50")]
	protected string DECAKHKEMCJ(double JEMDJMLMFDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1D01B00", Offset = "0x1D00D00", VA = "0x181D01B00")]
	protected string BKLFIPGEPBL(int CDFJMHFILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1D01D80", Offset = "0x1D00F80", VA = "0x181D01D80")]
	private static string OHEJPLMCAMM(TKey DHDAEDILENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1D01BB0", Offset = "0x1D00DB0", VA = "0x181D01BB0", Slot = "4")]
	public override string LBDNDBDCLHD(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1D01C60", Offset = "0x1D00E60", VA = "0x181D01C60")]
	public string LBDNDBDCLHD(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, [NotNull] BPJIOGNBPCK DJFAFDECMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string JJJKDLMNHGI(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, [NotNull] BPJIOGNBPCK DJFAFDECMGO);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1B35A70", Offset = "0x1B34C70", VA = "0x181B35A70")]
	protected LLACCAJOFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class EHAAJALCLNH<TKey> : global::IEHFDNKFCDE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public delegate string LDHIHMCBDLM(TKey DHDAEDILENC);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int FDDLGFMNANJ = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string LMLIDDNKIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double JCCBHHIOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool KEHFPGMNJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int FGLBMBCAAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> HCIMBFOLHBG;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x370DC00", Offset = "0x370CE00", VA = "0x18370DC00")]
	private static string OHEJPLMCAMM(TKey DHDAEDILENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x370DC40", Offset = "0x370CE40", VA = "0x18370DC40")]
	public EHAAJALCLNH(string LMLIDDNKIIK = "F2", double JCCBHHIOGHI = double.MaxValue, bool KEHFPGMNJGA = false, int FGLBMBCAAMC = int.MaxValue, [Optional] ISet<string> HCIMBFOLHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x370D910", Offset = "0x370CB10", VA = "0x18370D910", Slot = "4")]
	public override Dictionary<string, string> LBDNDBDCLHD(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x370D9C0", Offset = "0x370CBC0", VA = "0x18370D9C0")]
	private bool LMGNLFIAOGB(string AICFIDKHABF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x370D470", Offset = "0x370C670", VA = "0x18370D470")]
	public Dictionary<string, string> LBDNDBDCLHD(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, LDHIHMCBDLM DJFAFDECMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x370D2C0", Offset = "0x370C4C0", VA = "0x18370D2C0")]
	private string HGLGFKGPEEH(StringBuilder JOANMDNKOGA, List<TKey> JIOAFIMADGA, LDHIHMCBDLM DJFAFDECMGO, bool BOGBGEDNLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x370DAA0", Offset = "0x370CCA0", VA = "0x18370DAA0")]
	private static void LMNILMGEBBL(StringBuilder LDDDMCCDDCL, string LCHIPAGCKNA, bool CBCCEHDBIJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class JCOOAFJHFFF<TKey> : global::LLACCAJOFHH<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct NGKJPINAHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public BPJIOGNBPCK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::JCOOAFJHFFF<TKey> JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int DMKBOEEGCNC = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] ODLNOMKOCCE;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x38BA730", Offset = "0x38B9930", VA = "0x1838BA730")]
	private JCOOAFJHFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x38B9730", Offset = "0x38B8930", VA = "0x1838B9730", Slot = "5")]
	protected override string JJJKDLMNHGI(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, BPJIOGNBPCK DJFAFDECMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x38BA550", Offset = "0x38B9750", VA = "0x1838BA550")]
	[CompilerGenerated]
	internal static string LFBEMDAFADC(string PDCHCJDOLNK, TKey DHDAEDILENC, ref NGKJPINAHDN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class FIJKOENAIJA<TKey> : global::LLACCAJOFHH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class IOOJHAFFIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public BPJIOGNBPCK keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public IOOJHAFFIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1C92C90", Offset = "0x1C91E90", VA = "0x181C92C90")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1C98B00", Offset = "0x1C97D00", VA = "0x181C98B00", Slot = "5")]
	protected override string JJJKDLMNHGI(global::MKPPAJLLJAE<TKey> IDJNPLHMMHL, BPJIOGNBPCK DJFAFDECMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1C99250", Offset = "0x1C98450", VA = "0x181C99250")]
	public FIJKOENAIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class FFBFKNAENPK : global::MKPPAJLLJAE<string>
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class KMPCDHNKFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<FFBFKNAENPK> callback;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KMPCDHNKFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD110", Offset = "0x4EFC310", VA = "0x184EFD110")]
		internal void <Wrap>b__0(global::MKPPAJLLJAE<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4EFBA40", Offset = "0x4EFAC40", VA = "0x184EFBA40")]
	public FFBFKNAENPK([Optional] string MJKBDIDJIDB, [Optional] int? PHKLHBCGPED, [Optional] Stopwatch CBKJLJBKGKC, [Optional] Action<string, JEPKFGJBKOE> JDFMEOAEKNN, [Optional] Action<string, JEPKFGJBKOE> KNPEFHFENCI, [Optional] Action<FFBFKNAENPK> BKLNIIBOLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB980", Offset = "0x4EFAB80", VA = "0x184EFB980")]
	private static Action<global::MKPPAJLLJAE<string>> PFKBOHGNMIB(Action<FFBFKNAENPK> KMEGFPKBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class KKPDIOBBDLE
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class JMAEFJKOCMB : KKPDIOBBDLE
	{
		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static KKPDIOBBDLE JACNMOBBDPN
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4EFCDE0", Offset = "0x4EFBFE0", VA = "0x184EFCDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override DateTime BFOGGCAFLDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4EFCE40", Offset = "0x4EFC040", VA = "0x184EFCE40", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override float CLDMEJEKPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4EFCDD0", Offset = "0x4EFBFD0", VA = "0x184EFCDD0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x4EFCF30", Offset = "0x4EFC130", VA = "0x184EFCF30")]
		public JMAEFJKOCMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static KKPDIOBBDLE DNJMKNHODBJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public static KKPDIOBBDLE MLLBELOGAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x4EFCF90", Offset = "0x4EFC190", VA = "0x184EFCF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public abstract DateTime BFOGGCAFLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract float CLDMEJEKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	protected KKPDIOBBDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class EONHNHENGGN : global::ALOONKLMDOF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB940", Offset = "0x4EFAB40", VA = "0x184EFB940")]
	public EONHNHENGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class ALOONKLMDOF<T> : global::MGPAHIKLEPD<T>, MLDDCKJEIEF, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Task<T> JALLLNFLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Task APPNABNOBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x17B6A70", Offset = "0x17B5C70", VA = "0x1817B6A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public global::IAGOKENNLHI<T> MMCKCEEFDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private IMECNLPEGGD LJCPHFFKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x17BBDC0", Offset = "0x17BAFC0", VA = "0x1817BBDC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2EC94C0", Offset = "0x2EC86C0", VA = "0x182EC94C0")]
	public ALOONKLMDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class JIDENCKPDGN : global::GFKHJBBOPCB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCAF0", Offset = "0x4EFBCF0", VA = "0x184EFCAF0")]
	public JIDENCKPDGN(Exception BEHJIIABFNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class GFKHJBBOPCB<T> : global::MGPAHIKLEPD<T>, MLDDCKJEIEF, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Task<T> JALLLNFLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Task APPNABNOBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x17B6A70", Offset = "0x17B5C70", VA = "0x1817B6A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public global::IAGOKENNLHI<T> MMCKCEEFDND
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private IMECNLPEGGD LJCPHFFKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x17BBDC0", Offset = "0x17BAFC0", VA = "0x1817BBDC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2207400", Offset = "0x2206600", VA = "0x182207400")]
	public GFKHJBBOPCB(Exception BEHJIIABFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface MLDDCKJEIEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[NotNull]
	Task JALLLNFLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	IMECNLPEGGD MMCKCEEFDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface MGPAHIKLEPD<T> : MLDDCKJEIEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	new Task<T> JALLLNFLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	new global::IAGOKENNLHI<T> MMCKCEEFDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class HCMBEFFANKN<TTask, T> : global::MGPAHIKLEPD<T>, MLDDCKJEIEF, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MLCIMLOBAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::HCMBEFFANKN<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public MLCIMLOBAHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool KAELKFLNOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> ALCHLJLEFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource AFPPKFJFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool BJOLDLCEHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext ENFOFPKGBGA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Task<T> JALLLNFLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private Task APPNABNOBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public global::IAGOKENNLHI<T> MMCKCEEFDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private IMECNLPEGGD LJCPHFFKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1B32E70", Offset = "0x1B32070", VA = "0x181B32E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool EIMHGAAHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6074A0", Offset = "0x6066A0", VA = "0x1806074A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1E37800", Offset = "0x1E36A00", VA = "0x181E37800")]
	static HCMBEFFANKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1E37C90", Offset = "0x1E36E90", VA = "0x181E37C90")]
	protected HCMBEFFANKN(TTask ALCHLJLEFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1E37430", Offset = "0x1E36630", VA = "0x181E37430", Slot = "1")]
	~HCMBEFFANKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1E37360", Offset = "0x1E36560", VA = "0x181E37360", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1E37520", Offset = "0x1E36720", VA = "0x181E37520")]
	private void PPFJJMADIKP(bool NIJDGEECGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T OICIKHBPONB(TTask JFFKAOJGBHC);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GAKLILGFCKF();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1E374D0", Offset = "0x1E366D0", VA = "0x181E374D0")]
	[CompilerGenerated]
	private void MPLHBDLMAFF(object AMJBPOHLKIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface MPHPFDHGHKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	float NCCMJIGDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NHHCJIKBFMB IIEGPOMACNJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class BONKGPBDJMA : MPHPFDHGHKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public readonly struct ILJLEPPHDLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float GGEMHIJDKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float DLPKNMAOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool DIDNAKPDMAM;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float PHMELCGNMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC6F0", Offset = "0x4EFB8F0", VA = "0x184EFC6F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x4EFC860", Offset = "0x4EFBA60", VA = "0x184EFC860")]
		public ILJLEPPHDLK(float PIDBKIOIGJG, float BHNHKBKLDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4EFC700", Offset = "0x4EFB900", VA = "0x184EFC700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NELOBPCJKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BONKGPBDJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NELOBPCJKGK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int EICHEFNLNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int DFKMPDFDLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly MPHPFDHGHKJ[] BKANIFPADGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly NHHCJIKBFMB[] FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly ILJLEPPHDLK[] FCHMOBAPBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private ILJLEPPHDLK LNPCEOACPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly ODJOGAELAPJ HOILOJMJNAA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ILJLEPPHDLK KIENCLJPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEDD80", Offset = "0x2FECF80", VA = "0x182FEDD80")]
		get
		{
			return default(ILJLEPPHDLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float NCCMJIGDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4EFACB0", Offset = "0x4EF9EB0", VA = "0x184EFACB0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NHHCJIKBFMB IIEGPOMACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4EFACD0", Offset = "0x4EF9ED0", VA = "0x184EFACD0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x4EFAD90", Offset = "0x4EF9F90", VA = "0x184EFAD90", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB280", Offset = "0x4EFA480", VA = "0x184EFB280")]
	public BONKGPBDJMA(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAA50", Offset = "0x4EF9C50", VA = "0x184EFAA50")]
	public ODJOGAELAPJ CBENOLEENEO(ILJLEPPHDLK DKEPAEMMCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAE50", Offset = "0x4EFA050", VA = "0x184EFAE50")]
	public void LCHDGDJBECE(MPHPFDHGHKJ EOLCKNFHAMO, [Optional] ILJLEPPHDLK ICCMODNKOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAAD0", Offset = "0x4EF9CD0", VA = "0x184EFAAD0")]
	internal int DCCMJLEACFD(MPHPFDHGHKJ LGPKJCGHNFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB230", Offset = "0x4EFA430", VA = "0x184EFB230")]
	internal ILJLEPPHDLK PBOPGFMLAHD(int PPMIPKENDBN)
	{
		return default(ILJLEPPHDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x4EFAB20", Offset = "0x4EF9D20", VA = "0x184EFAB20", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public delegate void NHHCJIKBFMB(float PFDDIJEPIIF);
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class BAGKKECMHAI
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float NMIMHHGCOKH = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class AMLPECEEEBA
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class PIMECKOIDCM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MPHPFDHGHKJ LGPKJCGHNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly NHHCJIKBFMB KMEGFPKBBHD;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF2B0", Offset = "0x4EFE4B0", VA = "0x184EFF2B0")]
		public PIMECKOIDCM(MPHPFDHGHKJ LGPKJCGHNFO, NHHCJIKBFMB KMEGFPKBBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF260", Offset = "0x4EFE460", VA = "0x184EFF260", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA7F0", Offset = "0x4EF99F0", VA = "0x184EFA7F0")]
	internal static bool KBFPPMJCHHN(float JNDOPINGBDA, float CJCOEBBKILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3B06740", Offset = "0x3B05940", VA = "0x183B06740")]
	internal static float PJPALCHLNKJ(float JNDOPINGBDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA870", Offset = "0x4EF9A70", VA = "0x184EFA870")]
	public static IDisposable LHKDAFMDEDO(this MPHPFDHGHKJ LGPKJCGHNFO, NHHCJIKBFMB KMEGFPKBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class ODJOGAELAPJ : MPHPFDHGHKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float PFDDIJEPIIF;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float NCCMJIGDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0710", VA = "0x1809F1510", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x4EFDBD0", Offset = "0x4EFCDD0", VA = "0x184EFDBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NHHCJIKBFMB IIEGPOMACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4EFDCA0", Offset = "0x4EFCEA0", VA = "0x184EFDCA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4EFDD40", Offset = "0x4EFCF40", VA = "0x184EFDD40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public ODJOGAELAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BMHIFAJIPHC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly Type LIGNLPJDDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public readonly string PMBEKOGFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public readonly bool FLHJJHBLJDJ;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFA9F0", Offset = "0x4EF9BF0", VA = "0x184EFA9F0")]
	public BMHIFAJIPHC(Type EJMMIMHMKOF, string LELFMFELNMG, bool EKCANMMALGK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class LLFEKDDOKNC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD260", Offset = "0x4EFC460", VA = "0x184EFD260")]
	public LLFEKDDOKNC(string MPHBMEGMJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD1E0", Offset = "0x4EFC3E0", VA = "0x184EFD1E0")]
	public LLFEKDDOKNC(string MPHBMEGMJKJ, Exception BBKKANKNBCO)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x570190", VA = "0x180570F90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD680", Offset = "0x5FC880", VA = "0x1805FD680")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public T this[int PNNJEJIELDM, int EDAFIBJFOLO]
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x23B8B20", Offset = "0x23B7D20", VA = "0x1823B8B20")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x23B8BC0", Offset = "0x23B7DC0", VA = "0x1823B8BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x23B8A90", Offset = "0x23B7C90", VA = "0x1823B8A90")]
		public Array2D(uint MLMOINPPPFB, uint LDAGEPJGJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x23B8A10", Offset = "0x23B7C10", VA = "0x1823B8A10")]
		public void DHEPINIAIJL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4EFA930", Offset = "0x4EF9B30", VA = "0x184EFA930")]
		public Array2DVector3(uint MLMOINPPPFB, uint LDAGEPJGJAH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class EGLNACPJFJK
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public const int GOHBILDIDMI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public const int NKMKOGLNPNK = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DefaultMember("Item")]
public class JJJOECKDPLE<THandle, TValue> : IDisposable where THandle : struct, DJFLNBCFMEE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<THandle> JNGDAMPJLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<TValue> HBCFAOJOIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Func<TValue> ADIBAPNNODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action<TValue> IAMLNLGEIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int FNBCENLEHPC;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TValue DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF75F0", Offset = "0x1CF67F0", VA = "0x181CF75F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x398B350", Offset = "0x398A550", VA = "0x18398B350")]
	public JJJOECKDPLE(Action<TValue> IAMLNLGEIHC, [Optional] Func<TValue> ADIBAPNNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x398A920", Offset = "0x3989B20", VA = "0x18398A920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x398AAE0", Offset = "0x3989CE0", VA = "0x18398AAE0")]
	public THandle EJKEJHFJNHJ()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x398AF80", Offset = "0x398A180", VA = "0x18398AF80")]
	public THandle INLOBDHPAIC(TValue PNLMJAPAHBD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x398B130", Offset = "0x398A330", VA = "0x18398B130")]
	public bool MNIDDOJOCKH(THandle CKAMOFGOGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x398AFF0", Offset = "0x398A1F0", VA = "0x18398AFF0")]
	public bool JDANGEMIEOI(THandle CKAMOFGOGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x398AB80", Offset = "0x3989D80", VA = "0x18398AB80")]
	public bool FJDDEAOBJHK(THandle CKAMOFGOGEB, out TValue PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x398A7B0", Offset = "0x39899B0", VA = "0x18398A7B0")]
	public TValue DCCAFIHBGKB(THandle CKAMOFGOGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x398AED0", Offset = "0x398A0D0", VA = "0x18398AED0")]
	public bool IBJNBMFLFJH(THandle CKAMOFGOGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x398B0D0", Offset = "0x398A2D0", VA = "0x18398B0D0")]
	private THandle KDCNNONEDDA(int PPMIPKENDBN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x398B100", Offset = "0x398A300", VA = "0x18398B100")]
	private TValue LDOFPKIAPPK(int PPMIPKENDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x398AD40", Offset = "0x3989F40", VA = "0x18398AD40")]
	private void GNJPDOCAFMK(int PPMIPKENDBN, in THandle CKAMOFGOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x398AD80", Offset = "0x3989F80", VA = "0x18398AD80")]
	private void HIDJLFDDMID(int PPMIPKENDBN, in TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x398ADC0", Offset = "0x3989FC0", VA = "0x18398ADC0")]
	private THandle HJBICACIBIF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x398AC20", Offset = "0x3989E20", VA = "0x18398AC20")]
	private void GGAOMNCCNFO(THandle CKAMOFGOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x398B340", Offset = "0x398A540", VA = "0x18398B340")]
	private int PGAKBCAOCCH(int OJGBBKPGNFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x398B1E0", Offset = "0x398A3E0", VA = "0x18398B1E0")]
	private bool NEDEMADELGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x59D3B0", Offset = "0x59C5B0", VA = "0x18059D3B0")]
	private void PJABKLNNCGN(THandle CKAMOFGOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x398B1F0", Offset = "0x398A3F0", VA = "0x18398B1F0")]
	private bool NFDCKCIKGMC(out THandle CKAMOFGOGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x398B270", Offset = "0x398A470", VA = "0x18398B270")]
	private bool PALBIGDFONM(out THandle CKAMOFGOGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x398ACE0", Offset = "0x3989EE0", VA = "0x18398ACE0")]
	private void GHDMHPBICHG(THandle CKAMOFGOGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x398A800", Offset = "0x3989A00", VA = "0x18398A800")]
	private void DPGJDKIDDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface DJFLNBCFMEE
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int AGIDOAOJPID
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int JHEJHOEEPME
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface HLGOJBMMLBF<T> : DJFLNBCFMEE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class GAHIFDHANOE
{
	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x282C3A0", Offset = "0x282B5A0", VA = "0x18282C3A0")]
	public static bool DIDNAKPDMAM<T>(this T CKAMOFGOGEB) where T : struct, DJFLNBCFMEE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class PECIKFGCLPD
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private enum LIFBGHCKGAO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int GCMEFCLKGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool CMGIKHFCICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private LIFBGHCKGAO JFEOMJEBMNM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool IEEHPPFPCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x4EFEDD0", Offset = "0x4EFDFD0", VA = "0x184EFEDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool BCODOIDLHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE4E0", Offset = "0x4EFD6E0", VA = "0x184EFE4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF230", Offset = "0x4EFE430", VA = "0x184EFF230")]
	public PECIKFGCLPD(bool CMGIKHFCICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE710", Offset = "0x4EFD910", VA = "0x184EFE710")]
	public void IPPNLAIEHGN(object CEEAMODAEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEC30", Offset = "0x4EFDE30", VA = "0x184EFEC30")]
	public void KJGANHGCOPL(int PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EFECE0", Offset = "0x4EFDEE0", VA = "0x184EFECE0")]
	public void LHKEELOCHEN(uint KEJMLCJCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEDE0", Offset = "0x4EFDFE0", VA = "0x184EFEDE0")]
	public void PLAGENAJBAP(bool GGIDEHBKEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE650", Offset = "0x4EFD850", VA = "0x184EFE650")]
	public void DCJIHNGMLFC(long DIJMEFMIECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE610", Offset = "0x4EFD810", VA = "0x184EFE610")]
	public void DAIGHHOLOKE(ulong NOIKBAADBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EFED60", Offset = "0x4EFDF60", VA = "0x184EFED60")]
	public void MGFAENGENLF(string ANPGKNCGDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE450", Offset = "0x4EFD650", VA = "0x184EFE450")]
	public void AJKPMCPLNII(Enum BEHJIIABFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE4F0", Offset = "0x4EFD6F0", VA = "0x184EFE4F0")]
	public void CNINDAKNGOE(IList OPPKLAEFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1BB0", Offset = "0x2DF0DB0", VA = "0x182DF1BB0")]
	public void DFDPCHOJANB<T, U>(Dictionary<T, U> FDANDBGEEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEE70", Offset = "0x4EFE070", VA = "0x184EFEE70")]
	private void PNLHPKMJNAN(IDictionary FDANDBGEEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4EFECF0", Offset = "0x4EFDEF0", VA = "0x184EFECF0")]
	public int MDOPLBODHBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEE00", Offset = "0x4EFE000", VA = "0x184EFEE00")]
	public short PMGFLCLELPL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE690", Offset = "0x4EFD890", VA = "0x184EFE690")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE6A0", Offset = "0x4EFD8A0", VA = "0x184EFE6A0")]
	private void FNMLGOGEAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public abstract class JHGHOCNHIED<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal class AGIINBPEELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public TNode EEGMPMAILGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode KJHHLEFOCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public PEFHBAEFJBO LJMJEKEAKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<PEFHBAEFJBO> NEGKPEEOGDG;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public AGIINBPEELB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	internal struct PEFHBAEFJBO : IComparable<PEFHBAEFJBO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int MFOFJGHKKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TClaimant JEBCMKCFGJF;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x66D8D0", Offset = "0x66CAD0", VA = "0x18066D8D0")]
		public PEFHBAEFJBO(int MFOFJGHKKHL, TClaimant JEBCMKCFGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x38C9360", Offset = "0x38C8560", VA = "0x1838C9360")]
		public bool FJHGLHANJEL(in PEFHBAEFJBO EBJKBJMLDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x38C93C0", Offset = "0x38C85C0", VA = "0x1838C93C0")]
		public bool LLIMFJKJGDF(in PEFHBAEFJBO EBJKBJMLDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x38C9350", Offset = "0x38C8550", VA = "0x1838C9350", Slot = "4")]
		public int CompareTo(PEFHBAEFJBO EBJKBJMLDOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x38C93D0", Offset = "0x38C85D0", VA = "0x1838C93D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public enum IHHBKJFADIH
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class ABMELAGNGCM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public global::JHGHOCNHIED<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6B90", Offset = "0x1CF5D90", VA = "0x181CF6B90")]
		[DebuggerHidden]
		public ABMELAGNGCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x38B10D0", Offset = "0x38B02D0", VA = "0x1838B10D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x38B1290", Offset = "0x38B0490", VA = "0x1838B1290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x38B11B0", Offset = "0x38B03B0", VA = "0x1838B11B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x17C78F0", Offset = "0x17C6AF0", VA = "0x1817C78F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly global::CGGMEEDMOBE<AGIINBPEELB> BDEHKLOBBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly global::CGGMEEDMOBE<List<PEFHBAEFJBO>> NEFALNDBJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int EPCAGCOFNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	internal readonly Dictionary<TClaimant, TNode> EIIJOBJBAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TNode, AGIINBPEELB> IDGBMMDDCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private IHHBKJFADIH GNPBHEELLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool NELKGEDACJB;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AOHKMFOLLPF(TNode MBNJFBIGPPP);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void ICOEOKHNGFI(TNode MBNJFBIGPPP, TClaimant NHFDBBCBDKL, TClaimant CIMEMOPCNME);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x38C6E10", Offset = "0x38C6010", VA = "0x1838C6E10")]
	public JHGHOCNHIED(IHHBKJFADIH GNPBHEELLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x38C5920", Offset = "0x38C4B20", VA = "0x1838C5920")]
	public void BNGPILCHADL(TNode MBNJFBIGPPP, TNode JILEPKFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x38C6500", Offset = "0x38C5700", VA = "0x1838C6500")]
	public void KMPNAMIDNPN(TClaimant JEBCMKCFGJF, TNode CFDPGKBBEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x38C5DE0", Offset = "0x38C4FE0", VA = "0x1838C5DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x38C6600", Offset = "0x38C5800", VA = "0x1838C6600")]
	private void KPMOELMAKDM(TClaimant JEBCMKCFGJF, TNode KFCHFNFCIIB, TNode CFDPGKBBEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x38C6490", Offset = "0x38C5690", VA = "0x1838C6490")]
	private int KIEALDCKGDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x38C66A0", Offset = "0x38C58A0", VA = "0x1838C66A0")]
	private void MFPMNOKMILO(TClaimant JEBCMKCFGJF, TNode FPPHGIGGBFC, TNode ADAPAKPCOAP, int EHCDLOHBHFB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x38C6950", Offset = "0x38C5B50", VA = "0x1838C6950")]
	private void MJMFFAGMAKL(PEFHBAEFJBO GALOJMEEPIM, AGIINBPEELB BOPDFLLFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x38C55B0", Offset = "0x38C47B0", VA = "0x1838C55B0")]
	private void AIHEMKECLOG(TClaimant JEBCMKCFGJF, TNode FPPHGIGGBFC, TNode ADAPAKPCOAP, int EHCDLOHBHFB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x38C62C0", Offset = "0x38C54C0", VA = "0x1838C62C0")]
	private void HPIPIHCAAJJ(PEFHBAEFJBO GALOJMEEPIM, TNode MBNJFBIGPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x38C5820", Offset = "0x38C4A20", VA = "0x1838C5820")]
	private void APICEEDAHKI(PEFHBAEFJBO GALOJMEEPIM, AGIINBPEELB BOPDFLLFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x38C6B70", Offset = "0x38C5D70", VA = "0x1838C6B70")]
	private void MMNEFHLPNLC(AGIINBPEELB BOPDFLLFHIL, bool HDAFJJNFEKA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x38C59A0", Offset = "0x38C4BA0", VA = "0x1838C59A0")]
	private void BONFDCBOAEB(AGIINBPEELB BOPDFLLFHIL, TNode JILEPKFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x38C63C0", Offset = "0x38C55C0", VA = "0x1838C63C0")]
	[IteratorStateMachine(typeof(global::JHGHOCNHIED<, >.ABMELAGNGCM))]
	private IEnumerable<TNode> JCBNKPONKAC(TNode FPPHGIGGBFC, TNode ADAPAKPCOAP, bool GFEBBNNBMCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x38C6200", Offset = "0x38C5400", VA = "0x1838C6200")]
	private AGIINBPEELB HMBEPJBNDNM(TNode MBNJFBIGPPP, TNode KJHHLEFOCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x38C69E0", Offset = "0x38C5BE0", VA = "0x1838C69E0")]
	private AGIINBPEELB MLMIJMBIDAK(TNode MBNJFBIGPPP, TNode KJHHLEFOCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x38C6040", Offset = "0x38C5240", VA = "0x1838C6040")]
	private void HFIPPALGJEL(AGIINBPEELB BOPDFLLFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class BMPLOPNDGEM<T> : IEnumerable<global::BMPLOPNDGEM<T>.KFNEIIEKDOO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public struct KFNEIIEKDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T PNLMJAPAHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int PPMIPKENDBN;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class HDLKBECPOEE : IEnumerator<KFNEIIEKDOO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private global::BMPLOPNDGEM<T> IFOBLONBDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int PPMIPKENDBN;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x26746B0", Offset = "0x26738B0", VA = "0x1826746B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public KFNEIIEKDOO FMENHIFBNEH
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x3F09350", Offset = "0x3F08550", VA = "0x183F09350", Slot = "4")]
			get
			{
				return default(KFNEIIEKDOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x662110", Offset = "0x661310", VA = "0x180662110")]
		public HDLKBECPOEE(global::BMPLOPNDGEM<T> IFOBLONBDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F092C0", Offset = "0x3F084C0", VA = "0x183F092C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x662100", Offset = "0x661300", VA = "0x180662100", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x69D380", Offset = "0x69C580", VA = "0x18069D380", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private struct BKDOMONNPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool DCBFEBGMHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T PNLMJAPAHBD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private const int MOANBEBAJAD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Dictionary<T, int> NIJEOOKAANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private BKDOMONNPNC[] GMNGBJLCAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int JBOABAKPICP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int CKKAIOKDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC160", Offset = "0x5CB360", VA = "0x1805CC160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1D0", Offset = "0x5CB3D0", VA = "0x1805CC1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8920", Offset = "0x3EE7B20", VA = "0x183EE8920")]
	public BMPLOPNDGEM(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8530", Offset = "0x3EE7730", VA = "0x183EE8530")]
	public BMPLOPNDGEM(KFNEIIEKDOO[] MEIDBHHHAIB, bool BPGLNLNKHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8030", Offset = "0x3EE7230", VA = "0x183EE8030")]
	public int JFNKOMMFKIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7B90", Offset = "0x3EE6D90", VA = "0x183EE7B90")]
	private int HDHHPCAKBED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7DE0", Offset = "0x3EE6FE0", VA = "0x183EE7DE0", Slot = "6")]
	protected virtual uint HIPLHBNEJDF(uint GCMEFCLKGHN, T PNLMJAPAHBD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8480", Offset = "0x3EE7680", VA = "0x183EE8480")]
	public bool POEGPFHKEHI(T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8420", Offset = "0x3EE7620", VA = "0x183EE8420")]
	public bool PGEGEMOFCAE(int PPMIPKENDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7E10", Offset = "0x3EE7010", VA = "0x183EE7E10")]
	public bool IBFBFEPPJPP(Func<T, bool> PINNCDAIIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7AF0", Offset = "0x3EE6CF0", VA = "0x183EE7AF0")]
	public int EIBLKICMBFB(T PNLMJAPAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EE80A0", Offset = "0x3EE72A0", VA = "0x183EE80A0")]
	public T LDOFPKIAPPK(int PPMIPKENDBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7A70", Offset = "0x3EE6C70", VA = "0x183EE7A70")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EE83F0", Offset = "0x3EE75F0", VA = "0x183EE83F0")]
	public bool NCLDJIPBNOB(T PNLMJAPAHBD, bool KCEMOMIKCKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8190", Offset = "0x3EE7390", VA = "0x183EE8190")]
	public bool NCLDJIPBNOB(T PNLMJAPAHBD, int PPMIPKENDBN, bool KCEMOMIKCKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8110", Offset = "0x3EE7310", VA = "0x183EE8110")]
	public bool MNIDDOJOCKH(T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7A20", Offset = "0x3EE6C20", VA = "0x183EE7A20")]
	public bool CCOBAAGAIMD(int PPMIPKENDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7940", Offset = "0x3EE6B40", VA = "0x183EE7940")]
	private void BNEFDCCLEPH(int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7EC0", Offset = "0x3EE70C0", VA = "0x183EE7EC0")]
	public KFNEIIEKDOO[] ILGGLAGBPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7B40", Offset = "0x3EE6D40", VA = "0x183EE7B40")]
	private int GNLDBONMIBH(int IMDJFDAAEMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3EE84B0", Offset = "0x3EE76B0", VA = "0x183EE84B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3EE84B0", Offset = "0x3EE76B0", VA = "0x183EE84B0", Slot = "4")]
	private IEnumerator<KFNEIIEKDOO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class CGGMEEDMOBE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Stack<T> PCAHNENGLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly List<T> BPDECPBBJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly int LAIHOJIENGH;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int NDBFBLHAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x23B9620", Offset = "0x23B8820", VA = "0x1823B9620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int FFDAEAIEPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x23BE870", Offset = "0x23BDA70", VA = "0x1823BE870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x247F000", Offset = "0x247E200", VA = "0x18247F000")]
	public static global::CGGMEEDMOBE<T> NKMIPFCJDMD(int EICHEFNLNOA = 0, int LAIHOJIENGH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x247EC90", Offset = "0x247DE90", VA = "0x18247EC90")]
	public static global::CGGMEEDMOBE<T> FKNPHLIKDPI(int EICHEFNLNOA = 0, int LAIHOJIENGH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x247F260", Offset = "0x247E460", VA = "0x18247F260")]
	public CGGMEEDMOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x247F0D0", Offset = "0x247E2D0", VA = "0x18247F0D0")]
	public CGGMEEDMOBE(int EICHEFNLNOA, int LAIHOJIENGH = int.MaxValue, bool IENDCFMOJJN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x247ED60", Offset = "0x247DF60", VA = "0x18247ED60")]
	public T HGLOCPOOBFK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x247E9F0", Offset = "0x247DBF0", VA = "0x18247E9F0")]
	public void ECIAOJLGJLG(T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x247EE90", Offset = "0x247E090", VA = "0x18247EE90")]
	private void JOMPDECNOEH(T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x247EAB0", Offset = "0x247DCB0", VA = "0x18247EAB0")]
	private void EMKFFIIIMNP(T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x247E840", Offset = "0x247DA40", VA = "0x18247E840")]
	[Conditional("DEBUG_BUILD")]
	private void CODAFJNEKOP(T IDMKCPCMGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x247EF50", Offset = "0x247E150", VA = "0x18247EF50")]
	[Conditional("DEBUG_BUILD")]
	private void LBOGBABDIBO(T IDMKCPCMGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x247E8E0", Offset = "0x247DAE0", VA = "0x18247E8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x247EAD0", Offset = "0x247DCD0", VA = "0x18247EAD0")]
	private void FBGBLIKEMAD(IEnumerable<T> HBCFAOJOIOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class JMAAOMIGNAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<int, T> GFHDPPPFOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private T FFPENHEEEHC;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public virtual T HBCCEFBLNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool BOFBDANLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x398DB20", Offset = "0x398CD20", VA = "0x18398DB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x398E0C0", Offset = "0x398D2C0", VA = "0x18398E0C0")]
	public bool NKBPPDODNBD(T PNLMJAPAHBD, int MFOFJGHKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x398E180", Offset = "0x398D380", VA = "0x18398E180")]
	public bool OPJDMPHKCAN(int MFOFJGHKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x398DBC0", Offset = "0x398CDC0", VA = "0x18398DBC0")]
	public T EFCNFLBPKOE(int CMOELGOFCGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x398DB60", Offset = "0x398CD60", VA = "0x18398DB60")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x398D980", Offset = "0x398CB80", VA = "0x18398D980")]
	private bool AAGIOFHAAFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x398E090", Offset = "0x398D290", VA = "0x18398E090")]
	public bool FIDGIGFFKFJ(int MFOFJGHKKHL, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x26DDA70", Offset = "0x26DCC70", VA = "0x1826DDA70")]
	public JMAAOMIGNAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class DLJNDGLAPOG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	protected struct BLPCLLAIKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public T AMCKDLHOFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int POOAAECDLCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly List<BLPCLLAIKCF> IPLJMPLJHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T BJEGNKMOLKM;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E36100", VA = "0x181E36F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3E29690", Offset = "0x3E28890", VA = "0x183E29690")]
	public bool IBFBFEPPJPP(T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3E298E0", Offset = "0x3E28AE0", VA = "0x183E298E0")]
	public void INLOBDHPAIC(T PNLMJAPAHBD, int MFOFJGHKKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3E29980", Offset = "0x3E28B80", VA = "0x183E29980")]
	public bool MNIDDOJOCKH(T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x3E29420", Offset = "0x3E28620", VA = "0x183E29420")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x3E29AA0", Offset = "0x3E28CA0", VA = "0x183E29AA0")]
	public T PILNDDOLJIG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3E293B0", Offset = "0x3E285B0", VA = "0x183E293B0")]
	public T AMPCLHFIEOJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x3E29480", Offset = "0x3E28680", VA = "0x183E29480")]
	private void GBBKICBNAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3E29B30", Offset = "0x3E28D30", VA = "0x183E29B30")]
	public DLJNDGLAPOG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[MCJNGMPEMLD(EAEFHBMFHFN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x4F00240", Offset = "0x4EFF440", VA = "0x184F00240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x4F00710", Offset = "0x4EFF910", VA = "0x184F00710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x4F00530", Offset = "0x4EFF730", VA = "0x184F00530")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x4F008B0", Offset = "0x4EFFAB0", VA = "0x184F008B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x4F00100", Offset = "0x4EFF300", VA = "0x184F00100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x4F005D0", Offset = "0x4EFF7D0", VA = "0x184F005D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x4F003F0", Offset = "0x4EFF5F0", VA = "0x184F003F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x4F00060", Offset = "0x4EFF260", VA = "0x184F00060")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface INGJJMKOMNL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public abstract class ResourcePrefabReference<T> : INGJJMKOMNL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x23C9A20", Offset = "0x23C8C20", VA = "0x1823C9A20", Slot = "4")]
		public virtual T PCIFMLMNHOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class PJNGLJMKGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<byte, COOEGFMGNKA> IFJMGCFKGMI;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public COOEGFMGNKA HIBFFJFKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 KJFGFBHCBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE848A0", Offset = "0xE83AA0", VA = "0x180E848A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x224AE50", Offset = "0x224A050", VA = "0x18224AE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector2 CHLKOBPAIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x104B4A0", Offset = "0x104A6A0", VA = "0x18104B4A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x104B530", Offset = "0x104A730", VA = "0x18104B530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 MEHJGPBIMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF600", Offset = "0x4EFE800", VA = "0x184EFF600")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF470", Offset = "0x4EFE670", VA = "0x184EFF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int CKCJGPHELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x577190", Offset = "0x576390", VA = "0x180577190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x59D3B0", Offset = "0x59C5B0", VA = "0x18059D3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFB40", Offset = "0x4EFED40", VA = "0x184EFFB40")]
	public PJNGLJMKGIH(Bounds OKOGNOPEGKB, Vector2[] BKFMLFFGHPM, int ILMLBAMGELG, byte IMDJFDAAEMG, float PJJPNLOJJDF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF4B0", Offset = "0x4EFE6B0", VA = "0x184EFF4B0")]
	public COOEGFMGNKA DNJKIODHMNF(byte PPMIPKENDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF510", Offset = "0x4EFE710", VA = "0x184EFF510")]
	public void GBIMFIKNAKN(Vector3 AKHJPGEHPNE, float EOMFBINKFOP, float KCMBOBLKKMH, ref List<byte> IIOJDNDPKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF490", Offset = "0x4EFE690", VA = "0x184EFF490")]
	public void CHAOOBNKPBP(COOEGFMGNKA.NNIFMEPAAMD LLFMHOBNGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF340", Offset = "0x4EFE540", VA = "0x184EFF340")]
	private COOEGFMGNKA AAADMLAMAMF(byte PPMIPKENDBN, COOEGFMGNKA.AIFLKAPFHEJ DAMLDAMJGCM, COOEGFMGNKA KJHHLEFOCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF620", Offset = "0x4EFE820", VA = "0x184EFF620")]
	private void NNGILLJILOM(COOEGFMGNKA KJHHLEFOCFM, Vector2[] BKFMLFFGHPM, int OHBLMKBFDIH, int DPLKBGIMONJ, int GKHNDGICOJH, int KGEOAOIKECC, float PJJPNLOJJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class COOEGFMGNKA
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public enum AIFLKAPFHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public enum NNIFMEPAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public byte AJFFOOFLAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Vector3 MGEIACKMAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Vector3 PHMELCGNMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Vector3 GOKMEHNHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Vector3 KODIKDNHGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public AIFLKAPFHEJ JBHHFDOFCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public COOEGFMGNKA JEOIJKMCIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public List<COOEGFMGNKA> MBNPFLAAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public bool MMCBHGOLMON;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB790", Offset = "0x4EFA990", VA = "0x184EFB790")]
	public COOEGFMGNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB7B0", Offset = "0x4EFA9B0", VA = "0x184EFB7B0")]
	public COOEGFMGNKA(byte HAMKLMCJFNP, AIFLKAPFHEJ DAMLDAMJGCM, COOEGFMGNKA KJHHLEFOCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB690", Offset = "0x4EFA890", VA = "0x184EFB690")]
	public void KBANPNFKKPL(COOEGFMGNKA FHNNBKMCHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	public void CHAOOBNKPBP(int FHHBIMEKAOH, NNIFMEPAAMD LLFMHOBNGEM, int HHKKKKPMAML = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB3C0", Offset = "0x4EFA5C0", VA = "0x184EFB3C0")]
	public void GBIMFIKNAKN(List<byte> IIOJDNDPKKM, Vector3 AKHJPGEHPNE, float EOMFBINKFOP, float KCMBOBLKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB730", Offset = "0x4EFA930", VA = "0x184EFB730")]
	public bool NBOABNLAKPG(Vector3 AEDDGIMLFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB650", Offset = "0x4EFA850", VA = "0x184EFB650")]
	public bool INMAGALCPOL(Vector3 AEDDGIMLFIJ, float DJNLIHHPKIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LMDOAOJBDAH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<T, object> EFAAEKGIKDG;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1C92C90", Offset = "0x1C91E90", VA = "0x181C92C90")]
	public bool PDMOKJJCKCN(T HOONMCLBHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1D02BA0", Offset = "0x1D01DA0", VA = "0x181D02BA0")]
	public bool PDMOKJJCKCN(T HOONMCLBHEJ, object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1D02B40", Offset = "0x1D01D40", VA = "0x181D02B40")]
	public bool PDMOKJJCKCN(T HOONMCLBHEJ, object OFCAAIDMNPE, out object BFIFGLOBAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1D02B00", Offset = "0x1D01D00", VA = "0x181D02B00")]
	public bool MJIINKMPBGD(T HOONMCLBHEJ, object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1D02990", Offset = "0x1D01B90", VA = "0x181D02990")]
	public bool JPKBGHIJPND(T HOONMCLBHEJ, object OFCAAIDMNPE, out object BFIFGLOBAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1D02A70", Offset = "0x1D01C70", VA = "0x181D02A70")]
	public bool MJIINKMPBGD(T HOONMCLBHEJ, object OFCAAIDMNPE, out object BFIFGLOBAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1D02960", Offset = "0x1D01B60", VA = "0x181D02960")]
	public void JPCLDMBMLGP(T HOONMCLBHEJ, object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1D029D0", Offset = "0x1D01BD0", VA = "0x181D029D0")]
	public void MJBPCINLHOP(T HOONMCLBHEJ, object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1D02BE0", Offset = "0x1D01DE0", VA = "0x181D02BE0")]
	public LMDOAOJBDAH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public struct INIPMBGAEKI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private readonly List<Component> OPPKLAEFHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private readonly bool FPLJNMBKHLI;

			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x113AD20", Offset = "0x1139F20", VA = "0x18113AD20")]
			public INIPMBGAEKI(List<Component> OPPKLAEFHOK, bool FPLJNMBKHLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x23BC150", Offset = "0x23BB350", VA = "0x1823BC150")]
			public PGJCHGPBACK<T> FGPBPKKHKMK()
			{
				return default(PGJCHGPBACK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x23BC1C0", Offset = "0x23BB3C0", VA = "0x1823BC1C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x23BC1C0", Offset = "0x23BB3C0", VA = "0x1823BC1C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public struct PGJCHGPBACK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private readonly List<Component> OPPKLAEFHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly bool FPLJNMBKHLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private int PPMIPKENDBN;

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			public T FMENHIFBNEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000454")]
				[Cpp2IlInjected.Address(RVA = "0x23BFA10", Offset = "0x23BEC10", VA = "0x1823BFA10", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000455")]
				[Cpp2IlInjected.Address(RVA = "0x23BF9A0", Offset = "0x23BEBA0", VA = "0x1823BF9A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x23BF9E0", Offset = "0x23BEBE0", VA = "0x1823BF9E0")]
			public PGJCHGPBACK(List<Component> OPPKLAEFHOK, bool FPLJNMBKHLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x23BF8D0", Offset = "0x23BEAD0", VA = "0x1823BF8D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x23BF8E0", Offset = "0x23BEAE0", VA = "0x1823BF8E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x23BF990", Offset = "0x23BEB90", VA = "0x1823BF990", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x4F02570", Offset = "0x4F01770", VA = "0x184F02570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x4F02530", Offset = "0x4F01730", VA = "0x184F02530")]
		public ToolHierarchyCache(GameObject NDNCKELJOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x4F01D90", Offset = "0x4F00F90", VA = "0x184F01D90")]
		private void GDDEOJNJOEM(GameObject NDNCKELJOCP, bool HFJGMFMNLEA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x4F01EB0", Offset = "0x4F010B0", VA = "0x184F01EB0")]
		public static void GDDEOJNJOEM(GameObject NDNCKELJOCP, ref ToolHierarchyCache IAIJIEKIHGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x4F01FB0", Offset = "0x4F011B0", VA = "0x184F01FB0")]
		public void IINDBKFMDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x4F02330", Offset = "0x4F01530", VA = "0x184F02330")]
		public void MNGLGCANJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1AAF7A0", Offset = "0x1AAE9A0", VA = "0x181AAF7A0")]
		public void KLGKHCODNNA<T>(Action<T> DINDBGHHKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x4F02380", Offset = "0x4F01580", VA = "0x184F02380")]
		public Component NDJBNBHDCAO(Type DEJAEMDNDIC, bool FPLJNMBKHLI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x194B330", Offset = "0x194A530", VA = "0x18194B330")]
		public T NDJBNBHDCAO<T>(bool FPLJNMBKHLI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x4F02440", Offset = "0x4F01640", VA = "0x184F02440")]
		public INIPMBGAEKI<Component> NMLHGDHADJL(Type DEJAEMDNDIC, bool FPLJNMBKHLI = false)
		{
			return default(INIPMBGAEKI<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x19311D0", Offset = "0x19303D0", VA = "0x1819311D0")]
		public INIPMBGAEKI<T> NMLHGDHADJL<T>(bool FPLJNMBKHLI = false) where T : class
		{
			return default(INIPMBGAEKI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4F02080", Offset = "0x4F01280", VA = "0x184F02080")]
		public List<Component> JMANPEDKNEN(Type DEJAEMDNDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x4F01D10", Offset = "0x4F00F10", VA = "0x184F01D10", Slot = "4")]
		public bool Equals(ToolHierarchyCache NJBKHCBPNDB, ToolHierarchyCache CBNFMHDNCPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x4F01F40", Offset = "0x4F01140", VA = "0x184F01F40", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CEEAMODAEEL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class BBKPFEALBJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private int EICHEFNLNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int KCGPJCCKKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private List<T> IHJNFHBELBL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x23B9620", Offset = "0x23B8820", VA = "0x1823B9620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public T DFNKBGGDJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x3A359D0", Offset = "0x3A34BD0", VA = "0x183A359D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public T ADFKBEANOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3A35560", Offset = "0x3A34760", VA = "0x183A35560")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public T OCNMKBEPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x3A358E0", Offset = "0x3A34AE0", VA = "0x183A358E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x3A35AA0", Offset = "0x3A34CA0", VA = "0x183A35AA0")]
	public BBKPFEALBJK(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x3A35610", Offset = "0x3A34810", VA = "0x183A35610")]
	public void INLOBDHPAIC(T BCPHJCMGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x3A35520", Offset = "0x3A34720", VA = "0x183A35520")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x3A357D0", Offset = "0x3A349D0", VA = "0x183A357D0")]
	public void MGFMCODCGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x3A35A50", Offset = "0x3A34C50", VA = "0x183A35A50")]
	public void OGAMHAGOADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x3A357C0", Offset = "0x3A349C0", VA = "0x183A357C0")]
	public void KALACBONINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class EHBAIHDGJMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool EBDCADDCIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Action DINDBGHHKFD;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public static EHBAIHDGJMC IHCNNAEEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x4EFB8A0", Offset = "0x4EFAAA0", VA = "0x184EFB8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool KKJDEHIOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x576360", VA = "0x180577160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x64BA60", Offset = "0x64AC60", VA = "0x18064BA60")]
	public EHBAIHDGJMC(Action DINDBGHHKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB920", Offset = "0x4EFAB20", VA = "0x184EFB920")]
	public void BPHKGBFPAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4EFB920", Offset = "0x4EFAB20", VA = "0x184EFB920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class NJHDBENBPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	public static void MICFEAFPEBM(OAPIODPNINL CALCMHPBBEF, string GDDFCHLGHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class CKEBIFNNIKL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private struct HPPCCLLHCFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int POOAAECDLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T AMCKDLHOFMB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<object, HPPCCLLHCFK> GFHDPPPFOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T FFPENHEEEHC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual T HBCCEFBLNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE848A0", Offset = "0xE83AA0", VA = "0x180E848A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x224AE50", Offset = "0x224A050", VA = "0x18224AE50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool BOFBDANLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x26DCA70", Offset = "0x26DBC70", VA = "0x1826DCA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public object JFPLPIFDNJM
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26DD960", Offset = "0x26DCB60", VA = "0x1826DD960")]
	public bool NKBPPDODNBD(T PNLMJAPAHBD, object OFCAAIDMNPE, int MFOFJGHKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x26DDA00", Offset = "0x26DCC00", VA = "0x1826DDA00")]
	public bool OPJDMPHKCAN(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x26DCCF0", Offset = "0x26DBEF0", VA = "0x1826DCCF0")]
	public bool FIDGIGFFKFJ(object OFCAAIDMNPE, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x224AE70", Offset = "0x224A070", VA = "0x18224AE70")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x26D8480", Offset = "0x26D7680", VA = "0x1826D8480")]
	private bool AAGIOFHAAFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x26DDA70", Offset = "0x26DCC70", VA = "0x1826DDA70")]
	public CKEBIFNNIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class MNBKIENEEEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Dictionary<object, float> GFHDPPPFOKA;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public float LLIBMPJJLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0710", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C90", Offset = "0x8A5E90", VA = "0x1808A6C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD490", Offset = "0x4EFC690", VA = "0x184EFD490")]
	public void NKBPPDODNBD(float PNLMJAPAHBD, object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD500", Offset = "0x4EFC700", VA = "0x184EFD500")]
	public void OPJDMPHKCAN(object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD370", Offset = "0x4EFC570", VA = "0x184EFD370")]
	private void NEDEJDDDJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD570", Offset = "0x4EFC770", VA = "0x184EFD570")]
	public MNBKIENEEEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public class MNFFEBPEFEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public readonly string ECCPOKGJLMC;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B50", Offset = "0x5D3D50", VA = "0x1805D4B50")]
	public MNFFEBPEFEE(string GOPMFIGJBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD640", Offset = "0x4EFC840", VA = "0x184EFD640")]
	public MNFFEBPEFEE(UnityEngine.Object NCMMCODGFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD5F0", Offset = "0x4EFC7F0", VA = "0x184EFD5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OAPIODPNINL
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class GBNEAOLDEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public GBNEAOLDEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x4EFC210", Offset = "0x4EFB410", VA = "0x184EFC210")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HashSet<object> MIILDOJBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private int GACJDONLNOP;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyCollection<object> COGLGJFKNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool CLDDECKOCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD9E0", Offset = "0x4EFCBE0", VA = "0x184EFD9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int BNNMPMMNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAC0", Offset = "0x5ABCC0", VA = "0x1805ACAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD8E0", Offset = "0x4EFCAE0", VA = "0x184EFD8E0")]
	public bool INLOBDHPAIC(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD960", Offset = "0x4EFCB60", VA = "0x184EFD960")]
	public bool MNIDDOJOCKH(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD880", Offset = "0x4EFCA80", VA = "0x184EFD880")]
	public bool IBFBFEPPJPP(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD820", Offset = "0x4EFCA20", VA = "0x184EFD820")]
	public void CKOEKBNLMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD9F0", Offset = "0x4EFCBF0", VA = "0x184EFD9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDB60", Offset = "0x4EFCD60", VA = "0x184EFDB60")]
	public OAPIODPNINL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class KPMEHLICPMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct HHDCHIBAMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public float JCODDMCJPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public T AMCKDLHOFMB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Dictionary<object, HHDCHIBAMBA> GFHDPPPFOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private T NDJCJNGNKBP;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public virtual T OOFIFPNCPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x145CBE0", Offset = "0x145BDE0", VA = "0x18145CBE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x145C360", Offset = "0x145B560", VA = "0x18145C360", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public object DKBJOEJMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool BOFBDANLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x224AE10", Offset = "0x224A010", VA = "0x18224AE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x224B3F0", Offset = "0x224A5F0", VA = "0x18224B3F0")]
	public bool NKBPPDODNBD(T PNLMJAPAHBD, object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x224B6F0", Offset = "0x224A8F0", VA = "0x18224B6F0")]
	public bool OPJDMPHKCAN(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x224AE70", Offset = "0x224A070", VA = "0x18224AE70")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x224AF00", Offset = "0x224A100", VA = "0x18224AF00")]
	public bool FIDGIGFFKFJ(object OFCAAIDMNPE, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x224A3C0", Offset = "0x22495C0", VA = "0x18224A3C0")]
	private bool AAGIOFHAAFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x224B750", Offset = "0x224A950", VA = "0x18224B750")]
	public KPMEHLICPMO()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4EFBB60", Offset = "0x4EFAD60", VA = "0x184EFBB60")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4EFBC60", Offset = "0x4EFAE60", VA = "0x184EFBC60")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
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
