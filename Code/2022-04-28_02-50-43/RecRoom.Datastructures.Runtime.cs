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
public class HPMELBINPEI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B7AC0", Offset = "0x6B6CC0", VA = "0x1806B7AC0")]
	public HPMELBINPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2EC0", Offset = "0x4BA20C0", VA = "0x184BA2EC0")]
	public byte[] GJHJGIECMJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void HMKHCHIGPIN(IncrementalHash GHFGJNPFPIA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xCFC920", Offset = "0xCFBB20", VA = "0x180CFC920")]
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
	[KIFPFMFBJCJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[KIFPFMFBJCJ]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BA65A0", Offset = "0x4BA57A0", VA = "0x184BA65A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6560", Offset = "0x4BA5760", VA = "0x184BA6560")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BA65E0", Offset = "0x4BA57E0", VA = "0x184BA65E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BA67F0", Offset = "0x4BA59F0", VA = "0x184BA67F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6760", Offset = "0x4BA5960", VA = "0x184BA6760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE33FB0", Offset = "0xE331B0", VA = "0x180E33FB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE340D0", Offset = "0xE332D0", VA = "0x180E340D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6520", Offset = "0x4BA5720", VA = "0x184BA6520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA66D0", Offset = "0x4BA58D0", VA = "0x184BA66D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5F50", Offset = "0x4BA5150", VA = "0x184BA5F50")]
	public void CopyBounds(SavedExtents CDPFMCDBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6490", Offset = "0x4BA5690", VA = "0x184BA6490")]
	public void SetLocalSpaceBounds(Bounds ODNICBHFOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x861130", Offset = "0x860330", VA = "0x180861130")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6480", Offset = "0x4BA5680", VA = "0x184BA6480")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6040", Offset = "0x4BA5240", VA = "0x184BA6040")]
	private void LMPJCAEMFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6250", Offset = "0x4BA5450", VA = "0x184BA6250")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5990", Offset = "0x4BA4B90", VA = "0x184BA5990")]
	public static void CalculateLocalBoundsFor(GameObject KONKHHPIEFL, out Bounds ODNICBHFOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5F80", Offset = "0x4BA5180", VA = "0x184BA5F80")]
	private static void FCBALPMDJFA(Bounds DCOPGELFIOF, Color DFLGAKHACHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BA64B0", Offset = "0x4BA56B0", VA = "0x184BA64B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x527EE0", Offset = "0x5270E0", VA = "0x180527EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "4")]
	public virtual void KNCANEEBEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
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
	[HPMELBINPEI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EA5D80", Offset = "0x3EA4F80", VA = "0x183EA5D80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EA58C0", Offset = "0x3EA4AC0", VA = "0x183EA58C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6380", Offset = "0x3EA5580", VA = "0x183EA6380")]
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
	private sealed class KMKOMBCEBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public KMKOMBCEBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37F2DE0", Offset = "0x37F1FE0", VA = "0x1837F2DE0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[HPMELBINPEI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37EF070", Offset = "0x37EE270", VA = "0x1837EF070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37EF0A0", Offset = "0x37EE2A0", VA = "0x1837EF0A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37EEFC0", Offset = "0x37EE1C0", VA = "0x1837EEFC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey FOOEPPOEAPA]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37EEFF0", Offset = "0x37EE1F0", VA = "0x1837EEFF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37EEEC0", Offset = "0x37EE0C0", VA = "0x1837EEEC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37EE720", Offset = "0x37ED920", VA = "0x1837EE720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37EE090", Offset = "0x37ED290", VA = "0x1837EE090", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC90", Offset = "0x37ECE90", VA = "0x1837EDC90", Slot = "14")]
	protected virtual string OPPIEIJFEIE(TKeyVal PMLNEAFMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26D9480", Offset = "0x26D8680", VA = "0x1826D9480", Slot = "4")]
	public bool ContainsKey(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37EEDB0", Offset = "0x37EDFB0", VA = "0x1837EEDB0", Slot = "5")]
	public bool TryGetValue(TKey FOOEPPOEAPA, out TVal EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC00", Offset = "0x37ECE00", VA = "0x1837EDC00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC00", Offset = "0x37ECE00", VA = "0x1837EDC00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37EEDE0", Offset = "0x37EDFE0", VA = "0x1837EEDE0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LPPJHJJMLKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PPPEINKOMGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public PPPEINKOMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x26EF660", Offset = "0x26EE860", VA = "0x1826EF660")]
		internal bool <GetSamples>b__0(global::HLBKJAEFFHD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float IEFAFJBNDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float DBIIAFBHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::HLBKJAEFFHD<float, T>> PHLABNMGPJO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LCPLCCABPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x26E0400", Offset = "0x26DF600", VA = "0x1826E0400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26E0480", Offset = "0x26DF680", VA = "0x1826E0480")]
	public LPPJHJJMLKB(float CFPENCDLFDJ, float OAJFDOPELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26DF9E0", Offset = "0x26DEBE0", VA = "0x1826DF9E0")]
	public bool GLFFNILNMFG(float CBPDIPCJOPA, T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26DFCA0", Offset = "0x26DEEA0", VA = "0x1826DFCA0")]
	public int JIAOKLIAJNF(float CBPDIPCJOPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26E0040", Offset = "0x26DF240", VA = "0x1826E0040")]
	public IEnumerable<T> NCALPNLKOBP(float CBPDIPCJOPA, [Optional] float? OBPBCAIICKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26DF9B0", Offset = "0x26DEBB0", VA = "0x1826DF9B0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26DF8F0", Offset = "0x26DEAF0", VA = "0x1826DF8F0")]
	private void DFKIHGNMMDD(float CBPDIPCJOPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EIFKMHOHPII<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AJAFOPAOIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T LLFECFNJIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float MBMHDBABEMI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float OHLJNPOKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> OONGOLOHOPI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int FKCICPKPLAA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private AJAFOPAOIND[] ANMIADPHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int EBBOPIIKNJL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float EJEIADBFJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1145200", Offset = "0x1144400", VA = "0x181145200")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1145220", Offset = "0x1144420", VA = "0x181145220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1FA0", Offset = "0x1EE11A0", VA = "0x181EE1FA0")]
	public EIFKMHOHPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1FD0", Offset = "0x1EE11D0", VA = "0x181EE1FD0")]
	public EIFKMHOHPII(int AADFONHDDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1EE18A0", Offset = "0x1EE0AA0", VA = "0x181EE18A0")]
	public void JPGLGPDLMNH(float CBPDIPCJOPA, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1070", Offset = "0x1EE0270", VA = "0x181EE1070")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1BA0", Offset = "0x1EE0DA0", VA = "0x181EE1BA0")]
	public bool LBDPABDGLFC(float PNCBCIDHBGF, float GPIHCPOPDDN, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0AA0", Offset = "0x1EDFCA0", VA = "0x181EE0AA0")]
	public bool DBFGODOHFFH(float PNCBCIDHBGF, float GPIHCPOPDDN, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1EE15B0", Offset = "0x1EE07B0", VA = "0x181EE15B0")]
	public void JHMLHOBAGHP(float PNCBCIDHBGF, float GPIHCPOPDDN, List<T> ODGBLHHLGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0A70", Offset = "0x1EDFC70", VA = "0x181EE0A70")]
	private int AKENPHAMMEG(int HGCOLONCGPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1F10", Offset = "0x1EE1110", VA = "0x181EE1F10")]
	private void LGHPNJJLMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JMEIOCOMAOB();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BCNHMIEPNLO(T NIFHNIMLIIM, T LPCOLAIDHBK, float PAHPKCDHOGE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JJBEGHPMBIH(T EOEMKDLOAGI, float PAHPKCDHOGE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HBINPFBMJGA(T NIFHNIMLIIM, T LPCOLAIDHBK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KIEPJGJLFLP(T NIFHNIMLIIM, T LPCOLAIDHBK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MJDPHKLINJK : global::EIFKMHOHPII<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4BA36C0", Offset = "0x4BA28C0", VA = "0x184BA36C0", Slot = "4")]
	protected override Vector3 JMEIOCOMAOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4BA34B0", Offset = "0x4BA26B0", VA = "0x184BA34B0", Slot = "5")]
	protected override Vector3 BCNHMIEPNLO(Vector3 NIFHNIMLIIM, Vector3 LPCOLAIDHBK, float PAHPKCDHOGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3620", Offset = "0x4BA2820", VA = "0x184BA3620", Slot = "6")]
	protected override Vector3 JJBEGHPMBIH(Vector3 EOEMKDLOAGI, float PAHPKCDHOGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3570", Offset = "0x4BA2770", VA = "0x184BA3570", Slot = "7")]
	protected override Vector3 HBINPFBMJGA(Vector3 NIFHNIMLIIM, Vector3 LPCOLAIDHBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3730", Offset = "0x4BA2930", VA = "0x184BA3730", Slot = "8")]
	protected override Vector3 KIEPJGJLFLP(Vector3 NIFHNIMLIIM, Vector3 LPCOLAIDHBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4BA37A0", Offset = "0x4BA29A0", VA = "0x184BA37A0")]
	public MJDPHKLINJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HHACCLFDDHL : global::EIFKMHOHPII<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2E60", Offset = "0x4BA2060", VA = "0x184BA2E60")]
	public HHACCLFDDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2DF0", Offset = "0x4BA1FF0", VA = "0x184BA2DF0")]
	public HHACCLFDDHL(int AADFONHDDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xD8D780", Offset = "0xD8C980", VA = "0x180D8D780", Slot = "4")]
	protected override float JMEIOCOMAOB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2D60", Offset = "0x4BA1F60", VA = "0x184BA2D60", Slot = "5")]
	protected override float BCNHMIEPNLO(float NIFHNIMLIIM, float LPCOLAIDHBK, float PAHPKCDHOGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D00900", Offset = "0x3CFFB00", VA = "0x183D00900", Slot = "6")]
	protected override float JJBEGHPMBIH(float EOEMKDLOAGI, float PAHPKCDHOGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28162A0", Offset = "0x28154A0", VA = "0x1828162A0", Slot = "7")]
	protected override float HBINPFBMJGA(float NIFHNIMLIIM, float LPCOLAIDHBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2DE0", Offset = "0x4BA1FE0", VA = "0x184BA2DE0", Slot = "8")]
	protected override float KIEPJGJLFLP(float NIFHNIMLIIM, float LPCOLAIDHBK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MCKEBBJPKJI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC53A0", Offset = "0x1EC45A0", VA = "0x181EC53A0")]
	public static global::GDOFDDGGDAF<T1> JOBPNILIBDA<T1>(T1 NKANJBGGBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x20615A0", Offset = "0x20607A0", VA = "0x1820615A0")]
	public static global::HLBKJAEFFHD<T1, T2> JOBPNILIBDA<T1, T2>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8C10", Offset = "0x1EC7E10", VA = "0x181EC8C10")]
	public static global::BCDGAHNEPII<T1, T2, T3> JOBPNILIBDA<T1, T2, T3>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1F80", Offset = "0x1EC1180", VA = "0x181EC1F80")]
	public static global::FONEEOAMDAA<T1, T2, T3, T4> JOBPNILIBDA<T1, T2, T3, T4>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8E30", Offset = "0x1EC8030", VA = "0x181EC8E30")]
	public static global::DCBCJHBIGJA<T1, T2, T3, T4, T5> JOBPNILIBDA<T1, T2, T3, T4, T5>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2061610", Offset = "0x2060810", VA = "0x182061610")]
	public static global::PNDNOGNPAFG<T1, T2, T3, T4, T5, T6> JOBPNILIBDA<T1, T2, T3, T4, T5, T6>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8D70", Offset = "0x1EC7F70", VA = "0x181EC8D70")]
	public static global::FGBKKHDMFKF<T1, T2, T3, T4, T5, T6, T7> JOBPNILIBDA<T1, T2, T3, T4, T5, T6, T7>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO, T7 PIOMNFOEOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8CA0", Offset = "0x1EC7EA0", VA = "0x181EC8CA0")]
	public static global::GEJLCFNNOGD<T1, T2, T3, T4, T5, T6, T7, T8> JOBPNILIBDA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO, T7 PIOMNFOEOAB, T8 BPPCKKKOECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x189CEC0", Offset = "0x189C0C0", VA = "0x18189CEC0")]
	[IteratorStateMachine(typeof(CGLPDDHLJNN))]
	public static IEnumerable<global::HLBKJAEFFHD<T1, T2>> PBOLJDGOIBD<T1, T2>(IEnumerable<T1> LIEOABMIJDJ, IEnumerable<T2> DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B85C10", Offset = "0x1B84E10", VA = "0x181B85C10")]
	[IteratorStateMachine(typeof(NJFBOFPJFFO))]
	public static IEnumerable<global::BCDGAHNEPII<T1, T2, T3>> PBOLJDGOIBD<T1, T2, T3>(IEnumerable<T1> LIEOABMIJDJ, IEnumerable<T2> DCOPGELFIOF, IEnumerable<T3> DFLGAKHACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2435050", Offset = "0x2434250", VA = "0x182435050")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4340570", Offset = "0x433F770", VA = "0x184340570")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4340580", Offset = "0x433F780", VA = "0x184340580")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC, int IFMBGILICLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA31A0", Offset = "0x4BA23A0", VA = "0x184BA31A0")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC, int IFMBGILICLP, int MJHFAPEFMIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3180", Offset = "0x4BA2380", VA = "0x184BA3180")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC, int IFMBGILICLP, int MJHFAPEFMIO, int FAJLIBGAPFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA31C0", Offset = "0x4BA23C0", VA = "0x184BA31C0")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC, int IFMBGILICLP, int MJHFAPEFMIO, int FAJLIBGAPFA, int FLGGAOHOFMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA31F0", Offset = "0x4BA23F0", VA = "0x184BA31F0")]
	internal static int MEJACFPMFJC(int IBCHMGNIMGN, int MNCGLKICJGM, int LIEAGBAEKFC, int IFMBGILICLP, int MJHFAPEFMIO, int FAJLIBGAPFA, int FLGGAOHOFMG, int IPDOJLJMEFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GDOFDDGGDAF<T1> : IComparable<global::GDOFDDGGDAF<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2243CC0", Offset = "0x2242EC0", VA = "0x182243CC0")]
	public GDOFDDGGDAF(T1 NKANJBGGBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2244AB0", Offset = "0x2243CB0", VA = "0x182244AB0", Slot = "4")]
	public int CompareTo(global::GDOFDDGGDAF<T1> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2244B20", Offset = "0x2243D20", VA = "0x182244B20", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x853BF0", Offset = "0x852DF0", VA = "0x180853BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2244BC0", Offset = "0x2243DC0", VA = "0x182244BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HLBKJAEFFHD<T1, T2> : IComparable<global::HLBKJAEFFHD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2394E50", Offset = "0x2394050", VA = "0x182394E50")]
	public HLBKJAEFFHD(T1 NKANJBGGBGH, T2 BMOIPGOHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x23933F0", Offset = "0x23925F0", VA = "0x1823933F0", Slot = "4")]
	public int CompareTo(global::HLBKJAEFFHD<T1, T2> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2393E30", Offset = "0x2393030", VA = "0x182393E30", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x23943A0", Offset = "0x23935A0", VA = "0x1823943A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x23945E0", Offset = "0x23937E0", VA = "0x1823945E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BCDGAHNEPII<T1, T2, T3> : IComparable<global::BCDGAHNEPII<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB060", Offset = "0x2DBA260", VA = "0x182DBB060")]
	public BCDGAHNEPII(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA980", Offset = "0x2DB9B80", VA = "0x182DBA980", Slot = "4")]
	public int CompareTo(global::BCDGAHNEPII<T1, T2, T3> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBAB70", Offset = "0x2DB9D70", VA = "0x182DBAB70", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBACE0", Offset = "0x2DB9EE0", VA = "0x182DBACE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBADE0", Offset = "0x2DB9FE0", VA = "0x182DBADE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FONEEOAMDAA<T1, T2, T3, T4> : IComparable<global::FONEEOAMDAA<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 KOGAAFBJLOL;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3B35E90", Offset = "0x3B35090", VA = "0x183B35E90")]
	public FONEEOAMDAA(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3B35A60", Offset = "0x3B34C60", VA = "0x183B35A60", Slot = "4")]
	public int CompareTo(global::FONEEOAMDAA<T1, T2, T3, T4> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B35BA0", Offset = "0x3B34DA0", VA = "0x183B35BA0", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B35CC0", Offset = "0x3B34EC0", VA = "0x183B35CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B35D80", Offset = "0x3B34F80", VA = "0x183B35D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DCBCJHBIGJA<T1, T2, T3, T4, T5> : IComparable<global::DCBCJHBIGJA<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 KOGAAFBJLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 NIFEENEFFLK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EEB0", Offset = "0x2D3E0B0", VA = "0x182D3EEB0")]
	public DCBCJHBIGJA(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E9C0", Offset = "0x2D3DBC0", VA = "0x182D3E9C0", Slot = "4")]
	public int CompareTo(global::DCBCJHBIGJA<T1, T2, T3, T4, T5> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EB40", Offset = "0x2D3DD40", VA = "0x182D3EB40", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EC80", Offset = "0x2D3DE80", VA = "0x182D3EC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D3ED80", Offset = "0x2D3DF80", VA = "0x182D3ED80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PNDNOGNPAFG<T1, T2, T3, T4, T5, T6> : IComparable<global::PNDNOGNPAFG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 KOGAAFBJLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 NIFEENEFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 DAJNKPIAIBB;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A32C50", Offset = "0x3A31E50", VA = "0x183A32C50")]
	public PNDNOGNPAFG(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D09080", Offset = "0x3D08280", VA = "0x183D09080", Slot = "4")]
	public int CompareTo(global::PNDNOGNPAFG<T1, T2, T3, T4, T5, T6> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D09240", Offset = "0x3D08440", VA = "0x183D09240", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D093B0", Offset = "0x3D085B0", VA = "0x183D093B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D094D0", Offset = "0x3D086D0", VA = "0x183D094D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FGBKKHDMFKF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::FGBKKHDMFKF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 KOGAAFBJLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 NIFEENEFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 DAJNKPIAIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 EBOHOLCBPCO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x388DED0", Offset = "0x388D0D0", VA = "0x18388DED0")]
	public FGBKKHDMFKF(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO, T7 PIOMNFOEOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x388D870", Offset = "0x388CA70", VA = "0x18388D870", Slot = "4")]
	public int CompareTo(global::FGBKKHDMFKF<T1, T2, T3, T4, T5, T6, T7> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x388DA70", Offset = "0x388CC70", VA = "0x18388DA70", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x388DC10", Offset = "0x388CE10", VA = "0x18388DC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x388DD60", Offset = "0x388CF60", VA = "0x18388DD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GEJLCFNNOGD<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::GEJLCFNNOGD<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 EHDLGIKMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 EBBPGDKMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 HJKJEKKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 KOGAAFBJLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 NIFEENEFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 DAJNKPIAIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 EBOHOLCBPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 CJMLICCKPGC;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2248D30", Offset = "0x2247F30", VA = "0x182248D30")]
	public GEJLCFNNOGD(T1 NKANJBGGBGH, T2 BMOIPGOHEMF, T3 KLPOKFMLLDF, T4 DLCKFFPBFMP, T5 IAGGCKOGHIK, T6 NAGMNKGOAHO, T7 PIOMNFOEOAB, T8 BPPCKKKOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2248620", Offset = "0x2247820", VA = "0x182248620", Slot = "4")]
	public int CompareTo(global::GEJLCFNNOGD<T1, T2, T3, T4, T5, T6, T7, T8> CDPFMCDBFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2248870", Offset = "0x2247A70", VA = "0x182248870", Slot = "0")]
	public override bool Equals(object CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2248A30", Offset = "0x2247C30", VA = "0x182248A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2248BA0", Offset = "0x2247DA0", VA = "0x182248BA0", Slot = "3")]
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
	public T LLFECFNJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float HPJFPHOHEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD883A0", Offset = "0xD875A0", VA = "0x180D883A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3FACBA0", Offset = "0x3FABDA0", VA = "0x183FACBA0")]
	public T LBLNIDPJIEK(float PAHPKCDHOGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FACAA0", Offset = "0x3FABCA0", VA = "0x183FACAA0")]
	public T LABJPKIAAHB(float PAHPKCDHOGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BCNHMIEPNLO(T NIFHNIMLIIM, T LPCOLAIDHBK, float PAHPKCDHOGE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4BA24A0", Offset = "0x4BA16A0", VA = "0x184BA24A0", Slot = "4")]
	protected override float BCNHMIEPNLO(float NIFHNIMLIIM, float LPCOLAIDHBK, float PAHPKCDHOGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2520", Offset = "0x4BA1720", VA = "0x184BA2520")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7750", Offset = "0x4BA6950", VA = "0x184BA7750", Slot = "4")]
	protected override Vector3 BCNHMIEPNLO(Vector3 NIFHNIMLIIM, Vector3 LPCOLAIDHBK, float PAHPKCDHOGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7810", Offset = "0x4BA6A10", VA = "0x184BA7810")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4BA22F0", Offset = "0x4BA14F0", VA = "0x184BA22F0", Slot = "4")]
	protected override Color BCNHMIEPNLO(Color NIFHNIMLIIM, Color LPCOLAIDHBK, float PAHPKCDHOGE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2340", Offset = "0x4BA1540", VA = "0x184BA2340")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class DLLMFLIGLKC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] ENFJPEOMKPH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5B3670", Offset = "0x5B2870", VA = "0x1805B3670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CF0", Offset = "0x6A4EF0", VA = "0x1806A5CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB34F0", Offset = "0x3CB26F0", VA = "0x183CB34F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3090", Offset = "0x3CB2290", VA = "0x183CB3090")]
	public static global::DLLMFLIGLKC<T> IOMBLIPDFPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2F50", Offset = "0x3CB2150", VA = "0x183CB2F50")]
	public static global::DLLMFLIGLKC<T> HLIGMAFCFDE(int FMBBHGJJFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3530", Offset = "0x3CB2730", VA = "0x183CB3530")]
	private DLLMFLIGLKC(T[] BHDECNGPFBN, int FMBBHGJJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2850", Offset = "0x3CB1A50", VA = "0x183CB2850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB31C0", Offset = "0x3CB23C0", VA = "0x183CB31C0")]
	public void JPGLGPDLMNH(in T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB27B0", Offset = "0x3CB19B0", VA = "0x183CB27B0")]
	public void DDEOPDNACPM(int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2A40", Offset = "0x3CB1C40", VA = "0x183CB2A40")]
	public void FPHPJLPLMOJ(in T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2630", Offset = "0x3CB1830", VA = "0x183CB2630")]
	public void CHLCBBBPGHC(int AADFONHDDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2DD0", Offset = "0x3CB1FD0", VA = "0x183CB2DD0")]
	private void HABMFGBOHHL(int FMBBHGJJFDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EOCEGNPPJEK
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC60A0", Offset = "0x1EC52A0", VA = "0x181EC60A0")]
	public static global::DLLMFLIGLKC<T> IOMBLIPDFPE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A294F0", Offset = "0x1A286F0", VA = "0x181A294F0")]
	public static global::DLLMFLIGLKC<T> HLIGMAFCFDE<T>(int FMBBHGJJFDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class JLOGILELKII<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> LGDOPHNNADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> NGKOJIINNGA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2185B70", Offset = "0x2184D70", VA = "0x182185B70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool OFNCODNFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x527EC0", Offset = "0x5270C0", VA = "0x180527EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> AJLNLKIBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x27A1960", Offset = "0x27A0B60", VA = "0x1827A1960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> BBEENAFACKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2247CC0", Offset = "0x2246EC0", VA = "0x182247CC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x26E07C0", Offset = "0x26DF9C0", VA = "0x1826E07C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DC0", Offset = "0x37A5FC0", VA = "0x1837A6DC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x37A6B60", Offset = "0x37A5D60", VA = "0x1837A6B60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x37A6BD0", Offset = "0x37A5DD0", VA = "0x1837A6BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37A65F0", Offset = "0x37A57F0", VA = "0x1837A65F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x37A6C90", Offset = "0x37A5E90", VA = "0x1837A6C90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37A6120", Offset = "0x37A5320", VA = "0x1837A6120", Slot = "9")]
	public void Add(TKey FOOEPPOEAPA, TVal EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37A6180", Offset = "0x37A5380", VA = "0x1837A6180", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D55900", Offset = "0x2D54B00", VA = "0x182D55900", Slot = "8")]
	public bool ContainsKey(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37A6650", Offset = "0x37A5850", VA = "0x1837A6650", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3562CE0", Offset = "0x3561EE0", VA = "0x183562CE0", Slot = "10")]
	public bool Remove(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3562CE0", Offset = "0x3561EE0", VA = "0x183562CE0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E69790", Offset = "0x2E68990", VA = "0x182E69790", Slot = "11")]
	public bool TryGetValue(TKey FOOEPPOEAPA, out TVal EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37A6740", Offset = "0x37A5940", VA = "0x1837A6740", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37A66B0", Offset = "0x37A58B0", VA = "0x1837A66B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ANMIADPHPAJ, int NPDDOBLNACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x37A68A0", Offset = "0x37A5AA0", VA = "0x1837A68A0")]
	public void JPGLGPDLMNH(TVal OBGLKCDOPCN, TKey FOOEPPOEAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x37A6820", Offset = "0x37A5A20", VA = "0x1837A6820")]
	public void JPGLGPDLMNH(KeyValuePair<TVal, TKey> IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x37A67C0", Offset = "0x37A59C0", VA = "0x1837A67C0")]
	public bool HDNMHHKPHPF(TVal FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x37A6910", Offset = "0x37A5B10", VA = "0x1837A6910")]
	public bool KEANBBKKHCP(KeyValuePair<TVal, TKey> IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27A3E80", Offset = "0x27A3080", VA = "0x1827A3E80")]
	public bool FPHPJLPLMOJ(TVal FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27A3E80", Offset = "0x27A3080", VA = "0x1827A3E80")]
	public bool FPHPJLPLMOJ(KeyValuePair<TVal, TKey> IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37A62C0", Offset = "0x37A54C0", VA = "0x1837A62C0")]
	public bool CMEBCMBDPDA(TVal FOOEPPOEAPA, out TKey EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x37A61B0", Offset = "0x37A53B0", VA = "0x1837A61B0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CEKHHNLENBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x37A6A50", Offset = "0x37A5C50", VA = "0x1837A6A50")]
	private void OENALPGHOKF(TKey FOOEPPOEAPA, TVal OBGLKCDOPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x37A69D0", Offset = "0x37A5BD0", VA = "0x1837A69D0")]
	private void KGHPCIGLIGL(TKey FOOEPPOEAPA, TVal OBGLKCDOPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x37A63B0", Offset = "0x37A55B0", VA = "0x1837A63B0")]
	private bool CODEOOKALDP(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37A6530", Offset = "0x37A5730", VA = "0x1837A6530")]
	private bool CODEOOKALDP(TVal OBGLKCDOPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x37A6CE0", Offset = "0x37A5EE0", VA = "0x1837A6CE0")]
	public JLOGILELKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class PFHHCCLIHMN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::PFHHCCLIHMN<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x1145200", Offset = "0x1144400", VA = "0x181145200", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x355C950", Offset = "0x355BB50", VA = "0x18355C950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x355CD00", Offset = "0x355BF00", VA = "0x18355CD00")]
		public Enumerator(global::PFHHCCLIHMN<T> ODGBLHHLGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x355C1D0", Offset = "0x355B3D0", VA = "0x18355C1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x355C6B0", Offset = "0x355B8B0", VA = "0x18355C6B0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x355C150", Offset = "0x355B350", VA = "0x18355C150")]
		private void DKHCKEMEEGJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] DILHLNHNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int GAHGFCKGLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int JJIMCKAPBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int APCMBBDMJOE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3564710", Offset = "0x3563910", VA = "0x183564710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3565A10", Offset = "0x3564C10", VA = "0x183565A10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3565AB0", Offset = "0x3564CB0", VA = "0x183565AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x35663D0", Offset = "0x35655D0", VA = "0x1835663D0")]
	public PFHHCCLIHMN(int FMBBHGJJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x35657E0", Offset = "0x35649E0", VA = "0x1835657E0")]
	public void JPGLGPDLMNH(T PAHPKCDHOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x35651F0", Offset = "0x35643F0", VA = "0x1835651F0")]
	public void HHAAHCGEHCK(IEnumerable<T> JIOGPKDFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x35648B0", Offset = "0x3563AB0", VA = "0x1835648B0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x35654F0", Offset = "0x35646F0", VA = "0x1835654F0")]
	public void IICPEPBCBDE(int LMEIKANBNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x35658A0", Offset = "0x3564AA0", VA = "0x1835658A0")]
	public void MJGNGEOFCEN(int LMEIKANBNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3565DF0", Offset = "0x3564FF0", VA = "0x183565DF0")]
	public void POBAOPMHPIG(T[] ANMIADPHPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3564750", Offset = "0x3563950", VA = "0x183564750")]
	public Enumerator FEDOHNDFHEG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3566330", Offset = "0x3565530", VA = "0x183566330", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3566330", Offset = "0x3565530", VA = "0x183566330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3564530", Offset = "0x3563730", VA = "0x183564530")]
	private int BMHOIFFNKJB(int NCBDKCDKIIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3565580", Offset = "0x3564780", VA = "0x183565580")]
	private int JBDNLIMGGHO(int NCBDKCDKIIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class MIPBLJJMCKO<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Func<Internal, External> NHHGJKDDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Func<External, Internal> IBMLGAMJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private IList<Internal> DJGBKPCDNEE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> HNJDDMLCHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OFNCODNFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A8990", Offset = "0x5A7B90", VA = "0x1805A8990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EB0", Offset = "0x6E80B0", VA = "0x1806E8EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x26E65B0", Offset = "0x26E57B0", VA = "0x1826E65B0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x26E6650", Offset = "0x26E5850", VA = "0x1826E6650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x26E6550", Offset = "0x26E5750", VA = "0x1826E6550", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x26E64C0", Offset = "0x26E56C0", VA = "0x1826E64C0")]
	public MIPBLJJMCKO(Func<Internal, External> NHHGJKDDLNH, Func<External, Internal> IBMLGAMJIBJ, bool MLDKPFILJLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26E6290", Offset = "0x26E5490", VA = "0x1826E6290", Slot = "6")]
	public int IndexOf(External IBEBPLDEKLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26E5F10", Offset = "0x26E5110", VA = "0x1826E5F10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x26E5F70", Offset = "0x26E5170", VA = "0x1826E5F70", Slot = "13")]
	public bool Contains(External IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x26E6000", Offset = "0x26E5200", VA = "0x1826E6000", Slot = "14")]
	public void CopyTo(External[] ANMIADPHPAJ, int NPDDOBLNACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x26E5E80", Offset = "0x26E5080", VA = "0x1826E5E80", Slot = "11")]
	public void Add(External IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x26E6320", Offset = "0x26E5520", VA = "0x1826E6320", Slot = "7")]
	public void Insert(int NCBDKCDKIIG, External IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x26E6430", Offset = "0x26E5630", VA = "0x1826E6430", Slot = "15")]
	public bool Remove(External IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x26E63C0", Offset = "0x26E55C0", VA = "0x1826E63C0", Slot = "8")]
	public void RemoveAt(int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x26E6220", Offset = "0x26E5420", VA = "0x1826E6220", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1BBF0A0", Offset = "0x1BBE2A0", VA = "0x181BBF0A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class GMAPCMCJONM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Func<Internal, External> NHHGJKDDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private IReadOnlyList<Internal> DJGBKPCDNEE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> HNJDDMLCHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OFNCODNFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x527FE0", Offset = "0x5271E0", VA = "0x180527FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x22503A0", Offset = "0x224F5A0", VA = "0x1822503A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2250340", Offset = "0x224F540", VA = "0x182250340", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2243CC0", Offset = "0x2242EC0", VA = "0x182243CC0")]
	public GMAPCMCJONM(Func<Internal, External> NHHGJKDDLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x22502F0", Offset = "0x224F4F0", VA = "0x1822502F0")]
	public GMAPCMCJONM(IReadOnlyList<Internal> DJGBKPCDNEE, Func<Internal, External> NHHGJKDDLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x22500D0", Offset = "0x224F2D0", VA = "0x1822500D0")]
	public void POBAOPMHPIG(External[] ANMIADPHPAJ, int NPDDOBLNACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2250060", Offset = "0x224F260", VA = "0x182250060", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5EA0", Offset = "0x1BC50A0", VA = "0x181BC5EA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class PEDDFOJCOOA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IReadOnlyList<Internal> DJGBKPCDNEE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> HNJDDMLCHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OFNCODNFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x527FE0", Offset = "0x5271E0", VA = "0x180527FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x35633E0", Offset = "0x35625E0", VA = "0x1835633E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3563380", Offset = "0x3562580", VA = "0x183563380", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2243CC0", Offset = "0x2242EC0", VA = "0x182243CC0")]
	public PEDDFOJCOOA(IReadOnlyList<Internal> DJGBKPCDNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x35630B0", Offset = "0x35622B0", VA = "0x1835630B0")]
	public bool KEANBBKKHCP(External IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3563150", Offset = "0x3562350", VA = "0x183563150")]
	public void POBAOPMHPIG(External[] ANMIADPHPAJ, int NPDDOBLNACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3563040", Offset = "0x3562240", VA = "0x183563040", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1BBF0A0", Offset = "0x1BBE2A0", VA = "0x181BBF0A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class MAFPHCPDGMI
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DEDAPAKONAE(object[] FHGHEKFFGEB);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	protected MAFPHCPDGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class FOPPHKCFAJE<T> : MAFPHCPDGMI
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	protected struct ICGDABMAHPG
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum PBGEIHPOPAK
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
		public PBGEIHPOPAK OMCCJKNHBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T EPOOCOJOAOK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int NAICKNAPEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool FOJKFJLGPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	protected readonly bool ADALONBHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected List<T> PBHDMNOLFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<ICGDABMAHPG> CODNKKJDFPD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LINLGBIHNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B36410", Offset = "0x3B35610", VA = "0x183B36410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B366A0", Offset = "0x3B358A0", VA = "0x183B366A0")]
	protected FOPPHKCFAJE(bool ADALONBHCDM, bool FOJKFJLGPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3B36450", Offset = "0x3B35650", VA = "0x183B36450")]
	protected bool MOJCEJDPHFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3B361B0", Offset = "0x3B353B0", VA = "0x183B361B0")]
	protected void IJNJDKHLMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3B364F0", Offset = "0x3B356F0", VA = "0x183B364F0")]
	protected void OACHOIJDKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x25939A0", Offset = "0x2592BA0", VA = "0x1825939A0")]
	private static void HJEKLBGLMME<U>(ref List<U> DJGBKPCDNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3B36290", Offset = "0x3B35490", VA = "0x183B36290", Slot = "5")]
	public void JPGLGPDLMNH(T EPOOCOJOAOK, bool LCNFABDDAGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3B36050", Offset = "0x3B35250", VA = "0x183B36050", Slot = "6")]
	public void FPHPJLPLMOJ(T EPOOCOJOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3B35F20", Offset = "0x3B35120", VA = "0x183B35F20")]
	public void FGLHFGIEJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MNGPIOKIPBC
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OMGLOKENPJB : global::FOPPHKCFAJE<Action>, MNGPIOKIPBC
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3B00", Offset = "0x4BA2D00", VA = "0x184BA3B00")]
	public OMGLOKENPJB(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3880", Offset = "0x4BA2A80", VA = "0x184BA3880")]
	public void KBLLKEGFOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3800", Offset = "0x4BA2A00", VA = "0x184BA3800", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3AA0", Offset = "0x4BA2CA0", VA = "0x184BA3AA0")]
	public static OMGLOKENPJB OLJHOBLBIKO(OMGLOKENPJB PMCIFPDCBMC, Action EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3A40", Offset = "0x4BA2C40", VA = "0x184BA3A40")]
	public static OMGLOKENPJB MJIBNMDJPKD(OMGLOKENPJB PMCIFPDCBMC, Action EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FMLMOLOAEAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GAGIHGKDEBB<T> : global::FOPPHKCFAJE<Action<T>>, global::FMLMOLOAEAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public GAGIHGKDEBB(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3B3B2B0", Offset = "0x3B3A4B0", VA = "0x183B3B2B0")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3B36830", Offset = "0x3B35A30", VA = "0x183B36830", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3B3BA50", Offset = "0x3B3AC50", VA = "0x183B3BA50")]
	public static global::GAGIHGKDEBB<T> OLJHOBLBIKO(global::GAGIHGKDEBB<T> PMCIFPDCBMC, Action<T> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3B3B9B0", Offset = "0x3B3ABB0", VA = "0x183B3B9B0")]
	public static global::GAGIHGKDEBB<T> MJIBNMDJPKD(global::GAGIHGKDEBB<T> PMCIFPDCBMC, Action<T> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HNLBLHDCDME<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T, U> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T, U> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HNBCAFNGJPA<T, U> : global::FOPPHKCFAJE<Action<T, U>>, global::HNLBLHDCDME<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public HNBCAFNGJPA(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x239D060", Offset = "0x239C260", VA = "0x18239D060")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE, U HNIHGLGAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x23982F0", Offset = "0x23974F0", VA = "0x1823982F0", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x239E6A0", Offset = "0x239D8A0", VA = "0x18239E6A0")]
	public static global::HNBCAFNGJPA<T, U> OLJHOBLBIKO(global::HNBCAFNGJPA<T, U> PMCIFPDCBMC, Action<T, U> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x239E600", Offset = "0x239D800", VA = "0x18239E600")]
	public static global::HNBCAFNGJPA<T, U> MJIBNMDJPKD(global::HNBCAFNGJPA<T, U> PMCIFPDCBMC, Action<T, U> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OCKOBKFDAPB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T, U, V> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T, U, V> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class JNAPFLMLNBJ<T, U, V> : global::FOPPHKCFAJE<Action<T, U, V>>, global::OCKOBKFDAPB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public JNAPFLMLNBJ(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37A9950", Offset = "0x37A8B50", VA = "0x1837A9950")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE, U HNIHGLGAJBI, V FMBAOAOLBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37A75F0", Offset = "0x37A67F0", VA = "0x1837A75F0", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x37AAC70", Offset = "0x37A9E70", VA = "0x1837AAC70")]
	public static global::JNAPFLMLNBJ<T, U, V> OLJHOBLBIKO(global::JNAPFLMLNBJ<T, U, V> PMCIFPDCBMC, Action<T, U, V> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x37AABD0", Offset = "0x37A9DD0", VA = "0x1837AABD0")]
	public static global::JNAPFLMLNBJ<T, U, V> MJIBNMDJPKD(global::JNAPFLMLNBJ<T, U, V> PMCIFPDCBMC, Action<T, U, V> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NPOAEPLMOKH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T, U, V, W> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T, U, V, W> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class GHHAOBGLCFF<T, U, V, W> : global::FOPPHKCFAJE<Action<T, U, V, W>>, global::NPOAEPLMOKH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public GHHAOBGLCFF(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x224F0D0", Offset = "0x224E2D0", VA = "0x18224F0D0")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE, U HNIHGLGAJBI, V FMBAOAOLBAA, W AGHNKENFEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x224CF60", Offset = "0x224C160", VA = "0x18224CF60", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x224FEA0", Offset = "0x224F0A0", VA = "0x18224FEA0")]
	public static global::GHHAOBGLCFF<T, U, V, W> OLJHOBLBIKO(global::GHHAOBGLCFF<T, U, V, W> PMCIFPDCBMC, Action<T, U, V, W> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x224FE00", Offset = "0x224F000", VA = "0x18224FE00")]
	public static global::GHHAOBGLCFF<T, U, V, W> MJIBNMDJPKD(global::GHHAOBGLCFF<T, U, V, W> PMCIFPDCBMC, Action<T, U, V, W> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AHKCFDCAIOD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T, U, V, W, X> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T, U, V, W, X> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PPCEMEMJADF<T, U, V, W, X> : global::FOPPHKCFAJE<Action<T, U, V, W, X>>, global::AHKCFDCAIOD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public PPCEMEMJADF(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4169030", Offset = "0x4168230", VA = "0x184169030")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE, U HNIHGLGAJBI, V FMBAOAOLBAA, W AGHNKENFEOL, X GGMEAHKJCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4168D40", Offset = "0x4167F40", VA = "0x184168D40", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4169680", Offset = "0x4168880", VA = "0x184169680")]
	public static global::PPCEMEMJADF<T, U, V, W, X> OLJHOBLBIKO(global::PPCEMEMJADF<T, U, V, W, X> PMCIFPDCBMC, Action<T, U, V, W, X> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x41695E0", Offset = "0x41687E0", VA = "0x1841695E0")]
	public static global::PPCEMEMJADF<T, U, V, W, X> MJIBNMDJPKD(global::PPCEMEMJADF<T, U, V, W, X> PMCIFPDCBMC, Action<T, U, V, W, X> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BHJDPDLCEMB<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPGLGPDLMNH(Action<T, U, V, W, X, Y> EPOOCOJOAOK, bool LCNFABDDAGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPHPJLPLMOJ(Action<T, U, V, W, X, Y> EPOOCOJOAOK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HFAPIINMBAM<T, U, V, W, X, Y> : global::FOPPHKCFAJE<Action<T, U, V, W, X, Y>>, global::BHJDPDLCEMB<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x224FF40", Offset = "0x224F140", VA = "0x18224FF40")]
	public HFAPIINMBAM(bool ADALONBHCDM = false, bool FOJKFJLGPEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF080", Offset = "0x3CDE280", VA = "0x183CDF080")]
	public void KBLLKEGFOPE(T PAHPKCDHOGE, U HNIHGLGAJBI, V FMBAOAOLBAA, W AGHNKENFEOL, X GGMEAHKJCJC, Y DHBFNIJNBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3CDED40", Offset = "0x3CDDF40", VA = "0x183CDED40", Slot = "4")]
	public override void DEDAPAKONAE(object[] FHGHEKFFGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x238D6C0", Offset = "0x238C8C0", VA = "0x18238D6C0")]
	public static global::HFAPIINMBAM<T, U, V, W, X, Y> OLJHOBLBIKO(global::HFAPIINMBAM<T, U, V, W, X, Y> PMCIFPDCBMC, Action<T, U, V, W, X, Y> EPOOCOJOAOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x238D620", Offset = "0x238C820", VA = "0x18238D620")]
	public static global::HFAPIINMBAM<T, U, V, W, X, Y> MJIBNMDJPKD(global::HFAPIINMBAM<T, U, V, W, X, Y> PMCIFPDCBMC, Action<T, U, V, W, X, Y> EPOOCOJOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class GBGEPHNEOAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct MCAHNMGHJIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly global::GBGEPHNEOAJ<T> AADGECJHENG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T LLFECFNJIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3B458A0", Offset = "0x3B44AA0", VA = "0x183B458A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3B45870", Offset = "0x3B44A70", VA = "0x183B45870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x694850", Offset = "0x693A50", VA = "0x180694850")]
		public MCAHNMGHJIE(global::GBGEPHNEOAJ<T> AADGECJHENG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GDCFOGKCCIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<MCAHNMGHJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public global::GBGEPHNEOAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3B44FB0", Offset = "0x3B441B0", VA = "0x183B44FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x356A3F0", Offset = "0x35695F0", VA = "0x18356A3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IAOLOHPFDHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<MCAHNMGHJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::GBGEPHNEOAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3B45560", Offset = "0x3B44760", VA = "0x183B45560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x356A3F0", Offset = "0x35695F0", VA = "0x18356A3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly SemaphoreSlim EPIKLIDIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private T LGDOEKECEMH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FDNDLCHBNDL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x22447D0", Offset = "0x22439D0", VA = "0x1822447D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2244870", Offset = "0x2243A70", VA = "0x182244870")]
	public GBGEPHNEOAJ(in T LGDOEKECEMH, int IHEGGFFDOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CAF0", Offset = "0x1D5BCF0", VA = "0x181D5CAF0")]
	public GBGEPHNEOAJ(in T LGDOEKECEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22447F0", Offset = "0x22439F0", VA = "0x1822447F0")]
	public MCAHNMGHJIE NKMMKIHOLKH()
	{
		return default(MCAHNMGHJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2244830", Offset = "0x2243A30", VA = "0x182244830")]
	public MCAHNMGHJIE NKMMKIHOLKH(CancellationToken OOBFLHIIBLI)
	{
		return default(MCAHNMGHJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x22444F0", Offset = "0x22436F0", VA = "0x1822444F0")]
	[AsyncStateMachine(typeof(global::GBGEPHNEOAJ<>.GDCFOGKCCIC))]
	public Task<MCAHNMGHJIE> GNCEKEPPCMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2244370", Offset = "0x2243570", VA = "0x182244370")]
	[AsyncStateMachine(typeof(global::GBGEPHNEOAJ<>.IAOLOHPFDHB))]
	public Task<MCAHNMGHJIE> GNCEKEPPCMK(CancellationToken OOBFLHIIBLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DGFJNNLIKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4BA23F0", Offset = "0x4BA15F0", VA = "0x184BA23F0")]
	public static global::GBGEPHNEOAJ<IFGLEKMDLPA> IOMBLIPDFPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2380", Offset = "0x4BA1580", VA = "0x184BA2380")]
	public static global::GBGEPHNEOAJ<IFGLEKMDLPA> IOMBLIPDFPE(int IHEGGFFDOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC53A0", Offset = "0x1EC45A0", VA = "0x181EC53A0")]
	public static global::GBGEPHNEOAJ<T> IOMBLIPDFPE<T>(in T LGDOEKECEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1E80", Offset = "0x1EC1080", VA = "0x181EC1E80")]
	public static global::GBGEPHNEOAJ<T> IOMBLIPDFPE<T>(in T LGDOEKECEMH, int IHEGGFFDOLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KJJEPLKGHPP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate bool PKCEEANMJDA(global::KJJEPLKGHPP<T> BABNEKFABNN);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NIEGMIPHDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::KJJEPLKGHPP<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public NIEGMIPHDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2E1F240", Offset = "0x2E1E440", VA = "0x182E1F240")]
		internal bool <FindNode>b__0(global::KJJEPLKGHPP<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public T IGPHNBHICDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LinkedList<global::KJJEPLKGHPP<T>> BKCOOCMJCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public global::KJJEPLKGHPP<T> JKAELNJBAJG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::KJJEPLKGHPP<T> JHGHEEFPJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x57A130", Offset = "0x579330", VA = "0x18057A130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2E17710", Offset = "0x2E16910", VA = "0x182E17710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FGDPBPGKMML
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2E18B20", Offset = "0x2E17D20", VA = "0x182E18B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BGKFNHCMJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2E18DA0", Offset = "0x2E17FA0", VA = "0x182E18DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::KJJEPLKGHPP<T> AJOEJMPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2E16A10", Offset = "0x2E15C10", VA = "0x182E16A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E18DE0", Offset = "0x2E17FE0", VA = "0x182E18DE0")]
	public KJJEPLKGHPP(T FOBCFFOPNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2E18C40", Offset = "0x2E17E40", VA = "0x182E18C40")]
	public global::KJJEPLKGHPP<T> NLCFJJIGNMF(T KHGIAIGCHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2E18950", Offset = "0x2E17B50", VA = "0x182E18950")]
	public global::KJJEPLKGHPP<T> HBNGACAKOOK(T HDLPECHHBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2E175D0", Offset = "0x2E167D0", VA = "0x182E175D0")]
	public global::KJJEPLKGHPP<T> FPHPJLPLMOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2E17110", Offset = "0x2E16310", VA = "0x182E17110")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2E16830", Offset = "0x2E15A30", VA = "0x182E16830")]
	public global::KJJEPLKGHPP<T> COECLCNDNJK(T IBMHNPJPJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2E16DD0", Offset = "0x2E15FD0", VA = "0x182E16DD0")]
	public static void DHJAAOBGCFH(global::KJJEPLKGHPP<T> CGDCJFMEMBH, PKCEEANMJDA LEMGEKLIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x353C040", Offset = "0x353B240", VA = "0x18353C040")]
	public static void DHJAAOBGCFH<A>(global::KJJEPLKGHPP<T> CGDCJFMEMBH, Func<global::KJJEPLKGHPP<T>, A, bool> LEMGEKLIGBC, A GJBMEGLHMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2E18250", Offset = "0x2E17450", VA = "0x182E18250")]
	public static string GIMACDJOFKM(global::KJJEPLKGHPP<T> CGDCJFMEMBH, int LGBNPMIFAPG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2E17AE0", Offset = "0x2E16CE0", VA = "0x182E17AE0")]
	public static global::KJJEPLKGHPP<T> GHCOMKBDGHE(global::KJJEPLKGHPP<T> CGDCJFMEMBH, T LJGHPOGEDNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CMDKEABLBID<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> DJKEBBPDKMJ(TRequest HIMFANHOMLL, CancellationToken OOBFLHIIBLI);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum AEMCFIFKGKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ICHMGPOBIPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private const float BOCFDGMJCNH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TimeSpan HEOPPFHMNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int EDCGNLNCGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AEMCFIFKGKL KMCBMDMNCMN;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly ICHMGPOBIPL NGDBMKAAJLD;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BNGOMFGIDLO
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x37C9640", Offset = "0x37C8840", VA = "0x1837C9640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan COJDJMIOJAE
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x37C96B0", Offset = "0x37C88B0", VA = "0x1837C96B0")]
		public ICHMGPOBIPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct PINBKGJDAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly TRequest HIMFANHOMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly CancellationToken OOBFLHIIBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly TaskCompletionSource<TResult> APNFLHNJBHJ;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x37CE960", Offset = "0x37CDB60", VA = "0x1837CE960")]
		public PINBKGJDAFK(TRequest HIMFANHOMLL, TaskCompletionSource<TResult> APNFLHNJBHJ, CancellationToken OOBFLHIIBLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FFPLPKBIKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public FFPLPKBIKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2185B70", Offset = "0x2184D70", VA = "0x182185B70")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CIHBACCLDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::CMDKEABLBID<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x37BD9A0", Offset = "0x37BCBA0", VA = "0x1837BD9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6E9190", Offset = "0x6E8390", VA = "0x1806E9190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class DMDHAPALLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PINBKGJDAFK req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::CMDKEABLBID<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public DMDHAPALLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x37C65F0", Offset = "0x37C57F0", VA = "0x1837C65F0")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource EBPMBCMIABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<PINBKGJDAFK> JPIHOCCOIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ICHMGPOBIPL OLELMMKCGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DJKEBBPDKMJ EGIPGIAFDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Task LDJLHIEDBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int LAFDCHHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x37C5340", Offset = "0x37C4540", VA = "0x1837C5340")]
	public CMDKEABLBID(DJKEBBPDKMJ EGIPGIAFDKM, [Optional] ICHMGPOBIPL OLELMMKCGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x37C4AF0", Offset = "0x37C3CF0", VA = "0x1837C4AF0")]
	public Task<TResult> LGIPNAIIOPO(TRequest HIMFANHOMLL, CancellationToken OOBFLHIIBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x37C52B0", Offset = "0x37C44B0", VA = "0x1837C52B0")]
	private void PMFCCKAACGN(PINBKGJDAFK KNNJENJLBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x37C51A0", Offset = "0x37C43A0", VA = "0x1837C51A0")]
	[AsyncStateMachine(typeof(global::CMDKEABLBID<, >.CIHBACCLDOB))]
	private Task OMEAOCOOOIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x37C4D50", Offset = "0x37C3F50", VA = "0x1837C4D50")]
	private PINBKGJDAFK MAFOOLDMBGI()
	{
		return default(PINBKGJDAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x37C4FB0", Offset = "0x37C41B0", VA = "0x1837C4FB0")]
	private void NBLACGJHLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3041B80", Offset = "0x3040D80", VA = "0x183041B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class LLCOKDPIIAL<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int OGLDDACHFPC(TKey FOOEPPOEAPA, TVal EOEMKDLOAGI);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EGCMEMPIHGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TKey MHHPHCDMEDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TVal LLFECFNJIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x655BA0", Offset = "0x654DA0", VA = "0x180655BA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6E8AD0", Offset = "0x6E7CD0", VA = "0x1806E8AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int GEADDIGJHCF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x6A5CB0", Offset = "0x6A4EB0", VA = "0x1806A5CB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x6A5CE0", Offset = "0x6A4EE0", VA = "0x1806A5CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DateTime ALNCFOHAAOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x109A400", Offset = "0x1099600", VA = "0x18109A400")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x27946A0", Offset = "0x27938A0", VA = "0x1827946A0")]
		public EGCMEMPIHGG(TKey FOOEPPOEAPA, TVal OBGLKCDOPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int BEKDHPMMCFN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, LinkedListNode<EGCMEMPIHGG>> BIAONONIALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly LinkedList<EGCMEMPIHGG> OBBCOJILHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly OGLDDACHFPC EANECFMJOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly TimeSpan CBPFMNKDFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AJACNEBPPAF CBGCHBCEEAM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MIKEPAGPOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0B0", Offset = "0x6AE2B0", VA = "0x1806AF0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool EPLAIPLAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x27A3940", Offset = "0x27A2B40", VA = "0x1827A3940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal int HMJJBOACBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0C0", Offset = "0x6AE2C0", VA = "0x1806AF0C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD0", Offset = "0x6A2FD0", VA = "0x1806A3DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CBA0", Offset = "0x1D5BDA0", VA = "0x181D5CBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IEnumerable<TKey> AJLNLKIBAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x27A3720", Offset = "0x27A2920", VA = "0x1827A3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TVal HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x27A3E80", Offset = "0x27A3080", VA = "0x1827A3E80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x27A3EB0", Offset = "0x27A30B0", VA = "0x1827A3EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x27A4350", Offset = "0x27A3550", VA = "0x1827A4350")]
	public LLCOKDPIIAL(int FMBBHGJJFDP, [Optional] OGLDDACHFPC EANECFMJOCH, [Optional] IEqualityComparer<TKey> GPDFIPFPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x27A40B0", Offset = "0x27A32B0", VA = "0x1827A40B0")]
	public LLCOKDPIIAL(TimeSpan CBPFMNKDFLK, [Optional] IEqualityComparer<TKey> GPDFIPFPHLN, [Optional] AJACNEBPPAF CBGCHBCEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x27A4060", Offset = "0x27A3260", VA = "0x1827A4060")]
	public LLCOKDPIIAL(int FMBBHGJJFDP, TimeSpan CBPFMNKDFLK, [Optional] IEqualityComparer<TKey> GPDFIPFPHLN, [Optional] AJACNEBPPAF CBGCHBCEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x27A44F0", Offset = "0x27A36F0", VA = "0x1827A44F0")]
	public LLCOKDPIIAL(int FMBBHGJJFDP, OGLDDACHFPC EANECFMJOCH, TimeSpan CBPFMNKDFLK, [Optional] IEqualityComparer<TKey> GPDFIPFPHLN, [Optional] AJACNEBPPAF CBGCHBCEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x27A39D0", Offset = "0x27A2BD0", VA = "0x1827A39D0")]
	public void JGOKFIFCGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x27A3FA0", Offset = "0x27A31A0", VA = "0x1827A3FA0")]
	public void PECNJBNEMJB(TKey FOOEPPOEAPA, TVal EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x27A3410", Offset = "0x27A2610", VA = "0x1827A3410")]
	public bool FPHPJLPLMOJ(TKey FOOEPPOEAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x27A32D0", Offset = "0x27A24D0", VA = "0x1827A32D0")]
	private TVal FDILAOMJFDA(TKey NDJHIKPPENK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x27A2B80", Offset = "0x27A1D80", VA = "0x1827A2B80")]
	public bool CMEBCMBDPDA(TKey NDJHIKPPENK, out TVal EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x27A3390", Offset = "0x27A2590", VA = "0x1827A3390")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x27A3660", Offset = "0x27A2860", VA = "0x1827A3660")]
	private bool GBABDNFIJEO(EGCMEMPIHGG LMCLFBNJJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x27A2CE0", Offset = "0x27A1EE0", VA = "0x1827A2CE0")]
	private void DDIAJBJAHGP(LinkedListNode<EGCMEMPIHGG> DEIINJEHMDE, TVal AAGIEOKOOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x27A2620", Offset = "0x27A1820", VA = "0x1827A2620")]
	private void CJCBPGLAIDA(TKey FOOEPPOEAPA, TVal EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x27A3CE0", Offset = "0x27A2EE0", VA = "0x1827A3CE0")]
	private void KEPGGECDCDJ(EGCMEMPIHGG LMCLFBNJJMO, TVal AAGIEOKOOBN, int DDANNMMBAKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class PFEEIAFJHMK<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<T> DJGBKPCDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private HashSet<T> FKGIBPDPNLB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2185B70", Offset = "0x2184D70", VA = "0x182185B70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool OFNCODNFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x527EC0", Offset = "0x5270C0", VA = "0x180527EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x35641A0", Offset = "0x35633A0", VA = "0x1835641A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x35641D0", Offset = "0x35633D0", VA = "0x1835641D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x304E320", Offset = "0x304D520", VA = "0x18304E320", Slot = "11")]
	public void Add(T IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3563BB0", Offset = "0x3562DB0", VA = "0x183563BB0")]
	public bool IOKIDCPFCCG(T IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3564040", Offset = "0x3563240", VA = "0x183564040", Slot = "15")]
	public bool Remove(T IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2E696E0", Offset = "0x2E688E0", VA = "0x182E696E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x23A0C20", Offset = "0x239FE20", VA = "0x1823A0C20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3563A70", Offset = "0x3562C70", VA = "0x183563A70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x30BD750", Offset = "0x30BC950", VA = "0x1830BD750", Slot = "13")]
	public bool Contains(T IBEBPLDEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3563AD0", Offset = "0x3562CD0", VA = "0x183563AD0", Slot = "14")]
	public void CopyTo(T[] ANMIADPHPAJ, int NPDDOBLNACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26E07C0", Offset = "0x26DF9C0", VA = "0x1826E07C0", Slot = "6")]
	public int IndexOf(T IBEBPLDEKLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3563D20", Offset = "0x3562F20", VA = "0x183563D20", Slot = "7")]
	public void Insert(int NCBDKCDKIIG, T IBEBPLDEKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3563E10", Offset = "0x3563010", VA = "0x183563E10", Slot = "8")]
	public void RemoveAt(int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x35638D0", Offset = "0x3562AD0", VA = "0x1835638D0")]
	public void BNPAEJBNLPK(Predicate<T> OKAPCBMDLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3563DE0", Offset = "0x3562FE0", VA = "0x183563DE0")]
	public void LEDIJANGHCO(Comparison<T> JKPHHFCPANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x35640C0", Offset = "0x35632C0", VA = "0x1835640C0")]
	public PFEEIAFJHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MFACKMLIJAG
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3220", Offset = "0x4BA2420", VA = "0x184BA3220")]
	public static Vector3 CHCJKMLJNEG(this GameObject KONKHHPIEFL, float HLHHJKBOECM)
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
			[Cpp2IlInjected.Address(RVA = "0x20992F0", Offset = "0x20984F0", VA = "0x1820992F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6D30", Offset = "0x4BA5F30", VA = "0x184BA6D30")]
		public SerializedGuid(in Guid KNCDAFGFEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6AB0", Offset = "0x4BA5CB0", VA = "0x184BA6AB0")]
		public static SerializedGuid GFNCNKPJAJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6880", Offset = "0x4BA5A80", VA = "0x184BA6880")]
		public static SerializedGuid BAIOIDGHNFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6BD0", Offset = "0x4BA5DD0", VA = "0x184BA6BD0")]
		public bool NKPJPGOAJMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6D00", Offset = "0x4BA5F00", VA = "0x184BA6D00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6C60", Offset = "0x4BA5E60", VA = "0x184BA6C60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6B40", Offset = "0x4BA5D40", VA = "0x184BA6B40")]
		public bool HFPOKAFCGJI(in Guid KNCDAFGFEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6930", Offset = "0x4BA5B30", VA = "0x184BA6930", Slot = "7")]
		public bool Equals(SerializedGuid CDPFMCDBFNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4BA69D0", Offset = "0x4BA5BD0", VA = "0x184BA69D0", Slot = "0")]
		public override bool Equals(object KFCOOCIKJFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6B30", Offset = "0x4BA5D30", VA = "0x184BA6B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6900", Offset = "0x4BA5B00", VA = "0x184BA6900", Slot = "6")]
		public int CompareTo(SerializedGuid CDPFMCDBFNL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class POGBKPMIDCA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Type FLENOKGPDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string JFMHOALLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool JMIMNJEEPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool ANEENFNPIPO;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4BA5040", Offset = "0x4BA4240", VA = "0x184BA5040")]
	public POGBKPMIDCA(Type OKBHDFFPPJD, string HPONNHPGNHD, bool KMGBNJOGMHH = false, bool EHJLNGGMDOL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GFMMADOCGDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LJFMDJFECCM<T> : GFMMADOCGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	T LLFECFNJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FHCNEEEADHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string ECOOGJHACFF
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
	global::LJFMDJFECCM<T> OPBGIGDFJAO(Action<T> MDOEBNDFALA);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LJFMDJFECCM<T> OPBAOEFJOMF(Action<T> MDOEBNDFALA);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::LJFMDJFECCM<T> MIGIFMNDMMF(Action<T, T> FCFDOBBADKE);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::LJFMDJFECCM<T> FFEJJMCLKDD(Action<T, T> FCFDOBBADKE);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::LJFMDJFECCM<T> IAALIPDHJEO(Action<string> CIIGGLCPIBL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::LJFMDJFECCM<T> NOPMHFHJHDE(Action<string> CIIGGLCPIBL);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ALKFPOEIMKI<T> : global::LJFMDJFECCM<T>, GFMMADOCGDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private global::HNBCAFNGJPA<T, T> MGJALBLMLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private global::GAGIHGKDEBB<T> AAOJCNDKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private global::GAGIHGKDEBB<string> JDKMGFKDDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string CHFGOACPFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private T BKIAMPODCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool KAPHJHIDPFI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T LLFECFNJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x28284D0", Offset = "0x28276D0", VA = "0x1828284D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool FHCNEEEADHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5A98B0", Offset = "0x5A8AB0", VA = "0x1805A98B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ECOOGJHACFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5500C0", Offset = "0x54F2C0", VA = "0x1805500C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x26E0FE0", Offset = "0x26E01E0", VA = "0x1826E0FE0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x37CFCC0", Offset = "0x37CEEC0", VA = "0x1837CFCC0")]
	private void EDJCKHEKELA(T COLHIAEIIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x37CFEF0", Offset = "0x37CF0F0", VA = "0x1837CFEF0")]
	private void KHKBONMMKPB(string KJPKEJBABNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x37CFD60", Offset = "0x37CEF60", VA = "0x1837CFD60")]
	public void FEKLGHJHINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x37CFF90", Offset = "0x37CF190", VA = "0x1837CFF90", Slot = "6")]
	public global::LJFMDJFECCM<T> MIGIFMNDMMF(Action<T, T> FCFDOBBADKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x37CFE10", Offset = "0x37CF010", VA = "0x1837CFE10", Slot = "7")]
	public global::LJFMDJFECCM<T> FFEJJMCLKDD(Action<T, T> FCFDOBBADKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x37D00A0", Offset = "0x37CF2A0", VA = "0x1837D00A0", Slot = "4")]
	public global::LJFMDJFECCM<T> OPBGIGDFJAO(Action<T> FCFDOBBADKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x37D0050", Offset = "0x37CF250", VA = "0x1837D0050", Slot = "5")]
	public global::LJFMDJFECCM<T> OPBAOEFJOMF(Action<T> MDOEBNDFALA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x37CFE60", Offset = "0x37CF060", VA = "0x1837CFE60", Slot = "8")]
	public global::LJFMDJFECCM<T> IAALIPDHJEO(Action<string> CIIGGLCPIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x37CFFE0", Offset = "0x37CF1E0", VA = "0x1837CFFE0", Slot = "9")]
	public global::LJFMDJFECCM<T> NOPMHFHJHDE(Action<string> CIIGGLCPIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x37D0130", Offset = "0x37CF330", VA = "0x1837D0130")]
	public ALKFPOEIMKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class HKIMGBGDILG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class FEIIINMOBCI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::LJFMDJFECCM<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::OJFHBOONOPO<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public FEIIINMOBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x238C7E0", Offset = "0x238B9E0", VA = "0x18238C7E0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1DFAA70", Offset = "0x1DF9C70", VA = "0x181DFAA70")]
	public static global::HEDCDMAPDEO<T> NOKOMJAHOAJ<T>(this global::LJFMDJFECCM<T> EHIKNAPPHDO, Action<T> AGNPCLIMAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class AJACNEBPPAF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class PCGHMHNHIHA : AJACNEBPPAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static AJACNEBPPAF AACNHMOEADN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4BA48F0", Offset = "0x4BA3AF0", VA = "0x184BA48F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override DateTime IJHLECEDFNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4BA48A0", Offset = "0x4BA3AA0", VA = "0x184BA48A0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override float EPFAGIAOMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B91380", Offset = "0x4B90580", VA = "0x184B91380", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4BA49F0", Offset = "0x4BA3BF0", VA = "0x184BA49F0")]
		public PCGHMHNHIHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static AJACNEBPPAF KGBMCCIMADN;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static AJACNEBPPAF NGDBMKAAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1080", Offset = "0x4BA0280", VA = "0x184BA1080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract DateTime IJHLECEDFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public abstract float EPFAGIAOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	protected AJACNEBPPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class INFFKPAANFK : global::ADDFEBGPPIJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2FA0", Offset = "0x4BA21A0", VA = "0x184BA2FA0")]
	public INFFKPAANFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ADDFEBGPPIJ<T> : global::BHPGOEFKCJB<T>, IPJOIGMKABK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> BLMMMELIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task EMOCFCBNHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5000", Offset = "0x1BB4200", VA = "0x181BB5000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::HEDCDMAPDEO<T> BLHAFGDMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private HAKBKGDIMMA KIPJOEGLBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE9F0", Offset = "0x1BBDBF0", VA = "0x181BBE9F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3A25730", Offset = "0x3A24930", VA = "0x183A25730")]
	public ADDFEBGPPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EHIKMHIFLBF : global::IPEPKIBFFCI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2450", Offset = "0x4BA1650", VA = "0x184BA2450")]
	public EHIKMHIFLBF(Exception FFEJELOBLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IPEPKIBFFCI<T> : global::BHPGOEFKCJB<T>, IPJOIGMKABK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> BLMMMELIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task EMOCFCBNHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5000", Offset = "0x1BB4200", VA = "0x181BB5000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::HEDCDMAPDEO<T> BLHAFGDMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private HAKBKGDIMMA KIPJOEGLBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE9F0", Offset = "0x1BBDBF0", VA = "0x181BBE9F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A000", Offset = "0x1D59200", VA = "0x181D5A000")]
	public IPEPKIBFFCI(Exception FFEJELOBLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface IPJOIGMKABK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	Task BLMMMELIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	HAKBKGDIMMA BLHAFGDMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface BHPGOEFKCJB<T> : IPJOIGMKABK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[NotNull]
	new Task<T> BLMMMELIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	[NotNull]
	new global::HEDCDMAPDEO<T> BLHAFGDMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class PGAJMDLGKIA<TTask, T> : global::BHPGOEFKCJB<T>, IPJOIGMKABK, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BABDBMODACB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public global::PGAJMDLGKIA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public BABDBMODACB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static bool APMDEBBPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Task<T> AKMHEJIALMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CancellationTokenSource MIKKENGBIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LDNNKPLNAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SynchronizationContext LKNHBFNBECH;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> BLMMMELIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task EMOCFCBNHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::HEDCDMAPDEO<T> BLHAFGDMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private HAKBKGDIMMA KIPJOEGLBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CA10", Offset = "0x1D5BC10", VA = "0x181D5CA10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CIJJHMPALNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5A8990", Offset = "0x5A7B90", VA = "0x1805A8990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3566A50", Offset = "0x3565C50", VA = "0x183566A50")]
	static PGAJMDLGKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3566BC0", Offset = "0x3565DC0", VA = "0x183566BC0")]
	protected PGAJMDLGKIA(TTask AKMHEJIALMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x35664C0", Offset = "0x35656C0", VA = "0x1835664C0", Slot = "1")]
	~PGAJMDLGKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C6F0", Offset = "0x2E9B8F0", VA = "0x182E9C6F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3566770", Offset = "0x3565970", VA = "0x183566770")]
	private void NNIOEGIMEAF(bool CJOEHAHAIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T ALEIHLDEFJC(TTask KONMPAENLFP);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GNPAFLCGHBA();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3566470", Offset = "0x3565670", VA = "0x183566470")]
	[CompilerGenerated]
	private void BGHINHLEFKI(object LEFAEJLKHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OODPADBMCME : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly Type FLENOKGPDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly string JFMHOALLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly bool JMIMNJEEPNN;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3B60", Offset = "0x4BA2D60", VA = "0x184BA3B60")]
	public OODPADBMCME(Type OKBHDFFPPJD, string HPONNHPGNHD, bool KMGBNJOGMHH = false)
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
			[Cpp2IlInjected.Address(RVA = "0x527ED0", Offset = "0x5270D0", VA = "0x180527ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x54B710", Offset = "0x54A910", VA = "0x18054B710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public T this[int JBMKKAKPADN, int KBAHKLIBDEP]
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2184680", Offset = "0x2183880", VA = "0x182184680")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2184720", Offset = "0x2183920", VA = "0x182184720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x21845F0", Offset = "0x21837F0", VA = "0x1821845F0")]
		public Array2D(uint PJIIABFMCEC, uint JDCAGDMDMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2184570", Offset = "0x2183770", VA = "0x182184570")]
		public void FGLHFGIEJKB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1200", Offset = "0x4BA0400", VA = "0x184BA1200")]
		public Array2DVector3(uint PJIIABFMCEC, uint JDCAGDMDMDO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal static class DPPHNLDEOMB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int GLLFLLFLAKC = -1;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int GJANOBCIPGH = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class FEFFDKAOFDB<THandle, TValue> : IDisposable where THandle : struct, MHCNELDBBJC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<THandle> PPBNLFBGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<TValue> COLKLPOBKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TValue> MDIMCKEMHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue> LDMFBBACIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private int ECNMNNJOOOI;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TValue HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x27A3E80", Offset = "0x27A3080", VA = "0x1827A3E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x388AE90", Offset = "0x388A090", VA = "0x18388AE90")]
	public FEFFDKAOFDB(Action<TValue> LDMFBBACIKB, [Optional] Func<TValue> MDIMCKEMHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x388A300", Offset = "0x3889500", VA = "0x18388A300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x388A890", Offset = "0x3889A90", VA = "0x18388A890")]
	public THandle JOBPNILIBDA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x388AA70", Offset = "0x3889C70", VA = "0x18388AA70")]
	public THandle JPGLGPDLMNH(TValue EOEMKDLOAGI)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x388A560", Offset = "0x3889760", VA = "0x18388A560")]
	public bool FPHPJLPLMOJ(THandle LHJGJOFJCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x388AB90", Offset = "0x3889D90", VA = "0x18388AB90")]
	public bool KGDMNPBODAM(THandle LHJGJOFJCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x388A610", Offset = "0x3889810", VA = "0x18388A610")]
	public bool ICBEDKAPJKO(THandle LHJGJOFJCNF, out TValue EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x388A4E0", Offset = "0x38896E0", VA = "0x18388A4E0")]
	public TValue FDILAOMJFDA(THandle LHJGJOFJCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x388AAE0", Offset = "0x3889CE0", VA = "0x18388AAE0")]
	public bool KCLLNOKDEGE(THandle LHJGJOFJCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x388A530", Offset = "0x3889730", VA = "0x18388A530")]
	private THandle FEDMHPIAECI(int NCBDKCDKIIG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x388AE50", Offset = "0x388A050", VA = "0x18388AE50")]
	private TValue NOKOMJAHOAJ(int NCBDKCDKIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x388ACD0", Offset = "0x3889ED0", VA = "0x18388ACD0")]
	private void MKOONJOELHO(int NCBDKCDKIIG, in THandle LHJGJOFJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x388A4A0", Offset = "0x38896A0", VA = "0x18388A4A0")]
	private void EDJCKHEKELA(int NCBDKCDKIIG, in TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x388A780", Offset = "0x3889980", VA = "0x18388A780")]
	private THandle IMFFDKLKNOH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x388AD90", Offset = "0x3889F90", VA = "0x18388AD90")]
	private void NOGJMDNGHOM(THandle LHJGJOFJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x388A2F0", Offset = "0x38894F0", VA = "0x18388A2F0")]
	private int BHNFFECHCDD(int APCMBBDMJOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x388AE80", Offset = "0x388A080", VA = "0x18388AE80")]
	private bool OBDCJMMBKNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5789A0", Offset = "0x577BA0", VA = "0x1805789A0")]
	private void MKODEKOBIJK(THandle LHJGJOFJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x388AD10", Offset = "0x3889F10", VA = "0x18388AD10")]
	private bool MLCMGDOLDEG(out THandle LHJGJOFJCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x388A6B0", Offset = "0x38898B0", VA = "0x18388A6B0")]
	private bool IGOJAOOHIIN(out THandle LHJGJOFJCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x388AC70", Offset = "0x3889E70", VA = "0x18388AC70")]
	private void MIJOHHHPGAI(THandle LHJGJOFJCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x388A380", Offset = "0x3889580", VA = "0x18388A380")]
	private void EBOJNHEHAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface MHCNELDBBJC
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int PENJMDLPEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int OJFIGHCBHCP
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
public interface IPFMBECLOKB<T> : MHCNELDBBJC, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class CJIIHLGJAEN
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2920210", Offset = "0x291F410", VA = "0x182920210")]
	public static bool JAEDADFJEJD<T>(this T LHJGJOFJCNF) where T : struct, MHCNELDBBJC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BDDPIBGEMFE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private enum HBFLBJHLHBB : byte
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
	private int GHFGJNPFPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool JMBMBLPEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HBFLBJHLHBB HIDCAALMHPI;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DPOCHHCKNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2030", Offset = "0x4BA1230", VA = "0x184BA2030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FOHHHABBLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1A20", Offset = "0x4BA0C20", VA = "0x184BA1A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2040", Offset = "0x4BA1240", VA = "0x184BA2040")]
	public BDDPIBGEMFE(bool JMBMBLPEJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1AA0", Offset = "0x4BA0CA0", VA = "0x184BA1AA0")]
	public void NEDIDAFGIHL(object KFCOOCIKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1260", Offset = "0x4BA0460", VA = "0x184BA1260")]
	public void BCJMGEDEGMF(int EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1430", Offset = "0x4BA0630", VA = "0x184BA1430")]
	public void BKIPJJBIOIM(uint KJEBHGAAKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1900", Offset = "0x4BA0B00", VA = "0x184BA1900")]
	public void IPIKKLCJMLM(bool EKNAMIIJECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4BA18B0", Offset = "0x4BA0AB0", VA = "0x184BA18B0")]
	public void FGBEDJGDOGP(long DALMBIEEFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1440", Offset = "0x4BA0640", VA = "0x184BA1440")]
	public void DFBHPKLIHHM(ulong HKJLNHLNOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1A30", Offset = "0x4BA0C30", VA = "0x184BA1A30")]
	public void MEJHPEPIDFO(string FLKAGPMANPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1990", Offset = "0x4BA0B90", VA = "0x184BA1990")]
	public void KECLOCAMGJA(Enum FFEJELOBLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1310", Offset = "0x4BA0510", VA = "0x184BA1310")]
	public void BELNMAPMIBC(IList DJGBKPCDNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2352AE0", Offset = "0x2351CE0", VA = "0x182352AE0")]
	public void MAPNNMOGJHM<T, U>(Dictionary<T, U> JKOBJHCJLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1480", Offset = "0x4BA0680", VA = "0x184BA1480")]
	private void EIOPKCLIAGI(IDictionary JKOBJHCJLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1FC0", Offset = "0x4BA11C0", VA = "0x184BA1FC0")]
	public int OIMCOBILPEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1840", Offset = "0x4BA0A40", VA = "0x184BA1840")]
	public short ENOCOJNCCGG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4BA18F0", Offset = "0x4BA0AF0", VA = "0x184BA18F0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1920", Offset = "0x4BA0B20", VA = "0x184BA1920")]
	private void JNGMNGAECNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class FBDIEDDELHP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class NPPMMANALAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode JCFDJGMDKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode KJAPOBPIAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public LAMCLHIGGGM IHLDAMDNKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<LAMCLHIGGGM> ABGBPMCGKGA;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public NPPMMANALAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal struct LAMCLHIGGGM : IComparable<LAMCLHIGGGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int ILCCLPLFODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant KEJEEKIKBKL;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x52FCF0", Offset = "0x52EEF0", VA = "0x18052FCF0")]
		public LAMCLHIGGGM(int ILCCLPLFODI, TClaimant KEJEEKIKBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x37F33B0", Offset = "0x37F25B0", VA = "0x1837F33B0")]
		public bool MFJLLDEODIK(in LAMCLHIGGGM CDPFMCDBFNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x37F3410", Offset = "0x37F2610", VA = "0x1837F3410")]
		public bool PFNPMGGJJOG(in LAMCLHIGGGM CDPFMCDBFNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x37F33A0", Offset = "0x37F25A0", VA = "0x1837F33A0", Slot = "4")]
		public int CompareTo(LAMCLHIGGGM CDPFMCDBFNL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x37F3420", Offset = "0x37F2620", VA = "0x1837F3420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum CELBHPHKNPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class DKGGOBOPLCK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::FBDIEDDELHP<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x26D99A0", Offset = "0x26D8BA0", VA = "0x1826D99A0")]
		[DebuggerHidden]
		public DKGGOBOPLCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x37ECCB0", Offset = "0x37EBEB0", VA = "0x1837ECCB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x37ECE70", Offset = "0x37EC070", VA = "0x1837ECE70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x37ECD90", Offset = "0x37EBF90", VA = "0x1837ECD90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFFB0", Offset = "0x1BBF1B0", VA = "0x181BBFFB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly global::JGMDLHDKPFE<NPPMMANALAM> HNKIIMBMIOP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly global::JGMDLHDKPFE<List<LAMCLHIGGGM>> APNPCBDJLDD;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int KEGONDDFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> ONLLHMHKPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, NPPMMANALAM> PGGCHOOPHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private CELBHPHKNPG HCOKEIGPOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool GBJLMNKFEKF;

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GEMLHOLOPLK(TNode BABNEKFABNN);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CNHCPOFKIMC(TNode BABNEKFABNN, TClaimant KDPNDAHJACH, TClaimant LEDDEAEKCGD);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x37F2C20", Offset = "0x37F1E20", VA = "0x1837F2C20")]
	public FBDIEDDELHP(CELBHPHKNPG HCOKEIGPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x37F22A0", Offset = "0x37F14A0", VA = "0x1837F22A0")]
	public void JPAJLBOHLBL(TNode BABNEKFABNN, TNode IBMHNPJPJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x37F2320", Offset = "0x37F1520", VA = "0x1837F2320")]
	public void LDCDBBNIMPJ(TClaimant KEJEEKIKBKL, TNode NJFEJEKDGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x37F1E00", Offset = "0x37F1000", VA = "0x1837F1E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x37F2960", Offset = "0x37F1B60", VA = "0x1837F2960")]
	private void NOMMFDPLDBN(TClaimant KEJEEKIKBKL, TNode KHOPEFFIFNI, TNode NJFEJEKDGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x37F21A0", Offset = "0x37F13A0", VA = "0x1837F21A0")]
	private int FHALMMNGOCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x37F26B0", Offset = "0x37F18B0", VA = "0x1837F26B0")]
	private void MOBOEKGNDJB(TClaimant KEJEEKIKBKL, TNode MDHDPPAHKJO, TNode OJENMBADCPI, int ILGEIPICAPM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x37F2210", Offset = "0x37F1410", VA = "0x1837F2210")]
	private void IPHKEDBGBJG(LAMCLHIGGGM CLGMAALOGIB, NPPMMANALAM CMIKBEOHOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x37F1B90", Offset = "0x37F0D90", VA = "0x1837F1B90")]
	private void DBAKHLDANAL(TClaimant KEJEEKIKBKL, TNode MDHDPPAHKJO, TNode OJENMBADCPI, int ILGEIPICAPM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x37F1800", Offset = "0x37F0A00", VA = "0x1837F1800")]
	private void AIKHLIFHJEB(LAMCLHIGGGM CLGMAALOGIB, TNode BABNEKFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x37F1900", Offset = "0x37F0B00", VA = "0x1837F1900")]
	private void CAHKPHMANIN(LAMCLHIGGGM CLGMAALOGIB, NPPMMANALAM CMIKBEOHOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x37F2060", Offset = "0x37F1260", VA = "0x1837F2060")]
	private void FCNEBIMEKOF(NPPMMANALAM CMIKBEOHOPP, bool NEOKFOMCLHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x37F13C0", Offset = "0x37F05C0", VA = "0x1837F13C0")]
	private void AFHHAHEJAFL(NPPMMANALAM CMIKBEOHOPP, TNode IBMHNPJPJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x37F25E0", Offset = "0x37F17E0", VA = "0x1837F25E0")]
	[IteratorStateMachine(typeof(global::FBDIEDDELHP<, >.DKGGOBOPLCK))]
	private IEnumerable<TNode> MCNNDMLAGJC(TNode MDHDPPAHKJO, TNode OJENMBADCPI, bool HPOIOGJDOHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x37F2A00", Offset = "0x37F1C00", VA = "0x1837F2A00")]
	private NPPMMANALAM OMNECEDMOFJ(TNode BABNEKFABNN, TNode KJAPOBPIAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x37F1A00", Offset = "0x37F0C00", VA = "0x1837F1A00")]
	private NPPMMANALAM CCPIJFGJJKE(TNode BABNEKFABNN, TNode KJAPOBPIAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x37F2420", Offset = "0x37F1620", VA = "0x1837F2420")]
	private void LMCDEDIIJBE(NPPMMANALAM CMIKBEOHOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class OBEPCPFILFA<T> : IEnumerable<global::OBEPCPFILFA<T>.EOGOKOOKCPP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct EOGOKOOKCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T EOEMKDLOAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int NCBDKCDKIIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HIICOAAKCLG : IEnumerator<EOGOKOOKCPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private global::OBEPCPFILFA<T> FDBEBOKIJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int NCBDKCDKIIG;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x288DC40", Offset = "0x288CE40", VA = "0x18288DC40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public EOGOKOOKCPP DLDNOABCFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x46129E0", Offset = "0x4611BE0", VA = "0x1846129E0", Slot = "4")]
			get
			{
				return default(EOGOKOOKCPP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x877D30", Offset = "0x876F30", VA = "0x180877D30")]
		public HIICOAAKCLG(global::OBEPCPFILFA<T> FDBEBOKIJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4612950", Offset = "0x4611B50", VA = "0x184612950", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5B0", Offset = "0x7DA7B0", VA = "0x1807DB5B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x80FD40", Offset = "0x80EF40", VA = "0x18080FD40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct HPDLKEEELIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool KDFFAMAEICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T EOEMKDLOAGI;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int MMBCICINAEL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Dictionary<T, int> BNIBJPAONGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private HPDLKEEELIP[] MLOOJJJKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int OOPBFLGJOPO;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x27A1960", Offset = "0x27A0B60", VA = "0x1827A1960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x4613210", Offset = "0x4612410", VA = "0x184613210")]
	public static global::OBEPCPFILFA<T> NJGAKJFLGBK(EOGOKOOKCPP[] KGKNIOGIDDO, bool HABMGNOMAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x46136E0", Offset = "0x46128E0", VA = "0x1846136E0")]
	public OBEPCPFILFA(int FMBBHGJJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2E69680", Offset = "0x2E68880", VA = "0x182E69680")]
	public bool CJLHDMONMNI(T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4612C70", Offset = "0x4611E70", VA = "0x184612C70")]
	public bool FONNFEEHGIC(int NCBDKCDKIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4613160", Offset = "0x4612360", VA = "0x184613160")]
	public bool KEANBBKKHCP(Func<T, bool> LGPLJEOOKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4612BD0", Offset = "0x4611DD0", VA = "0x184612BD0")]
	public int ELLKPBJABNI(T EOEMKDLOAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x46135F0", Offset = "0x46127F0", VA = "0x1846135F0")]
	public T NOKOMJAHOAJ(int NCBDKCDKIIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4612C20", Offset = "0x4611E20", VA = "0x184612C20")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4612F10", Offset = "0x4612110", VA = "0x184612F10")]
	public bool IOKIDCPFCCG(T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4612F30", Offset = "0x4612130", VA = "0x184612F30")]
	public bool IOKIDCPFCCG(T EOEMKDLOAGI, int NCBDKCDKIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4612CD0", Offset = "0x4611ED0", VA = "0x184612CD0")]
	public bool FPHPJLPLMOJ(T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4612B80", Offset = "0x4611D80", VA = "0x184612B80")]
	public bool DDEOPDNACPM(int NCBDKCDKIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4612AD0", Offset = "0x4611CD0", VA = "0x184612AD0")]
	private void CODEOOKALDP(int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4612D50", Offset = "0x4611F50", VA = "0x184612D50")]
	public EOGOKOOKCPP[] HJOEPMDKIKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4612EC0", Offset = "0x46120C0", VA = "0x184612EC0")]
	private int IHKJBMDPDKN(int GAHGFCKGLIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4613660", Offset = "0x4612860", VA = "0x184613660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4613660", Offset = "0x4612860", VA = "0x184613660", Slot = "4")]
	private IEnumerator<EOGOKOOKCPP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class JGMDLHDKPFE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly Stack<T> BLFNPBPBJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<T> IMOFILANAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int OHKJGEGNIFO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int CAKCEOCPICB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1D68710", Offset = "0x1D67910", VA = "0x181D68710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int INJFBNGCDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1D68560", Offset = "0x1D67760", VA = "0x181D68560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1D68590", Offset = "0x1D67790", VA = "0x181D68590")]
	public static global::JGMDLHDKPFE<T> JPGMBIBMHCG(int FMBBHGJJFDP = 0, int OHKJGEGNIFO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D68760", Offset = "0x1D67960", VA = "0x181D68760")]
	public static global::JGMDLHDKPFE<T> MJPOLOGGBJL(int FMBBHGJJFDP = 0, int OHKJGEGNIFO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D68A50", Offset = "0x1D67C50", VA = "0x181D68A50")]
	public JGMDLHDKPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D68A90", Offset = "0x1D67C90", VA = "0x181D68A90")]
	public JGMDLHDKPFE(int FMBBHGJJFDP, int OHKJGEGNIFO = int.MaxValue, bool OBGEINEHPHI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D68100", Offset = "0x1D67300", VA = "0x181D68100")]
	public T APGIMGMELGN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1D68830", Offset = "0x1D67A30", VA = "0x181D68830")]
	public void OKDEKFKAOEN(T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D68990", Offset = "0x1D67B90", VA = "0x181D68990")]
	private void PLFDIDNEDNH(T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D68740", Offset = "0x1D67940", VA = "0x181D68740")]
	private void MACNMMPLFEN(T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1D688F0", Offset = "0x1D67AF0", VA = "0x181D688F0")]
	[Conditional("DEBUG_BUILD")]
	private void PHBCDDNIEOM(T CGHNHCGPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1D68660", Offset = "0x1D67860", VA = "0x181D68660")]
	[Conditional("DEBUG_BUILD")]
	private void KFGHHFBMFPJ(T CGHNHCGPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D68230", Offset = "0x1D67430", VA = "0x181D68230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D68340", Offset = "0x1D67540", VA = "0x181D68340")]
	private void HIOHGBEOLLE(IEnumerable<T> COLKLPOBKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KAKEICDDJBG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Dictionary<int, T> MONGBNECGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private T OAKOGBKDDMK;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public virtual T FIMOGOLFMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool ABNMFFDCJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x37AFB90", Offset = "0x37AED90", VA = "0x1837AFB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x37AF8A0", Offset = "0x37AEAA0", VA = "0x1837AF8A0")]
	public bool CJCBPGLAIDA(T EOEMKDLOAGI, int ILCCLPLFODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x37AFB30", Offset = "0x37AED30", VA = "0x1837AFB30")]
	public bool HKMDOBHKGNA(int ILCCLPLFODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x37AFBD0", Offset = "0x37AEDD0", VA = "0x1837AFBD0")]
	public T MMPDHJHNOHN(int BKKFPDHDIDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x37AFAD0", Offset = "0x37AECD0", VA = "0x1837AFAD0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x37AFA40", Offset = "0x37AEC40", VA = "0x1837AFA40")]
	private bool DLLCNOHMGDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x37AF900", Offset = "0x37AEB00", VA = "0x1837AF900")]
	public bool CMEBCMBDPDA(int ILCCLPLFODI, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3631E50", Offset = "0x3631050", VA = "0x183631E50")]
	public KAKEICDDJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HIDHDDLMIFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	protected struct JNDKLOAJKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public T LLFECFNJIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int FDNMKPEEJAE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	protected readonly List<JNDKLOAJKAP> DILHLNHNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private T LGHGFDNLHOH;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2185B70", Offset = "0x2184D70", VA = "0x182185B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2392820", Offset = "0x2391A20", VA = "0x182392820")]
	public bool KEANBBKKHCP(T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2392780", Offset = "0x2391980", VA = "0x182392780")]
	public void JPGLGPDLMNH(T EOEMKDLOAGI, int ILCCLPLFODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2392660", Offset = "0x2391860", VA = "0x182392660")]
	public bool FPHPJLPLMOJ(T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2392600", Offset = "0x2391800", VA = "0x182392600")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2392570", Offset = "0x2391770", VA = "0x182392570")]
	public T FABNOBMJGGC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2392A70", Offset = "0x2391C70", VA = "0x182392A70")]
	public T MAFOOLDMBGI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2392AE0", Offset = "0x2391CE0", VA = "0x182392AE0")]
	private void OMEOFLMNMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2392CF0", Offset = "0x2391EF0", VA = "0x182392CF0")]
	public HIDHDDLMIFG()
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
		[NLJOPEHPBNE(DIBELKIFKMM.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5290", Offset = "0x4BA4490", VA = "0x184BA5290")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5760", Offset = "0x4BA4960", VA = "0x184BA5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5580", Offset = "0x4BA4780", VA = "0x184BA5580")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5900", Offset = "0x4BA4B00", VA = "0x184BA5900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5150", Offset = "0x4BA4350", VA = "0x184BA5150")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5620", Offset = "0x4BA4820", VA = "0x184BA5620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4BA5440", Offset = "0x4BA4640", VA = "0x184BA5440")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA50B0", Offset = "0x4BA42B0", VA = "0x184BA50B0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface JDPIGNOBNEC
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public abstract class ResourcePrefabReference<T> : JDPIGNOBNEC where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2196310", Offset = "0x2195510", VA = "0x182196310", Slot = "4")]
		public virtual T MGMLMDPLFKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class PBLKGPJHMIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Dictionary<byte, GLEGAPHEDNJ> AANIAOLJENL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GLEGAPHEDNJ FOBIAFNCFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector2 KJBKMLAMIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xF52130", Offset = "0xF51330", VA = "0x180F52130")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E1BFB0", Offset = "0x2E1B1B0", VA = "0x182E1BFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Vector2 BCEKAEPJEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x14FA070", Offset = "0x14F9270", VA = "0x1814FA070")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x14FA0D0", Offset = "0x14F92D0", VA = "0x1814FA0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector2 LNMIHFMMOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3605270", Offset = "0x3604470", VA = "0x183605270")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3605290", Offset = "0x3604490", VA = "0x183605290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int NBEGLEJGOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5527E0", Offset = "0x5519E0", VA = "0x1805527E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5789A0", Offset = "0x577BA0", VA = "0x1805789A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4380", Offset = "0x4BA3580", VA = "0x184BA4380")]
	public PBLKGPJHMIJ(Bounds MGMEAGJGJMO, Vector2[] IEEICJKAFBI, int GLMOJADBGKA, byte GAHGFCKGLIO, float ALPLIADILFE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3BC0", Offset = "0x4BA2DC0", VA = "0x184BA3BC0")]
	public GLEGAPHEDNJ BEIGMBJGDFL(byte NCBDKCDKIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3C20", Offset = "0x4BA2E20", VA = "0x184BA3C20")]
	public void FAIEPNGPKKC(Vector3 OBHFOKDOECH, float FAJBCHBCIIM, float HBEOPNBEICL, ref List<byte> OCIKFKBIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4360", Offset = "0x4BA3560", VA = "0x184BA4360")]
	public void MFLACPECFKM(GLEGAPHEDNJ.DIFIDGCOBHO ILDFHEBAELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4230", Offset = "0x4BA3430", VA = "0x184BA4230")]
	private GLEGAPHEDNJ IMBABIFILGP(byte NCBDKCDKIIG, GLEGAPHEDNJ.CJOIAGIABJI NKLKNHLEJNJ, GLEGAPHEDNJ KJAPOBPIAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3D10", Offset = "0x4BA2F10", VA = "0x184BA3D10")]
	private void GJOHAOHOMFO(GLEGAPHEDNJ KJAPOBPIAAM, Vector2[] IEEICJKAFBI, int OJFMFGNLGCC, int GOLOHANFAPL, int BHKAPLDBBDB, int BCEMIGABMAN, float ALPLIADILFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GLEGAPHEDNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum CJOIAGIABJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum DIFIDGCOBHO
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
	public byte DADMOMNGOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 CGGAELLGDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 GEADDIGJHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector3 BKCFMBAMNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3 PGHKFPDHMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public CJOIAGIABJI ABIMELPOKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public GLEGAPHEDNJ JHGHEEFPJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public List<GLEGAPHEDNJ> HGCHKCOHLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool NBHJIOLGMIO;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2990", Offset = "0x4BA1B90", VA = "0x184BA2990")]
	public GLEGAPHEDNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2930", Offset = "0x4BA1B30", VA = "0x184BA2930")]
	public GLEGAPHEDNJ(byte LLDODNFBFON, CJOIAGIABJI NKLKNHLEJNJ, GLEGAPHEDNJ KJAPOBPIAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2890", Offset = "0x4BA1A90", VA = "0x184BA2890")]
	public void NLCFJJIGNMF(GLEGAPHEDNJ EOJPPBLIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80")]
	public void MFLACPECFKM(int NGJAACFFJMM, DIFIDGCOBHO ILDFHEBAELM, int FJOCCHIHAAI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2560", Offset = "0x4BA1760", VA = "0x184BA2560")]
	public void FAIEPNGPKKC(List<byte> OCIKFKBIMIA, Vector3 OBHFOKDOECH, float FAJBCHBCIIM, float HBEOPNBEICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4BA27F0", Offset = "0x4BA19F0", VA = "0x184BA27F0")]
	public bool GBKHKLPDDCC(Vector3 EMBNAEFNEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2850", Offset = "0x4BA1A50", VA = "0x184BA2850")]
	public bool GCJCLDFMGNB(Vector3 EMBNAEFNEME, float DBEJAGMBJPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class AAADJLFPGGG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Dictionary<T, object> MBKECMAIIJM;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0450", Offset = "0x1EDF650", VA = "0x181EE0450")]
	public bool IEHKIMIPJJA(T KPIKMHIJPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A23890", Offset = "0x3A22A90", VA = "0x183A23890")]
	public bool IEHKIMIPJJA(T KPIKMHIJPKI, object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A238D0", Offset = "0x3A22AD0", VA = "0x183A238D0")]
	public bool IEHKIMIPJJA(T KPIKMHIJPKI, object DKLKDEENFBH, out object BGKMKCCKGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A23930", Offset = "0x3A22B30", VA = "0x183A23930")]
	public bool JHGFOEDAHLH(T KPIKMHIJPKI, object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A23850", Offset = "0x3A22A50", VA = "0x183A23850")]
	public bool HEFIIFPMMGC(T KPIKMHIJPKI, object DKLKDEENFBH, out object BGKMKCCKGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A23970", Offset = "0x3A22B70", VA = "0x183A23970")]
	public bool JHGFOEDAHLH(T KPIKMHIJPKI, object DKLKDEENFBH, out object BGKMKCCKGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A23A00", Offset = "0x3A22C00", VA = "0x183A23A00")]
	public void PAGOEKDJOCN(T KPIKMHIJPKI, object DKLKDEENFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A237B0", Offset = "0x3A229B0", VA = "0x183A237B0")]
	public void HAJNEDDFGON(T KPIKMHIJPKI, object DKLKDEENFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A23A30", Offset = "0x3A22C30", VA = "0x183A23A30")]
	public AAADJLFPGGG()
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
		public struct ACIKEPJPHEE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly List<Component> DJGBKPCDNEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly bool ECOALJFLDPJ;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x786880", Offset = "0x785A80", VA = "0x180786880")]
			public ACIKEPJPHEE(List<Component> DJGBKPCDNEE, bool ECOALJFLDPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2183FF0", Offset = "0x21831F0", VA = "0x182183FF0")]
			public CCANMJEGMJJ<T> FEDOHNDFHEG()
			{
				return default(CCANMJEGMJJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2184060", Offset = "0x2183260", VA = "0x182184060", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2184060", Offset = "0x2183260", VA = "0x182184060", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public struct CCANMJEGMJJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private readonly List<Component> DJGBKPCDNEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private readonly bool ECOALJFLDPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int NCBDKCDKIIG;

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public T DLDNOABCFJK
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2184900", Offset = "0x2183B00", VA = "0x182184900", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2184890", Offset = "0x2183A90", VA = "0x182184890", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x21848D0", Offset = "0x2183AD0", VA = "0x1821848D0")]
			public CCANMJEGMJJ(List<Component> DJGBKPCDNEE, bool ECOALJFLDPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x21847C0", Offset = "0x21839C0", VA = "0x1821847C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x21847D0", Offset = "0x21839D0", VA = "0x1821847D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2184880", Offset = "0x2183A80", VA = "0x182184880", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BA75C0", Offset = "0x4BA67C0", VA = "0x184BA75C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4BA7580", Offset = "0x4BA6780", VA = "0x184BA7580")]
		public ToolHierarchyCache(GameObject GHGBGCPHMCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6F80", Offset = "0x4BA6180", VA = "0x184BA6F80")]
		private void DMAPEOFMGGD(GameObject GHGBGCPHMCL, bool PIAJBINGMKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6EF0", Offset = "0x4BA60F0", VA = "0x184BA6EF0")]
		public static void DMAPEOFMGGD(GameObject GHGBGCPHMCL, ref ToolHierarchyCache EIGKFKBICKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6E20", Offset = "0x4BA6020", VA = "0x184BA6E20")]
		public void CICDADIMPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4BA73D0", Offset = "0x4BA65D0", VA = "0x184BA73D0")]
		public void GMDNFMBENOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x18EC770", Offset = "0x18EB970", VA = "0x1818EC770")]
		public void PNEOCHELPNA<T>(Action<T> EPOOCOJOAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4BA6D60", Offset = "0x4BA5F60", VA = "0x184BA6D60")]
		public Component AJNENBGPDEO(Type OMCCJKNHBML, bool ECOALJFLDPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B850", Offset = "0x1E5AA50", VA = "0x181E5B850")]
		public T AJNENBGPDEO<T>(bool ECOALJFLDPJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4BA7490", Offset = "0x4BA6690", VA = "0x184BA7490")]
		public ACIKEPJPHEE<Component> PLIFPPMFHPA(Type OMCCJKNHBML, bool ECOALJFLDPJ = false)
		{
			return default(ACIKEPJPHEE<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x20678B0", Offset = "0x2066AB0", VA = "0x1820678B0")]
		public ACIKEPJPHEE<T> PLIFPPMFHPA<T>(bool ECOALJFLDPJ = false) where T : class
		{
			return default(ACIKEPJPHEE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4BA7120", Offset = "0x4BA6320", VA = "0x184BA7120")]
		public List<Component> FGMKIKCILFF(Type OMCCJKNHBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA70A0", Offset = "0x4BA62A0", VA = "0x184BA70A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache GGMEAHKJCJC, ToolHierarchyCache DHBFNIJNBON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x4BA7420", Offset = "0x4BA6620", VA = "0x184BA7420", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KFCOOCIKJFL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KMBCIJMPDLE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int FMBBHGJJFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private int DBMHENEKGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<T> NIOHMLNHHLE;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1D68710", Offset = "0x1D67910", VA = "0x181D68710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public T PHEGDNLHPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D370", Offset = "0x2E1C570", VA = "0x182E1D370")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public T OAACELIFNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D130", Offset = "0x2E1C330", VA = "0x182E1D130")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public T ENFGAEJMGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D0E0", Offset = "0x2E1C2E0", VA = "0x182E1D0E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D5F0", Offset = "0x2E1C7F0", VA = "0x182E1D5F0")]
	public KMBCIJMPDLE(int FMBBHGJJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D4D0", Offset = "0x2E1C6D0", VA = "0x182E1D4D0")]
	public void JPGLGPDLMNH(T KEGHCCOHNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D290", Offset = "0x2E1C490", VA = "0x182E1D290")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D1E0", Offset = "0x2E1C3E0", VA = "0x182E1D1E0")]
	public void CMJFHNGCKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D5A0", Offset = "0x2E1C7A0", VA = "0x182E1D5A0")]
	public void KDEHLEEGEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D280", Offset = "0x2E1C480", VA = "0x182E1D280")]
	public void EGHDPIOHHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LGMJBELEEBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool KOHKLLCHNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Action EPOOCOJOAOK;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static LGMJBELEEBB FPEJJACPOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA3050", Offset = "0x4BA2250", VA = "0x184BA3050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool PEFJEEBPCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5527B0", Offset = "0x5519B0", VA = "0x1805527B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8616F0", Offset = "0x8608F0", VA = "0x1808616F0")]
	public LGMJBELEEBB(Action EPOOCOJOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3030", Offset = "0x4BA2230", VA = "0x184BA3030")]
	public void LLIICMGDJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3030", Offset = "0x4BA2230", VA = "0x184BA3030", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class PHOBKEHDNNF
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80")]
	public static void DBBHNMNPDHL(HDNKJFEDINB AMEMPIDODJD, string FIMLJIJBOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class IDCKLKDOMIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private struct CNKCJBAEEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int FDNMKPEEJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public T LLFECFNJIDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<object, CNKCJBAEEHJ> MONGBNECGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T OAKOGBKDDMK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public virtual T FIMOGOLFMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xF52130", Offset = "0xF51330", VA = "0x180F52130", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2E1BFB0", Offset = "0x2E1B1B0", VA = "0x182E1BFB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool ABNMFFDCJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x3631D60", Offset = "0x3630F60", VA = "0x183631D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public object FFADPEBLOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x362C700", Offset = "0x362B900", VA = "0x18362C700")]
	public bool CJCBPGLAIDA(T EOEMKDLOAGI, object DKLKDEENFBH, int ILCCLPLFODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3631CF0", Offset = "0x3630EF0", VA = "0x183631CF0")]
	public bool HKMDOBHKGNA(object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x362CB80", Offset = "0x362BD80", VA = "0x18362CB80")]
	public bool CMEBCMBDPDA(object DKLKDEENFBH, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x34D5F50", Offset = "0x34D5150", VA = "0x1834D5F50")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x362EC90", Offset = "0x362DE90", VA = "0x18362EC90")]
	private bool DLLCNOHMGDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3631E50", Offset = "0x3631050", VA = "0x183631E50")]
	public IDCKLKDOMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class BDKLGOFFACC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Dictionary<object, float> MONGBNECGPH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public float LGFMBFBBLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE33FB0", Offset = "0xE331B0", VA = "0x180E33FB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xD54260", Offset = "0xD53460", VA = "0x180D54260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2070", Offset = "0x4BA1270", VA = "0x184BA2070")]
	public void CJCBPGLAIDA(float EOEMKDLOAGI, object DKLKDEENFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4BA20E0", Offset = "0x4BA12E0", VA = "0x184BA20E0")]
	public void HKMDOBHKGNA(object DKLKDEENFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2150", Offset = "0x4BA1350", VA = "0x184BA2150")]
	private void JEBAKDLAEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2270", Offset = "0x4BA1470", VA = "0x184BA2270")]
	public BDKLGOFFACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class HDNKJFEDINB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class LCOFENJKCOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly string HLPGMOGAMAA;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private LCOFENJKCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x688A70", Offset = "0x687C70", VA = "0x180688A70")]
		public LCOFENJKCOD(string HLPGMOGAMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2FE0", Offset = "0x4BA21E0", VA = "0x184BA2FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LNJMHPFJABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public LNJMHPFJABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4BA30D0", Offset = "0x4BA22D0", VA = "0x184BA30D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly HashSet<object> JAOKGKLFONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int LHMNECHNKNP;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FKACIEJDLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2A90", Offset = "0x4BA1C90", VA = "0x184BA2A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int OJDAKNNCCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5B3670", Offset = "0x5B2870", VA = "0x1805B3670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2AA0", Offset = "0x4BA1CA0", VA = "0x184BA2AA0")]
	public bool JPGLGPDLMNH(object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2A10", Offset = "0x4BA1C10", VA = "0x184BA2A10")]
	public bool FPHPJLPLMOJ(object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2B20", Offset = "0x4BA1D20", VA = "0x184BA2B20")]
	public bool KEANBBKKHCP(object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4BA29B0", Offset = "0x4BA1BB0", VA = "0x184BA29B0")]
	public void BLDAHNALBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2B80", Offset = "0x4BA1D80", VA = "0x184BA2B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2CF0", Offset = "0x4BA1EF0", VA = "0x184BA2CF0")]
	public HDNKJFEDINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class FEPJCOEIPHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct OMGJEDIPNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float MBMHDBABEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public T LLFECFNJIDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<object, OMGJEDIPNIN> MONGBNECGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private T FKGMLNGLOFC;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public virtual T PMFDCHBAECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xFD18A0", Offset = "0xFD0AA0", VA = "0x180FD18A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3631DB0", Offset = "0x3630FB0", VA = "0x183631DB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public object KBDKFFDDDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool ABNMFFDCJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x388D290", Offset = "0x388C490", VA = "0x18388D290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x388B650", Offset = "0x388A850", VA = "0x18388B650")]
	public bool CJCBPGLAIDA(T EOEMKDLOAGI, object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x388D230", Offset = "0x388C430", VA = "0x18388D230")]
	public bool HKMDOBHKGNA(object DKLKDEENFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x34D5F50", Offset = "0x34D5150", VA = "0x1834D5F50")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x388B7C0", Offset = "0x388A9C0", VA = "0x18388B7C0")]
	public bool CMEBCMBDPDA(object DKLKDEENFBH, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x388C0C0", Offset = "0x388B2C0", VA = "0x18388C0C0")]
	private bool DLLCNOHMGDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x388D2D0", Offset = "0x388C4D0", VA = "0x18388D2D0")]
	public FEPJCOEIPHK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PEGOPLHHMHI
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static byte[] HIBFFCCJJHD;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static int BICBCGELOBK;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int ILHMFLHJGFF;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static BigInteger OJJMNJJEBED;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PEGOPLHHMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4D80", Offset = "0x4BA3F80", VA = "0x184BA4D80")]
	private static string MCCHLMPJJNK(byte[] DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4A50", Offset = "0x4BA3C50", VA = "0x184BA4A50")]
	public static string ACFPKMGBPMA(byte[] GMBNEFEOHLO, bool EDLKFPFOADI)
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
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
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
