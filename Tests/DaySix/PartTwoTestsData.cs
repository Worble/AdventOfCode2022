using System.Collections;
using System.Collections.Generic;

namespace Tests.DaySix;

public class PartTwoTestsData : IEnumerable<object[]>
{
	public IEnumerator<object[]> GetEnumerator()
	{
		yield return new object[] {"mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19};
		yield return new object[] {"bvwbjplbgvbhsrlpgdmjqwftvncz", 23};
		yield return new object[] {"nppdvjthqldpwncqszvftbrmjlhg", 23};
		yield return new object[] {"nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29};
		yield return new object[] {"zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26};
		yield return new object[]
		{
			"vldvlvvhwhttcsttpntnvvqpqpddmlddwhwcwnwmwfwppdrrhllcwwgwhwvhwhshchshtsstzstztgtlggcwwtptrppfpggwpwmppnfpfnfznffmvfmvffgfwwwgrrqgglrgrqqlslhhgjgwwdswsbwwqswqwnqwqpqttqstqtjqqctcbtcbttcptpbbsmmhggwmggjllcpcvcrrphpjjwzwgzgtzggscggwdgghlhnhddlclrcchllrlbbnlbbgpbgghvggpbgpgssbszzjbbcpbpttwztwwgngnqqgllcvlvlzvzwwzssbppjwwvswwbjwbjwwwsjsdjsszmssfvsvcscqssnbnzbzzhsszttfvvdllzjzsjjzzvzsvzzdvvcpphfhzhrzrnnwffnrrhwrhrnrhnrrgfgmmzwmzmhzzsrzrgggnfntnpnqqdhhmrmrrqdqwqsqmssmllmvmgglttdmdffwzzhszhzphzphplpvpzvvsvcvgvqgqpgqqrmqmqssdbdcdpphddvppfggwrgrdgrggtvggrttmpmvmnmwnmmlcccwssfjftfbbgqbbnlldzlddzbbvmmvbmvvbsszggmnggqsqvssdlddqbbtfbttlhhlssplphlhzzcmmdcmmlqlqmmtddztzctzzlglwlzwwsmsddbrrzqqpdpjdpjjzhjjjzttvvwcvcdvvwqvvwqqgpgjgwgvgmmdjjmbbttmffwgwgppspzzvddjnjppmsscjczcqcczlzjzbbzmzllsshrrdtdttjdtdnnwbwttzptztrzzgfgfqfjjlwjjbfbsbmmhphqqjlqjjjshsvvrzrffvnfftrrpzzrdrbbcqbqjqccphhwfwgfwgwgwzzhggddctcsttjgjppghppfhhlnhhhwfwrfrggtjjgjbgbjbrrssjvvlcvvdzvdzzjhhgpprnpnpggfmfgfzfrzzsjjwhhrmmmvppgfffdsfddwlddmccjfcjjrwwsmwsstlsszbbjssjtsjjmpjpqqzffhphfffrzffnbnvnzvnvsvjjbljlflglrlvvghhcrhccnhccdbcdclcbbgffhwhnwwrwbbngnwwlpwlwsllsffzvzbzhbhppvdvfdvffvsvlslcslsqqszqzrrqbrrpjjvgjggbvvpbblnlvnnvrrprbpbvbccrjsdfrnqvhgfrwtvqjfzflnqqgbwlvfwwmrgnsltsqjfcctdwhqrstpvllhfrbnvnhvvgfvhbsgppslqnhmwdnrjnpfmrppppqpmrmcvtndrgwngrblpvrgnbhgtflthdjdtqhwcfzbdwsjshhnglprfcjfdwffmhbvhshbzsgdsbdwpcjfhrccqmjslqjjrwnbtqftqlvgnpmmzlfnmjzvrfslmmvhqwzjqbwsqfcnlmgdwlcbrlqlfwzhcfjsnncnnjqltfccmllhnjczqssjnjmhqbhqzdplbvfdpmdjmgthvqgjzqqschzgtmpdzmvvhlrwjpbqfplcqdbjfjfcrzdclctldvvqphtnvmgzvwprhzmbsbgfjlhvbtcmnccrgrpjlcjqqfcgjhtwvfstrtzszgcprmcngbhbdvjbfvgqdlhzgtzcjqnjmdtmwzchcfhzhgwprgrzbfwbhstfbprhnbzhsglmwhcjbppnshmzlnzsmbhcrmvpdgftfrwjfnmdvtrrqwjmzlbdjppsnvmlstsnrjwslqtqfmfcspzgrqhshhvclvqdfpbmzvsnthmcrzdmzqcjnnmbwbdlbfmcrzjjsrjbwchlvljplqdbjfchbslcvbjvvzfgdzmmnrgqwftppgpfwhfvdqqsrphrqmdtzjghlldfpgnczzjhqhfjvgqmcpzqssfqsfblcvqfttznpmvczprcptgcfwwlwsmqvfrjzcwbhppsjghmltqtcqljmpjzddncbslqdvgzhdvfpdpgpzljrfnjwdtnbdjwzjvmhqvnrdrjmhcfsbjcwtflljwjvtjbsbhzbghnzwtwpwzzwnfhwszsghggqthcbtwjrhdphbdslzmwhpmtjfbnpzspfqrvvtsjpvjmbtwrsqvfzzphllbvmvczsphdtblgdczjsqqthgscdqpvnmbpblspbcmpgjjtjtdrwhrqcgbrvlcsrwzwnjlgbfjbfgwpqpvnnmmgbdrhrwsptmddvtgbjhgzcphzmscjrqlnngpsnmjhvtmnhmqmcwdpjpbjsntcgppqrjndfsfhrhcvgcmrfrrsvnddwjsndlwffrgqnldqnvtgfvdrwtrlcqhltmbvdndzpdqndqrbtzqwbmbtzzsqftjftcnbrtsgvdrmnqlbbmhwmzpngltcslwdnpzpvstpdtfdcqvlwtbppsjvpdbspzlwnfvgcslzvmrpgplbnrvwpfwnrhcncdzptrjsqvghrczmrfwfntqlvlccwtbwqdcngzlqqvvnvfttqmcbqfqndhlsmbvcnstjcbpffmsptdnqbntnhhdctgdbnvwzgwznsgpvmslpmlcffsdtfnlcmbdgbntcslrlhfmrpddmjjttbtcrgbmfsbbwphtmlrdrgffdlnrwndhttjrplstwfwlpnljlcjphdvdvslwvnstqlrsgwdltlqwzdgsltzjqsgwqpbzgvqbdmvqtdgsnhttqprttzrnmddzdnqsgmnhfrmmfnrmltgjqpmgmdzdwpnzdsgstmwlgstmtjtqlhngmpwdqscrjmpmndddppsgthtbmznndswpsftcfltmhbbglnlmlszsssrlgbzcqpngvtgttlblsthmrltgctpgpjmhqqbldfgcrmclsmjhnjspzgwpmwncjgwrgdjmfgrpndztfdssmjhfmstgbjjzvmrpbmfzljpffwgvszwvtclfdnnbswzpjgthcbzpcbmgfvhfwnfthjdmnzdptqflzldnvnmfqnbggsrzjjssdntqhsjltjlfvjhncbrfbhllmqdpdnlbjptdcrqqghvvfvzzvtbvnjhshptcmgcnlmmpgdggdsfnpfsgrbcnfvrvfcqdfdfbgfvqcspvnrrljsgdtsbbcvcqnlwmrfgjhbdnjqgpggnpqtqgwspgljbrsggnmbmdbctwsdzqjmzrcwqgsvnhlpnlnqgfvgdfpgwsbqpqjcjpwwbrtzqhhgswggwnhmzwtvrqcrgbsrjspmczctgprgcwjtnzghvzqgnpmfqdswnzfzdbpdnpcgmwdrpmjtzhhwcnrrpfvqsgbrzngmwdgvjnmcftcjpcmdvcwjgfgvjrblsdnbsgfmjnvvvfwpfhztbgfddlcljzmwrwglnrfbnphlpvvcbfnwpsmsnhshzwrpnljzstmglrwdcctqlbwvqtfpjjdqzgncwgsnhczhvnvnzzmsjhfvgpdrhsmgnrfjcrzblzncdlffjrcqrqqdnjhgwgdgjlgbtphzgrjvmgnqrvdgmtgvpdbzqcvsfctrntjsnfcwnzpslzsvmtjhtcvcdsbqflbmtvclssrvcwjwcbspjgqhznzpttlbsnrpdrnqsddlcvjdrnqcgjhjfdclhwscdpbsjzcmrhgfwdnqbzqjsdqwbqdfcrztzfvclvbnhqstjztqdmsvlfqzmllphgrnwjqpdlrdnsbdltrggvlmdpfdwrdwnsdnscfcjzmrwqpsjwzrqcqcfndlvtfftbhdcbgcgtrfqrqnvwgbpstrtzgpjcjswfcwgvfnwlpprthntmlqbchjcwnqgppchgtvrzjbdzptfqqbmchmpqlnnfvpghjnmshpcjgsprbjpqnpwwddnswnfjvbzwszplhnhgzmzdqncmqrqtbqhdwbtrbrljpcwbdhjzvcqpdgvbtczlhwwzfmgvffnbcglpdqjdsnhhtnvvmtnhlbqcfqjfcgmcnqstzbgmqcfsgrzncwcfrlpsctpspvvdzwtbrhqzhfcwvwqvtzrmfjgpmlsdjmlgwhcldqlhsjvprvnmzcsldzfpzhmzdbqbpwnrsffswbjcwjgblnlcwzqlmcgfstqggdbsqpcpqcgfvn",
			3120
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}