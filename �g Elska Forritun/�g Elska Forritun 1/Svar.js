(function() {
	var Mem = {},
		Poss = function(x, y) {
			if (x === 100 && y === 100) return new Big('1');
			
			var k = x > y ? x + ',' + y : y + ',' + x;
			if (Mem.hasOwnProperty(k)) return Mem[k];
			
			var n = new Big('0');
			if (x <= 99 && y <= 99) n = n.plus(Poss(x + 1, y + 1));
			if (x <= 99) n = n.plus(Poss(x + 1, y));
			if (y <= 99) n = n.plus(Poss(x, y + 1));
			
			Mem[k] = n;
			return n;
		};
		
	document.body.innerHTML = Poss(0, 0).toString().replace('.', '');
}());