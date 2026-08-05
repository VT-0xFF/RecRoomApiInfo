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
public class HPKHHJNJLEH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x88E220", Offset = "0x88D020", VA = "0x18088E220")]
	public HPKHHJNJLEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B946D0", Offset = "0x4B934D0", VA = "0x184B946D0")]
	public byte[] EEOHJGHMIHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ADALPNLNBFL(IncrementalHash KFGHEEKLHKO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6E0", Offset = "0x5EC4E0", VA = "0x1805ED6E0")]
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
	[AIMMKNGPKKJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[AIMMKNGPKKJ]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B97680", Offset = "0x4B96480", VA = "0x184B97680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B97640", Offset = "0x4B96440", VA = "0x184B97640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B976C0", Offset = "0x4B964C0", VA = "0x184B976C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B978D0", Offset = "0x4B966D0", VA = "0x184B978D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4B97840", Offset = "0x4B96640", VA = "0x184B97840")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAD0", Offset = "0x8FE8D0", VA = "0x1808FFAD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x551910", Offset = "0x550710", VA = "0x180551910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B97600", Offset = "0x4B96400", VA = "0x184B97600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B977B0", Offset = "0x4B965B0", VA = "0x184B977B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B97030", Offset = "0x4B95E30", VA = "0x184B97030")]
	public void CopyBounds(SavedExtents MDLBKDPKIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B97570", Offset = "0x4B96370", VA = "0x184B97570")]
	public void SetLocalSpaceBounds(Bounds EFFOIEOOLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xCDB990", Offset = "0xCDA790", VA = "0x180CDB990")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B97560", Offset = "0x4B96360", VA = "0x184B97560")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B97060", Offset = "0x4B95E60", VA = "0x184B97060")]
	private void HOKAKLNOENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B97330", Offset = "0x4B96130", VA = "0x184B97330")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B96A70", Offset = "0x4B95870", VA = "0x184B96A70")]
	public static void CalculateLocalBoundsFor(GameObject MHCMMACILPC, out Bounds EFFOIEOOLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B97270", Offset = "0x4B96070", VA = "0x184B97270")]
	private static void IANCFGGEJEJ(Bounds JLGJJNEIJFM, Color OBNNFOCEGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B97590", Offset = "0x4B96390", VA = "0x184B97590")]
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
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54CBC0", Offset = "0x54B9C0", VA = "0x18054CBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "4")]
	public virtual void FBPINOPMFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
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
	[SerializeField]
	[HPKHHJNJLEH]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3349A60", Offset = "0x3348860", VA = "0x183349A60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33495A0", Offset = "0x33483A0", VA = "0x1833495A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x334A060", Offset = "0x3348E60", VA = "0x18334A060")]
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
	private sealed class FDDMKACNCMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public FDDMKACNCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3914290", Offset = "0x3913090", VA = "0x183914290")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[HPKHHJNJLEH]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3910CA0", Offset = "0x390FAA0", VA = "0x183910CA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3910CD0", Offset = "0x390FAD0", VA = "0x183910CD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3910BF0", Offset = "0x390F9F0", VA = "0x183910BF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey IIIMPJEHMOP]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3910C20", Offset = "0x390FA20", VA = "0x183910C20", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3910AF0", Offset = "0x390F8F0", VA = "0x183910AF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3910350", Offset = "0x390F150", VA = "0x183910350", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x390FCC0", Offset = "0x390EAC0", VA = "0x18390FCC0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x390F920", Offset = "0x390E720", VA = "0x18390F920", Slot = "14")]
	protected virtual string KJPHFLIKLPE(TKeyVal CICJDMMHPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3887D70", Offset = "0x3886B70", VA = "0x183887D70", Slot = "4")]
	public bool ContainsKey(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39109E0", Offset = "0x390F7E0", VA = "0x1839109E0", Slot = "5")]
	public bool TryGetValue(TKey IIIMPJEHMOP, out TVal FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x390F830", Offset = "0x390E630", VA = "0x18390F830", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x390F830", Offset = "0x390E630", VA = "0x18390F830", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3910A10", Offset = "0x390F810", VA = "0x183910A10")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PFBHJLPHHHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GICFNILJHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public GICFNILJHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D489B0", Offset = "0x3D477B0", VA = "0x183D489B0")]
		internal bool <GetSamples>b__0(global::GJDOCFJEMJA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float LGLEHGAFFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float LIOLIHALOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GJDOCFJEMJA<float, T>> JFOKDOIKECL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DHDJDLADDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D4FBD0", Offset = "0x3D4E9D0", VA = "0x183D4FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D50030", Offset = "0x3D4EE30", VA = "0x183D50030")]
	public PFBHJLPHHHL(float PEPBBPLEDIN, float EIDNEKCMGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FCB0", Offset = "0x3D4EAB0", VA = "0x183D4FCB0")]
	public bool NAJLKOCPNIK(float NHNBCPNNPKF, T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FC50", Offset = "0x3D4EA50", VA = "0x183D4FC50")]
	public int LELCFMBKOFP(float NHNBCPNNPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D4F4A0", Offset = "0x3D4E2A0", VA = "0x183D4F4A0")]
	public IEnumerable<T> ANAOBHHBOEE(float NHNBCPNNPKF, [Optional] float? JOMNIHJHPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FB20", Offset = "0x3D4E920", VA = "0x183D4FB20")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FF70", Offset = "0x3D4ED70", VA = "0x183D4FF70")]
	private void PKCDGGDIKFF(float NHNBCPNNPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FFFDJFEFGDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IIFNHCJNMOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T PGEGKAIHDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float PCACPGHJCKD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float GCKOMANIDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> DIPHOCFLCHE;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int JMJKELCJIHE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IIFNHCJNMOO[] JBGABNPCJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int BIEJAAMCKBI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JHODOCCNOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x55AB40", Offset = "0x559940", VA = "0x18055AB40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x55A790", Offset = "0x559590", VA = "0x18055A790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3918360", Offset = "0x3917160", VA = "0x183918360")]
	public FFFDJFEFGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3918280", Offset = "0x3917080", VA = "0x183918280")]
	public FFFDJFEFGDO(int NEPCFDJCABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3916E30", Offset = "0x3915C30", VA = "0x183916E30")]
	public void ACLEHGEDHGC(float NHNBCPNNPKF, T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3917840", Offset = "0x3916640", VA = "0x183917840")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39171C0", Offset = "0x3915FC0", VA = "0x1839171C0")]
	public bool BJCILJLFBKI(float DOADHBGLEBG, float ANPOAFNOCCB, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3917CA0", Offset = "0x3916AA0", VA = "0x183917CA0")]
	public bool IHFEIPBENGG(float DOADHBGLEBG, float ANPOAFNOCCB, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3917F70", Offset = "0x3916D70", VA = "0x183917F70")]
	public void KJPKHKKFHCK(float DOADHBGLEBG, float ANPOAFNOCCB, List<T> DIHJAPMJINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3918200", Offset = "0x3917000", VA = "0x183918200")]
	private int OPBMOMHALGP(int MNAIIMPHEND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3916FD0", Offset = "0x3915DD0", VA = "0x183916FD0")]
	private void AJBOIPOMGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AFMFPAPOGDD();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GCMAOPNNDAM(T JFEJNFHABLD, T AMFABEOMKAP, float NIPEJLHCHKC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DFFGDMBHPJB(T FCGCDNFBIMM, float NIPEJLHCHKC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DMBGKIILHGP(T JFEJNFHABLD, T AMFABEOMKAP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MECBDNKEBIG(T JFEJNFHABLD, T AMFABEOMKAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CCLKMHANBDG : global::FFFDJFEFGDO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4B92250", Offset = "0x4B91050", VA = "0x184B92250", Slot = "4")]
	protected override Vector3 AFMFPAPOGDD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B92410", Offset = "0x4B91210", VA = "0x184B92410", Slot = "5")]
	protected override Vector3 GCMAOPNNDAM(Vector3 JFEJNFHABLD, Vector3 AMFABEOMKAP, float NIPEJLHCHKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4B922C0", Offset = "0x4B910C0", VA = "0x184B922C0", Slot = "6")]
	protected override Vector3 DFFGDMBHPJB(Vector3 FCGCDNFBIMM, float NIPEJLHCHKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4B92360", Offset = "0x4B91160", VA = "0x184B92360", Slot = "7")]
	protected override Vector3 DMBGKIILHGP(Vector3 JFEJNFHABLD, Vector3 AMFABEOMKAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4B924D0", Offset = "0x4B912D0", VA = "0x184B924D0", Slot = "8")]
	protected override Vector3 MECBDNKEBIG(Vector3 JFEJNFHABLD, Vector3 AMFABEOMKAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B92540", Offset = "0x4B91340", VA = "0x184B92540")]
	public CCLKMHANBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GFGKDNFHJAA : global::FFFDJFEFGDO<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B93300", Offset = "0x4B92100", VA = "0x184B93300")]
	public GFGKDNFHJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B93290", Offset = "0x4B92090", VA = "0x184B93290")]
	public GFGKDNFHJAA(int NEPCFDJCABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x742990", Offset = "0x741790", VA = "0x180742990", Slot = "4")]
	protected override float AFMFPAPOGDD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B93200", Offset = "0x4B92000", VA = "0x184B93200", Slot = "5")]
	protected override float GCMAOPNNDAM(float JFEJNFHABLD, float AMFABEOMKAP, float NIPEJLHCHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4C20", Offset = "0x3FB3A20", VA = "0x183FB4C20", Slot = "6")]
	protected override float DFFGDMBHPJB(float FCGCDNFBIMM, float NIPEJLHCHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8F90", Offset = "0x2DA7D90", VA = "0x182DA8F90", Slot = "7")]
	protected override float DMBGKIILHGP(float JFEJNFHABLD, float AMFABEOMKAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B93280", Offset = "0x4B92080", VA = "0x184B93280", Slot = "8")]
	protected override float MECBDNKEBIG(float JFEJNFHABLD, float AMFABEOMKAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HADCHCGCBAB
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B7B0", Offset = "0x2B7A5B0", VA = "0x182B7B7B0")]
	public static global::HHFAOOBJDCM<T1> EPOPAOGMFCF<T1>(T1 KJMIBKNOGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C360", Offset = "0x2C2B160", VA = "0x182C2C360")]
	public static global::GJDOCFJEMJA<T1, T2> EPOPAOGMFCF<T1, T2>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B32B30", Offset = "0x2B31930", VA = "0x182B32B30")]
	public static global::MMBGJAGIJHC<T1, T2, T3> EPOPAOGMFCF<T1, T2, T3>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29B8390", Offset = "0x29B7190", VA = "0x1829B8390")]
	public static global::ECBIKOHFCAP<T1, T2, T3, T4> EPOPAOGMFCF<T1, T2, T3, T4>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B31A10", Offset = "0x2B30810", VA = "0x182B31A10")]
	public static global::KCAIOMHJHHA<T1, T2, T3, T4, T5> EPOPAOGMFCF<T1, T2, T3, T4, T5>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C3D0", Offset = "0x2C2B1D0", VA = "0x182C2C3D0")]
	public static global::ICADAFDNNCA<T1, T2, T3, T4, T5, T6> EPOPAOGMFCF<T1, T2, T3, T4, T5, T6>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3607C70", Offset = "0x3606A70", VA = "0x183607C70")]
	public static global::ANCLEIMFFKL<T1, T2, T3, T4, T5, T6, T7> EPOPAOGMFCF<T1, T2, T3, T4, T5, T6, T7>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH, T7 HOJFIGCDKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B32BC0", Offset = "0x2B319C0", VA = "0x182B32BC0")]
	public static global::LNLCGLLIJOJ<T1, T2, T3, T4, T5, T6, T7, T8> EPOPAOGMFCF<T1, T2, T3, T4, T5, T6, T7, T8>(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH, T7 HOJFIGCDKLG, T8 GCOCOOJHHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2632460", Offset = "0x2631260", VA = "0x182632460")]
	[IteratorStateMachine(typeof(CJCLFLDDLKH))]
	public static IEnumerable<global::GJDOCFJEMJA<T1, T2>> IEMAACJBEGB<T1, T2>(IEnumerable<T1> DCJNBPLJICC, IEnumerable<T2> JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27CCEC0", Offset = "0x27CBCC0", VA = "0x1827CCEC0")]
	[IteratorStateMachine(typeof(NKCAELDJMIN))]
	public static IEnumerable<global::MMBGJAGIJHC<T1, T2, T3>> IEMAACJBEGB<T1, T2, T3>(IEnumerable<T1> DCJNBPLJICC, IEnumerable<T2> JLGJJNEIJFM, IEnumerable<T3> OBNNFOCEGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3023630", Offset = "0x3022430", VA = "0x183023630")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4425970", Offset = "0x4424770", VA = "0x184425970")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4425980", Offset = "0x4424780", VA = "0x184425980")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF, int LDMHLBCPOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B937D0", Offset = "0x4B925D0", VA = "0x184B937D0")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF, int LDMHLBCPOJP, int IPJEGANOLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B937B0", Offset = "0x4B925B0", VA = "0x184B937B0")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF, int LDMHLBCPOJP, int IPJEGANOLOA, int POHHMCLCJBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B93820", Offset = "0x4B92620", VA = "0x184B93820")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF, int LDMHLBCPOJP, int IPJEGANOLOA, int POHHMCLCJBM, int LGKGLPODGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B937F0", Offset = "0x4B925F0", VA = "0x184B937F0")]
	internal static int BIIIGOGCIML(int IDIMGPKNABB, int HHCHMCIJJDM, int PPJJJIKAIPF, int LDMHLBCPOJP, int IPJEGANOLOA, int POHHMCLCJBM, int LGKGLPODGJD, int JNEMANJODBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HHFAOOBJDCM<T1> : IComparable<global::HHFAOOBJDCM<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FEEC30", Offset = "0x2FEDA30", VA = "0x182FEEC30")]
	public HHFAOOBJDCM(T1 KJMIBKNOGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F04520", Offset = "0x3F03320", VA = "0x183F04520", Slot = "4")]
	public int CompareTo(global::HHFAOOBJDCM<T1> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F04590", Offset = "0x3F03390", VA = "0x183F04590", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6563A0", Offset = "0x6551A0", VA = "0x1806563A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3F04630", Offset = "0x3F03430", VA = "0x183F04630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJDOCFJEMJA<T1, T2> : IComparable<global::GJDOCFJEMJA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0E70", Offset = "0x2CAFC70", VA = "0x182CB0E70")]
	public GJDOCFJEMJA(T1 KJMIBKNOGKN, T2 FELLGDJNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6220", Offset = "0x2FF5020", VA = "0x182FF6220", Slot = "4")]
	public int CompareTo(global::GJDOCFJEMJA<T1, T2> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6340", Offset = "0x2FF5140", VA = "0x182FF6340", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6E80", Offset = "0x2FF5C80", VA = "0x182FF6E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7900", Offset = "0x2FF6700", VA = "0x182FF7900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MMBGJAGIJHC<T1, T2, T3> : IComparable<global::MMBGJAGIJHC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A87F70", Offset = "0x3A86D70", VA = "0x183A87F70")]
	public MMBGJAGIJHC(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A87790", Offset = "0x3A86590", VA = "0x183A87790", Slot = "4")]
	public int CompareTo(global::MMBGJAGIJHC<T1, T2, T3> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A87A80", Offset = "0x3A86880", VA = "0x183A87A80", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A87C80", Offset = "0x3A86A80", VA = "0x183A87C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A87DE0", Offset = "0x3A86BE0", VA = "0x183A87DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ECBIKOHFCAP<T1, T2, T3, T4> : IComparable<global::ECBIKOHFCAP<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 PHMDGBHOIJI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3944590", Offset = "0x3943390", VA = "0x183944590")]
	public ECBIKOHFCAP(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3944160", Offset = "0x3942F60", VA = "0x183944160", Slot = "4")]
	public int CompareTo(global::ECBIKOHFCAP<T1, T2, T3, T4> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39442A0", Offset = "0x39430A0", VA = "0x1839442A0", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39443C0", Offset = "0x39431C0", VA = "0x1839443C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3944480", Offset = "0x3943280", VA = "0x183944480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KCAIOMHJHHA<T1, T2, T3, T4, T5> : IComparable<global::KCAIOMHJHHA<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 PHMDGBHOIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 MEPCFDNBCID;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x39EBA30", Offset = "0x39EA830", VA = "0x1839EBA30")]
	public KCAIOMHJHHA(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B810", Offset = "0x3F7A610", VA = "0x183F7B810", Slot = "4")]
	public int CompareTo(global::KCAIOMHJHHA<T1, T2, T3, T4, T5> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B990", Offset = "0x3F7A790", VA = "0x183F7B990", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BAD0", Offset = "0x3F7A8D0", VA = "0x183F7BAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BBD0", Offset = "0x3F7A9D0", VA = "0x183F7BBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ICADAFDNNCA<T1, T2, T3, T4, T5, T6> : IComparable<global::ICADAFDNNCA<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 PHMDGBHOIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 MEPCFDNBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 HHONAMBKELL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37CB130", Offset = "0x37C9F30", VA = "0x1837CB130")]
	public ICADAFDNNCA(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37CAB90", Offset = "0x37C9990", VA = "0x1837CAB90", Slot = "4")]
	public int CompareTo(global::ICADAFDNNCA<T1, T2, T3, T4, T5, T6> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37CAD50", Offset = "0x37C9B50", VA = "0x1837CAD50", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x37CAEC0", Offset = "0x37C9CC0", VA = "0x1837CAEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x37CAFE0", Offset = "0x37C9DE0", VA = "0x1837CAFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ANCLEIMFFKL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ANCLEIMFFKL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 PHMDGBHOIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 MEPCFDNBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 HHONAMBKELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 FDPAGGENGCP;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCCE0", Offset = "0x3BCBAE0", VA = "0x183BCCCE0")]
	public ANCLEIMFFKL(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH, T7 HOJFIGCDKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC680", Offset = "0x3BCB480", VA = "0x183BCC680", Slot = "4")]
	public int CompareTo(global::ANCLEIMFFKL<T1, T2, T3, T4, T5, T6, T7> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC880", Offset = "0x3BCB680", VA = "0x183BCC880", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCA20", Offset = "0x3BCB820", VA = "0x183BCCA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCB70", Offset = "0x3BCB970", VA = "0x183BCCB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LNLCGLLIJOJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::LNLCGLLIJOJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 NGPNLOKENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 DHAJLAIOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 GDLGJCNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 PHMDGBHOIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 MEPCFDNBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 HHONAMBKELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 FDPAGGENGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 JENKICGCPIM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2550", Offset = "0x2CB1350", VA = "0x182CB2550")]
	public LNLCGLLIJOJ(T1 KJMIBKNOGKN, T2 FELLGDJNMBE, T3 NMDMDMHLGDM, T4 FJPPEGNLNDF, T5 JJPFHFPOPAJ, T6 AGBGFHEAIDH, T7 HOJFIGCDKLG, T8 GCOCOOJHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1E40", Offset = "0x2CB0C40", VA = "0x182CB1E40", Slot = "4")]
	public int CompareTo(global::LNLCGLLIJOJ<T1, T2, T3, T4, T5, T6, T7, T8> MDLBKDPKIHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2090", Offset = "0x2CB0E90", VA = "0x182CB2090", Slot = "0")]
	public override bool Equals(object MDLBKDPKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2250", Offset = "0x2CB1050", VA = "0x182CB2250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CB23C0", Offset = "0x2CB11C0", VA = "0x182CB23C0", Slot = "3")]
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
	public T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MHBLOPDDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x681840", Offset = "0x680640", VA = "0x180681840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4063680", Offset = "0x4062480", VA = "0x184063680")]
	public T AGPHPGAIKCG(float NIPEJLHCHKC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x40639A0", Offset = "0x40627A0", VA = "0x1840639A0")]
	public T AKLMBCOOCPD(float NIPEJLHCHKC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GCMAOPNNDAM(T JFEJNFHABLD, T AMFABEOMKAP, float NIPEJLHCHKC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B93140", Offset = "0x4B91F40", VA = "0x184B93140", Slot = "4")]
	protected override float GCMAOPNNDAM(float JFEJNFHABLD, float AMFABEOMKAP, float NIPEJLHCHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B931C0", Offset = "0x4B91FC0", VA = "0x184B931C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B98830", Offset = "0x4B97630", VA = "0x184B98830", Slot = "4")]
	protected override Vector3 GCMAOPNNDAM(Vector3 JFEJNFHABLD, Vector3 AMFABEOMKAP, float NIPEJLHCHKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B988F0", Offset = "0x4B976F0", VA = "0x184B988F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F2E0", Offset = "0x1A4E0E0", VA = "0x181A4F2E0", Slot = "4")]
	protected override Color GCMAOPNNDAM(Color JFEJNFHABLD, Color AMFABEOMKAP, float NIPEJLHCHKC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B925A0", Offset = "0x4B913A0", VA = "0x184B925A0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class BIPACMFKOFK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] GMLDGAODONK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x527470", Offset = "0x526270", VA = "0x180527470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x54BBD0", Offset = "0x54A9D0", VA = "0x18054BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3620800", Offset = "0x361F600", VA = "0x183620800")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3620F30", Offset = "0x361FD30", VA = "0x183620F30")]
	public static global::BIPACMFKOFK<T> NLGMOIPFODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3620840", Offset = "0x361F640", VA = "0x183620840")]
	public static global::BIPACMFKOFK<T> IGEDFOBCEBB(int EHCNCIHFDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x36215D0", Offset = "0x36203D0", VA = "0x1836215D0")]
	private BIPACMFKOFK(T[] EEIJCDIHDKM, int EHCNCIHFDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3620710", Offset = "0x361F510", VA = "0x183620710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3620510", Offset = "0x361F310", VA = "0x183620510")]
	public void ACLEHGEDHGC(in T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3620980", Offset = "0x361F780", VA = "0x183620980")]
	public void JCCJEPICEDC(int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3620BB0", Offset = "0x361F9B0", VA = "0x183620BB0")]
	public void MDMFJHECCDC(in T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3621190", Offset = "0x361FF90", VA = "0x183621190")]
	public void OLLFHOOCNAD(int NEPCFDJCABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3621450", Offset = "0x3620250", VA = "0x183621450")]
	private void PDIEKMGNCOG(int EHCNCIHFDGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BPOMICEGKCF
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D49F00", Offset = "0x2D48D00", VA = "0x182D49F00")]
	public static global::BIPACMFKOFK<T> NLGMOIPFODL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2660680", Offset = "0x265F480", VA = "0x182660680")]
	public static global::BIPACMFKOFK<T> IGEDFOBCEBB<T>(int EHCNCIHFDGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class KDMGNMPAOJB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> BDCABMMANLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> BCHJIJJLHHA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8DC0", Offset = "0x2CB7BC0", VA = "0x182CB8DC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool AELLFDPMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56D080", Offset = "0x56BE80", VA = "0x18056D080", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> BOOLDBCADMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5600", Offset = "0x2FA4400", VA = "0x182FA5600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> LPHBFCFMEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3896A10", Offset = "0x3895810", VA = "0x183896A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6D50", Offset = "0x2DE5B50", VA = "0x182DE6D50", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A20EB0", Offset = "0x3A1FCB0", VA = "0x183A20EB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A20970", Offset = "0x3A1F770", VA = "0x183A20970")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A20B70", Offset = "0x3A1F970", VA = "0x183A20B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A203C0", Offset = "0x3A1F1C0", VA = "0x183A203C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A20D30", Offset = "0x3A1FB30", VA = "0x183A20D30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A20360", Offset = "0x3A1F160", VA = "0x183A20360", Slot = "9")]
	public void Add(TKey IIIMPJEHMOP, TVal FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A20330", Offset = "0x3A1F130", VA = "0x183A20330", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x340A460", Offset = "0x3409260", VA = "0x18340A460", Slot = "8")]
	public bool ContainsKey(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3822480", Offset = "0x3821280", VA = "0x183822480", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3894100", Offset = "0x3892F00", VA = "0x183894100", Slot = "10")]
	public bool Remove(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3894100", Offset = "0x3892F00", VA = "0x183894100", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37C60E0", Offset = "0x37C4EE0", VA = "0x1837C60E0", Slot = "11")]
	public bool TryGetValue(TKey IIIMPJEHMOP, out TVal FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A208F0", Offset = "0x3A1F6F0", VA = "0x183A208F0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A20450", Offset = "0x3A1F250", VA = "0x183A20450", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JBGABNPCJKJ, int BMHHGGDICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A202F0", Offset = "0x3A1F0F0", VA = "0x183A202F0")]
	public void ACLEHGEDHGC(TVal JLBKJKPDOGK, TKey IIIMPJEHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A20240", Offset = "0x3A1F040", VA = "0x183A20240")]
	public void ACLEHGEDHGC(KeyValuePair<TVal, TKey> GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A209A0", Offset = "0x3A1F7A0", VA = "0x183A209A0")]
	public bool HOELKKMDGJI(TVal IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A209D0", Offset = "0x3A1F7D0", VA = "0x183A209D0")]
	public bool LMKEPOFNNOB(KeyValuePair<TVal, TKey> GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x379CCD0", Offset = "0x379BAD0", VA = "0x18379CCD0")]
	public bool MDMFJHECCDC(TVal IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x379CCD0", Offset = "0x379BAD0", VA = "0x18379CCD0")]
	public bool MDMFJHECCDC(KeyValuePair<TVal, TKey> GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A208C0", Offset = "0x3A1F6C0", VA = "0x183A208C0")]
	public bool EIEDLFBIOLG(TVal IIIMPJEHMOP, out TKey FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A20AF0", Offset = "0x3A1F8F0", VA = "0x183A20AF0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MLKKLMECNPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A20BF0", Offset = "0x3A1F9F0", VA = "0x183A20BF0")]
	private void PJPKGAMJGOJ(TKey IIIMPJEHMOP, TVal JLBKJKPDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A20840", Offset = "0x3A1F640", VA = "0x183A20840")]
	private void DLJDGFEEIEM(TKey IIIMPJEHMOP, TVal JLBKJKPDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A204B0", Offset = "0x3A1F2B0", VA = "0x183A204B0")]
	private bool DFBAMDKGJGC(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A20570", Offset = "0x3A1F370", VA = "0x183A20570")]
	private bool DFBAMDKGJGC(TVal JLBKJKPDOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A20DD0", Offset = "0x3A1FBD0", VA = "0x183A20DD0")]
	public KDMGNMPAOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ONFMJLABKFP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::ONFMJLABKFP<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x55AB40", Offset = "0x559940", VA = "0x18055AB40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B534F0", Offset = "0x3B522F0", VA = "0x183B534F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3B538F0", Offset = "0x3B526F0", VA = "0x183B538F0")]
		public Enumerator(global::ONFMJLABKFP<T> DIHJAPMJINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3B53130", Offset = "0x3B51F30", VA = "0x183B53130", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B53350", Offset = "0x3B52150", VA = "0x183B53350", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B52D00", Offset = "0x3B51B00", VA = "0x183B52D00")]
		private void CIOINKLLMLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] JMMOMDLIGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ECAGHKFKCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int CIBHANHMOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IEMMODHJFLB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F4B0", Offset = "0x3B5E2B0", VA = "0x183B5F4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DC60", Offset = "0x3B5CA60", VA = "0x183B5DC60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F330", Offset = "0x3B5E130", VA = "0x183B5F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F6E0", Offset = "0x3B5E4E0", VA = "0x183B5F6E0")]
	public ONFMJLABKFP(int EHCNCIHFDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D7D0", Offset = "0x3B5C5D0", VA = "0x183B5D7D0")]
	public void ACLEHGEDHGC(T NIPEJLHCHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E910", Offset = "0x3B5D710", VA = "0x183B5E910")]
	public void NOENAMPIFHD(IEnumerable<T> JCPGADJLOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D9E0", Offset = "0x3B5C7E0", VA = "0x183B5D9E0")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5C750", VA = "0x183B5D950")]
	public void BELHKFGBFJD(int BFNOFMOBMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F420", Offset = "0x3B5E220", VA = "0x183B5F420")]
	public void PEGHEIFIJJJ(int BFNOFMOBMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E0D0", Offset = "0x3B5CED0", VA = "0x183B5E0D0")]
	public void NLFJOEDEMEC(T[] JBGABNPCJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DAF0", Offset = "0x3B5C8F0", VA = "0x183B5DAF0")]
	public Enumerator DDCMJDEOIHJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F5A0", Offset = "0x3B5E3A0", VA = "0x183B5F5A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F5A0", Offset = "0x3B5E3A0", VA = "0x183B5F5A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DEF0", Offset = "0x3B5CCF0", VA = "0x183B5DEF0")]
	private int JBIKJKAMGDO(int HLONBDLBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DB60", Offset = "0x3B5C960", VA = "0x183B5DB60")]
	private int FEBANPJPMHP(int HLONBDLBPCF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JFMAGPHKOCI<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Func<Internal, External> HIKBONHNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Func<External, Internal> ELEMKJKGKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private IList<Internal> JMOCBEAJCOO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> FPCMOCNLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AELLFDPMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x556EC0", Offset = "0x555CC0", VA = "0x180556EC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x556DF0", Offset = "0x555BF0", VA = "0x180556DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x31ABC30", Offset = "0x31AAA30", VA = "0x1831ABC30", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x31ABCD0", Offset = "0x31AAAD0", VA = "0x1831ABCD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x31ABBD0", Offset = "0x31AA9D0", VA = "0x1831ABBD0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x31ABB40", Offset = "0x31AA940", VA = "0x1831ABB40")]
	public JFMAGPHKOCI(Func<Internal, External> HIKBONHNNKN, Func<External, Internal> ELEMKJKGKFA, bool LPHGLIIDOLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x31AB8B0", Offset = "0x31AA6B0", VA = "0x1831AB8B0", Slot = "6")]
	public int IndexOf(External GAMNHLAINPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x31AB530", Offset = "0x31AA330", VA = "0x1831AB530", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x31AB590", Offset = "0x31AA390", VA = "0x1831AB590", Slot = "13")]
	public bool Contains(External GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x31AB620", Offset = "0x31AA420", VA = "0x1831AB620", Slot = "14")]
	public void CopyTo(External[] JBGABNPCJKJ, int BMHHGGDICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x31AB4A0", Offset = "0x31AA2A0", VA = "0x1831AB4A0", Slot = "11")]
	public void Add(External GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x31AB9A0", Offset = "0x31AA7A0", VA = "0x1831AB9A0", Slot = "7")]
	public void Insert(int HLONBDLBPCF, External GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x31ABAB0", Offset = "0x31AA8B0", VA = "0x1831ABAB0", Slot = "15")]
	public bool Remove(External GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x31ABA40", Offset = "0x31AA840", VA = "0x1831ABA40", Slot = "8")]
	public void RemoveAt(int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x31AB840", Offset = "0x31AA640", VA = "0x1831AB840", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC90D0", Offset = "0x2CC7ED0", VA = "0x182CC90D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class DGHOCPBOPJH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Func<Internal, External> HIKBONHNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private IReadOnlyList<Internal> JMOCBEAJCOO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> FPCMOCNLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AELLFDPMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x56D180", Offset = "0x56BF80", VA = "0x18056D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3823610", Offset = "0x3822410", VA = "0x183823610", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x38235B0", Offset = "0x38223B0", VA = "0x1838235B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEEC30", Offset = "0x2FEDA30", VA = "0x182FEEC30")]
	public DGHOCPBOPJH(Func<Internal, External> HIKBONHNNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3823560", Offset = "0x3822360", VA = "0x183823560")]
	public DGHOCPBOPJH(IReadOnlyList<Internal> JMOCBEAJCOO, Func<Internal, External> HIKBONHNNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3823340", Offset = "0x3822140", VA = "0x183823340")]
	public void NLFJOEDEMEC(External[] JBGABNPCJKJ, int BMHHGGDICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x38232D0", Offset = "0x38220D0", VA = "0x1838232D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x28EC580", Offset = "0x28EB380", VA = "0x1828EC580", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class FDPEPBHPPGD<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IReadOnlyList<Internal> JMOCBEAJCOO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> FPCMOCNLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AELLFDPMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x56D180", Offset = "0x56BF80", VA = "0x18056D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3914770", Offset = "0x3913570", VA = "0x183914770", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3914710", Offset = "0x3913510", VA = "0x183914710", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2FEEC30", Offset = "0x2FEDA30", VA = "0x182FEEC30")]
	public FDPEPBHPPGD(IReadOnlyList<Internal> JMOCBEAJCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3914440", Offset = "0x3913240", VA = "0x183914440")]
	public bool LMKEPOFNNOB(External GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39144E0", Offset = "0x39132E0", VA = "0x1839144E0")]
	public void NLFJOEDEMEC(External[] JBGABNPCJKJ, int BMHHGGDICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x39143D0", Offset = "0x39131D0", VA = "0x1839143D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC90D0", Offset = "0x2CC7ED0", VA = "0x182CC90D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class DDHLLMDCEAD
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FKLOLBPBNLF(object[] GHPOEKCNKKN);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	protected DDHLLMDCEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class OALAMFDJLCH<T> : DDHLLMDCEAD
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	protected struct CPPJDDDAENK
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum NMJAGDPKFOM
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NMJAGDPKFOM FHJGHNDLPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T CHNALKMKMGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int AECGPCIFAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool DJAPGCKMEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	protected readonly bool JIPIGODEEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected List<T> PMCMPCNMOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<CPPJDDDAENK> PKOMIJCGONC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MBDKKCOKKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4159610", Offset = "0x4158410", VA = "0x184159610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4159C10", Offset = "0x4158A10", VA = "0x184159C10")]
	protected OALAMFDJLCH(bool JIPIGODEEEK, bool DJAPGCKMEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4159780", Offset = "0x4158580", VA = "0x184159780")]
	protected bool JGOJAJJBNPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4159B30", Offset = "0x4158930", VA = "0x184159B30")]
	protected void OBHHMFGLMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4159980", Offset = "0x4158780", VA = "0x184159980")]
	protected void MLHMEMBECOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x373EBC0", Offset = "0x373D9C0", VA = "0x18373EBC0")]
	private static void CMFLCMIMCJA<U>(ref List<U> JMOCBEAJCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4159490", Offset = "0x4158290", VA = "0x184159490", Slot = "5")]
	public void ACLEHGEDHGC(T CHNALKMKMGL, bool BKKFKLOOAEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4159820", Offset = "0x4158620", VA = "0x184159820", Slot = "6")]
	public void MDMFJHECCDC(T CHNALKMKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4159650", Offset = "0x4158450", VA = "0x184159650")]
	public void CBNDPJOBHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HAMPDFPAIBP
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class MHBAOJKAIFE : global::OALAMFDJLCH<Action>, HAMPDFPAIBP
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4B95A20", Offset = "0x4B94820", VA = "0x184B95A20")]
	public MHBAOJKAIFE(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4B95860", Offset = "0x4B94660", VA = "0x184B95860")]
	public void MPLCFHLAICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4B95720", Offset = "0x4B94520", VA = "0x184B95720", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4B95800", Offset = "0x4B94600", VA = "0x184B95800")]
	public static MHBAOJKAIFE MNCPHEDMPDJ(MHBAOJKAIFE DHNCCPJGCPP, Action CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4B957A0", Offset = "0x4B945A0", VA = "0x184B957A0")]
	public static MHBAOJKAIFE LCOOIINHEEC(MHBAOJKAIFE DHNCCPJGCPP, Action CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CCMJPPDIOHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class LDCKPNFPHIJ<T> : global::OALAMFDJLCH<Action<T>>, global::CCMJPPDIOHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public LDCKPNFPHIJ(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD680", Offset = "0x3BFC480", VA = "0x183BFD680")]
	public void MPLCFHLAICD(T NIPEJLHCHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBF90", Offset = "0x3BFAD90", VA = "0x183BFBF90", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3BFCA00", Offset = "0x3BFB800", VA = "0x183BFCA00")]
	public static global::LDCKPNFPHIJ<T> MNCPHEDMPDJ(global::LDCKPNFPHIJ<T> DHNCCPJGCPP, Action<T> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC960", Offset = "0x3BFB760", VA = "0x183BFC960")]
	public static global::LDCKPNFPHIJ<T> LCOOIINHEEC(global::LDCKPNFPHIJ<T> DHNCCPJGCPP, Action<T> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface ONHHAPFIBFF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T, U> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T, U> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class JCBLMHJPGLL<T, U> : global::OALAMFDJLCH<Action<T, U>>, global::ONHHAPFIBFF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public JCBLMHJPGLL(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1F10", Offset = "0x2FA0D10", VA = "0x182FA1F10")]
	public void MPLCFHLAICD(T NIPEJLHCHKC, U OKCNMEJBPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FC10", Offset = "0x2F9EA10", VA = "0x182F9FC10", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1050", Offset = "0x2F9FE50", VA = "0x182FA1050")]
	public static global::JCBLMHJPGLL<T, U> MNCPHEDMPDJ(global::JCBLMHJPGLL<T, U> DHNCCPJGCPP, Action<T, U> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0FB0", Offset = "0x2F9FDB0", VA = "0x182FA0FB0")]
	public static global::JCBLMHJPGLL<T, U> LCOOIINHEEC(global::JCBLMHJPGLL<T, U> DHNCCPJGCPP, Action<T, U> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LCHKLEPDGLD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T, U, V> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T, U, V> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KFBFADJLIAD<T, U, V> : global::OALAMFDJLCH<Action<T, U, V>>, global::LCHKLEPDGLD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public KFBFADJLIAD(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3A25120", Offset = "0x3A23F20", VA = "0x183A25120")]
	public void MPLCFHLAICD(T NIPEJLHCHKC, U OKCNMEJBPLE, V MEIJOPLHICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3A23890", Offset = "0x3A22690", VA = "0x183A23890", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3A23B90", Offset = "0x3A22990", VA = "0x183A23B90")]
	public static global::KFBFADJLIAD<T, U, V> MNCPHEDMPDJ(global::KFBFADJLIAD<T, U, V> DHNCCPJGCPP, Action<T, U, V> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3A23AF0", Offset = "0x3A228F0", VA = "0x183A23AF0")]
	public static global::KFBFADJLIAD<T, U, V> LCOOIINHEEC(global::KFBFADJLIAD<T, U, V> DHNCCPJGCPP, Action<T, U, V> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NGHNEIBBOHD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T, U, V, W> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T, U, V, W> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DNJJDCCPCGC<T, U, V, W> : global::OALAMFDJLCH<Action<T, U, V, W>>, global::NGHNEIBBOHD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public DNJJDCCPCGC(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x36F4830", Offset = "0x36F3630", VA = "0x1836F4830")]
	public void MPLCFHLAICD(T NIPEJLHCHKC, U OKCNMEJBPLE, V MEIJOPLHICE, W BGFKLDGFFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x36F4100", Offset = "0x36F2F00", VA = "0x1836F4100", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36F4460", Offset = "0x36F3260", VA = "0x1836F4460")]
	public static global::DNJJDCCPCGC<T, U, V, W> MNCPHEDMPDJ(global::DNJJDCCPCGC<T, U, V, W> DHNCCPJGCPP, Action<T, U, V, W> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x36F43C0", Offset = "0x36F31C0", VA = "0x1836F43C0")]
	public static global::DNJJDCCPCGC<T, U, V, W> LCOOIINHEEC(global::DNJJDCCPCGC<T, U, V, W> DHNCCPJGCPP, Action<T, U, V, W> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EJPOMFGLKAG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T, U, V, W, X> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T, U, V, W, X> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class FIOKHMHEJCI<T, U, V, W, X> : global::OALAMFDJLCH<Action<T, U, V, W, X>>, global::EJPOMFGLKAG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public FIOKHMHEJCI(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C71250", Offset = "0x3C70050", VA = "0x183C71250")]
	public void MPLCFHLAICD(T NIPEJLHCHKC, U OKCNMEJBPLE, V MEIJOPLHICE, W BGFKLDGFFJD, X EIPKBLJANKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3C70E20", Offset = "0x3C6FC20", VA = "0x183C70E20", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3C711B0", Offset = "0x3C6FFB0", VA = "0x183C711B0")]
	public static global::FIOKHMHEJCI<T, U, V, W, X> MNCPHEDMPDJ(global::FIOKHMHEJCI<T, U, V, W, X> DHNCCPJGCPP, Action<T, U, V, W, X> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3C71110", Offset = "0x3C6FF10", VA = "0x183C71110")]
	public static global::FIOKHMHEJCI<T, U, V, W, X> LCOOIINHEEC(global::FIOKHMHEJCI<T, U, V, W, X> DHNCCPJGCPP, Action<T, U, V, W, X> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface JDJAMPMNPMJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLEHGEDHGC(Action<T, U, V, W, X, Y> CHNALKMKMGL, bool BKKFKLOOAEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFJHECCDC(Action<T, U, V, W, X, Y> CHNALKMKMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class JNALMDFMCMI<T, U, V, W, X, Y> : global::OALAMFDJLCH<Action<T, U, V, W, X, Y>>, global::JDJAMPMNPMJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A40", Offset = "0x2FA3840", VA = "0x182FA4A40")]
	public JNALMDFMCMI(bool JIPIGODEEEK = false, bool DJAPGCKMEGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F6C0", Offset = "0x3F6E4C0", VA = "0x183F6F6C0")]
	public void MPLCFHLAICD(T NIPEJLHCHKC, U OKCNMEJBPLE, V MEIJOPLHICE, W BGFKLDGFFJD, X EIPKBLJANKN, Y POPNGEAPMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EEF0", Offset = "0x3F6DCF0", VA = "0x183F6EEF0", Slot = "4")]
	public override void FKLOLBPBNLF(object[] GHPOEKCNKKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F620", Offset = "0x3F6E420", VA = "0x183F6F620")]
	public static global::JNALMDFMCMI<T, U, V, W, X, Y> MNCPHEDMPDJ(global::JNALMDFMCMI<T, U, V, W, X, Y> DHNCCPJGCPP, Action<T, U, V, W, X, Y> CHNALKMKMGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F580", Offset = "0x3F6E380", VA = "0x183F6F580")]
	public static global::JNALMDFMCMI<T, U, V, W, X, Y> LCOOIINHEEC(global::JNALMDFMCMI<T, U, V, W, X, Y> DHNCCPJGCPP, Action<T, U, V, W, X, Y> CHNALKMKMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CDMKELCOHNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LPIPEHIBCPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly global::CDMKELCOHNI<T> NHDAFFEKKJD;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T PGEGKAIHDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3AF0020", Offset = "0x3AEEE20", VA = "0x183AF0020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0040", Offset = "0x3AEEE40", VA = "0x183AF0040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB00", Offset = "0x7D9900", VA = "0x1807DAB00")]
		public LPIPEHIBCPE(global::CDMKELCOHNI<T> NHDAFFEKKJD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NLMHJOKHEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<LPIPEHIBCPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public global::CDMKELCOHNI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0070", Offset = "0x3AEEE70", VA = "0x183AF0070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x39E7BB0", Offset = "0x39E69B0", VA = "0x1839E7BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FOJNCPJKIOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<LPIPEHIBCPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::CDMKELCOHNI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF560", Offset = "0x3AEE360", VA = "0x183AEF560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x39E7BB0", Offset = "0x39E69B0", VA = "0x1839E7BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly SemaphoreSlim LEPMMHIIIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private T FHKNPJBFHPK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int AKDPHPGILDC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8F30", Offset = "0x3AE7D30", VA = "0x183AE8F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8F50", Offset = "0x3AE7D50", VA = "0x183AE8F50")]
	public CDMKELCOHNI(in T FHKNPJBFHPK, int ADKDGCOJMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9090", Offset = "0x3AE7E90", VA = "0x183AE9090")]
	public CDMKELCOHNI(in T FHKNPJBFHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8EB0", Offset = "0x3AE7CB0", VA = "0x183AE8EB0")]
	public LPIPEHIBCPE FMOOKBNDHOP()
	{
		return default(LPIPEHIBCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8EF0", Offset = "0x3AE7CF0", VA = "0x183AE8EF0")]
	public LPIPEHIBCPE FMOOKBNDHOP(CancellationToken JPKIDIFCNPO)
	{
		return default(LPIPEHIBCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8D50", Offset = "0x3AE7B50", VA = "0x183AE8D50")]
	[AsyncStateMachine(typeof(global::CDMKELCOHNI<>.NLMHJOKHEPN))]
	public Task<LPIPEHIBCPE> EJDAJOGOHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3AE88F0", Offset = "0x3AE76F0", VA = "0x183AE88F0")]
	[AsyncStateMachine(typeof(global::CDMKELCOHNI<>.FOJNCPJKIOG))]
	public Task<LPIPEHIBCPE> EJDAJOGOHLM(CancellationToken JPKIDIFCNPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NNLINKKLCII
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4B95D80", Offset = "0x4B94B80", VA = "0x184B95D80")]
	public static global::CDMKELCOHNI<NDDAMLGKLIM> NLGMOIPFODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4B95D10", Offset = "0x4B94B10", VA = "0x184B95D10")]
	public static global::CDMKELCOHNI<NDDAMLGKLIM> NLGMOIPFODL(int ADKDGCOJMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B7B0", Offset = "0x2B7A5B0", VA = "0x182B7B7B0")]
	public static global::CDMKELCOHNI<T> NLGMOIPFODL<T>(in T FHKNPJBFHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C6C0", Offset = "0x2C2B4C0", VA = "0x182C2C6C0")]
	public static global::CDMKELCOHNI<T> NLGMOIPFODL<T>(in T FHKNPJBFHPK, int ADKDGCOJMGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GAIHONFINOC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate bool JJEPHJNOGLN(global::GAIHONFINOC<T> KCNHGDMDEHK);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GHPMOPHDLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::GAIHONFINOC<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public GHPMOPHDLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F99BF0", Offset = "0x3F989F0", VA = "0x183F99BF0")]
		internal bool <FindNode>b__0(global::GAIHONFINOC<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public T HBGDADIGPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LinkedList<global::GAIHONFINOC<T>> DCPBEMCIMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public global::GAIHONFINOC<T> LPPJIGEJBLB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::GAIHONFINOC<T> GHLEIDFDHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x562140", Offset = "0x560F40", VA = "0x180562140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B550", Offset = "0x3F8A350", VA = "0x183F8B550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NIOPFDAFGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B3C0", Offset = "0x3F8A1C0", VA = "0x183F8B3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NMBAEJHAEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C680", Offset = "0x3F8B480", VA = "0x183F8C680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GAIHONFINOC<T> BLGMEJFMEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B3F0", Offset = "0x3F8A1F0", VA = "0x183F8B3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D4B0", Offset = "0x3F8C2B0", VA = "0x183F8D4B0")]
	public GAIHONFINOC(T JMOEADJJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BA60", Offset = "0x3F8A860", VA = "0x183F8BA60")]
	public global::GAIHONFINOC<T> HCFBMOELJMH(T CCMGFKEHMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BE30", Offset = "0x3F8AC30", VA = "0x183F8BE30")]
	public global::GAIHONFINOC<T> HGMLFDJADND(T HBINFGAINKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C790", Offset = "0x3F8B590", VA = "0x183F8C790")]
	public global::GAIHONFINOC<T> MDMFJHECCDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B160", Offset = "0x3F89F60", VA = "0x183F8B160")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D3A0", Offset = "0x3F8C1A0", VA = "0x183F8D3A0")]
	public global::GAIHONFINOC<T> PIBNBIILOPO(T OFMLLPMLIKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C340", Offset = "0x3F8B140", VA = "0x183F8C340")]
	public static void JJPLEPCLMBC(global::GAIHONFINOC<T> NFJHOCBCEDB, JJEPHJNOGLN ODNPFMHPBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x35CCEF0", Offset = "0x35CBCF0", VA = "0x1835CCEF0")]
	public static void JJPLEPCLMBC<A>(global::GAIHONFINOC<T> NFJHOCBCEDB, Func<global::GAIHONFINOC<T>, A, bool> ODNPFMHPBKB, A KFLNHIHANKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C840", Offset = "0x3F8B640", VA = "0x183F8C840")]
	public static string ONDOBCBEFJJ(global::GAIHONFINOC<T> NFJHOCBCEDB, int JNMLENKGGDM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B840", Offset = "0x3F8A640", VA = "0x183F8B840")]
	public static global::GAIHONFINOC<T> GKDGMENDAAB(global::GAIHONFINOC<T> NFJHOCBCEDB, T HMELDLEFMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NDHKPJMCBGN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> OGFEINHCKBN(TRequest PAHHEBOMPLG, CancellationToken JPKIDIFCNPO);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum EAGCCJEEFDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class OHHKGNLMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private const float IFKIPHLKBLK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TimeSpan IBFOJMHOELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int NNGMEFJFJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EAGCCJEEFDA INOCBKPILOM;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly OHHKGNLMEJI MHNALHBMJHB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BJLLOFAFGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3CBDA10", Offset = "0x3CBC810", VA = "0x183CBDA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan KBEENOJIKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDA80", Offset = "0x3CBC880", VA = "0x183CBDA80")]
		public OHHKGNLMEJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct NNAOEIIHBHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly TRequest PAHHEBOMPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly CancellationToken JPKIDIFCNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly TaskCompletionSource<TResult> GCEKHGAGJFJ;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCAD0", Offset = "0x3CBB8D0", VA = "0x183CBCAD0")]
		public NNAOEIIHBHF(TRequest PAHHEBOMPLG, TaskCompletionSource<TResult> GCEKHGAGJFJ, CancellationToken JPKIDIFCNPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PFPININJJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public PFPININJJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8DC0", Offset = "0x2CB7BC0", VA = "0x182CB8DC0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct HKGLLPJLKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::NDHKPJMCBGN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE320", Offset = "0x3CAD120", VA = "0x183CAE320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x819040", Offset = "0x817E40", VA = "0x180819040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class CEKBEONCNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NNAOEIIHBHF req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::NDHKPJMCBGN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public CEKBEONCNKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE020", Offset = "0x3CACE20", VA = "0x183CAE020")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource FEMPCNLNHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<NNAOEIIHBHF> LDECIABPMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OHHKGNLMEJI MPIGCBOFIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OGFEINHCKBN AOOMEMHLOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Task GNHHOMEMCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int AODBILLONPL;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9EA0", Offset = "0x3CB8CA0", VA = "0x183CB9EA0")]
	public NDHKPJMCBGN(OGFEINHCKBN AOOMEMHLOIE, [Optional] OHHKGNLMEJI MPIGCBOFIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9420", Offset = "0x3CB8220", VA = "0x183CB9420")]
	public Task<TResult> JPLOMJEAOOJ(TRequest PAHHEBOMPLG, CancellationToken JPKIDIFCNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3CB85D0", Offset = "0x3CB73D0", VA = "0x183CB85D0")]
	private void CNBMNJGIFOD(NNAOEIIHBHF BHFMADCDGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8E80", Offset = "0x3CB7C80", VA = "0x183CB8E80")]
	[AsyncStateMachine(typeof(global::NDHKPJMCBGN<, >.HKGLLPJLKNE))]
	private Task EHEPPMGCLDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8990", Offset = "0x3CB7790", VA = "0x183CB8990")]
	private NNAOEIIHBHF DEHCKNGDEDJ()
	{
		return default(NNAOEIIHBHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3CB98D0", Offset = "0x3CB86D0", VA = "0x183CB98D0")]
	private void NJJCLGALOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8E40", Offset = "0x3CB7C40", VA = "0x183CB8E40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class IGBEKNMINHM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int GAGANPEDMEA(TKey IIIMPJEHMOP, TVal FCGCDNFBIMM);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JAPGNKIGPAB
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TKey CMHEHIDHKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TVal PGEGKAIHDFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5518F0", Offset = "0x5506F0", VA = "0x1805518F0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x551AE0", Offset = "0x5508E0", VA = "0x180551AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int CLMEKPFJDDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x55A300", Offset = "0x559100", VA = "0x18055A300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x55A310", Offset = "0x559110", VA = "0x18055A310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DateTime OPEHPLNLHJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x9131F0", Offset = "0x911FF0", VA = "0x1809131F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x37CC720", Offset = "0x37CB520", VA = "0x1837CC720")]
		public JAPGNKIGPAB(TKey IIIMPJEHMOP, TVal JLBKJKPDOGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int GJBJBMJCELM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, LinkedListNode<JAPGNKIGPAB>> KIHKCLKKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly LinkedList<JAPGNKIGPAB> ILLBPKNGAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GAGANPEDMEA PHPBMFGPDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly TimeSpan IIJKPHLMDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly IJEFENNHFFN GKCNDEMBIGG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PGHAJOMDPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x526A00", Offset = "0x525800", VA = "0x180526A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool PMCGHLADADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x37CBFC0", Offset = "0x37CADC0", VA = "0x1837CBFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal int GHIGNGLOHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9309F0", Offset = "0x92F7F0", VA = "0x1809309F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D70", Offset = "0x8C3B70", VA = "0x1808C4D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCFF0", Offset = "0x2BBBDF0", VA = "0x182BBCFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IEnumerable<TKey> BOOLDBCADMA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x37CB6A0", Offset = "0x37CA4A0", VA = "0x1837CB6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TVal LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x379CCD0", Offset = "0x379BAD0", VA = "0x18379CCD0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x37CC1E0", Offset = "0x37CAFE0", VA = "0x1837CC1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3890900", Offset = "0x388F700", VA = "0x183890900")]
	public IGBEKNMINHM(int EHCNCIHFDGJ, [Optional] GAGANPEDMEA PHPBMFGPDLO, [Optional] IEqualityComparer<TKey> POANMEKHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x37CC5D0", Offset = "0x37CB3D0", VA = "0x1837CC5D0")]
	public IGBEKNMINHM(TimeSpan IIJKPHLMDDF, [Optional] IEqualityComparer<TKey> POANMEKHABD, [Optional] IJEFENNHFFN GKCNDEMBIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x37CC580", Offset = "0x37CB380", VA = "0x1837CC580")]
	public IGBEKNMINHM(int EHCNCIHFDGJ, TimeSpan IIJKPHLMDDF, [Optional] IEqualityComparer<TKey> POANMEKHABD, [Optional] IJEFENNHFFN GKCNDEMBIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x37CC2E0", Offset = "0x37CB0E0", VA = "0x1837CC2E0")]
	public IGBEKNMINHM(int EHCNCIHFDGJ, GAGANPEDMEA PHPBMFGPDLO, TimeSpan IIJKPHLMDDF, [Optional] IEqualityComparer<TKey> POANMEKHABD, [Optional] IJEFENNHFFN GKCNDEMBIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x37CB470", Offset = "0x37CA270", VA = "0x1837CB470")]
	public void CDCAOCCJLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x37CB980", Offset = "0x37CA780", VA = "0x1837CB980")]
	public void EDLAGHPBKKE(TKey IIIMPJEHMOP, TVal FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x37CC050", Offset = "0x37CAE50", VA = "0x1837CC050")]
	public bool MDMFJHECCDC(TKey IIIMPJEHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x37CB8C0", Offset = "0x37CA6C0", VA = "0x1837CB8C0")]
	private TVal DNADPOIAFHF(TKey MDHOFOCAIKK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3890370", Offset = "0x388F170", VA = "0x183890370")]
	public bool EIEDLFBIOLG(TKey MDHOFOCAIKK, out TVal FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x37CB3F0", Offset = "0x37CA1F0", VA = "0x1837CB3F0")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x37CB5E0", Offset = "0x37CA3E0", VA = "0x1837CB5E0")]
	private bool CKKMFAOMGDA(JAPGNKIGPAB CFPNDIKCILA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x37CBD30", Offset = "0x37CAB30", VA = "0x1837CBD30")]
	private void GFIEIFGKOKO(LinkedListNode<JAPGNKIGPAB> EJBKOOPJJHC, TVal DMFFGABONKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x37CB1E0", Offset = "0x37C9FE0", VA = "0x1837CB1E0")]
	private void BGHKPAIEIGJ(TKey IIIMPJEHMOP, TVal FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x37CBB90", Offset = "0x37CA990", VA = "0x1837CBB90")]
	private void FEHLKHNHDCP(JAPGNKIGPAB CFPNDIKCILA, TVal DMFFGABONKN, int NJPLAFPDJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class PNDDKLHPJLJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<T> JMOCBEAJCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private HashSet<T> HGPCOGJJDPE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8DC0", Offset = "0x2CB7BC0", VA = "0x182CB8DC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool AELLFDPMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x56D080", Offset = "0x56BE80", VA = "0x18056D080", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE72D0", Offset = "0x2DE60D0", VA = "0x182DE72D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7300", Offset = "0x2DE6100", VA = "0x182DE7300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6A40", Offset = "0x2DE5840", VA = "0x182DE6A40", Slot = "11")]
	public void Add(T GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE68F0", Offset = "0x2DE56F0", VA = "0x182DE68F0")]
	public bool AMCNFHOKNDD(T GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7170", Offset = "0x2DE5F70", VA = "0x182DE7170", Slot = "15")]
	public bool Remove(T GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6CD0", Offset = "0x2DE5AD0", VA = "0x182DE6CD0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CC70C0", Offset = "0x2CC5EC0", VA = "0x182CC70C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6C10", Offset = "0x2DE5A10", VA = "0x182DE6C10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6C70", Offset = "0x2DE5A70", VA = "0x182DE6C70", Slot = "13")]
	public bool Contains(T GAMNHLAINPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6CA0", Offset = "0x2DE5AA0", VA = "0x182DE6CA0", Slot = "14")]
	public void CopyTo(T[] JBGABNPCJKJ, int BMHHGGDICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6D50", Offset = "0x2DE5B50", VA = "0x182DE6D50", Slot = "6")]
	public int IndexOf(T GAMNHLAINPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6D80", Offset = "0x2DE5B80", VA = "0x182DE6D80", Slot = "7")]
	public void Insert(int HLONBDLBPCF, T GAMNHLAINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6F40", Offset = "0x2DE5D40", VA = "0x182DE6F40", Slot = "8")]
	public void RemoveAt(int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6A70", Offset = "0x2DE5870", VA = "0x182DE6A70")]
	public void CFENJOFMEGE(Predicate<T> OBKLEBMGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6F10", Offset = "0x2DE5D10", VA = "0x182DE6F10")]
	public void JMPBBNGMBEA(Comparison<T> DMHENEKHBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE71F0", Offset = "0x2DE5FF0", VA = "0x182DE71F0")]
	public PNDDKLHPJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NKGIIDMNBGB
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B95A80", Offset = "0x4B94880", VA = "0x184B95A80")]
	public static Vector3 FAKAKGAGEKJ(this GameObject MHCMMACILPC, float BECAOCBOPMJ)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5EE230", Offset = "0x5ED030", VA = "0x1805EE230")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B97E10", Offset = "0x4B96C10", VA = "0x184B97E10")]
		public SerializedGuid(in Guid GPMFNPNNKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B97CC0", Offset = "0x4B96AC0", VA = "0x184B97CC0")]
		public static SerializedGuid MJGGBKIBKFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B97C30", Offset = "0x4B96A30", VA = "0x184B97C30")]
		public static SerializedGuid GFFBPJKNGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B97960", Offset = "0x4B96760", VA = "0x184B97960")]
		public bool CIJOBKNNJEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4B97DE0", Offset = "0x4B96BE0", VA = "0x184B97DE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4B97D40", Offset = "0x4B96B40", VA = "0x184B97D40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4B97BA0", Offset = "0x4B969A0", VA = "0x184B97BA0")]
		public bool FFGLJKBEKDL(in Guid GPMFNPNNKFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4B97A20", Offset = "0x4B96820", VA = "0x184B97A20", Slot = "7")]
		public bool Equals(SerializedGuid MDLBKDPKIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4B97AC0", Offset = "0x4B968C0", VA = "0x184B97AC0", Slot = "0")]
		public override bool Equals(object HOBENCJANIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4B97CB0", Offset = "0x4B96AB0", VA = "0x184B97CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B979F0", Offset = "0x4B967F0", VA = "0x184B979F0", Slot = "6")]
		public int CompareTo(SerializedGuid MDLBKDPKIHG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HHLFAHEANON : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Type KMPHBAJFNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string OKDOIHCBIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool KIMCDKOKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool MCKHLHDMLIH;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B94660", Offset = "0x4B93460", VA = "0x184B94660")]
	public HHLFAHEANON(Type DGDDMIKALIN, string BEHNOMNIKPD, bool FCABLAOBGGI = false, bool FPMNEMNOMPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface ELBGOIIHMHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface AGOOKCIHHGF<T> : ELBGOIIHMHK
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool AEKNALNJBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string PODACOLLDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AGOOKCIHHGF<T> IANHCJEDLGD(Action<T> IFNALIFDHMA);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AGOOKCIHHGF<T> LCNEDNLIAEE(Action<T> IFNALIFDHMA);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AGOOKCIHHGF<T> FOGNJBKOOGI(Action<T, T> KMOOKFNLFAG);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AGOOKCIHHGF<T> HIBOFENPBFH(Action<T, T> KMOOKFNLFAG);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AGOOKCIHHGF<T> NPFDDGDCHCK(Action<string> PKBICDLCFJL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AGOOKCIHHGF<T> GEOLHMBPAAF(Action<string> PKBICDLCFJL);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DCOKBGPMPHD<T> : global::AGOOKCIHHGF<T>, ELBGOIIHMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private global::JCBLMHJPGLL<T, T> OLMEJAJPPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private global::LDCKPNFPHIJ<T> GLBGKKGMNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private global::LDCKPNFPHIJ<string> KJOLFIKDEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string NLMHPLPAFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private T CKHKIPCNPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool OOOHDHKCICO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2740", Offset = "0x2DE1540", VA = "0x182DE2740", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool AEKNALNJBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6016F0", Offset = "0x6004F0", VA = "0x1806016F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string PODACOLLDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526290", VA = "0x180527490", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x31B5000", Offset = "0x31B3E00", VA = "0x1831B5000", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x39EFF10", Offset = "0x39EED10", VA = "0x1839EFF10")]
	private void JCODMBJCOJN(T FHIGODIFLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x39F0140", Offset = "0x39EEF40", VA = "0x1839F0140")]
	private void PBPOAOLJMMN(string EPHFPFMDCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x39F0000", Offset = "0x39EEE00", VA = "0x1839F0000")]
	public void LPAKPFAJHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x39EFD70", Offset = "0x39EEB70", VA = "0x1839EFD70", Slot = "6")]
	public global::AGOOKCIHHGF<T> FOGNJBKOOGI(Action<T, T> KMOOKFNLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x39EFE30", Offset = "0x39EEC30", VA = "0x1839EFE30", Slot = "7")]
	public global::AGOOKCIHHGF<T> HIBOFENPBFH(Action<T, T> KMOOKFNLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x39EFE80", Offset = "0x39EEC80", VA = "0x1839EFE80", Slot = "4")]
	public global::AGOOKCIHHGF<T> IANHCJEDLGD(Action<T> KMOOKFNLFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x39EFFB0", Offset = "0x39EEDB0", VA = "0x1839EFFB0", Slot = "5")]
	public global::AGOOKCIHHGF<T> LCNEDNLIAEE(Action<T> IFNALIFDHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x39F00B0", Offset = "0x39EEEB0", VA = "0x1839F00B0", Slot = "8")]
	public global::AGOOKCIHHGF<T> NPFDDGDCHCK(Action<string> PKBICDLCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x39EFDC0", Offset = "0x39EEBC0", VA = "0x1839EFDC0", Slot = "9")]
	public global::AGOOKCIHHGF<T> GEOLHMBPAAF(Action<string> PKBICDLCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x39F01E0", Offset = "0x39EEFE0", VA = "0x1839F01E0")]
	public DCOKBGPMPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class JKAMIJMDJLE
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CKEMHNJHNAD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::AGOOKCIHHGF<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::NHLAFCECFCD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public CKEMHNJHNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x31A7110", Offset = "0x31A5F10", VA = "0x1831A7110")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x29B9320", Offset = "0x29B8120", VA = "0x1829B9320")]
	public static global::JDJCJHOOLJN<T> CNJMPMKBCAL<T>(this global::AGOOKCIHHGF<T> GKABFHKJDIL, Action<T> NIBAGIPBILN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class IJEFENNHFFN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class EECJKJDNCLA : IJEFENNHFFN
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static IJEFENNHFFN OECOELJNNCK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4B92F40", Offset = "0x4B91D40", VA = "0x184B92F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override DateTime OIOMLCJMHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4B92FA0", Offset = "0x4B91DA0", VA = "0x184B92FA0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override float GBNGNFOJKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B92020", Offset = "0x4B90E20", VA = "0x184B92020", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4B93090", Offset = "0x4B91E90", VA = "0x184B93090")]
		public EECJKJDNCLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static IJEFENNHFFN AJJOCPKOJFB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static IJEFENNHFFN MHNALHBMJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B94810", Offset = "0x4B93610", VA = "0x184B94810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract DateTime OIOMLCJMHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public abstract float GBNGNFOJKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	protected IJEFENNHFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BKACGGEGMLN : global::HEJAMCELGCF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B92210", Offset = "0x4B91010", VA = "0x184B92210")]
	public BKACGGEGMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HEJAMCELGCF<T> : global::HGOLGKDEBAO<T>, DKMAOLPDHHK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> HMJCJHMEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task PFKDMLCBKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28DACC0", Offset = "0x28D9AC0", VA = "0x1828DACC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::JDJCJHOOLJN<T> NOFJBFODDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private GGJFLBABPCA BMKIDPMLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x28DC600", Offset = "0x28DB400", VA = "0x1828DC600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3F04440", Offset = "0x3F03240", VA = "0x183F04440")]
	public HEJAMCELGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FDHLHBHIPHJ : global::JEGJENCEPOK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B930F0", Offset = "0x4B91EF0", VA = "0x184B930F0")]
	public FDHLHBHIPHJ(Exception BNOCGDMHEJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JEGJENCEPOK<T> : global::HGOLGKDEBAO<T>, DKMAOLPDHHK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> HMJCJHMEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task PFKDMLCBKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x28DACC0", Offset = "0x28D9AC0", VA = "0x1828DACC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::JDJCJHOOLJN<T> NOFJBFODDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private GGJFLBABPCA BMKIDPMLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x28DC600", Offset = "0x28DB400", VA = "0x1828DC600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x31AB3A0", Offset = "0x31AA1A0", VA = "0x1831AB3A0")]
	public JEGJENCEPOK(Exception BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface DKMAOLPDHHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	Task HMJCJHMEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	GGJFLBABPCA NOFJBFODDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface HGOLGKDEBAO<T> : DKMAOLPDHHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[NotNull]
	new Task<T> HMJCJHMEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	[NotNull]
	new global::JDJCJHOOLJN<T> NOFJBFODDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class AGKJGJFJAEG<TTask, T> : global::HGOLGKDEBAO<T>, DKMAOLPDHHK, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FKDPDNIIKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public global::AGKJGJFJAEG<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public FKDPDNIIKIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static bool KBIMIPGIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Task<T> OKIBMKJNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CancellationTokenSource DLHLAICPPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool IMDFPFHAILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SynchronizationContext CDDBOIKIDKO;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> HMJCJHMEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task PFKDMLCBKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::JDJCJHOOLJN<T> NOFJBFODDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private GGJFLBABPCA BMKIDPMLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6280", Offset = "0x2CC5080", VA = "0x182CC6280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool KOHPBENLGML
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x556EC0", Offset = "0x555CC0", VA = "0x180556EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x39DF850", Offset = "0x39DE650", VA = "0x1839DF850")]
	static AGKJGJFJAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x39DF9C0", Offset = "0x39DE7C0", VA = "0x1839DF9C0")]
	protected AGKJGJFJAEG(TTask OKIBMKJNBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x39DF270", Offset = "0x39DE070", VA = "0x1839DF270", Slot = "1")]
	~AGKJGJFJAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3662D00", Offset = "0x3661B00", VA = "0x183662D00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x39DF3B0", Offset = "0x39DE1B0", VA = "0x1839DF3B0")]
	private void JHKCEBHDNNF(bool GPIJKOLDNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T EPAJPMDPEBK(TTask OHAHAGMLBMG);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HHOMJCLCJLB();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x39DF690", Offset = "0x39DE490", VA = "0x1839DF690")]
	[CompilerGenerated]
	private void LLMGPMEKOHO(object EDLFDAMBHJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IGPEJPJLOPG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly Type KMPHBAJFNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly string OKDOIHCBIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly bool KIMCDKOKDNL;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4B947B0", Offset = "0x4B935B0", VA = "0x184B947B0")]
	public IGPEJPJLOPG(Type DGDDMIKALIN, string BEHNOMNIKPD, bool FCABLAOBGGI = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x523010", Offset = "0x521E10", VA = "0x180523010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x54EBA0", Offset = "0x54D9A0", VA = "0x18054EBA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public T this[int JOJIIFJCHGB, int ENLIMEIJDBG]
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x28DB250", Offset = "0x28DA050", VA = "0x1828DB250")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x28DB2F0", Offset = "0x28DA0F0", VA = "0x1828DB2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x28DB1C0", Offset = "0x28D9FC0", VA = "0x1828DB1C0")]
		public Array2D(uint CEKEOJFHGKE, uint GNPEIMEDGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x28DB140", Offset = "0x28D9F40", VA = "0x1828DB140")]
		public void CBNDPJOBHAL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4B921B0", Offset = "0x4B90FB0", VA = "0x184B921B0")]
		public Array2DVector3(uint CEKEOJFHGKE, uint GNPEIMEDGFJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal static class ELLMOICBAOB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int OFMLFLEEOOH = -1;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int FCEBDDDDMMG = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class ANLCFPKMOGG<THandle, TValue> : IDisposable where THandle : struct, OBPJHNKLAEJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<THandle> FIMOECJLAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<TValue> MPAKKJPOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TValue> DFKOHDEEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue> DMFLBFFJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private int CGJPOPHMEND;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TValue LCBDGGGBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x379CCD0", Offset = "0x379BAD0", VA = "0x18379CCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x379D260", Offset = "0x379C060", VA = "0x18379D260")]
	public ANLCFPKMOGG(Action<TValue> DMFLBFFJLDO, [Optional] Func<TValue> DFKOHDEEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x379CAD0", Offset = "0x379B8D0", VA = "0x18379CAD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD8C0", Offset = "0x3BCC6C0", VA = "0x183BCD8C0")]
	public THandle EPOPAOGMFCF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x379C7D0", Offset = "0x379B5D0", VA = "0x18379C7D0")]
	public THandle ACLEHGEDHGC(TValue FCGCDNFBIMM)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x379CF30", Offset = "0x379BD30", VA = "0x18379CF30")]
	public bool MDMFJHECCDC(THandle CBGDBIFJHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x379C840", Offset = "0x379B640", VA = "0x18379C840")]
	public bool AOCFLIMKKCB(THandle CBGDBIFJHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x379D0F0", Offset = "0x379BEF0", VA = "0x18379D0F0")]
	public bool NOOJLMIMJBL(THandle CBGDBIFJHEA, out TValue FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x379CA80", Offset = "0x379B880", VA = "0x18379CA80")]
	public TValue DNADPOIAFHF(THandle CBGDBIFJHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x379C960", Offset = "0x379B760", VA = "0x18379C960")]
	public bool CDIMJMFDDKL(THandle CBGDBIFJHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x379C930", Offset = "0x379B730", VA = "0x18379C930")]
	private THandle BOPDMLEJFHE(int HLONBDLBPCF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x379CA50", Offset = "0x379B850", VA = "0x18379CA50")]
	private TValue CNJMPMKBCAL(int HLONBDLBPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x379CA10", Offset = "0x379B810", VA = "0x18379CA10")]
	private void CLLCBNKIAKO(int HLONBDLBPCF, in THandle CBGDBIFJHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x379CD00", Offset = "0x379BB00", VA = "0x18379CD00")]
	private void JCODMBJCOJN(int HLONBDLBPCF, in TValue FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x379CFE0", Offset = "0x379BDE0", VA = "0x18379CFE0")]
	private THandle MKJFCOFKJJB()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x379D190", Offset = "0x379BF90", VA = "0x18379D190")]
	private void PGENLFAPFOI(THandle CBGDBIFJHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x379D250", Offset = "0x379C050", VA = "0x18379D250")]
	private int PPLEKKEMDBC(int IEMMODHJFLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x379C920", Offset = "0x379B720", VA = "0x18379C920")]
	private bool APJOGLCGMLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5BD8B0", Offset = "0x5BC6B0", VA = "0x1805BD8B0")]
	private void ALMAILGKKEC(THandle CBGDBIFJHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x379CC50", Offset = "0x379BA50", VA = "0x18379CC50")]
	private bool GONICOJJCAH(out THandle CBGDBIFJHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x379CE60", Offset = "0x379BC60", VA = "0x18379CE60")]
	private bool KNDOPKMKOFE(out THandle CBGDBIFJHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x379CBF0", Offset = "0x379B9F0", VA = "0x18379CBF0")]
	private void FAKOAFCJBEO(THandle CBGDBIFJHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x379CD40", Offset = "0x379BB40", VA = "0x18379CD40")]
	private void KJACMNKGPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface OBPJHNKLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int LFGMGBIAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int GBJCFDLFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HDPJKMLNJIB<T> : OBPJHNKLAEJ, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class PFNJGCAJPML
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2F5A370", Offset = "0x2F59170", VA = "0x182F5A370")]
	public static bool DONMHAMPNGK<T>(this T CBGDBIFJHEA) where T : struct, OBPJHNKLAEJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HDKFIPFDOFG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private enum NDHLDPDELHA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int KFGHEEKLHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool AOJGLHGONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NDHLDPDELHA ENONIIKBBGJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GPHKLGMAKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4B93C90", Offset = "0x4B92A90", VA = "0x184B93C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LGMAOOHKGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4B93F30", Offset = "0x4B92D30", VA = "0x184B93F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4B94630", Offset = "0x4B93430", VA = "0x184B94630")]
	public HDKFIPFDOFG(bool AOJGLHGONNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4B93F40", Offset = "0x4B92D40", VA = "0x184B93F40")]
	public void LBOANKLNKKK(object HOBENCJANIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4B93D70", Offset = "0x4B92B70", VA = "0x184B93D70")]
	public void FPLMNNDCLDM(int FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4B93F20", Offset = "0x4B92D20", VA = "0x184B93F20")]
	public void LAEONLNHICE(uint ALJDJAOOCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4B93E90", Offset = "0x4B92C90", VA = "0x184B93E90")]
	public void JJDKNBLCOPK(bool NADLJOMEEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4B93D30", Offset = "0x4B92B30", VA = "0x184B93D30")]
	public void FLCDEMOCGPH(long OKNNDDIGHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4B94580", Offset = "0x4B93380", VA = "0x184B94580")]
	public void NBGENOHADLL(ulong JKKBDNCCMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4B93EB0", Offset = "0x4B92CB0", VA = "0x184B93EB0")]
	public void KICPFJNEFGH(string LPPBOIFMJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4B93CA0", Offset = "0x4B92AA0", VA = "0x184B93CA0")]
	public void EGPBOJOFPPC(Enum BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B94460", Offset = "0x4B93260", VA = "0x184B94460")]
	public void MJDEEGPAGJE(IList JMOCBEAJCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x35CE440", Offset = "0x35CD240", VA = "0x1835CE440")]
	public void OKDPFABJJKA<T, U>(Dictionary<T, U> DLDJBPKDFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B93850", Offset = "0x4B92650", VA = "0x184B93850")]
	private void AABPIJIPEDD(IDictionary DLDJBPKDFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B945C0", Offset = "0x4B933C0", VA = "0x184B945C0")]
	public int OBINFKANEFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B93C10", Offset = "0x4B92A10", VA = "0x184B93C10")]
	public short ADLLDCBEDEP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B93C80", Offset = "0x4B92A80", VA = "0x184B93C80")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4B93E20", Offset = "0x4B92C20", VA = "0x184B93E20")]
	private void IADPEJKGOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class INHHHDNNNFH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class HHECKBIFHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode PJJIFCLGFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode MGDGFFLAOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GAPEHALPCDA IOFLGNGIBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<GAPEHALPCDA> LBNEDFPOGIN;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public HHECKBIFHDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal struct GAPEHALPCDA : IComparable<GAPEHALPCDA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int BCAPGCABECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant PLOOEMDHFAA;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x574E20", Offset = "0x573C20", VA = "0x180574E20")]
		public GAPEHALPCDA(int BCAPGCABECN, TClaimant PLOOEMDHFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x388FE00", Offset = "0x388EC00", VA = "0x18388FE00")]
		public bool LLFCLNFJGCK(in GAPEHALPCDA MDLBKDPKIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x388FE60", Offset = "0x388EC60", VA = "0x18388FE60")]
		public bool LLGOBLDOHPP(in GAPEHALPCDA MDLBKDPKIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x388FDF0", Offset = "0x388EBF0", VA = "0x18388FDF0", Slot = "4")]
		public int CompareTo(GAPEHALPCDA MDLBKDPKIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x388FE70", Offset = "0x388EC70", VA = "0x18388FE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum DCLMGDKBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JLGNDJLMMCC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::INHHHDNNNFH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3208ED0", Offset = "0x3207CD0", VA = "0x183208ED0")]
		[DebuggerHidden]
		public JLGNDJLMMCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3899990", Offset = "0x3898790", VA = "0x183899990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3899B50", Offset = "0x3898950", VA = "0x183899B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3899A70", Offset = "0x3898870", VA = "0x183899A70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x28EA140", Offset = "0x28E8F40", VA = "0x1828EA140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly global::NCLOEDLBGBI<HHECKBIFHDO> POMEBCEGAPI;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly global::NCLOEDLBGBI<List<GAPEHALPCDA>> LDABEFGEIHC;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int DCIOAEGNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> ENNEFKOEIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, HHECKBIFHDO> HJFDOHEDKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private DCLMGDKBFPM IFEODBIGMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CFEHALKHCMA;

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AINGDPMBHJL(TNode KCNHGDMDEHK);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HFAPDIMJLMK(TNode KCNHGDMDEHK, TClaimant ELLKFODNLKB, TClaimant LELFOEOBFEI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3898AD0", Offset = "0x38978D0", VA = "0x183898AD0")]
	public INHHHDNNNFH(DCLMGDKBFPM IFEODBIGMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x38981B0", Offset = "0x3896FB0", VA = "0x1838981B0")]
	public void LEKBGDJHANJ(TNode KCNHGDMDEHK, TNode OFMLLPMLIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3898870", Offset = "0x3897670", VA = "0x183898870")]
	public void PLPHEGAOEBC(TClaimant PLOOEMDHFAA, TNode BKNACFJABOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x38975A0", Offset = "0x38963A0", VA = "0x1838975A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x38987D0", Offset = "0x38975D0", VA = "0x1838987D0")]
	private void OKDBKPGBLGJ(TClaimant PLOOEMDHFAA, TNode BDJKMFDANFG, TNode BKNACFJABOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3897270", Offset = "0x3896070", VA = "0x183897270")]
	private int APEKKLLOKEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3897BD0", Offset = "0x38969D0", VA = "0x183897BD0")]
	private void HBENHDFCKCK(TClaimant PLOOEMDHFAA, TNode NLKLMPJLAMK, TNode KONLDBGMAEJ, int IBPIKGJDGMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3898740", Offset = "0x3897540", VA = "0x183898740")]
	private void OCNCECJBJGP(GAPEHALPCDA EINLPNEPDNC, HHECKBIFHDO CDNBOBCPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3897E80", Offset = "0x3896C80", VA = "0x183897E80")]
	private void JLJIOALPNMP(TClaimant PLOOEMDHFAA, TNode NLKLMPJLAMK, TNode KONLDBGMAEJ, int IBPIKGJDGMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x38974A0", Offset = "0x38962A0", VA = "0x1838974A0")]
	private void CIJIAFNHPLD(GAPEHALPCDA EINLPNEPDNC, TNode KCNHGDMDEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3897AD0", Offset = "0x38968D0", VA = "0x183897AD0")]
	private void GJDLLMDNNMN(GAPEHALPCDA EINLPNEPDNC, HHECKBIFHDO CDNBOBCPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3897990", Offset = "0x3896790", VA = "0x183897990")]
	private void FAMBLEMBPJL(HHECKBIFHDO CDNBOBCPIPM, bool OCJAJKDPJML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3898230", Offset = "0x3897030", VA = "0x183898230")]
	private void NAPDPLGFGEA(HHECKBIFHDO CDNBOBCPIPM, TNode OFMLLPMLIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3898670", Offset = "0x3897470", VA = "0x183898670")]
	[IteratorStateMachine(typeof(global::INHHHDNNNFH<, >.JLGNDJLMMCC))]
	private IEnumerable<TNode> NEKNDDNDCFJ(TNode NLKLMPJLAMK, TNode KONLDBGMAEJ, bool LKLCDLGFHFA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x38980F0", Offset = "0x3896EF0", VA = "0x1838980F0")]
	private HHECKBIFHDO KMBPGKGLAMO(TNode KCNHGDMDEHK, TNode MGDGFFLAOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3897800", Offset = "0x3896600", VA = "0x183897800")]
	private HHECKBIFHDO ELOEDNHJBDH(TNode KCNHGDMDEHK, TNode MGDGFFLAOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x38972E0", Offset = "0x38960E0", VA = "0x1838972E0")]
	private void CCINAACBLBL(HHECKBIFHDO CDNBOBCPIPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JCIABPKEOIN<T> : IEnumerable<global::JCIABPKEOIN<T>.MBKGKHHBCKC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct MBKGKHHBCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T FCGCDNFBIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int HLONBDLBPCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class DDIBACHBFHP : IEnumerator<MBKGKHHBCKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private global::JCIABPKEOIN<T> HCOGKCOKLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int HLONBDLBPCF;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x2F96B00", Offset = "0x2F95900", VA = "0x182F96B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MBKGKHHBCKC JDBGCCNGAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x2F96B70", Offset = "0x2F95970", VA = "0x182F96B70", Slot = "4")]
			get
			{
				return default(MBKGKHHBCKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB24DB0", Offset = "0xB23BB0", VA = "0x180B24DB0")]
		public DDIBACHBFHP(global::JCIABPKEOIN<T> HCOGKCOKLDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2F96A70", Offset = "0x2F95870", VA = "0x182F96A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xB24DA0", Offset = "0xB23BA0", VA = "0x180B24DA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xC6BC40", Offset = "0xC6AA40", VA = "0x180C6BC40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct OCLDBOAGONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool ODNDDNDDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T FCGCDNFBIMM;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int FCIDBHANIND = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Dictionary<T, int> LPAIPGAENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private OCLDBOAGONI[] CJPPOJNAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int HJGHKFLGPNP;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5600", Offset = "0x2FA4400", VA = "0x182FA5600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2FA50A0", Offset = "0x2FA3EA0", VA = "0x182FA50A0")]
	public static global::JCIABPKEOIN<T> JFONDKKAGEG(MBKGKHHBCKC[] KGHKPHAIKEI, bool BINHFLICOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2FA56E0", Offset = "0x2FA44E0", VA = "0x182FA56E0")]
	public JCIABPKEOIN(int EHCNCIHFDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5630", Offset = "0x2FA4430", VA = "0x182FA5630")]
	public bool POPLPLAFGOP(T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4F40", Offset = "0x2FA3D40", VA = "0x182FA4F40")]
	public bool DEBBCLFCNJB(int HLONBDLBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5480", Offset = "0x2FA4280", VA = "0x182FA5480")]
	public bool LMKEPOFNNOB(Func<T, bool> CPFIOJIPBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4E80", Offset = "0x2FA3C80", VA = "0x182FA4E80")]
	public int CCBIDHOPFLO(T FCGCDNFBIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4ED0", Offset = "0x2FA3CD0", VA = "0x182FA4ED0")]
	public T CNJMPMKBCAL(int HLONBDLBPCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4E30", Offset = "0x2FA3C30", VA = "0x182FA4E30")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A70", Offset = "0x2FA3870", VA = "0x182FA4A70")]
	public bool AMCNFHOKNDD(T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4A90", Offset = "0x2FA3890", VA = "0x182FA4A90")]
	public bool AMCNFHOKNDD(T FCGCDNFBIMM, int HLONBDLBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5530", Offset = "0x2FA4330", VA = "0x182FA5530")]
	public bool MDMFJHECCDC(T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5050", Offset = "0x2FA3E50", VA = "0x182FA5050")]
	public bool JCCJEPICEDC(int HLONBDLBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4FA0", Offset = "0x2FA3DA0", VA = "0x182FA4FA0")]
	private void DFBAMDKGJGC(int HLONBDLBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4CC0", Offset = "0x2FA3AC0", VA = "0x182FA4CC0")]
	public MBKGKHHBCKC[] BIHOIADABAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2FA55B0", Offset = "0x2FA43B0", VA = "0x182FA55B0")]
	private int NDGJPLDLDOE(int ECAGHKFKCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5660", Offset = "0x2FA4460", VA = "0x182FA5660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5660", Offset = "0x2FA4460", VA = "0x182FA5660", Slot = "4")]
	private IEnumerator<MBKGKHHBCKC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NCLOEDLBGBI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly Stack<T> HHFLENNBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<T> IALLGNNHAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int LOPALEGODNG;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int NOEFIDECJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x28E28B0", Offset = "0x28E16B0", VA = "0x1828E28B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int JADHOMOMIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AB00", Offset = "0x2C19900", VA = "0x182C1AB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B2F0", Offset = "0x2C1A0F0", VA = "0x182C1B2F0")]
	public static global::NCLOEDLBGBI<T> NPENOJIDMEB(int EHCNCIHFDGJ = 0, int LOPALEGODNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ADA0", Offset = "0x2C19BA0", VA = "0x182C1ADA0")]
	public static global::NCLOEDLBGBI<T> FMKDJFIMDGH(int EHCNCIHFDGJ = 0, int LOPALEGODNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B3C0", Offset = "0x2C1A1C0", VA = "0x182C1B3C0")]
	public NCLOEDLBGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B400", Offset = "0x2C1A200", VA = "0x182C1B400")]
	public NCLOEDLBGBI(int EHCNCIHFDGJ, int LOPALEGODNG = int.MaxValue, bool BMBHJNBDKCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AF20", Offset = "0x2C19D20", VA = "0x182C1AF20")]
	public T IICHCGDFKHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B230", Offset = "0x2C1A030", VA = "0x182C1B230")]
	public void NJGCPANBBJK(T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AB30", Offset = "0x2C19930", VA = "0x182C1AB30")]
	private void ALKEPIKLLGL(T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B210", Offset = "0x2C1A010", VA = "0x182C1B210")]
	private void KNBDBPKLJFO(T FCGCDNFBIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ABF0", Offset = "0x2C199F0", VA = "0x182C1ABF0")]
	[Conditional("DEBUG_BUILD")]
	private void DLHCLEENPMK(T PINFGNAHBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AE70", Offset = "0x2C19C70", VA = "0x182C1AE70")]
	[Conditional("DEBUG_BUILD")]
	private void GEBAEFEDLGA(T PINFGNAHBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AC90", Offset = "0x2C19A90", VA = "0x182C1AC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B050", Offset = "0x2C19E50", VA = "0x182C1B050")]
	private void ILLJOPNDBPF(IEnumerable<T> MPAKKJPOBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MCDCLNMPLHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Dictionary<int, T> OBHFPGPIEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private T HBBGEOPEHBA;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public virtual T HPOJPDIAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool FOKPDHFBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA290", Offset = "0x3EB9090", VA = "0x183EBA290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA1A0", Offset = "0x3EB8FA0", VA = "0x183EBA1A0")]
	public bool BGHKPAIEIGJ(T FCGCDNFBIMM, int BCAPGCABECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA940", Offset = "0x3EB9740", VA = "0x183EBA940")]
	public bool PFLIOBNHNNG(int BCAPGCABECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA540", Offset = "0x3EB9340", VA = "0x183EBA540")]
	public T NMHOIADCNIO(int IIFPLKCKBGJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA200", Offset = "0x3EB9000", VA = "0x183EBA200")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA8B0", Offset = "0x3EB96B0", VA = "0x183EBA8B0")]
	private bool OJNIMFPEOKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA260", Offset = "0x3EB9060", VA = "0x183EBA260")]
	public bool EIEDLFBIOLG(int BCAPGCABECN, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CB8AA0", Offset = "0x2CB78A0", VA = "0x182CB8AA0")]
	public MCDCLNMPLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KGDGLLADLCF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	protected struct GLLHCPLICPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public T PGEGKAIHDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int HDABJLABHJC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	protected readonly List<GLLHCPLICPI> JMMOMDLIGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private T DGFMFFPBDCM;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8DC0", Offset = "0x2CB7BC0", VA = "0x182CB8DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A25EF0", Offset = "0x3A24CF0", VA = "0x183A25EF0")]
	public bool LMKEPOFNNOB(T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A25B70", Offset = "0x3A24970", VA = "0x183A25B70")]
	public void ACLEHGEDHGC(T FCGCDNFBIMM, int BCAPGCABECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A26140", Offset = "0x3A24F40", VA = "0x183A26140")]
	public bool MDMFJHECCDC(T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A25C10", Offset = "0x3A24A10", VA = "0x183A25C10")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A26260", Offset = "0x3A25060", VA = "0x183A26260")]
	public T NKMMBOBHNEP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A25C70", Offset = "0x3A24A70", VA = "0x183A25C70")]
	public T DEHCKNGDEDJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A25CE0", Offset = "0x3A24AE0", VA = "0x183A25CE0")]
	private void KBMMPDDLOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A262F0", Offset = "0x3A250F0", VA = "0x183A262F0")]
	public KGDGLLADLCF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[GOENDBONKAK(NEMAIODNDOF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x4B96370", Offset = "0x4B95170", VA = "0x184B96370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4B96840", Offset = "0x4B95640", VA = "0x184B96840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x4B96660", Offset = "0x4B95460", VA = "0x184B96660")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x4B969E0", Offset = "0x4B957E0", VA = "0x184B969E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4B96230", Offset = "0x4B95030", VA = "0x184B96230")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x4B96700", Offset = "0x4B95500", VA = "0x184B96700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4B96520", Offset = "0x4B95320", VA = "0x184B96520")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4B96190", Offset = "0x4B94F90", VA = "0x184B96190")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface DKPGDEEDJII
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public abstract class ResourcePrefabReference<T> : DKPGDEEDJII where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x28E9D20", Offset = "0x28E8B20", VA = "0x1828E9D20", Slot = "4")]
		public virtual T JOKGMKNDLLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class LCNHOEKCGEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Dictionary<byte, GOHDCHBEHBC> CJNJMLMOMEL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GOHDCHBEHBC ENJDFGGPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector2 OOBHGJBOINB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xF869D0", Offset = "0xF857D0", VA = "0x180F869D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x18871F0", Offset = "0x1885FF0", VA = "0x1818871F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Vector2 DDBKKKNLNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1895A10", Offset = "0x1894810", VA = "0x181895A10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2303CF0", Offset = "0x2302AF0", VA = "0x182303CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector2 KOENCMABCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x13F28D0", Offset = "0x13F16D0", VA = "0x1813F28D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x13F28F0", Offset = "0x13F16F0", VA = "0x1813F28F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int FDNNIKCMNGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5977B0", Offset = "0x5965B0", VA = "0x1805977B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8B0", Offset = "0x5BC6B0", VA = "0x1805BD8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B95200", Offset = "0x4B94000", VA = "0x184B95200")]
	public LCNHOEKCGEH(Bounds AMBNLBPHGOE, Vector2[] OLGJODMDLLC, int MANCGAHEAHC, byte ECAGHKFKCAE, float JNKOHJKFKMP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B94A40", Offset = "0x4B93840", VA = "0x184B94A40")]
	public GOHDCHBEHBC APLEJPIGKNF(byte HLONBDLBPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B95110", Offset = "0x4B93F10", VA = "0x184B95110")]
	public void LCLEAEFLAFC(Vector3 JOOGNDBIIGC, float EGECIJLHNEO, float KMHDJEKJICP, ref List<byte> DKIMLBNNOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B94FC0", Offset = "0x4B93DC0", VA = "0x184B94FC0")]
	public void ELCKFMPJEAO(GOHDCHBEHBC.JBOOMGFACNG IFDDCCOPDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B94FE0", Offset = "0x4B93DE0", VA = "0x184B94FE0")]
	private GOHDCHBEHBC FNEBALCNKFD(byte HLONBDLBPCF, GOHDCHBEHBC.FPBPBCPOJEF LELJKLGCPJN, GOHDCHBEHBC MGDGFFLAOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B94AA0", Offset = "0x4B938A0", VA = "0x184B94AA0")]
	private void EDFNCFKDJOD(GOHDCHBEHBC MGDGFFLAOJF, Vector2[] OLGJODMDLLC, int MNEENPCCGCG, int DCGEKGKANOC, int MFEIBLNBMCG, int NGDPLPOMBKE, float JNKOHJKFKMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GOHDCHBEHBC
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum FPBPBCPOJEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum JBOOMGFACNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte JEELLAJLPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 PGAPGFAHOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 CLMEKPFJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector3 AOOHJILOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3 PNNMBNPKODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public FPBPBCPOJEF KODFGJHFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public GOHDCHBEHBC GHLEIDFDHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public List<GOHDCHBEHBC> ACOBMJPMNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool MCPBGACAGOH;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B93730", Offset = "0x4B92530", VA = "0x184B93730")]
	public GOHDCHBEHBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B93750", Offset = "0x4B92550", VA = "0x184B93750")]
	public GOHDCHBEHBC(byte AACOJDLCGDD, FPBPBCPOJEF LELJKLGCPJN, GOHDCHBEHBC MGDGFFLAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B93400", Offset = "0x4B92200", VA = "0x184B93400")]
	public void HCFBMOELJMH(GOHDCHBEHBC MHLKEPFALKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30")]
	public void ELCKFMPJEAO(int EILCDJECKDF, JBOOMGFACNG IFDDCCOPDBM, int BIANBILDKFD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B934A0", Offset = "0x4B922A0", VA = "0x184B934A0")]
	public void LCLEAEFLAFC(List<byte> DKIMLBNNOPF, Vector3 JOOGNDBIIGC, float EGECIJLHNEO, float KMHDJEKJICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B933A0", Offset = "0x4B921A0", VA = "0x184B933A0")]
	public bool FKGAPBNHPCI(Vector3 EILIPCLOLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B93360", Offset = "0x4B92160", VA = "0x184B93360")]
	public bool CABEGBNIOBD(Vector3 EILIPCLOLPL, float PACFNEAHLNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class JOCAKOINJFL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Dictionary<T, object> MHEKHLDGLJM;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x31B1050", Offset = "0x31AFE50", VA = "0x1831B1050")]
	public bool MDKLDOGPFIM(T GEFDAJMEGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3F70180", Offset = "0x3F6EF80", VA = "0x183F70180")]
	public bool MDKLDOGPFIM(T GEFDAJMEGOD, object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3F701C0", Offset = "0x3F6EFC0", VA = "0x183F701C0")]
	public bool MDKLDOGPFIM(T GEFDAJMEGOD, object DNBCDMIAJIF, out object JCHAEBPJMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F70140", Offset = "0x3F6EF40", VA = "0x183F70140")]
	public bool JHLPJDAIGOE(T GEFDAJMEGOD, object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F70250", Offset = "0x3F6F050", VA = "0x183F70250")]
	public bool PEBELILECID(T GEFDAJMEGOD, object DNBCDMIAJIF, out object JCHAEBPJMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F700B0", Offset = "0x3F6EEB0", VA = "0x183F700B0")]
	public bool JHLPJDAIGOE(T GEFDAJMEGOD, object DNBCDMIAJIF, out object JCHAEBPJMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F70220", Offset = "0x3F6F020", VA = "0x183F70220")]
	public void OCIEMOACODC(T GEFDAJMEGOD, object DNBCDMIAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F70010", Offset = "0x3F6EE10", VA = "0x183F70010")]
	public void CBHILGHPEFI(T GEFDAJMEGOD, object DNBCDMIAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3F70290", Offset = "0x3F6F090", VA = "0x183F70290")]
	public JOCAKOINJFL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public struct DIJNGNDGPPP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly List<Component> JMOCBEAJCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly bool IFFBMGJOOOM;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xB82C90", Offset = "0xB81A90", VA = "0x180B82C90")]
			public DIJNGNDGPPP(List<Component> JMOCBEAJCOO, bool IFFBMGJOOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x28DCE10", Offset = "0x28DBC10", VA = "0x1828DCE10")]
			public MNEMCFCEEML<T> DDCMJDEOIHJ()
			{
				return default(MNEMCFCEEML<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x28DCE80", Offset = "0x28DBC80", VA = "0x1828DCE80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x28DCE80", Offset = "0x28DBC80", VA = "0x1828DCE80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public struct MNEMCFCEEML<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private readonly List<Component> JMOCBEAJCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private readonly bool IFFBMGJOOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int HLONBDLBPCF;

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public T JDBGCCNGAME
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x28E2BE0", Offset = "0x28E19E0", VA = "0x1828E2BE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x28E2B70", Offset = "0x28E1970", VA = "0x1828E2B70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x28E2BB0", Offset = "0x28E19B0", VA = "0x1828E2BB0")]
			public MNEMCFCEEML(List<Component> JMOCBEAJCOO, bool IFFBMGJOOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x28E2AA0", Offset = "0x28E18A0", VA = "0x1828E2AA0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x28E2AB0", Offset = "0x28E18B0", VA = "0x1828E2AB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x28E2B60", Offset = "0x28E1960", VA = "0x1828E2B60", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B986A0", Offset = "0x4B974A0", VA = "0x184B986A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B98660", Offset = "0x4B97460", VA = "0x184B98660")]
		public ToolHierarchyCache(GameObject BEGAPEHJKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B984E0", Offset = "0x4B972E0", VA = "0x184B984E0")]
		private void OGICEOHIGPL(GameObject BEGAPEHJKGJ, bool DKKCAKBAFCA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B98450", Offset = "0x4B97250", VA = "0x184B98450")]
		public static void OGICEOHIGPL(GameObject BEGAPEHJKGJ, ref ToolHierarchyCache IKIBNKJFGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B98380", Offset = "0x4B97180", VA = "0x184B98380")]
		public void NNNKLBFFDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B98330", Offset = "0x4B97130", VA = "0x184B98330")]
		public void KKMDDOKHFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D06E30", Offset = "0x2D05C30", VA = "0x182D06E30")]
		public void NHJCIOLKBIH<T>(Action<T> CHNALKMKMGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B98270", Offset = "0x4B97070", VA = "0x184B98270")]
		public Component JLIKLMOELFJ(Type FHJGHNDLPMM, bool IFFBMGJOOOM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A436E0", Offset = "0x2A424E0", VA = "0x182A436E0")]
		public T JLIKLMOELFJ<T>(bool IFFBMGJOOOM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B980F0", Offset = "0x4B96EF0", VA = "0x184B980F0")]
		public DIJNGNDGPPP<Component> EPBOGLNBMGP(Type FHJGHNDLPMM, bool IFFBMGJOOOM = false)
		{
			return default(DIJNGNDGPPP<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B437C0", Offset = "0x2B425C0", VA = "0x182B437C0")]
		public DIJNGNDGPPP<T> EPBOGLNBMGP<T>(bool IFFBMGJOOOM = false) where T : class
		{
			return default(DIJNGNDGPPP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4B97E40", Offset = "0x4B96C40", VA = "0x184B97E40")]
		public List<Component> ANANHKLEFEN(Type FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4B98180", Offset = "0x4B96F80", VA = "0x184B98180", Slot = "4")]
		public bool Equals(ToolHierarchyCache EIPKBLJANKN, ToolHierarchyCache POPNGEAPMKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x4B98200", Offset = "0x4B97000", VA = "0x184B98200", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HOBENCJANIA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EHCNAPBCIFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int EHCNCIHFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private int IIAIJMDBBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<T> GEABGALFBEC;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x28E28B0", Offset = "0x28E16B0", VA = "0x1828E28B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public T AEGJDDFPAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x38F36B0", Offset = "0x38F24B0", VA = "0x1838F36B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public T BFJJHOBGELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x38F35A0", Offset = "0x38F23A0", VA = "0x1838F35A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public T ALBILHBEOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x38F3660", Offset = "0x38F2460", VA = "0x1838F3660")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x38F3820", Offset = "0x38F2620", VA = "0x1838F3820")]
	public EHCNAPBCIFN(int EHCNCIHFDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x38F3380", Offset = "0x38F2180", VA = "0x1838F3380")]
	public void ACLEHGEDHGC(T ODNJPKPBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x38F3450", Offset = "0x38F2250", VA = "0x1838F3450")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x38F3490", Offset = "0x38F2290", VA = "0x1838F3490")]
	public void DOKIPBKNOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x38F37D0", Offset = "0x38F25D0", VA = "0x1838F37D0")]
	public void KOBBOEKCOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x38F35E0", Offset = "0x38F23E0", VA = "0x1838F35E0")]
	public void HFJAOMGOEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EADIMIIJCDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool PPDJDNMDDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Action CHNALKMKMGL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static EADIMIIJCDG PGHHMIHAIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4B92EA0", Offset = "0x4B91CA0", VA = "0x184B92EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool AJNHNOEMLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x55DC30", Offset = "0x55CA30", VA = "0x18055DC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x74F4E0", Offset = "0x74E2E0", VA = "0x18074F4E0")]
	public EADIMIIJCDG(Action CHNALKMKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4B92F20", Offset = "0x4B91D20", VA = "0x184B92F20")]
	public void ELGHEPGNNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4B92F20", Offset = "0x4B91D20", VA = "0x184B92F20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class JOHHELOACFB
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30")]
	public static void OMHOCMACNHL(NPFMBDLCDJK DPKFKFGPIPD, string KFECBMKGBBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class LOFIJJNPHAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private struct KLBKNEGCHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int HDABJLABHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public T PGEGKAIHDFD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<object, KLBKNEGCHDN> OBHFPGPIEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T HBBGEOPEHBA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public virtual T HPOJPDIAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xF869D0", Offset = "0xF857D0", VA = "0x180F869D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x18871F0", Offset = "0x1885FF0", VA = "0x1818871F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FOKPDHFBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3CB0", Offset = "0x2CB2AB0", VA = "0x182CB3CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public object AOIPBDCMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2CB3260", Offset = "0x2CB2060", VA = "0x182CB3260")]
	public bool BGHKPAIEIGJ(T FCGCDNFBIMM, object DNBCDMIAJIF, int BCAPGCABECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2CB8970", Offset = "0x2CB7770", VA = "0x182CB8970")]
	public bool PFLIOBNHNNG(object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2CB3B00", Offset = "0x2CB2900", VA = "0x182CB3B00")]
	public bool EIEDLFBIOLG(object DNBCDMIAJIF, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB35F0", Offset = "0x2CB23F0", VA = "0x182CB35F0")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7EE0", Offset = "0x2CB6CE0", VA = "0x182CB7EE0")]
	private bool OJNIMFPEOKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2CB8AA0", Offset = "0x2CB78A0", VA = "0x182CB8AA0")]
	public LOFIJJNPHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class DPLMIEOMFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Dictionary<object, float> OBHFPGPIEHB;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public float MMIGHDLBAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAD0", Offset = "0x8FE8D0", VA = "0x1808FFAD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFD0", Offset = "0x8FEDD0", VA = "0x1808FFFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4B92C20", Offset = "0x4B91A20", VA = "0x184B92C20")]
	public void BGHKPAIEIGJ(float FCGCDNFBIMM, object DNBCDMIAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4B92DB0", Offset = "0x4B91BB0", VA = "0x184B92DB0")]
	public void PFLIOBNHNNG(object DNBCDMIAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4B92C90", Offset = "0x4B91A90", VA = "0x184B92C90")]
	private void HPKLBJHGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4B92E20", Offset = "0x4B91C20", VA = "0x184B92E20")]
	public DPLMIEOMFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class NPFMBDLCDJK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class DKCIODEJGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly string EKBCCCNOIPP;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		private DKCIODEJGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7166E0", Offset = "0x7154E0", VA = "0x1807166E0")]
		public DKCIODEJGJJ(string EKBCCCNOIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4B92BD0", Offset = "0x4B919D0", VA = "0x184B92BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JNMPMMNCAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public JNMPMMNCAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4B94990", Offset = "0x4B93790", VA = "0x184B94990")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly HashSet<object> PJHEEJNGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int HKIBDKBEFKG;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool BNGEKPMINNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4B95E60", Offset = "0x4B94C60", VA = "0x184B95E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x527470", Offset = "0x526270", VA = "0x180527470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4B95DE0", Offset = "0x4B94BE0", VA = "0x184B95DE0")]
	public bool ACLEHGEDHGC(object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4B95F30", Offset = "0x4B94D30", VA = "0x184B95F30")]
	public bool MDMFJHECCDC(object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4B95ED0", Offset = "0x4B94CD0", VA = "0x184B95ED0")]
	public bool LMKEPOFNNOB(object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4B95E70", Offset = "0x4B94C70", VA = "0x184B95E70")]
	public void JNEPIKBGMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4B95FB0", Offset = "0x4B94DB0", VA = "0x184B95FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4B96120", Offset = "0x4B94F20", VA = "0x184B96120")]
	public NPFMBDLCDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class EDGFFEEJOMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct NKJGDJJLNNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float PCACPGHJCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public T PGEGKAIHDFD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<object, NKJGDJJLNNF> OBHFPGPIEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private T GNAGCKEDPLN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public virtual T FEAMAPODMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2725550", Offset = "0x2724350", VA = "0x182725550", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2CB89F0", Offset = "0x2CB77F0", VA = "0x182CB89F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public object LMMPGPPMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool FOKPDHFBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x38EC020", Offset = "0x38EAE20", VA = "0x1838EC020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x38EB980", Offset = "0x38EA780", VA = "0x1838EB980")]
	public bool BGHKPAIEIGJ(T FCGCDNFBIMM, object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x38ED8C0", Offset = "0x38EC6C0", VA = "0x1838ED8C0")]
	public bool PFLIOBNHNNG(object DNBCDMIAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2CB35F0", Offset = "0x2CB23F0", VA = "0x182CB35F0")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x38EBDA0", Offset = "0x38EABA0", VA = "0x1838EBDA0")]
	public bool EIEDLFBIOLG(object DNBCDMIAJIF, out T FCGCDNFBIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x38EC3D0", Offset = "0x38EB1D0", VA = "0x1838EC3D0")]
	private bool OJNIMFPEOKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x38ED920", Offset = "0x38EC720", VA = "0x1838ED920")]
	public EDGFFEEJOMH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4B92910", Offset = "0x4B91710", VA = "0x184B92910")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4B925E0", Offset = "0x4B913E0", VA = "0x184B925E0")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
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
